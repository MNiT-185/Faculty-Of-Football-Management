using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class ThanhVien
    {
        public ThanhVien(string mssv,string ten,string lop)
        {
            this.Mssv = mssv;
            this.Ten = ten;
            this.Lop = lop;
        }

        public ThanhVien(DataRow row)
        {
            this.Mssv = row["mssv"].ToString();
            this.Ten = row["ten"].ToString();
            this.Lop = row["lop"].ToString();
        }

        
        private string mssv;

        public string Mssv
        {
            get { return mssv; }
            set { mssv = value; }
        }
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
    }
}
