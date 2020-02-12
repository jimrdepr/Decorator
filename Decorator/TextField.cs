using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class TextField : Widget
    {
        private int width;
        private int height;

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }

        public void Draw()
        {
            Console.WriteLine(width + "x" + height + " textbox");
        }
    }
}
