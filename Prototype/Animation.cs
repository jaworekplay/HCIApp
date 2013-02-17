using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace Prototype
{
    class Animation
    {
        System.Windows.Forms.SplitContainer splCtn;
        Graphics graph;
        Brush red;
        Brush black;
        Rectangle sprite;
        public Animation(System.Windows.Forms.SplitContainer sC)
        {
            splCtn = sC;
            graph = splCtn.CreateGraphics();
            red = new SolidBrush(Color.Red);
            black = new SolidBrush(Color.Black);
            sprite = new Rectangle(255, -50, 5, 50);
        }

        public void startAnimation()
        {
            while (sprite.Y < 500)
            {
                graph.FillRectangle(black, sprite);
                sprite.Y += 3;
                graph.FillRectangle(red, sprite);
                Thread.Sleep(50);
            }
        }
    }
}
