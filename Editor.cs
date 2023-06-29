using Raylib_CsLo;
using System.Numerics;

namespace Workbench.Editor
{
	public class Editor
	{
		public static void DoWork()
		{
			Vector3 camPosition = new Vector3(-6.17f, 2.42f, 0);
			Raylib.SetWindowState(ConfigFlags.FLAG_WINDOW_RESIZABLE);
			Raylib.InitWindow(800, 480, "Workbench World Editor");
			Raylib_CsLo.Image icon = Raylib.LoadImage("hammer.png");
			Raylib.SetWindowIcon(icon);
			Camera3D camera = new(camPosition, Vector3.Zero, new Vector3(0, 1, 0), 60, CameraProjection.CAMERA_PERSPECTIVE);
			Raylib.SetCameraMode(camera, CameraMode.CAMERA_FREE);
			while (!Raylib.WindowShouldClose())
			{
				Vector2 render = new(Raylib.GetRenderWidth(), Raylib.GetRenderHeight());
				Raylib.BeginDrawing();
				Raylib.ClearBackground(Raylib.BLACK);

				Raylib.UpdateCamera(ref camera);
				Raylib.BeginMode3D(camera);
				Raylib.DrawGrid(10, 1);
				Raylib.DrawCube(Vector3.Zero, 1, 1, 1, Raylib.MAROON);
				Raylib.DrawCubeWires(Vector3.Zero, 1, 1, 1, Raylib.RED);
				Raylib.EndMode3D();

				Raylib.DrawFPS(10, 10);
				Raylib.DrawText("TTMC Corporation", 10, render.Y - 25, 20, Raylib.GRAY);
				Raylib.EndDrawing();
			}
			Raylib.CloseWindow();
		}
	}
}