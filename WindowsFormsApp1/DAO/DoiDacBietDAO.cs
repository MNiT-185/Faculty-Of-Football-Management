using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAO
{
    class DoiDacBietDAO
    {
        private static DoiDacBietDAO instance;

        public static DoiDacBietDAO Instance
        {
            get { if (instance == null) instance = new DoiDacBietDAO(); return DoiDacBietDAO.instance; }
            private set { DoiDacBietDAO.instance = value; }
        }

        private DoiDacBietDAO() { }

        public bool InsertDoiDacBiet(int mavongdau, string doi)
        {
            string query = string.Format("INSERT doidacbiet VALUES  ({0},N'{1}')", mavongdau, doi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool CheckDoiDacBiet(int mavongdau)
        {
            string query = string.Format("select count(*) from doidacbiet where mavongdau = {0}", mavongdau);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            return result > 0;
        }
        public string GetDoiDacBiet(int mavongdau)
        {
            string query = string.Format("select doi from doidacbiet where mavongdau = {0}", mavongdau);
            string result = (string)DataProvider.Instance.ExecuteScalar(query);

            return result;
        }
    }
}
