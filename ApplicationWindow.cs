using static Raylib.Raylib;
using static Raylib.Raylib;

namespace _4Elements
{
    class ApplicationWindow
    {
        public int width { get; }
        public int height { get; }
        public ApplicationWindow(int width, int height, string caption, int fps)
        {
            InitWindow(width, height, caption);
            this.width = width;
            this.height = height;
            SetTargetFPS(fps);
        }

        public void HandleWindowClosing()
        {
            if (WindowShouldClose())
            {
                CloseWindow();
            }
        }
    }
}
