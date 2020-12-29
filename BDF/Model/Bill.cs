using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BDF.Model
{
    public class Bill : BaseModel
    {
        public int id { get; set; }
        public int tips { get; set; }
        public DateTime time { get; set; }
    }
}
