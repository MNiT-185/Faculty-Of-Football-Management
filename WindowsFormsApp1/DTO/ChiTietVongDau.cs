using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class ChiTietVongDau
    {
        public ChiTietVongDau(int mavongdau, string doi1 ,string doi2, string tyso, string doithang, string san, DateTime? thoigian)
        {
            this.Mavongdau = mavongdau;
            this.Doi1 = doi1;
            this.Doi2 = doi2;
            this.Tyso = tyso;
            this.Doithang = doithang;
            this.San = san;
            this.Thoigian = thoigian;
        }

        public ChiTietVongDau(DataRow row)
        {
            this.Mavongdau = (int)row["mavongdau"];
            this.Doi1 = row["doi1"].ToString();
            this.Doi2 = row["doi2"].ToString();
            this.Tyso = row["tyso"].ToString();
            this.Doithang = row["doithang"].ToString();
            this.San = row["san"].ToString();
            this.Thoigian = (DateTime?)row["thoigian"];
        }

        private int mavongdau;

        public int Mavongdau
        {
            get { return mavongdau; }
            set { mavongdau = value; }
        }

        private string doi1;

        public string Doi1
        {
            get { return doi1; }
            set { doi1 = value; }
        }

        private string doi2;

        public string Doi2
        {
            get { return doi2; }
            set { doi2 = value; }
        }

        private string tyso;

        public string Tyso
        {
            get { return tyso; }
            set { tyso = value; }
        }

        private string doithang;

        public string Doithang
        {
            get { return doithang; }
            set { doithang = value; }
        }

        private string san;

        public string San
        {
            get { return san; }
            set { san = value; }
        }

        private DateTime? thoigian;

        public DateTime? Thoigian
        {
            get { return thoigian; }
            set { thoigian = value; }
        }

    }
}
