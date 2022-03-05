using CheckList.Controller;
using DoctorMeeting.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorMeeting.Controller
{
    class RegisterCtrl : DataBaseConecction
    {
        public List<Object> consultation()
        {
            MySqlDataReader reader;
            List<Object> registerList = new List<object>();
            string sql;
           
            sql = "SELECT * FROM transactions ORDER BY date DESC, time DESC";
          
            try
            {
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Register register = new Register();
                    register.Id = Convert.ToInt32(reader[0]);
                    register.Date = reader[1].ToString();
                    register.Time = reader[2].ToString();
                    register.Action = reader[3].ToString();
                    register.ProductData = reader[4].ToString();
                    register.Motive = reader[5].ToString();
                    registerList.Add(register);
                }
            }
            catch (MySqlException ex)
            {
                registerList = null;
            }
            return registerList;
        }
        public bool add(Register data)
        {
            bool flag = false;
            string sql = "INSERT INTO transactions (id, date, time, action, productData, motive) VALUES ('" + data.Id + "', '" + data.Date + "', '" + data.Time + "', '" + data.Action + "', '" + data.ProductData + "', '" + data.Motive + "')";
               
            //try
            //{
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                command.ExecuteNonQuery();
                flag = true;
            //}
            //catch (MySqlException ex)
            //{
            //    Console.WriteLine("Error " + ex.Message);
            //    flag = false;
            //}
            return flag;
        }
        public void insertMotive(int idNumber, string motive)
        {
            string sql = "UPDATE transactions SET motive='" + motive + "'WHERE id= '" + idNumber + "'";
            try
            {
                MySqlConnection dataBase = base.conecction();
                dataBase.Open();
                MySqlCommand command = new MySqlCommand(sql, dataBase);
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }

        }
    }
}
