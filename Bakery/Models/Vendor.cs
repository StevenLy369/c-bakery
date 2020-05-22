using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public string Name { get; set; }
      
        public List<Vendor> Items { get; set; }
        public Vendor(string name)
        {
            Name = name;
            _instances.Add(this);
           
            Items = new List<Vendor> { };
        }


        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Vendor> GetAll()
        {
            return _instances;
        }

        public static Vendor Find(int searchId)
        {
            return _instances[searchId -1];
        }
        
       




    }


}