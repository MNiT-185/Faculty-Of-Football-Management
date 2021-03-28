using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO
{
    class VongDau
    {
        public VongDau(int mavongdau, string tenvongdau,  int diem)
        {
            this.Mavongdau = mavongdau;
            this.Tenvongdau = tenvongdau;
            this.Diem = diem;
        }

        public VongDau(DataRow row)
        {
            this.Mavongdau = (int)row["mavongdau"];
            this.Tenvongdau = row["tenvongdau"].ToString();
            this.Diem = (int)row["diem"];
        }

        private string tenvongdau;

        public string Tenvongdau
        {
            get { return tenvongdau; }
            set { tenvongdau = value; }
        }
        private int mavongdau;

        public int Mavongdau
        {
            get { return mavongdau; }
            set { mavongdau = value; }
        }
        private int diem;

        public int Diem
        {
            get { return diem; }
            set { diem = value; }
        }
    }
}
