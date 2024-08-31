using ExampleFramework.ImGuiDemo;
using Hexa.NET.ImGui;
using Hexa.NET.Raylib;

Raylib.InitWindow(1280, 720, "Example");

Raylib.SetTargetFPS(60);

ImGuiManager manager = new();

while (!Raylib.WindowShouldClose())
{
    manager.NewFrame();

    ImGui.ShowDemoWindow();

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Raylib.Blank);
    manager.EndFrame();

    Raylib.EndDrawing();
}

manager.Dispose();

Raylib.CloseWindow();