namespace ExampleImGui
{
    using Hexa.NET.ImGui;
    using Hexa.NET.Raylib;
    using System.Numerics;
    using System.Runtime.InteropServices;
    using ImDrawIdx = ushort;

    public static unsafe class ImGuiRaylibPlatform
    {
        private static ImGuiMouseCursor CurrentMouseCursor = ImGuiMouseCursor.Count;
        private static readonly MouseCursor[] MouseCursorMap = new MouseCursor[(int)ImGuiMouseCursor.Count];

        private static bool LastFrameFocused = false;

        private static bool LastControlPressed = false;
        private static bool LastShiftPressed = false;
        private static bool LastAltPressed = false;
        private static bool LastSuperPressed = false;

        // internal only functions
        private static bool RlImGuiIsControlDown()
        {
            return Raylib.IsKeyDown((int)KeyboardKey.RightControl) || Raylib.IsKeyDown((int)KeyboardKey.LeftControl);
        }

        private static bool RlImGuiIsShiftDown()
        {
            return Raylib.IsKeyDown((int)KeyboardKey.RightShift) || Raylib.IsKeyDown((int)KeyboardKey.LeftShift);
        }

        private static bool RlImGuiIsAltDown()
        {
            return Raylib.IsKeyDown((int)KeyboardKey.RightAlt) || Raylib.IsKeyDown((int)KeyboardKey.LeftAlt);
        }

        private static bool RlImGuiIsSuperDown()
        {
            return Raylib.IsKeyDown((int)KeyboardKey.RightSuper) || Raylib.IsKeyDown((int)KeyboardKey.LeftSuper);
        }

        private static void ReloadFonts()
        {
            ImGuiIOPtr io = ImGui.GetIO();
            byte* pixels;

            int width;
            int height;
            io.Fonts.GetTexDataAsRGBA32(&pixels, &width, &height, null);

            Image image = new Image
            {
                Data = pixels,
                Width = width,
                Height = height,
                Mipmaps = 1,
                Format = (int)PixelFormat.UncompressedR8G8B8A8,
            };

            Texture* fontTexture = (Texture*)io.Fonts.TexID.Handle;
            if (fontTexture != null && fontTexture->Id != 0)
            {
                Raylib.UnloadTexture(*fontTexture);
                Raylib.MemFree(fontTexture);
            }

            fontTexture = (Texture*)Raylib.MemAlloc((uint)sizeof(Texture));
            *fontTexture = Raylib.LoadTextureFromImage(image);

            io.Fonts.TexID = new ImTextureID((nint)fontTexture);
        }

        private static byte* GetClipTextCallback(void* userdata)
        {
            return Raylib.GetClipboardText();
        }

        private static void SetClipTextCallback(void* userdata, byte* text)
        {
            Raylib.SetClipboardText(text);
        }

        private static void ImGuiNewFrame(float deltaTime)
        {
            ImGuiIOPtr io = ImGui.GetIO();

            Vector2 resolutionScale = Raylib.GetWindowScaleDPI();

#if !PLATFORM_DRM
            if (Raylib.IsWindowFullscreen())
            {
                int monitor = Raylib.GetCurrentMonitor();
                io.DisplaySize.X = (Raylib.GetMonitorWidth(monitor));
                io.DisplaySize.Y = (Raylib.GetMonitorHeight(monitor));
            }
            else
            {
                io.DisplaySize.X = (Raylib.GetScreenWidth());
                io.DisplaySize.Y = (Raylib.GetScreenHeight());
            }

#if !APPLE
            if (!Raylib.IsWindowState((uint)ConfigFlags.FlagWindowHighdpi))
                resolutionScale = new Vector2(1, 1);
#endif
#else
            io.DisplaySize.X = (Raylib.GetScreenWidth());
            io.DisplaySize.Y = (Raylib.GetScreenHeight());
#endif

            io.DisplayFramebufferScale = new(resolutionScale.X, resolutionScale.Y);

            io.DeltaTime = deltaTime;

            if (io.WantSetMousePos)
            {
                Raylib.SetMousePosition((int)io.MousePos.X, (int)io.MousePos.Y);
            }
            else
            {
                io.AddMousePosEvent((float)Raylib.GetMouseX(), (float)Raylib.GetMouseY());
            }

            static void setMouseEvent(ImGuiIOPtr io, int rayMouse, int imGuiMouse)
            {
                if (Raylib.IsMouseButtonPressed(rayMouse))
                    io.AddMouseButtonEvent(imGuiMouse, true);
                else if (Raylib.IsMouseButtonReleased(rayMouse))
                    io.AddMouseButtonEvent(imGuiMouse, false);
            };

            setMouseEvent(io, (int)MouseButton.Left, (int)ImGuiMouseButton.Left);
            setMouseEvent(io, (int)MouseButton.Right, (int)ImGuiMouseButton.Right);
            setMouseEvent(io, (int)MouseButton.Middle, (int)ImGuiMouseButton.Middle);
            setMouseEvent(io, (int)MouseButton.Forward, (int)(ImGuiMouseButton.Middle + 1));
            setMouseEvent(io, (int)MouseButton.Back, (int)(ImGuiMouseButton.Middle + 2));

            {
                Vector2 mouseWheel = Raylib.GetMouseWheelMoveV();
                io.AddMouseWheelEvent(mouseWheel.X, mouseWheel.Y);
            }

            if ((ImGui.GetIO().BackendFlags & ImGuiBackendFlags.HasMouseCursors) != 0)
            {
                if ((io.ConfigFlags & ImGuiConfigFlags.NoMouseCursorChange) == 0)
                {
                    ImGuiMouseCursor imgui_cursor = ImGui.GetMouseCursor();
                    if (imgui_cursor != CurrentMouseCursor || io.MouseDrawCursor)
                    {
                        CurrentMouseCursor = imgui_cursor;
                        if (io.MouseDrawCursor || imgui_cursor == ImGuiMouseCursor.None)
                        {
                            Raylib.HideCursor();
                        }
                        else
                        {
                            Raylib.ShowCursor();

                            if ((io.ConfigFlags & ImGuiConfigFlags.NoMouseCursorChange) == 0)
                            {
                                Raylib.SetMouseCursor((int)(((int)imgui_cursor > -1 && imgui_cursor < ImGuiMouseCursor.Count) ? MouseCursorMap[(int)imgui_cursor] : MouseCursor.Default));
                            }
                        }
                    }
                }
            }
        }

        private static void ImGuiTriangleVert(ImDrawVert idx_vert)
        {
            Color* c;
            c = (Color*)&idx_vert.Col;
            Raylib.RlColor4Ub(c->R, c->G, c->B, c->A);
            Raylib.RlTexCoord2F(idx_vert.Uv.X, idx_vert.Uv.Y);
            Raylib.RlVertex2F(idx_vert.Pos.X, idx_vert.Pos.Y);
        }

        private static void ImGuiRenderTriangles(uint count, uint indexStart, ImVector<ImDrawIdx>* indexBuffer, ImVector<ImDrawVert>* vertBuffer, void* texturePtr)
        {
            if (count < 3)
                return;

            Texture* texture = (Texture*)texturePtr;

            uint textureId = (texture == null) ? 0 : texture->Id;

            Raylib.RlBegin(Raylib.RL_TRIANGLES);
            Raylib.RlSetTexture(textureId);

            for (uint i = 0; i <= (count - 3); i += 3)
            {
                ImDrawIdx indexA = indexBuffer->Data[indexStart + i];
                ImDrawIdx indexB = indexBuffer->Data[indexStart + i + 1];
                ImDrawIdx indexC = indexBuffer->Data[indexStart + i + 2];

                ImDrawVert vertexA = vertBuffer->Data[indexA];
                ImDrawVert vertexB = vertBuffer->Data[indexB];
                ImDrawVert vertexC = vertBuffer->Data[indexC];

                ImGuiTriangleVert(vertexA);
                ImGuiTriangleVert(vertexB);
                ImGuiTriangleVert(vertexC);
            }
            Raylib.RlEnd();
        }

        private static void EnableScissor(float x, float y, float width, float height)
        {
            Raylib.RlEnableScissorTest();
            ImGuiIOPtr io = ImGui.GetIO();

            Vector2 scale = io.DisplayFramebufferScale;
#if !APPLE
            if (!Raylib.IsWindowState((uint)ConfigFlags.FlagWindowHighdpi))
            {
                scale.X = 1;
                scale.Y = 1;
            }
#endif

            Raylib.RlScissor((int)(x * scale.X),
                (int)((io.DisplaySize.Y - (int)(y + height)) * scale.Y),
                (int)(width * scale.X),
                (int)(height * scale.Y));
        }

        private static void SetupMouseCursors()
        {
            MouseCursorMap[(int)ImGuiMouseCursor.Arrow] = MouseCursor.Arrow;
            MouseCursorMap[(int)ImGuiMouseCursor.TextInput] = MouseCursor.Ibeam;
            MouseCursorMap[(int)ImGuiMouseCursor.Hand] = MouseCursor.PointingHand;
            MouseCursorMap[(int)ImGuiMouseCursor.ResizeAll] = MouseCursor.ResizeAll;
            MouseCursorMap[(int)ImGuiMouseCursor.ResizeEw] = MouseCursor.ResizeEw;
            MouseCursorMap[(int)ImGuiMouseCursor.ResizeNesw] = MouseCursor.ResizeNesw;
            MouseCursorMap[(int)ImGuiMouseCursor.ResizeNs] = MouseCursor.ResizeNs;
            MouseCursorMap[(int)ImGuiMouseCursor.ResizeNwse] = MouseCursor.ResizeNwse;
            MouseCursorMap[(int)ImGuiMouseCursor.NotAllowed] = MouseCursor.NotAllowed;
        }

        private static ImGuiKey MapKeyToImGuiKey(KeyboardKey key)
        {
            return key switch
            {
                KeyboardKey.Apostrophe => ImGuiKey.Apostrophe,
                KeyboardKey.Comma => ImGuiKey.Comma,
                KeyboardKey.Minus => ImGuiKey.Minus,
                KeyboardKey.Period => ImGuiKey.Period,
                KeyboardKey.Slash => ImGuiKey.Slash,
                KeyboardKey.Zero => ImGuiKey.Key0,
                KeyboardKey.One => ImGuiKey.Key1,
                KeyboardKey.Two => ImGuiKey.Key2,
                KeyboardKey.Three => ImGuiKey.Key3,
                KeyboardKey.Four => ImGuiKey.Key4,
                KeyboardKey.Five => ImGuiKey.Key5,
                KeyboardKey.Six => ImGuiKey.Key6,
                KeyboardKey.Seven => ImGuiKey.Key7,
                KeyboardKey.Eight => ImGuiKey.Key8,
                KeyboardKey.Nine => ImGuiKey.Key9,
                KeyboardKey.Semicolon => ImGuiKey.Semicolon,
                KeyboardKey.Equal => ImGuiKey.Equal,
                KeyboardKey.A => ImGuiKey.A,
                KeyboardKey.B => ImGuiKey.B,
                KeyboardKey.C => ImGuiKey.C,
                KeyboardKey.D => ImGuiKey.D,
                KeyboardKey.E => ImGuiKey.E,
                KeyboardKey.F => ImGuiKey.F,
                KeyboardKey.G => ImGuiKey.G,
                KeyboardKey.H => ImGuiKey.H,
                KeyboardKey.I => ImGuiKey.I,
                KeyboardKey.J => ImGuiKey.J,
                KeyboardKey.K => ImGuiKey.K,
                KeyboardKey.L => ImGuiKey.L,
                KeyboardKey.M => ImGuiKey.M,
                KeyboardKey.N => ImGuiKey.N,
                KeyboardKey.O => ImGuiKey.O,
                KeyboardKey.P => ImGuiKey.P,
                KeyboardKey.Q => ImGuiKey.Q,
                KeyboardKey.R => ImGuiKey.R,
                KeyboardKey.S => ImGuiKey.S,
                KeyboardKey.T => ImGuiKey.T,
                KeyboardKey.U => ImGuiKey.U,
                KeyboardKey.V => ImGuiKey.V,
                KeyboardKey.W => ImGuiKey.W,
                KeyboardKey.X => ImGuiKey.X,
                KeyboardKey.Y => ImGuiKey.Y,
                KeyboardKey.Z => ImGuiKey.Z,
                KeyboardKey.Space => ImGuiKey.Space,
                KeyboardKey.Escape => ImGuiKey.Escape,
                KeyboardKey.Enter => ImGuiKey.Enter,
                KeyboardKey.Tab => ImGuiKey.Tab,
                KeyboardKey.Backspace => ImGuiKey.Backspace,
                KeyboardKey.Insert => ImGuiKey.Insert,
                KeyboardKey.Delete => ImGuiKey.Delete,
                KeyboardKey.Right => ImGuiKey.RightArrow,
                KeyboardKey.Left => ImGuiKey.LeftArrow,
                KeyboardKey.Down => ImGuiKey.DownArrow,
                KeyboardKey.Up => ImGuiKey.UpArrow,
                KeyboardKey.PageUp => ImGuiKey.PageUp,
                KeyboardKey.PageDown => ImGuiKey.PageDown,
                KeyboardKey.Home => ImGuiKey.Home,
                KeyboardKey.End => ImGuiKey.End,
                KeyboardKey.CapsLock => ImGuiKey.CapsLock,
                KeyboardKey.ScrollLock => ImGuiKey.ScrollLock,
                KeyboardKey.NumLock => ImGuiKey.NumLock,
                KeyboardKey.PrintScreen => ImGuiKey.PrintScreen,
                KeyboardKey.Pause => ImGuiKey.Pause,
                KeyboardKey.F1 => ImGuiKey.F1,
                KeyboardKey.F2 => ImGuiKey.F2,
                KeyboardKey.F3 => ImGuiKey.F3,
                KeyboardKey.F4 => ImGuiKey.F4,
                KeyboardKey.F5 => ImGuiKey.F5,
                KeyboardKey.F6 => ImGuiKey.F6,
                KeyboardKey.F7 => ImGuiKey.F7,
                KeyboardKey.F8 => ImGuiKey.F8,
                KeyboardKey.F9 => ImGuiKey.F9,
                KeyboardKey.F10 => ImGuiKey.F10,
                KeyboardKey.F11 => ImGuiKey.F11,
                KeyboardKey.F12 => ImGuiKey.F12,
                KeyboardKey.LeftShift => ImGuiKey.LeftShift,
                KeyboardKey.LeftControl => ImGuiKey.LeftCtrl,
                KeyboardKey.LeftAlt => ImGuiKey.LeftAlt,
                KeyboardKey.LeftSuper => ImGuiKey.LeftSuper,
                KeyboardKey.RightShift => ImGuiKey.RightShift,
                KeyboardKey.RightControl => ImGuiKey.RightCtrl,
                KeyboardKey.RightAlt => ImGuiKey.RightAlt,
                KeyboardKey.RightSuper => ImGuiKey.RightSuper,
                KeyboardKey.KbMenu => ImGuiKey.Menu,
                KeyboardKey.LeftBracket => ImGuiKey.LeftBracket,
                KeyboardKey.Backslash => ImGuiKey.Backslash,
                KeyboardKey.RightBracket => ImGuiKey.RightBracket,
                KeyboardKey.Grave => ImGuiKey.GraveAccent,
                KeyboardKey.Kp0 => ImGuiKey.Keypad0,
                KeyboardKey.Kp1 => ImGuiKey.Keypad1,
                KeyboardKey.Kp2 => ImGuiKey.Keypad2,
                KeyboardKey.Kp3 => ImGuiKey.Keypad3,
                KeyboardKey.Kp4 => ImGuiKey.Keypad4,
                KeyboardKey.Kp5 => ImGuiKey.Keypad5,
                KeyboardKey.Kp6 => ImGuiKey.Keypad6,
                KeyboardKey.Kp7 => ImGuiKey.Keypad7,
                KeyboardKey.Kp8 => ImGuiKey.Keypad8,
                KeyboardKey.Kp9 => ImGuiKey.Keypad9,
                KeyboardKey.KpDecimal => ImGuiKey.KeypadDecimal,
                KeyboardKey.KpDivide => ImGuiKey.KeypadDivide,
                KeyboardKey.KpMultiply => ImGuiKey.KeypadMultiply,
                KeyboardKey.KpSubtract => ImGuiKey.KeypadSubtract,
                KeyboardKey.KpAdd => ImGuiKey.KeypadAdd,
                KeyboardKey.KpEnter => ImGuiKey.KeypadEnter,
                KeyboardKey.KpEqual => ImGuiKey.KeypadEqual,
                _ => ImGuiKey.None,
            };
        }

        // raw ImGui backend API
        public static bool Init()
        {
            LastFrameFocused = Raylib.IsWindowFocused();
            LastControlPressed = false;
            LastShiftPressed = false;
            LastAltPressed = false;
            LastSuperPressed = false;

            SetupMouseCursors();

            ImGuiIOPtr io = ImGui.GetIO();
            io.BackendPlatformName = "imgui_impl_raylib".ToUTF8Ptr();
            io.BackendFlags |= ImGuiBackendFlags.HasGamepad | ImGuiBackendFlags.HasSetMousePos;

#if !PLATFORM_DRM
            io.BackendFlags |= ImGuiBackendFlags.HasMouseCursors;
#endif

            io.MousePos = new(0, 0);

            ImGuiPlatformIOPtr platformIO = ImGui.GetPlatformIO();

            io.SetClipboardTextFn = (void*)Marshal.GetFunctionPointerForDelegate<SetClipboardTextFn>(SetClipTextCallback);
            io.GetClipboardTextFn = (void*)Marshal.GetFunctionPointerForDelegate<GetClipboardTextFn>(GetClipTextCallback);

            io.ClipboardUserData = null;

            BuildFontAtlas();

            return true;
        }

        private static void BuildFontAtlas()
        {
            ReloadFonts();
        }

        public static void Shutdown()
        {
            ImGuiIOPtr io = ImGui.GetIO();
            Texture* fontTexture = (Texture*)io.Fonts.TexID.Handle;

            if (fontTexture != null)
            {
                Raylib.UnloadTexture(*fontTexture);
                Raylib.MemFree(fontTexture);
            }

            io.Fonts.TexID = 0;
        }

        public static void NewFrame()
        {
            ImGuiNewFrame(Raylib.GetFrameTime());
            ProcessEvents();
        }

        public static void RenderDrawData(ImDrawData* draw_data)
        {
            Raylib.RlDrawRenderBatchActive();
            Raylib.RlDisableBackfaceCulling();

            for (int l = 0; l < draw_data->CmdListsCount; ++l)
            {
                ImDrawList* commandList = draw_data->CmdLists[l];

                for (int i = 0; i < commandList->CmdBuffer.Size; i++)
                {
                    var cmd = commandList->CmdBuffer[i];
                    EnableScissor(cmd.ClipRect.X - draw_data->DisplayPos.X, cmd.ClipRect.Y - draw_data->DisplayPos.Y, cmd.ClipRect.Z - (cmd.ClipRect.X - draw_data->DisplayPos.X), cmd.ClipRect.W - (cmd.ClipRect.Y - draw_data->DisplayPos.Y));
                    if (cmd.UserCallback != null)
                    {
                        delegate*<ImDrawList*, ImDrawCmd*, void> userCallback = (delegate*<ImDrawList*, ImDrawCmd*, void>)cmd.UserCallback;

                        userCallback(commandList, &cmd);

                        continue;
                    }

                    ImGuiRenderTriangles(cmd.ElemCount, cmd.IdxOffset, &commandList->IdxBuffer, &commandList->VtxBuffer, (void*)cmd.TextureId.Handle);
                    Raylib.RlDrawRenderBatchActive();
                }
            }

            Raylib.RlSetTexture(0);
            Raylib.RlDisableScissorTest();
            Raylib.RlEnableBackfaceCulling();
        }

        private static void HandleGamepadButtonEvent(ImGuiIOPtr io, GamepadButton button, ImGuiKey key)
        {
            if (Raylib.IsGamepadButtonPressed(0, (int)button))
                io.AddKeyEvent(key, true);
            else if (Raylib.IsGamepadButtonReleased(0, (int)button))
                io.AddKeyEvent(key, false);
        }

        private static void HandleGamepadStickEvent(ImGuiIOPtr io, GamepadAxis axis, ImGuiKey negKey, ImGuiKey posKey)
        {
            const float deadZone = 0.20f;

            float axisValue = Raylib.GetGamepadAxisMovement(0, (int)axis);

            io.AddKeyAnalogEvent(negKey, axisValue < -deadZone, axisValue < -deadZone ? -axisValue : 0);
            io.AddKeyAnalogEvent(posKey, axisValue > deadZone, axisValue > deadZone ? axisValue : 0);
        }

        private static bool ProcessEvents()
        {
            ImGuiIOPtr io = ImGui.GetIO();

            bool focused = Raylib.IsWindowFocused();
            if (focused != LastFrameFocused)
                io.AddFocusEvent(focused);
            LastFrameFocused = focused;

            // handle the modifyer key events so that shortcuts work
            bool ctrlDown = RlImGuiIsControlDown();
            if (ctrlDown != LastControlPressed)
                io.AddKeyEvent(ImGuiKey.ModCtrl, ctrlDown);
            LastControlPressed = ctrlDown;

            bool shiftDown = RlImGuiIsShiftDown();
            if (shiftDown != LastShiftPressed)
                io.AddKeyEvent(ImGuiKey.ModShift, shiftDown);
            LastShiftPressed = shiftDown;

            bool altDown = RlImGuiIsAltDown();
            if (altDown != LastAltPressed)
                io.AddKeyEvent(ImGuiKey.ModAlt, altDown);
            LastAltPressed = altDown;

            bool superDown = RlImGuiIsSuperDown();
            if (superDown != LastSuperPressed)
                io.AddKeyEvent(ImGuiKey.ModSuper, superDown);
            LastSuperPressed = superDown;

            // get the pressed keys, just walk the keys so we don
            for (int keyId = (int)KeyboardKey.Null; keyId < (int)KeyboardKey.KpEqual; keyId++)
            {
                if (Raylib.IsKeyReleased(keyId))
                {
                    io.AddKeyEvent(MapKeyToImGuiKey((KeyboardKey)keyId), false);
                }
                else if (Raylib.IsKeyPressed(keyId))
                {
                    io.AddKeyEvent(MapKeyToImGuiKey((KeyboardKey)keyId), true);
                }
            }

            if (io.WantCaptureKeyboard)
            {
                // add the text input in order
                uint pressed = (uint)Raylib.GetCharPressed();
                while (pressed != 0)
                {
                    io.AddInputCharacter(pressed);
                    pressed = (uint)Raylib.GetCharPressed();
                }
            }

            if ((io.ConfigFlags & ImGuiConfigFlags.NavEnableGamepad) != 0 && Raylib.IsGamepadAvailable(0))
            {
                HandleGamepadButtonEvent(io, GamepadButton.LeftFaceUp, ImGuiKey.GamepadDpadUp);
                HandleGamepadButtonEvent(io, GamepadButton.LeftFaceRight, ImGuiKey.GamepadDpadRight);
                HandleGamepadButtonEvent(io, GamepadButton.LeftFaceDown, ImGuiKey.GamepadDpadDown);
                HandleGamepadButtonEvent(io, GamepadButton.LeftFaceLeft, ImGuiKey.GamepadDpadLeft);

                HandleGamepadButtonEvent(io, GamepadButton.RightFaceUp, ImGuiKey.GamepadFaceUp);
                HandleGamepadButtonEvent(io, GamepadButton.RightFaceRight, ImGuiKey.GamepadFaceLeft);
                HandleGamepadButtonEvent(io, GamepadButton.RightFaceDown, ImGuiKey.GamepadFaceDown);
                HandleGamepadButtonEvent(io, GamepadButton.RightFaceLeft, ImGuiKey.GamepadFaceRight);

                HandleGamepadButtonEvent(io, GamepadButton.LeftTrigger1, ImGuiKey.GamepadL1);
                HandleGamepadButtonEvent(io, GamepadButton.LeftTrigger2, ImGuiKey.GamepadL2);
                HandleGamepadButtonEvent(io, GamepadButton.RightTrigger1, ImGuiKey.GamepadR1);
                HandleGamepadButtonEvent(io, GamepadButton.RightTrigger2, ImGuiKey.GamepadR2);
                HandleGamepadButtonEvent(io, GamepadButton.LeftThumb, ImGuiKey.GamepadL3);
                HandleGamepadButtonEvent(io, GamepadButton.RightThumb, ImGuiKey.GamepadR3);

                HandleGamepadButtonEvent(io, GamepadButton.MiddleLeft, ImGuiKey.GamepadStart);
                HandleGamepadButtonEvent(io, GamepadButton.MiddleRight, ImGuiKey.GamepadBack);

                // left stick
                HandleGamepadStickEvent(io, GamepadAxis.LeftX, ImGuiKey.GamepadLStickLeft, ImGuiKey.GamepadLStickRight);
                HandleGamepadStickEvent(io, GamepadAxis.LeftY, ImGuiKey.GamepadLStickUp, ImGuiKey.GamepadLStickDown);

                // right stick
                HandleGamepadStickEvent(io, GamepadAxis.RightX, ImGuiKey.GamepadRStickLeft, ImGuiKey.GamepadRStickRight);
                HandleGamepadStickEvent(io, GamepadAxis.RightY, ImGuiKey.GamepadRStickUp, ImGuiKey.GamepadRStickDown);
            }

            return true;
        }
    }
}