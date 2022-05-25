using System;
using System.Collections.Generic;
using System.Text;

namespace ItemCRUD.Repositories.Data
{
    class ItemRepository : GeneralRepository
    {
        public ItemRepository()
        {
            TableName = "items";
        }
    }
}
