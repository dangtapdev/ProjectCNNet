using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class GetData
    {
        public static DataTable LayKhachHang()
        {
            using(DataAccess db =new DataAccess())
            {
                var customers = db.DSCustomer.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Customer).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                foreach(var customer in customers)
                {
                    DataRow dr = dt.NewRow();
                    foreach(var prop in typeof (Customer).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(customer);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
    }
}
