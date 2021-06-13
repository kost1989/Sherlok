using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace sherlok
{
    class Spark
    {

        protected float alpha;



        public Spark(Color c, PointF position, PointF speed)
        {
            Clr = c;
            Position = position;
            Speed = speed;
            alpha = 1.0F;
            Size = 8F;
        }

        public Color Clr { get; set; }
        public float Size { get; set; }
        public PointF Position { get; set; }
        public PointF Speed { get; set; }

        public float Gravity { get; set; }
        
        private float offSpeed = 0.1F;
        public float OffSpeed
        {
            get { return offSpeed; }
            set
            {
                if (value <= 0) throw new ArgumentOutOfRangeException();
                offSpeed = value;
            }
        }

        public bool IsAlive
        {
            get { return alpha > 0; }
        }

        public virtual void Update(double time)
        {
            Position = new PointF(
                Position.X + Speed.X * (float)time,
                Position.Y + Speed.Y * (float)time);

            Speed = new PointF(
                Speed.X,
                Speed.Y - Gravity*(float)time
                );

            alpha = alpha - OffSpeed;
        }

        public virtual void Paint(Graphics g)
        {
            if (!IsAlive) return;

            Color c = Color.FromArgb(Convert.ToInt32( Math.Round(255*alpha)), Clr);
            using (Brush b = new SolidBrush(c))
            {
                g.FillEllipse(b, Position.X - Size / 2, Position.Y - Size / 2, Size, Size);
            }
        }
    }
}
