using Raylib_CsLo;

namespace Workbench_World_Editor
{
    public class Editor
    {
        public static void DoWork()
        {
            Raylib.InitWindow(800, 480, "Workbench World Editor");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib.BLACK);

                Raylib.DrawFPS(10, 10);

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
