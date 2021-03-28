using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class VongDauDAO
    {
        private static VongDauDAO instance;

        public static VongDauDAO Instance
        {
            get { if (instance == null) instance = new VongDauDAO(); return VongDauDAO.instance; }
            private set { VongDauDAO.instance = value; }
        }

        private VongDauDAO() { }

        public List<VongDau> GetInforByVongDau(string maVongDau)
        {
            List<VongDau> list = new List<VongDau>();

            string query = "select * from vongdau where mavongdau =" + maVongDau;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                VongDau member = new VongDau(item);
                list.Add(member);
            }

            return list;
        }

        public List<VongDau> GetListVongDau()
        {
            List<VongDau> list = new List<VongDau>();

            string query = "select * from vongdau";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                VongDau member = new VongDau(item);
                list.Add(member);
            }

            return list;
        }
        public bool InsertVongDau(string name,int diem)
        {
            string query = string.Format("INSERT vongdau VALUES  ( N'{0}',{1})", name, diem);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
