using BDF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Controller
{
    class OrderController : IController<Order>
    {
        private Context context = new Context();
        private DbSet<Order> table;

        public OrderController()
        {
            table = this.context.orders;
        }

        public void Create(Order entity)
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

        public Order Find(int id)
        {
            return table.Find(id);
        }
        public IEnumerable<Order> Read()
        {
            return table;
        }
        public void Update(Order entity)
        {
            table.Update(entity);
            context.SaveChanges();
        }
    }
}
