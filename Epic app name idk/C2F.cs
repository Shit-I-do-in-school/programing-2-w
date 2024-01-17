using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epic_app_name_idk
{
    internal class C2F
    {
        public double Cel ( double C )
        {
            double f = (C * 1.8) / 5 + 32;

            return f;
        }
    }
}
