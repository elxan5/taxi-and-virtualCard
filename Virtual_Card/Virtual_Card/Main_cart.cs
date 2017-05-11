using System;

namespace Virtual_Card
{
    class Main_cart
    {

        Random ran = new Random();
        public string user;
        public int amount;
        public string ID;
        public DateTime dead_line;
        public string CVC;


        public Main_cart(string user,int amount,DateTime dead_line)
        {
            this.user = user;
            this.amount = amount;
            this.dead_line = dead_line;
            this.CVC = Bank.create_cvc();
            this.ID= Bank.create_id();
        }
        public virtual_cart create_cart(string user, int amount, DateTime dead_line)
        {
            if (amount<this.amount)
            {
                virtual_cart virtualc = new virtual_cart( user, amount, dead_line);
                this.amount-= amount;
                return virtualc;
            }
            else
            {
                Console.WriteLine("hesbiniz sifira yaxinlasir");
                return null;
            }
            
        }
    }
}