using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w) { }

        public override void Draw()
        {
            Console.Write("I am a Border Decorator holding a: ");
            Wid.Draw();
        }
    }
}
