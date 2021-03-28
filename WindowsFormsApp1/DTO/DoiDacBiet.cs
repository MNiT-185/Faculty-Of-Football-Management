using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class DoiDacBiet
    {
        public DoiDacBiet(int mavongdau, string doi)
        {
            this.Mavongdau = mavongdau;
            this.Doi = doi;
        }

        public DoiDacBiet(DataRow row)
        {
            this.Mavongdau = (int)row["mavongdau"];
            this.Doi = row["doi"].ToString();
        }

        private int mavongdau;

        public int Mavongdau
        {
            get { return mavongdau; }
            set { mavongdau = value; }
        }

        private string doi;

        public string Doi
        {
            get { return doi; }
            set { doi = value; }
        }
    }
}
