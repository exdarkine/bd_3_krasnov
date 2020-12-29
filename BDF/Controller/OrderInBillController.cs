using BDF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Controller
{
    public class OrderInBillController : IController<OrderInBill>
    {
        private Context context = new Context();
        private DbSet<OrderInBill> table;

        public OrderInBillController()
        {
            table = this.context.orders_in_bills;
        }

        public void Create(OrderInBill entity)
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

        public OrderInBill Find(int id)
        {
            return table.Find(id);
        }
        public IEnumerable<OrderInBill> Read()
        {
            return table;
        }
        public void Update(OrderInBill entity)
        {
            table.Update(entity);
            context.SaveChanges();
        }
    }
}
