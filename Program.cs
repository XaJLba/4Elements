using System;
using static Raylib.Raylib;

namespace _4Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationWindow window = new ApplicationWindow(640, 480, "4 elements", 60);
            Map map = new Map(320, 240);
            while (!WindowShouldClose())
            {
                window.HandleWindowClosing();
                ClearBackground(Raylib.Color.BLACK);
                BeginDrawing();

                map.UpdateSelf();

                EndDrawing();
            }
        }
    }
}
