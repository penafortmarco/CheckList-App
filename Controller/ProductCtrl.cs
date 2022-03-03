using CheckList;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Controller
{
    class ProductCtrl : DataBaseConecction
    {
        public List<Object> consultation(string data)
        {
            MySqlDataReader reader;
            List<Object> productList = new List<object>();
            string sql;
            if(data == null)
            {
                sql = "SELECT id, name, description, price, stock FROM products ORDER BY name ASC";
            }
            else
            {
                sql = "SELECT id, name, description, price, stock FROM products WHERE id LIKE '%" + data + "%' " +
                    "OR name LIKE '%" + data + "%' OR description LIKE '%" + data + "%' ORDER BY name ASC";
            }
            try
            {
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product();
                    product.Id = Convert.ToInt32(reader[0]);
                    product.Name = reader[1].ToString();
                    product.Description = reader[2].ToString();
                    product.Price = Convert.ToSingle(reader[3]);
                    product.Stock = Convert.ToInt32(reader[4]);
                    productList.Add(product);
                }
            }
            catch (MySqlException ex)
            {

            }
            return productList;
        }
        public bool add(Product data)
        {
            bool flag = false;
            string sql = "INSERT INTO Products (id, name, description, price, stock) " +
                "VALUES('"+data.Id+"','"+data.Name+"','" +data.Description+ 
                "','"+data.Price+"','"+data.Stock+"')";
            try
            {
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                command.ExecuteNonQuery();
                flag = true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error "+ex.Message);
                flag = false;
            }
            return flag;
        }
        public bool update(Product data)
        {
            bool flag = false;
            string sql = "UPDATE Products SET id='" + data.Id + "', name='" + data.Name + 
                "', description='"+data.Description + "', price='" + data.Price + "'stock='"+
                data.Stock+ "'WHERE id='"+data.Id + "'";
            try
            {
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                command.ExecuteNonQuery();
                flag = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                flag = false;
            }
            return flag;
        }
        public bool delete(int id)
        {
            bool flag = false;
            string sql = "DELETE FROM products WHERE id= '" + id + "'";
            try
            {
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                command.ExecuteNonQuery();
                flag = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
                flag = false;
            }
            return flag;
        }
    }
}
