using System;
using System.Net;
using System.Globalization;



namespace lesson3
{
    public class Family : Person
    {
        private string surname;
        private string address;
        private int age;
        private bool married;
        
        public Family(string n, string adr, int a, bool m)
        {

            surname=n;

            address = adr;
            age = a;
            married = m;
        }


        public string Surname => surname;

       
        public int Age{ get; }


        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (String.Compare(address, "") == 0)
                {
                    throw new Exception("Adress must be filled in!!");
                }
                address = value;
            }
        }

        public string get_marry(bool marry)
        {
            if (marry == true)
            {
                return "married";
            }
            else
            {
                return "notmarried";
            }
        }
        

       
    }
}