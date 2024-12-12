using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{//mark 12/12
    public class Customer
    {
        private int id;
        private string name;
        private bool clubMember;
        private int kamutIskaot;
        private int totalIskaot;
        public Customer(int id, string name) 
        {
            this.id = id;
            this.name = name;
            this.clubMember = false;
            this.totalIskaot = 0;
            this.kamutIskaot = 0;
        }
        public void MakeIska(int amount)
        {// get amount of deal. if in club get 10% discount, if more then 10 deals or 1000 shek become club member
            this.kamutIskaot++;
            if (!clubMember)
            {
                this.totalIskaot += amount;
            }
            else
            {
                this.totalIskaot += (amount * 9)/10;
            }
            if ((this.kamutIskaot >= 10) || (this.totalIskaot > 1000))
            {
                clubMember = true;
            }
        }
        public override string ToString()
        {
            string str2return = "id: " + this.id + " name: " + this.name + " is club member: " + this.clubMember + " kamut iskaot: " + this.kamutIskaot + " total iskaot: " + this.totalIskaot;
            return str2return;
        }
        public bool IsBetterCustomer(Customer other)
        {
            return this.totalIskaot > other.totalIskaot;
        }
        public bool GetClubMember()
        {
            return this.clubMember;
        }

    }
}
