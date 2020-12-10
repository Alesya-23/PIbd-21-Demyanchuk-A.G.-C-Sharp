using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBoat
{
    class BoatComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.MainColor.R > y.MainColor.R)
            {
                return 1;
            }
            if(x.MainColor.R < y.MainColor.R)
            {
                return -1;
            }
            return 0;
        }

        private int ComparerBoat(Boat x, Boat y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerMotorBoat(MotorBoat x, MotorBoat y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.SideLine != y.SideLine)
            {
                return x.SideLine.CompareTo(y.SideLine);
            }
            if (x.Cabin != y.Cabin)
            {
                return x.Cabin.CompareTo(y.Cabin);
            }
            if (x.Motors != y.Motors)
            {
                return x.Motors.CompareTo(y.Motors);
            }
            return 0;
        }
    }
}