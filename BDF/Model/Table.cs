using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDF.Model
{
    public class Table : BaseModel
    {
        public int id { get; set; }
        public int chair_quantity { get; set; }
    }
}
