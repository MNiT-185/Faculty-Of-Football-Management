using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class Doi
    {
        public Doi(string lop,int sovongthang ,int diem)
        {
            this.Lop = lop;
            this.Sovongthang = sovongthang;
            this.Diem = diem;
        }

        public Doi(DataRow row)
        {
            this.Lop = row["lop"].ToString();
            this.Sovongthang = (int)row["sovongthang"];
            this.Diem = (int)row["diem"];
        }

        private string lop;

        public string Lop
        {
            get { return lop; }
            set { lop = value; }
        }
        private int sovongthang;

        public int Sovongthang
        {
            get { return sovongthang; }
            set { sovongthang = value; }
        }
        private int diem;

        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }
    }
}
