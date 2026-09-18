using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercies
{
    class Sach
    {
        protected string maSach;
        protected DateTime ngayNhap;
        protected double donGia;
        protected int soLuong;
        protected string nhaXuatBan;

        public string getMaSach()
        {
            return maSach;
        }

        public void setMaSach(string maSach)
        {
            this.maSach = maSach;
        }

        public DateTime getNgayNhap()
        {
            return ngayNhap;
        }

        public void setNgayNhap(DateTime ngayNhap)
        {
            this.ngayNhap = ngayNhap;
        }

        public double getDonGia()
        {
            return donGia;
        }

        public void setDonGia(double donGia)
        {
            this.donGia = donGia;
        }

        public int getSoLuong()
        {
            return soLuong;
        }

        public void setSoLuong(int soLuong)
        {
            this.soLuong = soLuong;
        }

        public string getNhaXuatBan()
        {
            return nhaXuatBan;
        }

        public void setNhaXuatBan(string nhaXuatBan)
        {
            this.nhaXuatBan = nhaXuatBan;
        }

        public Sach(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan)
        {
            this.maSach = maSach;
            this.ngayNhap = ngayNhap;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.nhaXuatBan = nhaXuatBan;
        }

      

        public virtual double getThanhTien()
        {
            return soLuong * donGia;
        }

        public override string ToString()
        {
            return "Ma sach: " + maSach +
                   ", Ngay nhap: " + ngayNhap.ToString("dd/MM/yyyy") +
                   ", Don gia: " + donGia +
                   ", So luong: " + soLuong +
                   ", Nha xuat ban: " + nhaXuatBan +
                   ", Thanh tien: " + getThanhTien();
        }
    }

    class SachGiaoKhoa : Sach
    {
        private bool tinhTrang;

        public bool getTinhTrang()
        {
            return tinhTrang;
        }

        public void setTinhTrang(bool tinhTrang)
        {
            this.tinhTrang = tinhTrang;
        }

        public SachGiaoKhoa(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, bool tinhTrang)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.tinhTrang = tinhTrang;
        }

        

        public override double getThanhTien()
        {
            if (tinhTrang == true)
                return soLuong * donGia;
            else
                return soLuong * donGia * 0.5;
        }

        public override string ToString()
        {
            string tt;

            if (tinhTrang == true)
                tt = "Moi";
            else
                tt = "Cu";

            return base.ToString() + ", Tinh trang: " + tt;
        }
    }

    class SachThamKhao : Sach
    {
        private double thue;

        public double getThue()
        {
            return thue;
        }

        public void setThue(double thue)
        {
            this.thue = thue;
        }

        public SachThamKhao(string maSach, DateTime ngayNhap, double donGia, int soLuong, string nhaXuatBan, double thue)
            : base(maSach, ngayNhap, donGia, soLuong, nhaXuatBan)
        {
            this.thue = thue;
        }

       

        public override double getThanhTien()
        {
            return soLuong * donGia + thue;
        }

        public override string ToString()
        {
            return base.ToString() + ", Thue: " + thue;
        }
    }

    class Tinhtien
    {
      public static double tinhTongThanhTienSGK(List<Sach> ds)
        {
            double tong = 0;

            foreach (Sach s in ds)
            {
                if (s is SachGiaoKhoa)
                    tong += s.getThanhTien();
            }

            return tong;
        }

       public static double tinhTongThanhTienSTK(List<Sach> ds)
        {
            double tong = 0;

            foreach (Sach s in ds)
            {
                if (s is SachThamKhao)
                    tong += s.getThanhTien();
            }

            return tong;
        }

      public static List<Sach> timSachGiaoKhoaTheoNXB(List<Sach> ds, string nxb)
        {
            List<Sach> ketQua = new List<Sach>();

            foreach (Sach s in ds)
            {
                if (s is SachGiaoKhoa && s.getNhaXuatBan() == nxb)
                    ketQua.Add(s);
            }

            return ketQua;
        }

       public static double timThanhTienCaoNhat(List<Sach> ds)
        {
            double max = 0;

            foreach (Sach s in ds)
            {
                if (s.getThanhTien() > max)
                    max = s.getThanhTien();
            }

            return max;
        }

    }
}