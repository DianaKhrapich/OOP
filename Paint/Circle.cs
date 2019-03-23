using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Paint
{
    class Circle : Shape
    {
        public override StylusPointCollection GetPoints(Point anchor, Point cursor)
        {
            var pointCollection = new StylusPointCollection();

            return pointCollection;
        }
    }
}
