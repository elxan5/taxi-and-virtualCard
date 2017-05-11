using System;

namespace Virtual_Card
{
    class Program
    {
        static void Main(string[] args)
        {

            Main_cart mainC = new Main_cart("Vezir",1000,new DateTime(05/06/2017));
            virtual_cart virtualC1 = mainC.create_cart("Xeyal", 500, new DateTime(05 / 06 / 2017));
            virtual_cart virtualC2 = mainC.create_cart("Perviz", 200, new DateTime(05 / 06 / 2017));

            Console.WriteLine(mainC.amount);
        }
    }
}