using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net
{
    class product
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float price { get; set; }
        public string img { get; set; }
        public product(string id, string name, string description, float price, string img)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.img = img;
        }
    }
}
