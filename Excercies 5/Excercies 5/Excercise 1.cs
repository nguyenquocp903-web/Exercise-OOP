using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercies
{
    public class ChuyenXe
    {

        public string MaSoChuyen { get; set; }
        public string HoTenTaiXe { get; set; }

        public string SoXe { get; set; }
            public double DoanhThu { get; set; }

        public ChuyenXe(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu)
        {
            MaSoChuyen = maSoChuyen;
            HoTenTaiXe = hoTenTaiXe;
            SoXe = soXe;
            DoanhThu = doanhThu;
        }


    }
    public class ChuyenXeNoiThanh : ChuyenXe
    {
        public int SoTuyen { get; set; }
        public double SoKm { get; set; }
        public ChuyenXeNoiThanh(string maSoChuyen, string hoTenTaiXe, string soXe, double doanhThu, int soTuyen, double soKm)
            : base(maSoChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            SoTuyen = soTuyen;
            SoKm = soKm;
        }
    }
    public class ChuyenXeNgoaiThanh : ChuyenXe
    {
        public string NoiDen { get; set; }
        public int SoNgayDiDuoc { get; set; }
        public ChuyenXeNgoaiThanh(string maChuyen, string hoTenTaiXe,string soXe, string noiDen, int soNgayDiDuoc, double doanhThu)
       : base(maChuyen, hoTenTaiXe, soXe, doanhThu)
        {
            NoiDen = noiDen;
            SoNgayDiDuoc = soNgayDiDuoc;
        }
    }



}