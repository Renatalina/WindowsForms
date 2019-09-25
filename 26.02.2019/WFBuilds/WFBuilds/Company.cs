using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFBuilds
    {
    class Company
    {
        public int ID { set; get; }
        public string CompanyName { set; get; }
        public string ContactName { set; get; }
        public string ContactPhone { set; get; }

        public Company(int id,string company,string contact,string phone)
        {
            ID = id;
            CompanyName = company;
            ContactName = contact;
            ContactPhone = phone;
        }
    }
}
