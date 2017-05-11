using System;

namespace Virtual_Card
{
    class virtual_cart
    {
        public string V_user;
        public int V_amount;
        public string V_ID;
        public DateTime V_dead_line;
        public string V_CVC;

        public virtual_cart(string user, int amount, DateTime dead_line)
        {
            this.V_user = user;
            this.V_amount = amount;
            this.V_dead_line = dead_line;
            this.V_CVC = Bank.create_cvc();
            this.V_ID = Bank.create_id();
        }
    }
}