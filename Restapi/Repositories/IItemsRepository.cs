using System;
using System.Collections.Generic;
using Restapi.Models;

namespace Restapi.Repositories
{
        public interface IItemsRepository
        {
            Item GetItem(Guid id);
            IEnumerable<Item> GetItems();
        }
}