using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class Initial
    {
      public  static Random rnd = new Random();
        public static int a = rnd.Next(100);
        public static int b = rnd.Next(100);
        public static int c;
        public static string SetInf()
        {
            return string.Format("{0} + "+" + {1}", a, b);
        }
       
        public static int SumInf()
        {
            c  = a + b;
            return c;
        }

    }
}