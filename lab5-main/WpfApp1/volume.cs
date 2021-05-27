using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    class volume
    {
        public double height;
        public double lowRadius;
        public double upRadius;
        public double volumee;

        public volume(double height, double lowRadius)
        {
            this.height = height;
            this.lowRadius = lowRadius;
        }
        
    }

    class cutVolume : volume
    {
        public cutVolume(double height, double lowRadius, double upRadius) : base(height, lowRadius)
        {
            this.height = height;
            this.lowRadius = lowRadius;
            this.upRadius = upRadius;
        }

        public double volume()
        {
            
            if (this.upRadius != null)
            {
                volumee = (Math.PI * Math.Pow(this.upRadius, 2) + Math.PI * Math.Pow(this.lowRadius, 2)) / 2 *
                         this.height;
            }
            else if (this.upRadius == null)
            {
                volumee = Math.PI * Math.Pow(this.lowRadius, 2) / 2 * this.height;
            }
            else
            {
                volumee = 9999999;
                MessageBox.Show("Error");
            }
            return volumee;

        }

        public void  show()
        {
            MessageBox.Show($"Объём: {volume()}");
        }
    }
}
