using DataAccessLayer.Entities;
using System.Data;
namespace BussinessLogicLayer
{
    public class BLL
    {
        public static List<Account> DSAcc() {return DataAccessLayer.GetData.LayDSAcc(); }         
        public static DataTable LayKhachHang()
        {
            return DataAccessLayer.GetData.LayKhachHang();
        }
        public static DataTable LayXe()
        {
            return DataAccessLayer.GetData.LayXe();
        }
        public static DataTable LayNSX()
        {
            return DataAccessLayer.GetData.LayNSX();
        }
        public static DataTable LayNV() { return DataAccessLayer.GetData.LayNhanVien(); }
        public static DataTable LayGD() { return DataAccessLayer.GetData.LayGiaoDich(); }
        public static DataTable LayThongKeGD() { return DataAccessLayer.GetData.LayThongKeGiaoDich(); }
        public static DataTable ThongKeXe() { return DataAccessLayer.GetData.LayThongKeXe(); }
    }
}