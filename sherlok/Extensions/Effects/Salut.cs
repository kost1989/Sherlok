using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace sherlok
{
    abstract class Salut
    {
        public abstract void Start(Point explosionPoint);

        public abstract void Update(double time);

        public abstract void Paint(Graphics g);

        public abstract bool CheckAlive();

        public virtual float Gravity { get; set; }
    }
}
