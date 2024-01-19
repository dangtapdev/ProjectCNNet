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
        public static List<Account> LayDSAcc()
        {
            List<Account> list = null;
            using (DataAccess db = new DataAccess())
            {
                list = db.DSAccount.ToList();
            }
            return list;
        }
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
        public static DataTable LayXe()
        {
            using(DataAccess db = new DataAccess())
            {
                var cars = db.DSCar.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Car).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                foreach(var car in cars)
                {
                    DataRow dr = dt.NewRow();
                    foreach( var prop in typeof(Car).GetProperties())
                    {
                        dr[prop.Name]= prop.GetValue(car);
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public static DataTable LayNSX()
        {
            using(DataAccess db = new DataAccess())
            {
                var manus = db.DSManu.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Manufacturer).GetProperties())
                {
                    dt.Columns.Add(prop.Name,prop.PropertyType);
                }
                foreach(var manu in manus)
                {
                    DataRow dr = dt.NewRow();
                    foreach(var prop in typeof(Manufacturer).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(manu);
                    }
                    dt.Rows.Add(dr );
                }
                return dt;
            }
        }
        public static DataTable LayNhanVien()
        {
            using(DataAccess db = new DataAccess())
            {
                var nhanviens = db.DSSaler.ToList();
                DataTable dt = new DataTable();
                foreach(var prop in typeof(Saler).GetProperties())
                {
                    dt.Columns.Add(prop.Name,prop.PropertyType);
                }
                foreach(var nhanvien in nhanviens)
                {
                    DataRow dr = dt.NewRow();
                    foreach(var prop in typeof(Saler).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(nhanvien);
                    }
                    dt.Rows.Add(dr );
                }
                return dt;
            }
        }
        public static DataTable LayGiaoDich()
        {
            using (DataAccess db = new DataAccess())
            {
                var giaodichs = db.DSTrans.ToList();
                DataTable dt = new DataTable();
                foreach (var prop in typeof(Transaction).GetProperties())
                {
                    dt.Columns.Add(prop.Name, prop.PropertyType);
                }
                dt.Columns.Add("Price",typeof(double));
                foreach (var giaodich in giaodichs)
                {
                    DataRow dr = dt.NewRow();
                    foreach (var prop in typeof(Transaction).GetProperties())
                    {
                        dr[prop.Name] = prop.GetValue(giaodich);
                    }
                    var carinfo = db.DSCar.FirstOrDefault(car => car.Car_ID== giaodich.Car_ID);
                    if(carinfo != null)
                    {
                        double tong = carinfo.Price + (carinfo.Price * giaodich.Taxes_Fees * 0.01);
                        dr["Price"] = tong;
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public static DataTable LayThongKeGiaoDich()
        {
            using (DataAccess db = new DataAccess())
            {
                var giaodichs = db.DSTrans.ToList();
                DataTable dt = new DataTable();                                     
                dt.Columns.Add("Price", typeof(double));
                dt.Columns.Add("MaGD", typeof(string));
                dt.Columns.Add("MaKH", typeof(string));
                foreach (var giaodich in giaodichs)
                {
                    DataRow dr = dt.NewRow();                                                         
                    var carInfo = db.DSCar.FirstOrDefault(car => car.Car_ID == giaodich.Car_ID);
                    if (carInfo != null)
                    {                        
                        double tong = carInfo.Price + (carInfo.Price * giaodich.Taxes_Fees * 0.01);
                        dr["Price"] = tong;                        
                        dr["MaGD"] = giaodich.Transaction_ID;
                        dr["MaKH"] = giaodich.Customer_ID;
                    }
                    dt.Rows.Add(dr);
                }
                return dt;
            }
        }
        public static DataTable LayThongKeXe()
        {
            using (DataAccess db = new DataAccess())
            {
                var cars = db.DSCar.ToList();
                DataTable dt = new DataTable();
                dt.Columns.Add("MaXe", typeof(string));
                dt.Columns.Add("TenXe", typeof(string));
                dt.Columns.Add("MaNSX", typeof(string));
                foreach(var car in cars)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaXe"] = car.Car_ID;
                    dr["TenXe"] = car.Model_Name;
                    dr["MaNSX"] = car.Man_ID;
                    dt.Rows.Add(dr);
                }                
                return dt;
            }
        }
    }
}
