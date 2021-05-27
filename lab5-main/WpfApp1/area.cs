using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class area
    {
        public double lowRadius;

        public area(double lowRadius)
        {
            this.lowRadius = lowRadius;
        }

        public void show()
        {
            MessageBox.Show($"Площадь нижнего основания: {Math.PI * Math.Pow(this.lowRadius, 2)}");
        }
    }
}
