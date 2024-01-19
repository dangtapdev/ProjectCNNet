using DataAccessLayer.Entities;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BussinessLogicLayer
{
    public class BLL
    {
        public static DataTable ShowCustomerInfo()
        {
            return DataAccessLayer.GetData.LayKhachHang();
        }
    }
}