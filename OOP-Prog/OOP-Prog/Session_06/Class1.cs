using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Prog.Session_06
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }


        public SinhVien(string maSV, string hoTen)
        {
            MaSV = maSV;
            HoTen = hoTen;
        }

        public SinhVien(): this("0000","noname"){ }


    }
   
}
