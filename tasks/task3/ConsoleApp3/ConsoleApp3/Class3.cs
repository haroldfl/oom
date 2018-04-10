using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson3
{


    public class Customer : Person
    {
        private string surname;
        private string adrress;
        private int customerID;
        private int visit;
        public Customer(string n, int id, int v, string adr)
        {
            surname = n;
            customerID = id;
            visit = v;
            adrress = adr;
        }
        public string Surname => surname;


        public int CustomerID { get; }
        public int Visit { get; }
        public void inc_visit() {
            visit++;
        }

        public string Address
        {
            get
            {
                return adrress;
            }
            set
            {
                if (String.Compare(adrress, "") == 0)
                {
                    throw new Exception("Adress must be filled in!!");
                }
                adrress = value;
            }
        }
    }
}
