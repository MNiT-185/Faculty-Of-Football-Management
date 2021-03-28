using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class ThanhVienDAO
    {
        private static ThanhVienDAO instance;

        public static ThanhVienDAO Instance
        {
            get { if (instance == null) instance = new ThanhVienDAO(); return ThanhVienDAO.instance; }
            private set { ThanhVienDAO.instance = value; }
        }

        private ThanhVienDAO() { }

        public List<ThanhVien> GetThanhVienByDoi(string lop)
        {
            List<ThanhVien> list = new List<ThanhVien>();

            string query = "select * from ThanhVien where lop ="+lop;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhVien member = new ThanhVien(item);
                list.Add(member);
            }

            return list;
        }

        public List<ThanhVien> GetListThanhVien()
        {
            List<ThanhVien> list = new List<ThanhVien>();

            string query = "select * from ThanhVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThanhVien member = new ThanhVien(item);
                list.Add(member);
            }

            return list;
        }

        public bool InsertMembers(string mssv, string ten, string lop)
        {
            string query = string.Format("INSERT Thanhvien VALUES  ( N'{0}',N'{1}',N'{2}')", mssv, ten, lop);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteMembers(string mssv)
        {
            string query = string.Format("Delete Thanhvien where mssv =  N'{0}'", mssv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateMembers(string mssv, string ten, string lop)
        {
            string query = string.Format("UPDATE Thanhvien SET ten = N'{0}', lop = N'{1}' where mssv = N'{2}'", ten, lop, mssv);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool CheckThanhVien(string name)
        {
            string query = string.Format("select count(*) from Thanhvien,Doi where mssv = '{0}' and Thanhvien.lop = Doi.lop", name);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            return result == 0;
        }
    }
}
