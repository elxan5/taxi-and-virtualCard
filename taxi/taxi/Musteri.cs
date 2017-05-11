using System;
namespace taxi
{
    public class Musteri
    {
        public Point point;
        public string name;
        public Musteri(string name,Point point)
        {
            this.name = name;
            this.point = point;

        }
        public void taksiCall(Point d)
        {
            Taksi taksi = Sirket.taksiList[0];
            int Vaxt;
            int minMes = (int)Math.Sqrt((Sirket.taksiList[0].point.x - this.point.x) * (Sirket.taksiList[0].point.x - this.point.x) + (Sirket.taksiList[0].point.y - this.point.y) * (Sirket.taksiList[0].point.y - this.point.y));

           

            for (int i = 0; i < Sirket.taksiList.Count; i++)
            {
                int m= (int)Math.Sqrt((Sirket.taksiList[i].point.x - this.point.x) * (Sirket.taksiList[i].point.x - this.point.x) + (Sirket.taksiList[i].point.y - this.point.y) * (Sirket.taksiList[i].point.y - this.point.y));
                if (m < minMes)
                {
                   
                    minMes = m;
                    taksi = Sirket.taksiList[i];

                }
            }


            Vaxt = minMes / taksi.speed;
            double mebleg = ((int)Math.Sqrt((d.x - this.point.x) * (d.x - this.point.x) + (d.y - this.point.y) * (d.y - this.point.y))) / 5;

            int AddresTime = ((int)Math.Sqrt((d.x - this.point.x) * (d.x - this.point.x) + (d.y - this.point.y) * (d.y - this.point.y)) ) / taksi.speed;

            Console.WriteLine("Hormetli "+this.name+" Sizin taksiniz teyin edildi.Taksiniz "+Vaxt+ "-deqiqeye adresinizde olacaq, qeyd etdiyiniz adrese catma vatxiniz "+AddresTime+" - deqiqedir ve gedis haqqiniz "+mebleg+" AZN olacaqdir.Bizi secdiyiniz ucun tesekkur etmirik \n");



            
        }

    }
}