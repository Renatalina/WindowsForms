using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;


namespace WFBuilds
    {
    [Serializable]
    
   public class Person
    {
        
        public int ID { set; get; }
       
        public string FullName { set; get; }
        
        public string Birthday { set; get; }
       
        public string Sex { set; get; }
        
        public string Country { set; get; }
        
        public string City { set; get; }
        
        public int Height { set; get; }
        
        public int Weight { set; get; }
        
        public string Hair { set; get; }
        
        public string Eyes { set; get; }
        public Person ()
        {

        }
        public Person (int id, string fullName, string birtday, string sex, string country, string city, int height, int weight, string hair, string eyes)
        {
            ID = id;
            FullName = fullName;          
            Birthday = birtday;
            Sex = sex;
            Country = country;
            City = city;
            Height = height;
            Weight = weight;
            Hair = hair;
            Eyes = eyes;
        }
        public void Save(Person person)
        {
          
        }

    }
}
