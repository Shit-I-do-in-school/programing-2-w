using Epic_app_name_idk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{

    class MyApplication
    {

        static void Main(string[] args)
        {
            C2F ctf = new C2F();
            //Console.WriteLine("Skriv in temp i C");
            //string C_ = Console.ReadLine();
            //double c = double.Parse(C_);

            //double f = ctf.Cel(c);
            //Console.WriteLine("F är " + f);

            Loop lo = new Loop();
            int l = lo.Loop2(-20);

            Loop lz = new Loop();
            int lv = lz.Loop3(-20);

            Console.WriteLine(l);
            Console.WriteLine(lv);
        }
    }
}