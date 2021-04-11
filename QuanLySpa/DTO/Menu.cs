using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DTO
{
    public class Menu
    {

        public Menu (string serviceName, int count, float price, float totalPrice = 0)
        {
            this.ServiceName = serviceName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        { 
            this.ServiceName = row["name"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }


        private string serviceName;
        public string ServiceName { get => serviceName; set => serviceName = value; }
       
        private int count;
        public int Count { get => count; set => count = value; }
        
        private float price;
        public float Price { get => price; set => price = value; }
        
        private float totalPrice;
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

    }
}
