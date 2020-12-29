using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDF.Model
{
    public class Item : BaseModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int quantity {get;set;}
    }
}
