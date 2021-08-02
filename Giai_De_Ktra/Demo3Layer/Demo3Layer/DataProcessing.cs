using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Demo3Layer
{
    class DataProcessing
    {
        DBConnection dataConn = new DBConnection();

        public DataTable ShowAllProducts()
        {
            string sql = "Select * from Products";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public DataTable ShowAllCategory()
        {
            string sql = "select * from Category";
            DataTable table = new DataTable();
            table = dataConn.GetTable(sql);
            return table;
        }

        public void InsertProduct(string ProductsCode, string Description, double UnitPrice, int OnHandQuantity, string CategoryID)
        {
            String sql = "Insert Into Products Values('" + ProductsCode + "', '" + Description + "', '" + UnitPrice + "', '" + OnHandQuantity + "', '" + CategoryID + "')";
            dataConn.ExecuteNonQuery(sql);
        }

        public void EditProduct(string ProductsCode, string Description, double UnitPrice, int OnHandQuantity, string CategoryID)
        {
            String sql = "Update Products Set Description='" + Description + "', UnitPrice='" + UnitPrice + "', OnHandQuantity='" + OnHandQuantity + "', CategoryID='" + CategoryID + "' Where ProductsCode='" + ProductsCode + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        public void DeleteProductById(string ProductsCode)
        {
            String sql = "Delete Products Where ProductsCode='" + ProductsCode + "'";
            dataConn.ExecuteNonQuery(sql);
        }

        public string GetCategoryNameByID(string id)
        {
            string sql = "select CategoryName from Category where CategoryID = '" + id + "'";
            DataTable table = new DataTable();
            table = dataConn.ExecuteReturnTable(sql);

            return table.Rows[0].ItemArray[0].ToString();
        }
    }
}
