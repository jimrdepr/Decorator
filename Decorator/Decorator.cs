using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
            wid = w;
        }

        public Widget Wid
        {
            get { return wid; }
        }

        public abstract void Draw();
    }
}
