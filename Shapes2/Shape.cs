using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    public abstract class Shape
    {
        int width;
        int height;

        public double CalculateArea()
        {
            return this.width * this.height;
        }



    }
}
