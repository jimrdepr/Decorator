using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w) { }

        public override void Draw()
        {
            Console.Write(" I am a Scroll Decorator holding a: ");
            Wid.Draw();
        }
    }
}
