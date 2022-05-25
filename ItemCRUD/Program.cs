using System;
using System.Data.SqlClient;
using ItemCRUD.Repositories;
using ItemCRUD.Repositories.Data;

namespace ItemCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuUtama();
            
        }

        static void MenuUtama()
        {
            Console.WriteLine("Menu : \n1. Tambah Data \n2. Ubah Data Harga \n3. Hapus Data \n4. Tampilkan Data");
            Console.Write("pilih : ");
            int pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (pilih)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    ItemRepository ir = new ItemRepository();
                    SqlDataReader dataReader = ir.GetAll();
                    while (dataReader.Read())
                    {
                        Console.WriteLine(dataReader.GetValue(0) + "   " + dataReader.GetValue(1) + "   " + dataReader.GetValue(2) + "   " + dataReader.GetValue(3));
                    }
                    break;
                default:
                    Console.WriteLine("pilih nomor 1 - 4");
                    break;
            }
        }
    }
}
