using BDF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Controller
{
    public class ItemController : IController<Item>
    {
        private Context context = new Context();
        private DbSet<Item> table;

        public ItemController()
        {
            table = this.context.items;
        }

        public void Create(Item entity)
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

        public Item Find(int id)
        {
            return table.Find(id);
        }
        public IEnumerable<Item> Read()
        {
            return table;
        }
        public void Update(Item entity)
        {
            table.Update(entity);
            context.SaveChanges();
        }
    }
}
