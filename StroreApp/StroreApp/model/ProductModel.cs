using System;
using MySql.Data.MySqlClient;
using StroreApp.entity;

namespace StroreApp.model
{
    public class ProductModel
    {
        public Boolean Save(Product product)
        {
            Db.Instance().OpenConnection();
            var sqlQuery = "insert into 'products' ('id', 'name', 'price') values (@id, @name, @price)";
            var cmd = new MySqlCommand(sqlQuery, Db.Instance().Connection);
            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@name", product.Name);
            cmd.Parameters.AddWithValue("@price", product.Price);
            var result = cmd.ExecuteNonQuery();
            Db.Instance().CloseConnection();
            return result == 1;
        }

        public Boolean GetId( string id)
        {
            Db.Instance().OpenConnection();
            var queryString = "delete  from  `products` where id = @id";
            var cmd = new MySqlCommand(queryString, Db.Instance().Connection);
            cmd.Parameters.AddWithValue("@id", id);
            var reader = cmd.ExecuteReader();
            Db.Instance().CloseConnection();
            return true;
        }
        
    }
}