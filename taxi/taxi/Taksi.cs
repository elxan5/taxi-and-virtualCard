namespace taxi
{
    public class Taksi
    {
        public string number;
        public Point point;
        public int speed;
        public Taksi(string number,Point point,int speed)
        {
            this.number = number;
            this.point = point;
            this.speed = speed;
            Sirket.taksiList.Add(this);
        }

    }
}