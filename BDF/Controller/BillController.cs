using BDF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Controller
{
    public class BillController : IController<Bill>
    {
        private Context context = new Context();
        private DbSet<Bill> table;

        public BillController()
        {
            table = this.context.bills;
        }

        public void Create(Bill entity)
        {
            table.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = table.Find(id);
            table.Remove(entity);
            context.SaveChanges();
        }

        public Bill Find(int id)
        {
            return table.Find(id);
        }
        public IEnumerable<Bill> Read()
        {
            return table;
        }
        public void Update(Bill entity)
        {
            table.Update(entity);
            context.SaveChanges();
        }
    }
}
