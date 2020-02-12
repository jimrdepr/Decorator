using System;

namespace Decorator
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            int w = 9;
            int h = 13;

            TextField txt = new TextField(w, h);
            BorderDecorator bd = new BorderDecorator(txt);
            ScrollDecorator sd = new ScrollDecorator(bd);
            LineDecorator ld = new LineDecorator(sd);

            ld.Draw();
        }
    }
}
