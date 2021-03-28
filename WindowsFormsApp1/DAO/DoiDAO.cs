using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class DoiDAO
    {
        private static DoiDAO instance;

        public static DoiDAO Instance
        {
            get { if (instance == null) instance = new DoiDAO(); return DoiDAO.instance; }
            private set { DoiDAO.instance = value; }
        }

        private DoiDAO() { }

        public List<Doi> GetDoi()
        {
            List<Doi> list = new List<Doi>();

            string query = "select * from Doi";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Doi team = new Doi(item);
                list.Add(team);
            }

            return list;
        }
        public bool InsertTeam(string name)
        {
            string query = string.Format("INSERT Doi VALUES  ( N'{0}',0,0)", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public List<Doi> LayLopCuaDoi()
        {
            List<Doi> list = new List<Doi>();

            string query = "select * from Doi";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Doi team = new Doi(item);
                list.Add(team);
            }

            return list;
        }

        public List<Doi> GetRank()
        {
            List<Doi> list = new List<Doi>();

            string query = "select top(50) * from Doi ORDER BY diem DESC";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Doi team = new Doi(item);
                list.Add(team);
            }

            return list;
        }

        public bool CheckLop(string name)
        {
            string query = string.Format("select count(*) from doi where lop = '{0}'", name);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            return result == 0;
        }
        public bool UpdateDoi(string doi, int diem, int sovongthang)
        {
            string query = string.Format("UPDATE doi SET diem = {0} ,sovongthang = {1} where lop = N'{2}'", diem, sovongthang,doi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public int getDiem(string doi)
        {
            string query = string.Format("select diem from doi where lop =N'{0}'", doi);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result ;
        }
        public int getSoVongThang(string doi)
        {
            string query = string.Format("select sovongthang from doi where lop =N'{0}'", doi);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            return result;
        }
    }
}
