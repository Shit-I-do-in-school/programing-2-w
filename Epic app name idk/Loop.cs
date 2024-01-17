using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epic_app_name_idk
{
    internal class Loop
    {
        public int Loop2 ( int l ) // loop som går från -20c till 40c med hop av 10c varje gång
        { 
            while (l < 40)
            {
                Console.WriteLine(l);

                l = l + 10;

            }
            return l;
        }
        public int Loop3 ( int lv )
        {
            while (lv < 40)
            {
                Console.WriteLine(lv);


                lv = lv + 10;
            }
            return lv;
        }
    }
}
