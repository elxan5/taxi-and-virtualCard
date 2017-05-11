using System;
using System.Collections.Generic;

namespace Virtual_Card
{
    public static class Bank
    {
       static Random ran = new Random();
        static  public List<string> list_id = new List<string>();
        public static string create_id()
        {
            string str = "";
            while (true)
            {
                 str = "";
                string numbers = "0123456789";
                for (int i = 0; i < 16; i++)
                {
                    str += numbers[ran.Next(0, 9)];
                }

                if (!list_id.Contains(str))
                {
                    list_id.Add(str);
                    break;
                }

            }
         
            return str;
        }
        public static string create_cvc()
        {
            string str = "";
           
                str = "";
                string numbers = "0123456789";
                for (int i = 0; i < 3; i++)
                {
                    str += numbers[ran.Next(0, 9)];
                }

            return str;
        }
    }
}