using ItemCRUD.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ItemCRUD.Repositories
{
    class GeneralRepository : IItem
    {
        public SqlConnection conn = new SqlConnection("Data Source=DESKTOP-HGKV6T7;Initial Catalog=contoh1;User ID=sa;Password=root");

        public string TableName;
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public SqlDataReader GetAll()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM {TableName}", conn);
                return command.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            conn.Close();
            return null;
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
