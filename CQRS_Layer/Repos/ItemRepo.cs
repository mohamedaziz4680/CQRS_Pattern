using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS_Layer.Data;
using CQRS_Layer.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Layer.Repos
{
    public class ItemRepo : IItemRepo
    {
        private readonly AppDbContext _db;

        public ItemRepo(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public List<Item> GetItems()
        {
            return  _db.Items.ToList();
        }

        public Item GetItem(int id)
        {
            return _db.Items.FirstOrDefault(x => x.Id == id) ?? new();
        }

        public int InsertItem(Item item)
        {
            _db.Items.Add(item);
            _db.SaveChanges();
            return item.Id;
        }

        public int UpdateItem(Item item)
        {
            try
            {
                _db.Items.Attach(item);
                _db.Entry(item).State = EntityState.Modified;
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int DeleteItem(int id)
        {
            var item = _db.Items.FirstOrDefault(x=>x.Id == id);
            if (item != null) { _db.Items.Remove(item); }
            return _db.SaveChanges();
        }
    }
}
