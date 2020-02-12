using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class LineDecorator : Decorator
    {
        public LineDecorator(Widget w) : base(w) { }

        public override void Draw()
        {
            Console.Write(" I am a Line Decorator holding a: ");
            Wid.Draw();
        }
    }
}
