// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.Raylib
{
	public unsafe partial class Raylib
	{
		internal static FunctionTable funcTable;

		/// <summary>
		/// Initializes the function table, automatically called. Do not call manually, only after <see cref="FreeApi"/>.
		/// </summary>
		public static void InitApi()
		{
			funcTable = new FunctionTable(LibraryLoader.LoadLibrary(GetLibraryName, null), 748);
			funcTable.Load(0, "InitWindow");
			funcTable.Load(1, "CloseWindow");
			funcTable.Load(2, "WindowShouldClose");
			funcTable.Load(3, "IsWindowReady");
			funcTable.Load(4, "IsWindowFullscreen");
			funcTable.Load(5, "IsWindowHidden");
			funcTable.Load(6, "IsWindowMinimized");
			funcTable.Load(7, "IsWindowMaximized");
			funcTable.Load(8, "IsWindowFocused");
			funcTable.Load(9, "IsWindowResized");
			funcTable.Load(10, "IsWindowState");
			funcTable.Load(11, "SetWindowState");
			funcTable.Load(12, "ClearWindowState");
			funcTable.Load(13, "ToggleFullscreen");
			funcTable.Load(14, "ToggleBorderlessWindowed");
			funcTable.Load(15, "MaximizeWindow");
			funcTable.Load(16, "MinimizeWindow");
			funcTable.Load(17, "RestoreWindow");
			funcTable.Load(18, "SetWindowIcon");
			funcTable.Load(19, "SetWindowIcons");
			funcTable.Load(20, "SetWindowTitle");
			funcTable.Load(21, "SetWindowPosition");
			funcTable.Load(22, "SetWindowMonitor");
			funcTable.Load(23, "SetWindowMinSize");
			funcTable.Load(24, "SetWindowMaxSize");
			funcTable.Load(25, "SetWindowSize");
			funcTable.Load(26, "SetWindowOpacity");
			funcTable.Load(27, "SetWindowFocused");
			funcTable.Load(28, "GetWindowHandle");
			funcTable.Load(29, "GetScreenWidth");
			funcTable.Load(30, "GetScreenHeight");
			funcTable.Load(31, "GetRenderWidth");
			funcTable.Load(32, "GetRenderHeight");
			funcTable.Load(33, "GetMonitorCount");
			funcTable.Load(34, "GetCurrentMonitor");
			funcTable.Load(35, "GetMonitorPosition");
			funcTable.Load(36, "GetMonitorWidth");
			funcTable.Load(37, "GetMonitorHeight");
			funcTable.Load(38, "GetMonitorPhysicalWidth");
			funcTable.Load(39, "GetMonitorPhysicalHeight");
			funcTable.Load(40, "GetMonitorRefreshRate");
			funcTable.Load(41, "GetWindowPosition");
			funcTable.Load(42, "GetWindowScaleDPI");
			funcTable.Load(43, "GetMonitorName");
			funcTable.Load(44, "SetClipboardText");
			funcTable.Load(45, "GetClipboardText");
			funcTable.Load(46, "GetClipboardImage");
			funcTable.Load(47, "EnableEventWaiting");
			funcTable.Load(48, "DisableEventWaiting");
			funcTable.Load(49, "ShowCursor");
			funcTable.Load(50, "HideCursor");
			funcTable.Load(51, "IsCursorHidden");
			funcTable.Load(52, "EnableCursor");
			funcTable.Load(53, "DisableCursor");
			funcTable.Load(54, "IsCursorOnScreen");
			funcTable.Load(55, "ClearBackground");
			funcTable.Load(56, "BeginDrawing");
			funcTable.Load(57, "EndDrawing");
			funcTable.Load(58, "BeginMode2D");
			funcTable.Load(59, "EndMode2D");
			funcTable.Load(60, "BeginMode3D");
			funcTable.Load(61, "EndMode3D");
			funcTable.Load(62, "BeginTextureMode");
			funcTable.Load(63, "EndTextureMode");
			funcTable.Load(64, "BeginShaderMode");
			funcTable.Load(65, "EndShaderMode");
			funcTable.Load(66, "BeginBlendMode");
			funcTable.Load(67, "EndBlendMode");
			funcTable.Load(68, "BeginScissorMode");
			funcTable.Load(69, "EndScissorMode");
			funcTable.Load(70, "BeginVrStereoMode");
			funcTable.Load(71, "EndVrStereoMode");
			funcTable.Load(72, "LoadVrStereoConfig");
			funcTable.Load(73, "UnloadVrStereoConfig");
			funcTable.Load(74, "LoadShader");
			funcTable.Load(75, "LoadShaderFromMemory");
			funcTable.Load(76, "IsShaderValid");
			funcTable.Load(77, "GetShaderLocation");
			funcTable.Load(78, "GetShaderLocationAttrib");
			funcTable.Load(79, "SetShaderValue");
			funcTable.Load(80, "SetShaderValueV");
			funcTable.Load(81, "SetShaderValueMatrix");
			funcTable.Load(82, "SetShaderValueTexture");
			funcTable.Load(83, "UnloadShader");
			funcTable.Load(84, "GetScreenToWorldRay");
			funcTable.Load(85, "GetScreenToWorldRayEx");
			funcTable.Load(86, "GetWorldToScreen");
			funcTable.Load(87, "GetWorldToScreenEx");
			funcTable.Load(88, "GetWorldToScreen2D");
			funcTable.Load(89, "GetScreenToWorld2D");
			funcTable.Load(90, "GetCameraMatrix");
			funcTable.Load(91, "GetCameraMatrix2D");
			funcTable.Load(92, "SetTargetFPS");
			funcTable.Load(93, "GetFrameTime");
			funcTable.Load(94, "GetTime");
			funcTable.Load(95, "GetFPS");
			funcTable.Load(96, "SwapScreenBuffer");
			funcTable.Load(97, "PollInputEvents");
			funcTable.Load(98, "WaitTime");
			funcTable.Load(99, "SetRandomSeed");
			funcTable.Load(100, "GetRandomValue");
			funcTable.Load(101, "LoadRandomSequence");
			funcTable.Load(102, "UnloadRandomSequence");
			funcTable.Load(103, "TakeScreenshot");
			funcTable.Load(104, "SetConfigFlags");
			funcTable.Load(105, "OpenURL");
			funcTable.Load(106, "TraceLog");
			funcTable.Load(107, "SetTraceLogLevel");
			funcTable.Load(108, "MemAlloc");
			funcTable.Load(109, "MemRealloc");
			funcTable.Load(110, "MemFree");
			funcTable.Load(111, "SetTraceLogCallback");
			funcTable.Load(112, "SetLoadFileDataCallback");
			funcTable.Load(113, "SetSaveFileDataCallback");
			funcTable.Load(114, "SetLoadFileTextCallback");
			funcTable.Load(115, "SetSaveFileTextCallback");
			funcTable.Load(116, "LoadFileData");
			funcTable.Load(117, "UnloadFileData");
			funcTable.Load(118, "SaveFileData");
			funcTable.Load(119, "ExportDataAsCode");
			funcTable.Load(120, "LoadFileText");
			funcTable.Load(121, "UnloadFileText");
			funcTable.Load(122, "SaveFileText");
			funcTable.Load(123, "FileExists");
			funcTable.Load(124, "DirectoryExists");
			funcTable.Load(125, "IsFileExtension");
			funcTable.Load(126, "GetFileLength");
			funcTable.Load(127, "GetFileExtension");
			funcTable.Load(128, "GetFileName");
			funcTable.Load(129, "GetFileNameWithoutExt");
			funcTable.Load(130, "GetDirectoryPath");
			funcTable.Load(131, "GetPrevDirectoryPath");
			funcTable.Load(132, "GetWorkingDirectory");
			funcTable.Load(133, "GetApplicationDirectory");
			funcTable.Load(134, "MakeDirectory");
			funcTable.Load(135, "ChangeDirectory");
			funcTable.Load(136, "IsPathFile");
			funcTable.Load(137, "IsFileNameValid");
			funcTable.Load(138, "LoadDirectoryFiles");
			funcTable.Load(139, "LoadDirectoryFilesEx");
			funcTable.Load(140, "UnloadDirectoryFiles");
			funcTable.Load(141, "IsFileDropped");
			funcTable.Load(142, "LoadDroppedFiles");
			funcTable.Load(143, "UnloadDroppedFiles");
			funcTable.Load(144, "GetFileModTime");
			funcTable.Load(145, "CompressData");
			funcTable.Load(146, "DecompressData");
			funcTable.Load(147, "EncodeDataBase64");
			funcTable.Load(148, "DecodeDataBase64");
			funcTable.Load(149, "ComputeCRC32");
			funcTable.Load(150, "ComputeMD5");
			funcTable.Load(151, "ComputeSHA1");
			funcTable.Load(152, "LoadAutomationEventList");
			funcTable.Load(153, "UnloadAutomationEventList");
			funcTable.Load(154, "ExportAutomationEventList");
			funcTable.Load(155, "SetAutomationEventList");
			funcTable.Load(156, "SetAutomationEventBaseFrame");
			funcTable.Load(157, "StartAutomationEventRecording");
			funcTable.Load(158, "StopAutomationEventRecording");
			funcTable.Load(159, "PlayAutomationEvent");
			funcTable.Load(160, "IsKeyPressed");
			funcTable.Load(161, "IsKeyPressedRepeat");
			funcTable.Load(162, "IsKeyDown");
			funcTable.Load(163, "IsKeyReleased");
			funcTable.Load(164, "IsKeyUp");
			funcTable.Load(165, "GetKeyPressed");
			funcTable.Load(166, "GetCharPressed");
			funcTable.Load(167, "SetExitKey");
			funcTable.Load(168, "IsGamepadAvailable");
			funcTable.Load(169, "GetGamepadName");
			funcTable.Load(170, "IsGamepadButtonPressed");
			funcTable.Load(171, "IsGamepadButtonDown");
			funcTable.Load(172, "IsGamepadButtonReleased");
			funcTable.Load(173, "IsGamepadButtonUp");
			funcTable.Load(174, "GetGamepadButtonPressed");
			funcTable.Load(175, "GetGamepadAxisCount");
			funcTable.Load(176, "GetGamepadAxisMovement");
			funcTable.Load(177, "SetGamepadMappings");
			funcTable.Load(178, "SetGamepadVibration");
			funcTable.Load(179, "IsMouseButtonPressed");
			funcTable.Load(180, "IsMouseButtonDown");
			funcTable.Load(181, "IsMouseButtonReleased");
			funcTable.Load(182, "IsMouseButtonUp");
			funcTable.Load(183, "GetMouseX");
			funcTable.Load(184, "GetMouseY");
			funcTable.Load(185, "GetMousePosition");
			funcTable.Load(186, "GetMouseDelta");
			funcTable.Load(187, "SetMousePosition");
			funcTable.Load(188, "SetMouseOffset");
			funcTable.Load(189, "SetMouseScale");
			funcTable.Load(190, "GetMouseWheelMove");
			funcTable.Load(191, "GetMouseWheelMoveV");
			funcTable.Load(192, "SetMouseCursor");
			funcTable.Load(193, "GetTouchX");
			funcTable.Load(194, "GetTouchY");
			funcTable.Load(195, "GetTouchPosition");
			funcTable.Load(196, "GetTouchPointId");
			funcTable.Load(197, "GetTouchPointCount");
			funcTable.Load(198, "SetGesturesEnabled");
			funcTable.Load(199, "IsGestureDetected");
			funcTable.Load(200, "GetGestureDetected");
			funcTable.Load(201, "GetGestureHoldDuration");
			funcTable.Load(202, "GetGestureDragVector");
			funcTable.Load(203, "GetGestureDragAngle");
			funcTable.Load(204, "GetGesturePinchVector");
			funcTable.Load(205, "GetGesturePinchAngle");
			funcTable.Load(206, "UpdateCamera");
			funcTable.Load(207, "UpdateCameraPro");
			funcTable.Load(208, "SetShapesTexture");
			funcTable.Load(209, "GetShapesTexture");
			funcTable.Load(210, "GetShapesTextureRectangle");
			funcTable.Load(211, "DrawPixel");
			funcTable.Load(212, "DrawPixelV");
			funcTable.Load(213, "DrawLine");
			funcTable.Load(214, "DrawLineV");
			funcTable.Load(215, "DrawLineEx");
			funcTable.Load(216, "DrawLineStrip");
			funcTable.Load(217, "DrawLineBezier");
			funcTable.Load(218, "DrawCircle");
			funcTable.Load(219, "DrawCircleSector");
			funcTable.Load(220, "DrawCircleSectorLines");
			funcTable.Load(221, "DrawCircleGradient");
			funcTable.Load(222, "DrawCircleV");
			funcTable.Load(223, "DrawCircleLines");
			funcTable.Load(224, "DrawCircleLinesV");
			funcTable.Load(225, "DrawEllipse");
			funcTable.Load(226, "DrawEllipseLines");
			funcTable.Load(227, "DrawRing");
			funcTable.Load(228, "DrawRingLines");
			funcTable.Load(229, "DrawRectangle");
			funcTable.Load(230, "DrawRectangleV");
			funcTable.Load(231, "DrawRectangleRec");
			funcTable.Load(232, "DrawRectanglePro");
			funcTable.Load(233, "DrawRectangleGradientV");
			funcTable.Load(234, "DrawRectangleGradientH");
			funcTable.Load(235, "DrawRectangleGradientEx");
			funcTable.Load(236, "DrawRectangleLines");
			funcTable.Load(237, "DrawRectangleLinesEx");
			funcTable.Load(238, "DrawRectangleRounded");
			funcTable.Load(239, "DrawRectangleRoundedLines");
			funcTable.Load(240, "DrawRectangleRoundedLinesEx");
			funcTable.Load(241, "DrawTriangle");
			funcTable.Load(242, "DrawTriangleLines");
			funcTable.Load(243, "DrawTriangleFan");
			funcTable.Load(244, "DrawTriangleStrip");
			funcTable.Load(245, "DrawPoly");
			funcTable.Load(246, "DrawPolyLines");
			funcTable.Load(247, "DrawPolyLinesEx");
			funcTable.Load(248, "DrawSplineLinear");
			funcTable.Load(249, "DrawSplineBasis");
			funcTable.Load(250, "DrawSplineCatmullRom");
			funcTable.Load(251, "DrawSplineBezierQuadratic");
			funcTable.Load(252, "DrawSplineBezierCubic");
			funcTable.Load(253, "DrawSplineSegmentLinear");
			funcTable.Load(254, "DrawSplineSegmentBasis");
			funcTable.Load(255, "DrawSplineSegmentCatmullRom");
			funcTable.Load(256, "DrawSplineSegmentBezierQuadratic");
			funcTable.Load(257, "DrawSplineSegmentBezierCubic");
			funcTable.Load(258, "GetSplinePointLinear");
			funcTable.Load(259, "GetSplinePointBasis");
			funcTable.Load(260, "GetSplinePointCatmullRom");
			funcTable.Load(261, "GetSplinePointBezierQuad");
			funcTable.Load(262, "GetSplinePointBezierCubic");
			funcTable.Load(263, "CheckCollisionRecs");
			funcTable.Load(264, "CheckCollisionCircles");
			funcTable.Load(265, "CheckCollisionCircleRec");
			funcTable.Load(266, "CheckCollisionCircleLine");
			funcTable.Load(267, "CheckCollisionPointRec");
			funcTable.Load(268, "CheckCollisionPointCircle");
			funcTable.Load(269, "CheckCollisionPointTriangle");
			funcTable.Load(270, "CheckCollisionPointLine");
			funcTable.Load(271, "CheckCollisionPointPoly");
			funcTable.Load(272, "CheckCollisionLines");
			funcTable.Load(273, "GetCollisionRec");
			funcTable.Load(274, "LoadImage");
			funcTable.Load(275, "LoadImageRaw");
			funcTable.Load(276, "LoadImageAnim");
			funcTable.Load(277, "LoadImageAnimFromMemory");
			funcTable.Load(278, "LoadImageFromMemory");
			funcTable.Load(279, "LoadImageFromTexture");
			funcTable.Load(280, "LoadImageFromScreen");
			funcTable.Load(281, "IsImageValid");
			funcTable.Load(282, "UnloadImage");
			funcTable.Load(283, "ExportImage");
			funcTable.Load(284, "ExportImageToMemory");
			funcTable.Load(285, "ExportImageAsCode");
			funcTable.Load(286, "GenImageColor");
			funcTable.Load(287, "GenImageGradientLinear");
			funcTable.Load(288, "GenImageGradientRadial");
			funcTable.Load(289, "GenImageGradientSquare");
			funcTable.Load(290, "GenImageChecked");
			funcTable.Load(291, "GenImageWhiteNoise");
			funcTable.Load(292, "GenImagePerlinNoise");
			funcTable.Load(293, "GenImageCellular");
			funcTable.Load(294, "GenImageText");
			funcTable.Load(295, "ImageCopy");
			funcTable.Load(296, "ImageFromImage");
			funcTable.Load(297, "ImageFromChannel");
			funcTable.Load(298, "ImageText");
			funcTable.Load(299, "ImageTextEx");
			funcTable.Load(300, "ImageFormat");
			funcTable.Load(301, "ImageToPOT");
			funcTable.Load(302, "ImageCrop");
			funcTable.Load(303, "ImageAlphaCrop");
			funcTable.Load(304, "ImageAlphaClear");
			funcTable.Load(305, "ImageAlphaMask");
			funcTable.Load(306, "ImageAlphaPremultiply");
			funcTable.Load(307, "ImageBlurGaussian");
			funcTable.Load(308, "ImageKernelConvolution");
			funcTable.Load(309, "ImageResize");
			funcTable.Load(310, "ImageResizeNN");
			funcTable.Load(311, "ImageResizeCanvas");
			funcTable.Load(312, "ImageMipmaps");
			funcTable.Load(313, "ImageDither");
			funcTable.Load(314, "ImageFlipVertical");
			funcTable.Load(315, "ImageFlipHorizontal");
			funcTable.Load(316, "ImageRotate");
			funcTable.Load(317, "ImageRotateCW");
			funcTable.Load(318, "ImageRotateCCW");
			funcTable.Load(319, "ImageColorTint");
			funcTable.Load(320, "ImageColorInvert");
			funcTable.Load(321, "ImageColorGrayscale");
			funcTable.Load(322, "ImageColorContrast");
			funcTable.Load(323, "ImageColorBrightness");
			funcTable.Load(324, "ImageColorReplace");
			funcTable.Load(325, "LoadImageColors");
			funcTable.Load(326, "LoadImagePalette");
			funcTable.Load(327, "UnloadImageColors");
			funcTable.Load(328, "UnloadImagePalette");
			funcTable.Load(329, "GetImageAlphaBorder");
			funcTable.Load(330, "GetImageColor");
			funcTable.Load(331, "ImageClearBackground");
			funcTable.Load(332, "ImageDrawPixel");
			funcTable.Load(333, "ImageDrawPixelV");
			funcTable.Load(334, "ImageDrawLine");
			funcTable.Load(335, "ImageDrawLineV");
			funcTable.Load(336, "ImageDrawLineEx");
			funcTable.Load(337, "ImageDrawCircle");
			funcTable.Load(338, "ImageDrawCircleV");
			funcTable.Load(339, "ImageDrawCircleLines");
			funcTable.Load(340, "ImageDrawCircleLinesV");
			funcTable.Load(341, "ImageDrawRectangle");
			funcTable.Load(342, "ImageDrawRectangleV");
			funcTable.Load(343, "ImageDrawRectangleRec");
			funcTable.Load(344, "ImageDrawRectangleLines");
			funcTable.Load(345, "ImageDrawTriangle");
			funcTable.Load(346, "ImageDrawTriangleEx");
			funcTable.Load(347, "ImageDrawTriangleLines");
			funcTable.Load(348, "ImageDrawTriangleFan");
			funcTable.Load(349, "ImageDrawTriangleStrip");
			funcTable.Load(350, "ImageDraw");
			funcTable.Load(351, "ImageDrawText");
			funcTable.Load(352, "ImageDrawTextEx");
			funcTable.Load(353, "LoadTexture");
			funcTable.Load(354, "LoadTextureFromImage");
			funcTable.Load(355, "LoadTextureCubemap");
			funcTable.Load(356, "LoadRenderTexture");
			funcTable.Load(357, "IsTextureValid");
			funcTable.Load(358, "UnloadTexture");
			funcTable.Load(359, "IsRenderTextureValid");
			funcTable.Load(360, "UnloadRenderTexture");
			funcTable.Load(361, "UpdateTexture");
			funcTable.Load(362, "UpdateTextureRec");
			funcTable.Load(363, "GenTextureMipmaps");
			funcTable.Load(364, "SetTextureFilter");
			funcTable.Load(365, "SetTextureWrap");
			funcTable.Load(366, "DrawTexture");
			funcTable.Load(367, "DrawTextureV");
			funcTable.Load(368, "DrawTextureEx");
			funcTable.Load(369, "DrawTextureRec");
			funcTable.Load(370, "DrawTexturePro");
			funcTable.Load(371, "DrawTextureNPatch");
			funcTable.Load(372, "ColorIsEqual");
			funcTable.Load(373, "Fade");
			funcTable.Load(374, "ColorToInt");
			funcTable.Load(375, "ColorNormalize");
			funcTable.Load(376, "ColorFromNormalized");
			funcTable.Load(377, "ColorToHSV");
			funcTable.Load(378, "ColorFromHSV");
			funcTable.Load(379, "ColorTint");
			funcTable.Load(380, "ColorBrightness");
			funcTable.Load(381, "ColorContrast");
			funcTable.Load(382, "ColorAlpha");
			funcTable.Load(383, "ColorAlphaBlend");
			funcTable.Load(384, "ColorLerp");
			funcTable.Load(385, "GetColor");
			funcTable.Load(386, "GetPixelColor");
			funcTable.Load(387, "SetPixelColor");
			funcTable.Load(388, "GetPixelDataSize");
			funcTable.Load(389, "GetFontDefault");
			funcTable.Load(390, "LoadFont");
			funcTable.Load(391, "LoadFontEx");
			funcTable.Load(392, "LoadFontFromImage");
			funcTable.Load(393, "LoadFontFromMemory");
			funcTable.Load(394, "IsFontValid");
			funcTable.Load(395, "LoadFontData");
			funcTable.Load(396, "GenImageFontAtlas");
			funcTable.Load(397, "UnloadFontData");
			funcTable.Load(398, "UnloadFont");
			funcTable.Load(399, "ExportFontAsCode");
			funcTable.Load(400, "DrawFPS");
			funcTable.Load(401, "DrawText");
			funcTable.Load(402, "DrawTextEx");
			funcTable.Load(403, "DrawTextPro");
			funcTable.Load(404, "DrawTextCodepoint");
			funcTable.Load(405, "DrawTextCodepoints");
			funcTable.Load(406, "SetTextLineSpacing");
			funcTable.Load(407, "MeasureText");
			funcTable.Load(408, "MeasureTextEx");
			funcTable.Load(409, "GetGlyphIndex");
			funcTable.Load(410, "GetGlyphInfo");
			funcTable.Load(411, "GetGlyphAtlasRec");
			funcTable.Load(412, "LoadUTF8");
			funcTable.Load(413, "UnloadUTF8");
			funcTable.Load(414, "LoadCodepoints");
			funcTable.Load(415, "UnloadCodepoints");
			funcTable.Load(416, "GetCodepointCount");
			funcTable.Load(417, "GetCodepoint");
			funcTable.Load(418, "GetCodepointNext");
			funcTable.Load(419, "GetCodepointPrevious");
			funcTable.Load(420, "CodepointToUTF8");
			funcTable.Load(421, "TextCopy");
			funcTable.Load(422, "TextIsEqual");
			funcTable.Load(423, "TextLength");
			funcTable.Load(424, "TextFormat");
			funcTable.Load(425, "TextSubtext");
			funcTable.Load(426, "TextReplace");
			funcTable.Load(427, "TextInsert");
			funcTable.Load(428, "TextJoin");
			funcTable.Load(429, "TextAppend");
			funcTable.Load(430, "TextFindIndex");
			funcTable.Load(431, "TextToUpper");
			funcTable.Load(432, "TextToLower");
			funcTable.Load(433, "TextToPascal");
			funcTable.Load(434, "TextToSnake");
			funcTable.Load(435, "TextToCamel");
			funcTable.Load(436, "TextToInteger");
			funcTable.Load(437, "TextToFloat");
			funcTable.Load(438, "DrawLine3D");
			funcTable.Load(439, "DrawPoint3D");
			funcTable.Load(440, "DrawCircle3D");
			funcTable.Load(441, "DrawTriangle3D");
			funcTable.Load(442, "DrawTriangleStrip3D");
			funcTable.Load(443, "DrawCube");
			funcTable.Load(444, "DrawCubeV");
			funcTable.Load(445, "DrawCubeWires");
			funcTable.Load(446, "DrawCubeWiresV");
			funcTable.Load(447, "DrawSphere");
			funcTable.Load(448, "DrawSphereEx");
			funcTable.Load(449, "DrawSphereWires");
			funcTable.Load(450, "DrawCylinder");
			funcTable.Load(451, "DrawCylinderEx");
			funcTable.Load(452, "DrawCylinderWires");
			funcTable.Load(453, "DrawCylinderWiresEx");
			funcTable.Load(454, "DrawCapsule");
			funcTable.Load(455, "DrawCapsuleWires");
			funcTable.Load(456, "DrawPlane");
			funcTable.Load(457, "DrawRay");
			funcTable.Load(458, "DrawGrid");
			funcTable.Load(459, "LoadModel");
			funcTable.Load(460, "LoadModelFromMesh");
			funcTable.Load(461, "IsModelValid");
			funcTable.Load(462, "UnloadModel");
			funcTable.Load(463, "GetModelBoundingBox");
			funcTable.Load(464, "DrawModel");
			funcTable.Load(465, "DrawModelEx");
			funcTable.Load(466, "DrawModelWires");
			funcTable.Load(467, "DrawModelWiresEx");
			funcTable.Load(468, "DrawModelPoints");
			funcTable.Load(469, "DrawModelPointsEx");
			funcTable.Load(470, "DrawBoundingBox");
			funcTable.Load(471, "DrawBillboard");
			funcTable.Load(472, "DrawBillboardRec");
			funcTable.Load(473, "DrawBillboardPro");
			funcTable.Load(474, "UploadMesh");
			funcTable.Load(475, "UpdateMeshBuffer");
			funcTable.Load(476, "UnloadMesh");
			funcTable.Load(477, "DrawMesh");
			funcTable.Load(478, "DrawMeshInstanced");
			funcTable.Load(479, "GetMeshBoundingBox");
			funcTable.Load(480, "GenMeshTangents");
			funcTable.Load(481, "ExportMesh");
			funcTable.Load(482, "ExportMeshAsCode");
			funcTable.Load(483, "GenMeshPoly");
			funcTable.Load(484, "GenMeshPlane");
			funcTable.Load(485, "GenMeshCube");
			funcTable.Load(486, "GenMeshSphere");
			funcTable.Load(487, "GenMeshHemiSphere");
			funcTable.Load(488, "GenMeshCylinder");
			funcTable.Load(489, "GenMeshCone");
			funcTable.Load(490, "GenMeshTorus");
			funcTable.Load(491, "GenMeshKnot");
			funcTable.Load(492, "GenMeshHeightmap");
			funcTable.Load(493, "GenMeshCubicmap");
			funcTable.Load(494, "LoadMaterials");
			funcTable.Load(495, "LoadMaterialDefault");
			funcTable.Load(496, "IsMaterialValid");
			funcTable.Load(497, "UnloadMaterial");
			funcTable.Load(498, "SetMaterialTexture");
			funcTable.Load(499, "SetModelMeshMaterial");
			funcTable.Load(500, "LoadModelAnimations");
			funcTable.Load(501, "UpdateModelAnimation");
			funcTable.Load(502, "UpdateModelAnimationBones");
			funcTable.Load(503, "UnloadModelAnimation");
			funcTable.Load(504, "UnloadModelAnimations");
			funcTable.Load(505, "IsModelAnimationValid");
			funcTable.Load(506, "CheckCollisionSpheres");
			funcTable.Load(507, "CheckCollisionBoxes");
			funcTable.Load(508, "CheckCollisionBoxSphere");
			funcTable.Load(509, "GetRayCollisionSphere");
			funcTable.Load(510, "GetRayCollisionBox");
			funcTable.Load(511, "GetRayCollisionMesh");
			funcTable.Load(512, "GetRayCollisionTriangle");
			funcTable.Load(513, "GetRayCollisionQuad");
			funcTable.Load(514, "InitAudioDevice");
			funcTable.Load(515, "CloseAudioDevice");
			funcTable.Load(516, "IsAudioDeviceReady");
			funcTable.Load(517, "SetMasterVolume");
			funcTable.Load(518, "GetMasterVolume");
			funcTable.Load(519, "LoadWave");
			funcTable.Load(520, "LoadWaveFromMemory");
			funcTable.Load(521, "IsWaveValid");
			funcTable.Load(522, "LoadSound");
			funcTable.Load(523, "LoadSoundFromWave");
			funcTable.Load(524, "LoadSoundAlias");
			funcTable.Load(525, "IsSoundValid");
			funcTable.Load(526, "UpdateSound");
			funcTable.Load(527, "UnloadWave");
			funcTable.Load(528, "UnloadSound");
			funcTable.Load(529, "UnloadSoundAlias");
			funcTable.Load(530, "ExportWave");
			funcTable.Load(531, "ExportWaveAsCode");
			funcTable.Load(532, "PlaySound");
			funcTable.Load(533, "StopSound");
			funcTable.Load(534, "PauseSound");
			funcTable.Load(535, "ResumeSound");
			funcTable.Load(536, "IsSoundPlaying");
			funcTable.Load(537, "SetSoundVolume");
			funcTable.Load(538, "SetSoundPitch");
			funcTable.Load(539, "SetSoundPan");
			funcTable.Load(540, "WaveCopy");
			funcTable.Load(541, "WaveCrop");
			funcTable.Load(542, "WaveFormat");
			funcTable.Load(543, "LoadWaveSamples");
			funcTable.Load(544, "UnloadWaveSamples");
			funcTable.Load(545, "LoadMusicStream");
			funcTable.Load(546, "LoadMusicStreamFromMemory");
			funcTable.Load(547, "IsMusicValid");
			funcTable.Load(548, "UnloadMusicStream");
			funcTable.Load(549, "PlayMusicStream");
			funcTable.Load(550, "IsMusicStreamPlaying");
			funcTable.Load(551, "UpdateMusicStream");
			funcTable.Load(552, "StopMusicStream");
			funcTable.Load(553, "PauseMusicStream");
			funcTable.Load(554, "ResumeMusicStream");
			funcTable.Load(555, "SeekMusicStream");
			funcTable.Load(556, "SetMusicVolume");
			funcTable.Load(557, "SetMusicPitch");
			funcTable.Load(558, "SetMusicPan");
			funcTable.Load(559, "GetMusicTimeLength");
			funcTable.Load(560, "GetMusicTimePlayed");
			funcTable.Load(561, "LoadAudioStream");
			funcTable.Load(562, "IsAudioStreamValid");
			funcTable.Load(563, "UnloadAudioStream");
			funcTable.Load(564, "UpdateAudioStream");
			funcTable.Load(565, "IsAudioStreamProcessed");
			funcTable.Load(566, "PlayAudioStream");
			funcTable.Load(567, "PauseAudioStream");
			funcTable.Load(568, "ResumeAudioStream");
			funcTable.Load(569, "IsAudioStreamPlaying");
			funcTable.Load(570, "StopAudioStream");
			funcTable.Load(571, "SetAudioStreamVolume");
			funcTable.Load(572, "SetAudioStreamPitch");
			funcTable.Load(573, "SetAudioStreamPan");
			funcTable.Load(574, "SetAudioStreamBufferSizeDefault");
			funcTable.Load(575, "SetAudioStreamCallback");
			funcTable.Load(576, "AttachAudioStreamProcessor");
			funcTable.Load(577, "DetachAudioStreamProcessor");
			funcTable.Load(578, "AttachAudioMixedProcessor");
			funcTable.Load(579, "DetachAudioMixedProcessor");
			funcTable.Load(580, "GetCameraForward");
			funcTable.Load(581, "GetCameraUp");
			funcTable.Load(582, "GetCameraRight");
			funcTable.Load(583, "CameraMoveForward");
			funcTable.Load(584, "CameraMoveUp");
			funcTable.Load(585, "CameraMoveRight");
			funcTable.Load(586, "CameraMoveToTarget");
			funcTable.Load(587, "CameraYaw");
			funcTable.Load(588, "CameraPitch");
			funcTable.Load(589, "CameraRoll");
			funcTable.Load(590, "GetCameraViewMatrix");
			funcTable.Load(591, "GetCameraProjectionMatrix");
			funcTable.Load(592, "ProcessGestureEvent");
			funcTable.Load(593, "UpdateGestures");
			funcTable.Load(594, "rlMatrixMode");
			funcTable.Load(595, "rlPushMatrix");
			funcTable.Load(596, "rlPopMatrix");
			funcTable.Load(597, "rlLoadIdentity");
			funcTable.Load(598, "rlTranslatef");
			funcTable.Load(599, "rlRotatef");
			funcTable.Load(600, "rlScalef");
			funcTable.Load(601, "rlMultMatrixf");
			funcTable.Load(602, "rlFrustum");
			funcTable.Load(603, "rlOrtho");
			funcTable.Load(604, "rlViewport");
			funcTable.Load(605, "rlSetClipPlanes");
			funcTable.Load(606, "rlGetCullDistanceNear");
			funcTable.Load(607, "rlGetCullDistanceFar");
			funcTable.Load(608, "rlBegin");
			funcTable.Load(609, "rlEnd");
			funcTable.Load(610, "rlVertex2i");
			funcTable.Load(611, "rlVertex2f");
			funcTable.Load(612, "rlVertex3f");
			funcTable.Load(613, "rlTexCoord2f");
			funcTable.Load(614, "rlNormal3f");
			funcTable.Load(615, "rlColor4ub");
			funcTable.Load(616, "rlColor3f");
			funcTable.Load(617, "rlColor4f");
			funcTable.Load(618, "rlEnableVertexArray");
			funcTable.Load(619, "rlDisableVertexArray");
			funcTable.Load(620, "rlEnableVertexBuffer");
			funcTable.Load(621, "rlDisableVertexBuffer");
			funcTable.Load(622, "rlEnableVertexBufferElement");
			funcTable.Load(623, "rlDisableVertexBufferElement");
			funcTable.Load(624, "rlEnableVertexAttribute");
			funcTable.Load(625, "rlDisableVertexAttribute");
			funcTable.Load(626, "rlActiveTextureSlot");
			funcTable.Load(627, "rlEnableTexture");
			funcTable.Load(628, "rlDisableTexture");
			funcTable.Load(629, "rlEnableTextureCubemap");
			funcTable.Load(630, "rlDisableTextureCubemap");
			funcTable.Load(631, "rlTextureParameters");
			funcTable.Load(632, "rlCubemapParameters");
			funcTable.Load(633, "rlEnableShader");
			funcTable.Load(634, "rlDisableShader");
			funcTable.Load(635, "rlEnableFramebuffer");
			funcTable.Load(636, "rlDisableFramebuffer");
			funcTable.Load(637, "rlGetActiveFramebuffer");
			funcTable.Load(638, "rlActiveDrawBuffers");
			funcTable.Load(639, "rlBlitFramebuffer");
			funcTable.Load(640, "rlBindFramebuffer");
			funcTable.Load(641, "rlEnableColorBlend");
			funcTable.Load(642, "rlDisableColorBlend");
			funcTable.Load(643, "rlEnableDepthTest");
			funcTable.Load(644, "rlDisableDepthTest");
			funcTable.Load(645, "rlEnableDepthMask");
			funcTable.Load(646, "rlDisableDepthMask");
			funcTable.Load(647, "rlEnableBackfaceCulling");
			funcTable.Load(648, "rlDisableBackfaceCulling");
			funcTable.Load(649, "rlColorMask");
			funcTable.Load(650, "rlSetCullFace");
			funcTable.Load(651, "rlEnableScissorTest");
			funcTable.Load(652, "rlDisableScissorTest");
			funcTable.Load(653, "rlScissor");
			funcTable.Load(654, "rlEnableWireMode");
			funcTable.Load(655, "rlEnablePointMode");
			funcTable.Load(656, "rlDisableWireMode");
			funcTable.Load(657, "rlSetLineWidth");
			funcTable.Load(658, "rlGetLineWidth");
			funcTable.Load(659, "rlEnableSmoothLines");
			funcTable.Load(660, "rlDisableSmoothLines");
			funcTable.Load(661, "rlEnableStereoRender");
			funcTable.Load(662, "rlDisableStereoRender");
			funcTable.Load(663, "rlIsStereoRenderEnabled");
			funcTable.Load(664, "rlClearColor");
			funcTable.Load(665, "rlClearScreenBuffers");
			funcTable.Load(666, "rlCheckErrors");
			funcTable.Load(667, "rlSetBlendMode");
			funcTable.Load(668, "rlSetBlendFactors");
			funcTable.Load(669, "rlSetBlendFactorsSeparate");
			funcTable.Load(670, "rlglInit");
			funcTable.Load(671, "rlglClose");
			funcTable.Load(672, "rlLoadExtensions");
			funcTable.Load(673, "rlGetVersion");
			funcTable.Load(674, "rlSetFramebufferWidth");
			funcTable.Load(675, "rlGetFramebufferWidth");
			funcTable.Load(676, "rlSetFramebufferHeight");
			funcTable.Load(677, "rlGetFramebufferHeight");
			funcTable.Load(678, "rlGetTextureIdDefault");
			funcTable.Load(679, "rlGetShaderIdDefault");
			funcTable.Load(680, "rlGetShaderLocsDefault");
			funcTable.Load(681, "rlLoadRenderBatch");
			funcTable.Load(682, "rlUnloadRenderBatch");
			funcTable.Load(683, "rlDrawRenderBatch");
			funcTable.Load(684, "rlSetRenderBatchActive");
			funcTable.Load(685, "rlDrawRenderBatchActive");
			funcTable.Load(686, "rlCheckRenderBatchLimit");
			funcTable.Load(687, "rlSetTexture");
			funcTable.Load(688, "rlLoadVertexArray");
			funcTable.Load(689, "rlLoadVertexBuffer");
			funcTable.Load(690, "rlLoadVertexBufferElement");
			funcTable.Load(691, "rlUpdateVertexBuffer");
			funcTable.Load(692, "rlUpdateVertexBufferElements");
			funcTable.Load(693, "rlUnloadVertexArray");
			funcTable.Load(694, "rlUnloadVertexBuffer");
			funcTable.Load(695, "rlSetVertexAttribute");
			funcTable.Load(696, "rlSetVertexAttributeDivisor");
			funcTable.Load(697, "rlSetVertexAttributeDefault");
			funcTable.Load(698, "rlDrawVertexArray");
			funcTable.Load(699, "rlDrawVertexArrayElements");
			funcTable.Load(700, "rlDrawVertexArrayInstanced");
			funcTable.Load(701, "rlDrawVertexArrayElementsInstanced");
			funcTable.Load(702, "rlLoadTexture");
			funcTable.Load(703, "rlLoadTextureDepth");
			funcTable.Load(704, "rlLoadTextureCubemap");
			funcTable.Load(705, "rlUpdateTexture");
			funcTable.Load(706, "rlGetGlTextureFormats");
			funcTable.Load(707, "rlGetPixelFormatName");
			funcTable.Load(708, "rlUnloadTexture");
			funcTable.Load(709, "rlGenTextureMipmaps");
			funcTable.Load(710, "rlReadTexturePixels");
			funcTable.Load(711, "rlReadScreenPixels");
			funcTable.Load(712, "rlLoadFramebuffer");
			funcTable.Load(713, "rlFramebufferAttach");
			funcTable.Load(714, "rlFramebufferComplete");
			funcTable.Load(715, "rlUnloadFramebuffer");
			funcTable.Load(716, "rlLoadShaderCode");
			funcTable.Load(717, "rlCompileShader");
			funcTable.Load(718, "rlLoadShaderProgram");
			funcTable.Load(719, "rlUnloadShaderProgram");
			funcTable.Load(720, "rlGetLocationUniform");
			funcTable.Load(721, "rlGetLocationAttrib");
			funcTable.Load(722, "rlSetUniform");
			funcTable.Load(723, "rlSetUniformMatrix");
			funcTable.Load(724, "rlSetUniformMatrices");
			funcTable.Load(725, "rlSetUniformSampler");
			funcTable.Load(726, "rlSetShader");
			funcTable.Load(727, "rlLoadComputeShaderProgram");
			funcTable.Load(728, "rlComputeShaderDispatch");
			funcTable.Load(729, "rlLoadShaderBuffer");
			funcTable.Load(730, "rlUnloadShaderBuffer");
			funcTable.Load(731, "rlUpdateShaderBuffer");
			funcTable.Load(732, "rlBindShaderBuffer");
			funcTable.Load(733, "rlReadShaderBuffer");
			funcTable.Load(734, "rlCopyShaderBuffer");
			funcTable.Load(735, "rlGetShaderBufferSize");
			funcTable.Load(736, "rlBindImageTexture");
			funcTable.Load(737, "rlGetMatrixModelview");
			funcTable.Load(738, "rlGetMatrixProjection");
			funcTable.Load(739, "rlGetMatrixTransform");
			funcTable.Load(740, "rlGetMatrixProjectionStereo");
			funcTable.Load(741, "rlGetMatrixViewOffsetStereo");
			funcTable.Load(742, "rlSetMatrixProjection");
			funcTable.Load(743, "rlSetMatrixModelview");
			funcTable.Load(744, "rlSetMatrixProjectionStereo");
			funcTable.Load(745, "rlSetMatrixViewOffsetStereo");
			funcTable.Load(746, "rlLoadDrawCube");
			funcTable.Load(747, "rlLoadDrawQuad");
		}

		public static void FreeApi()
		{
			funcTable.Free();
		}
	}
}
