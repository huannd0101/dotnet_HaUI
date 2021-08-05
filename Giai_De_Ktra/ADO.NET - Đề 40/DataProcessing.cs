using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace demo
{
    class DataProcessing
    {
        DBConnection dBConnection = new DBConnection();
        public DataTable GetAllProduct()
        {
            string sql = "select * from Product";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table;
        }

        public DataTable GetAllCategory()
        {
            string sql = "select * from Category";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table;
        }

        public void InsertProduct(int maSP, string tenSP, int dongChai, string dvTinh, int giaBan, int maChungLoai)
        {
            String sql = "Insert Into Product Values('" + maSP + "', '" + tenSP + "', '" + dongChai + "', '" + dvTinh + "', '" + giaBan + "', '" + maChungLoai + "')";
            dBConnection.ExecuteNonQuery(sql);
        }

        public void EditProduct(int maSP, string tenSP, int dongChai, string dvTinh, int giaBan, int maChungLoai)
        {
            String sql = "Update product Set TenMon=N'" + tenSP + "', DongChai='" + dongChai + "', DonViTinh='" + dvTinh + "', GiaBan='" + giaBan + "', MaChungLoai='" + maChungLoai + "' Where MaMon='" + maSP + "'";
            dBConnection.ExecuteNonQuery(sql);
        }

        public void DeleteProductById(int id)
        {
            String sql = "Delete Product Where MaMon='" + id + "'";
            dBConnection.ExecuteNonQuery(sql);
        }
    }
}
