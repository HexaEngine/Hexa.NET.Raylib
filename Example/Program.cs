using Hexa.NET.Raylib;

Raylib.InitWindow(1280, 720, "Example");

Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Raylib.White);
    Raylib.DrawText("Hello, world!", 190, 200, 20, Raylib.LightGray);
    Raylib.EndDrawing();
}

Raylib.CloseWindow();