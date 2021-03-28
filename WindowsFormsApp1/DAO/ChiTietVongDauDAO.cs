using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO;

namespace WindowsFormsApp1.DAO
{
    class ChiTietVongDauDAO
    {
        private static ChiTietVongDauDAO instance;

        public static ChiTietVongDauDAO Instance
        {
            get { if (instance == null) instance = new ChiTietVongDauDAO(); return ChiTietVongDauDAO.instance; }
            private set { ChiTietVongDauDAO.instance = value; }
        }

        private ChiTietVongDauDAO() { }

        public List<ChiTietVongDau> GetInforByVongDau(int maVongDau)
        {
            List<ChiTietVongDau> list = new List<ChiTietVongDau>();

            string query = "select * from chitietvongdau where mavongdau =" + maVongDau;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ChiTietVongDau member = new ChiTietVongDau(item);
                list.Add(member);
            }

            return list;
        }
        public bool InsertChiTietVongDau(int mavongdau,string doi1, string doi2)
        {
            string query = string.Format("INSERT chitietvongdau VALUES  ({0},N'{1}',N'{2}','','','','{3}')", mavongdau, doi1, doi2,DateTime.Now);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool CheckVongDau(int id)
        {
            string query = string.Format("select count(*) from chitietvongdau where mavongdau = '{0}'", id);
            int result = (int)DataProvider.Instance.ExecuteScalar(query);

            return result == 0;
        }
        public bool UpdateCTVD(int mavongdau, string doi1, string doi2,string tyso,string doithang,string san,DateTime tg)
        {
            string query = string.Format("UPDATE chitietvongdau SET tyso = N'{0}', doithang = N'{1}',san = N'{2}',thoigian = '{6}' where mavongdau = {3} and doi1 = N'{4}' and doi2 = N'{5}'", tyso, doithang, san,mavongdau,doi1,doi2,tg);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
