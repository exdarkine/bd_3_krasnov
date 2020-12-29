using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDF.Model
{
    public class OrderInBill : BaseModel
    {
        public int id { get; set; }
        public int bill_id { get; set; }
        public int order_id { get; set; }
    }
}
