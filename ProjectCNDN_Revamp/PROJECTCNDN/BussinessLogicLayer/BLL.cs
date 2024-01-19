using System.Data;
namespace BussinessLogicLayer
{
    public class BLL
    {
        public static DataTable LayKhachHang()
        {
            return DataAccessLayer.GetData.LayKhachHang();
        }
    }
}