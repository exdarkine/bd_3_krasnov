using BDF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Controller
{
    public class TableController : IController<Table>
    {
        private Context context = new Context();
        private DbSet<Table> table;

        public TableController()
        {
            table = this.context.tables;
        }

        public void Create(Table entity)
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

        public Table Find(int id)
        {
            return table.Find(id);
        }
        public IEnumerable<Table> Read()
        {
            return table;
        }
        public void Update(Table entity)
        {
            table.Update(entity);
            context.SaveChanges();
        }
    }
}
