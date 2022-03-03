using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorMeeting.Model
{
    class Register
    {
        private int _id;
        private string _date, _time, _action, _productData, _motive;

        public Register()
        {
        }
        public int Id { get => _id; set => _id = value; }
        public string Date { get => _date; set => _date = value; }
        public string Time { get => _time; set => _time = value; }
        public string Action { get => _action; set => _action = value; }
        public string ProductData { get => _productData; set => _productData = value; }
        public string Motive { get => _motive; set => _motive = value; }
        
    }
}
