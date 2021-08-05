using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BUS
{
    public class BUS_Class
    {
        DAL_Class dal = new DAL_Class();
        public DataTable GetAllNhanSu()
        {
            string sql = "select * from NhanVien";
            return dal.GetTable(sql); ;
        }
        public void InsertNS(string maNS, string tenNS, string namSinh, int nu, string chucVu)
        {
            String sql = "Insert Into NhanVien Values('" + maNS + "', N'" + tenNS + "', '" + namSinh + "', '" + nu + "', N'" + chucVu + "')";
            dal.ExecuteNonQuery(sql);
        }

        public void EditNS(string maNS, string tenNS, string namSinh, int nu, string chucVu)
        {
            String sql = "Update NhanVien Set HoTen=N'" + tenNS + "', NamSinh='" + namSinh + "', Nu='" + nu + "', ChucVu=N'" + chucVu + "' Where MaNhanVien='" + maNS + "'";
            dal.ExecuteNonQuery(sql);
        }

        public void DeleteNSById(string id)
        {
            String sql = "Delete NhanVien Where MaNhanVien='" + id + "'";
            dal.ExecuteNonQuery(sql);
        }

        public DataTable FindNSById(string id)
        {
            String sql = "Select HoTen from NhanVien Where MaNhanVien='" + id + "'";
            return dal.GetTable(sql);
        }
    }
}
