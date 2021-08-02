using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Demo
{
    class DataProcessing
    {
        DBConnection dBConnection = new DBConnection();
        public DataTable GetAllProduct()
        {
            string sql = "select * from SanPham";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table; 
        }

        public DataTable GetAllCategory()
        {
            string sql = "select * from HangSX";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table;
        }

        public void InsertProduct(int maSP, string tenSP, int soLuong, int maHang) 
        {
            String sql = "Insert Into SanPham Values('" + maSP + "', '" + tenSP + "', '" + soLuong + "', '" + maHang + "')";
            dBConnection.ExecuteNonQuery(sql);
        }

        public void EditProduct(int maSP, string tenSP, int soLuong, int maHang)
        {
            //String sql = $"update SanPham set TenSP = {tenSP}, SoLuong = {soLuong}, MaHang = {maHang} where MaSP = {maSP}";
            String sql = "Update SanPham Set TenSP=N'" + tenSP + "', SoLuong='" + soLuong + "', MaHang='" + maHang + "' Where MaSP='" + maSP + "'";
            dBConnection.ExecuteNonQuery(sql);
        }

        public void DeleteProductById(int id)
        {
            String sql = "Delete SanPham Where MaSP='" + id + "'";
            dBConnection.ExecuteNonQuery(sql);
        }


        public string FindTenHangByMaHang (int maHang)
        {
            string sql = "select TenHang from HangSX where MaHang = '" + maHang + "'";
            DataTable table = new DataTable();
            table = dBConnection.GetTable(sql);
            return table.Rows[0].ItemArray[0].ToString();
        }
    }
}
