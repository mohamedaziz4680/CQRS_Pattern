using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS_Layer.Data.Models;

namespace CQRS_Layer.Repos
{
    public interface IItemRepo
    {
        public List<Item> GetItems();
        public Item GetItem(int id);
        public int InsertItem(Item item);
        public int UpdateItem(Item item);
        public int DeleteItem(int id);
    }
}
