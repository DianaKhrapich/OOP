using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Paint
{
    abstract class Shape
    {
        public abstract StylusPointCollection GetPoints(Point anchor, Point cursor);
    }
}
