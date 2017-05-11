using System;
using System.Collections.Generic;

namespace taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taksi tagi1 = new Taksi("10-AA-999",new Point(95,5),15);

            Taksi tagi2 = new Taksi("10-BB-888", new Point(40, 30), 12);

            Taksi tagi3 = new Taksi("10-CC-777", new Point(12, 28), 7);

            Musteri mush = new Musteri("Ehmed",new Point(0,0));
            Musteri mush1 = new Musteri("Zakir", new Point(10, 37));

            mush.taksiCall(new Point(150,284));
            
            mush1.taksiCall(new Point(10, 15));

        }
    }
}