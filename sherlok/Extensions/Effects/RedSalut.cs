using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace sherlok
{
    class ColorSalut : Salut
    {
        public ColorSalut(Color c)
        {
            SparksCount = 20;
            clr = c;
            r = new Random();
            sparks = new List<Spark>();
        }

        Color clr;
        List<Spark> sparks;
        Random r;

        const double SPARK_SPEED = 15.0;
        const float SPARKING_TIME = 9F;

        public int SparksCount { get; set; }

        public override void Start(System.Drawing.Point explosionPoint)
        {
            sparks.Clear();

            double angle = 2 * Math.PI / SparksCount;
            double rt = r.NextDouble() * angle;

            float ssize = (float)(r.NextDouble() * 6.0 + 8.0);

            for (int i = 0; i < SparksCount; i++)
            {
                double ns = r.NextDouble() * angle / 15;
                double spx = SPARK_SPEED * Math.Cos(angle * i+rt+ns);
                double spy = SPARK_SPEED * Math.Sin(angle * i +rt+ns);
                SparkWithTrace s = new SparkWithTrace(clr, new PointF(explosionPoint.X, explosionPoint.Y), new PointF((float)spx, (float)spy), 30, SPARKING_TIME);
                s.Size = ssize;
                s.OffSpeed = 0.035F;
                s.Gravity = Gravity;
                sparks.Add(s);
            }
        }

        public override void Update(double time)
        {
            foreach (Spark s in sparks)
            {
                s.Update(time);
            }
        }

        public override void Paint(System.Drawing.Graphics g)
        {
            foreach (Spark s in sparks)
            {
                s.Paint(g);
            }
        }

        public override bool CheckAlive()
        {
            foreach (Spark s in sparks)
            {
                if (s.IsAlive) return true;
            }
            return false;
        }
    }
}
