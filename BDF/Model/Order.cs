using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDF.Model
{
    public class Order : BaseModel
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public int item_id { get; set; }
        public int quantity { get; set; }
        public int table_id { get; set; }
    }
}
