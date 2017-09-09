using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Editer
    {
        public Shape[] drawn;
        
        public void Draw()
        {
            Random r = new Random();

            int circleCount = r.Next(0, 10);
            int rectCount = r.Next(0, 10);
            int triCount = r.Next(0, 10);

            drawn = new Shape[circleCount + rectCount + triCount];

            for (int i = 0; i < circleCount; i++)
            {
                Circle c = new Circle();
                c.Draw();
            }
            for (int i = 0; i < rectCount; i++)
            {
                Triangle tri = new Triangle();
                tri.Draw();
            }
            for (int i = 0; i < triCount; i++)
            {
                Rectangle rect = new Rectangle();
                rect.Draw();
            }

        }
        
        public void Save()
        {

        }
        
        public void Load()
        {

        }

    }
}
