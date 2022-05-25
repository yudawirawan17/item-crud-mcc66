using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ItemCRUD.Repositories.Interface
{
    interface IItem
    {
        public void Insert();
        public void Update();
        public void Delete();
        public void GetById();
        public SqlDataReader GetAll();
    }
}
