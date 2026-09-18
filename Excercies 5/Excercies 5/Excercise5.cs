using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercies
{
    public abstract class HangHoa
    {
        protected string maHang;
        protected string tenHang;
        protected double donGia;
        protected int soLuongTon;

        public string getMaHang()
        {
            return maHang;
        }

        public void setMaHang(string maHang)
        {
            if (!string.IsNullOrWhiteSpace(maHang))
                this.maHang = maHang;
        }

        public string getTenHang()
        {
            return tenHang;
        }

        public void setTenHang(string tenHang)
        {
            if (!string.IsNullOrWhiteSpace(tenHang))
                this.tenHang = tenHang;
            else
                this.tenHang = "xxx";
        }

        public double getDonGia()
        {
            return donGia;
        }

        public void setDonGia(double donGia)
        {
            if (donGia >= 0)
                this.donGia = donGia;
        }

        public int getSoLuongTon()
        {
            return soLuongTon;
        }

        public void setSoLuongTon(int soLuongTon)
        {
            if (soLuongTon >= 0)
                this.soLuongTon = soLuongTon;
        }

        public HangHoa(string maHang, string tenHang, double donGia, int soLuongTon)
        {
            if (string.IsNullOrWhiteSpace(maHang))
                throw new ArgumentException("Ma hang khong duoc rong");

            this.maHang = maHang;
            this.tenHang = string.IsNullOrWhiteSpace(tenHang) ? "xxx" : tenHang;
            this.donGia = donGia >= 0 ? donGia : 0;
            this.soLuongTon = soLuongTon >= 0 ? soLuongTon : 0;
        }

        public abstract double tinhVAT();

        public abstract string danhGia();

        public override string ToString()
        {
            return "Ma hang: " + maHang +
                   ", Ten hang: " + tenHang +
                   ", Don gia: " + donGia +
                   ", So luong ton: " + soLuongTon +
                   ", VAT: " + tinhVAT() +
                   ", Danh gia: " + danhGia();
        }
    }

    public class HangThucPham : HangHoa
    {
        private string nhaCungCap;
        private DateTime ngaySanXuat;
        private DateTime ngayHetHan;

        public string getNhaCungCap()
        {
            return nhaCungCap;
        }

        public void setNhaCungCap(string nhaCungCap)
        {
            this.nhaCungCap = nhaCungCap;
        }

        public DateTime getNgaySanXuat()
        {
            return ngaySanXuat;
        }

        public void setNgaySanXuat(DateTime ngaySanXuat)
        {
            this.ngaySanXuat = ngaySanXuat;
        }

        public DateTime getNgayHetHan()
        {
            return ngayHetHan;
        }

        public void setNgayHetHan(DateTime ngayHetHan)
        {
            this.ngayHetHan = ngayHetHan;
        }

        public HangThucPham(
            string maHang,
            string tenHang,
            double donGia,
            int soLuongTon,
            string nhaCungCap,
            DateTime ngaySanXuat,
            DateTime ngayHetHan)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            this.nhaCungCap = nhaCungCap;
            this.ngaySanXuat = ngaySanXuat;
            this.ngayHetHan = ngayHetHan;
        }

        public override double tinhVAT()
        {
            return donGia * soLuongTon * 0.05;
        }

        public override string danhGia()
        {
            if (soLuongTon > 0 && DateTime.Now.Date > ngayHetHan.Date)
                return "Kho ban";

            return "Khong danh gia";
        }

        public override string ToString()
        {
            return base.ToString() +
                   ", Nha cung cap: " + nhaCungCap +
                   ", Ngay san xuat: " + ngaySanXuat.ToString("dd/MM/yyyy") +
                   ", Ngay het han: " + ngayHetHan.ToString("dd/MM/yyyy");
        }
    }

    public class HangDienMay : HangHoa
    {
        private int thoiGianBaoHanh;
        private double congSuat;

        public int getThoiGianBaoHanh()
        {
            return thoiGianBaoHanh;
        }

        public void setThoiGianBaoHanh(int thoiGianBaoHanh)
        {
            if (thoiGianBaoHanh > 0)
                this.thoiGianBaoHanh = thoiGianBaoHanh;
        }

        public double getCongSuat()
        {
            return congSuat;
        }

        public void setCongSuat(double congSuat)
        {
            if (congSuat > 0)
                this.congSuat = congSuat;
        }

        public HangDienMay(
            string maHang,
            string tenHang,
            double donGia,
            int soLuongTon,
            int thoiGianBaoHanh,
            double congSuat)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            this.thoiGianBaoHanh = thoiGianBaoHanh > 0 ? thoiGianBaoHanh : 1;
            this.congSuat = congSuat > 0 ? congSuat : 1;
        }

        public override double tinhVAT()
        {
            return donGia * soLuongTon * 0.10;
        }

        public override string danhGia()
        {
            if (soLuongTon < 3)
                return "Ban duoc";

            return "Khong danh gia";
        }

        public override string ToString()
        {
            return base.ToString() +
                   ", Thoi gian bao hanh: " + thoiGianBaoHanh +
                   " thang, Cong suat: " + congSuat + " KW";
        }
    }

    public class HangSanhSu : HangHoa
    {
        private string nhaSanXuat;
        private DateTime ngayNhapKho;

        public string getNhaSanXuat()
        {
            return nhaSanXuat;
        }

        public void setNhaSanXuat(string nhaSanXuat)
        {
            this.nhaSanXuat = nhaSanXuat;
        }

        public DateTime getNgayNhapKho()
        {
            return ngayNhapKho;
        }

        public void setNgayNhapKho(DateTime ngayNhapKho)
        {
            this.ngayNhapKho = ngayNhapKho;
        }

        public HangSanhSu(
            string maHang,
            string tenHang,
            double donGia,
            int soLuongTon,
            string nhaSanXuat,
            DateTime ngayNhapKho)
            : base(maHang, tenHang, donGia, soLuongTon)
        {
            this.nhaSanXuat = nhaSanXuat;
            this.ngayNhapKho = ngayNhapKho;
        }

        public override double tinhVAT()
        {
            return donGia * soLuongTon * 0.10;
        }

        public override string danhGia()
        {
            double soNgayLuuKho = (DateTime.Now.Date - ngayNhapKho.Date).TotalDays;

            if (soLuongTon > 50 && soNgayLuuKho > 10)
                return "Ban cham";

            return "Khong danh gia";
        }

        public override string ToString()
        {
            return base.ToString() +
                   ", Nha san xuat: " + nhaSanXuat +
                   ", Ngay nhap kho: " + ngayNhapKho.ToString("dd/MM/yyyy");
        }
    }

    public class QuanLyHangHoa
    {
        private List<HangHoa> ds;

        public QuanLyHangHoa(int n)
        {
            ds = new List<HangHoa>();

            for (int i = 0; i < n; i++)
            {
                ds.Add(null);
            }
        }

        public bool themHangHoa(HangHoa hang)
        {
            if (hang == null)
                return false;

            foreach (HangHoa h in ds)
            {
                if (h != null && h.getMaHang() == hang.getMaHang())
                    return false;
            }

            ds.Add(hang);
            return true;
        }

        public void layThongTinToanBo()
        {
            foreach (HangHoa h in ds)
            {
                if (h != null)
                    Console.WriteLine(h);
            }
        }

        public void layThongTinHangThucPham()
        {
            foreach (HangHoa h in ds)
            {
                if (h is HangThucPham)
                    Console.WriteLine(h);
            }
        }

        public void layThongTinHangDienMay()
        {
            foreach (HangHoa h in ds)
            {
                if (h is HangDienMay)
                    Console.WriteLine(h);
            }
        }

        public void layThongTinHangSanhSu()
        {
            foreach (HangHoa h in ds)
            {
                if (h is HangSanhSu)
                    Console.WriteLine(h);
            }
        }

        public HangHoa timKiemHangHoa(string maHang)
        {
            foreach (HangHoa h in ds)
            {
                if (h != null && h.getMaHang() == maHang)
                    return h;
            }

            return null;
        }

        public void sapXepTheoTenTangDan()
        {
            ds.Sort(delegate (HangHoa x, HangHoa y)
            {
                if (x == null)
                    return 1;

                if (y == null)
                    return -1;

                return x.getTenHang().CompareTo(y.getTenHang());
            });
        }

        public void sapXepTheoSoLuongTonGiamDan()
        {
            ds.Sort(delegate (HangHoa x, HangHoa y)
            {
                if (x == null)
                    return 1;

                if (y == null)
                    return -1;

                return y.getSoLuongTon().CompareTo(x.getSoLuongTon());
            });
        }

        public void layThongTinHangKhoBan()
        {
            foreach (HangHoa h in ds)
            {
                if (h != null && h.danhGia() == "Kho ban")
                    Console.WriteLine(h);
            }
        }

        public void xoaHangHoa(string maHang)
        {
            HangHoa h = timKiemHangHoa(maHang);

            if (h != null)
                ds.Remove(h);
        }

        public void suaDonGia(string maHang, double donGiaMoi)
        {
            HangHoa h = timKiemHangHoa(maHang);

            if (h != null)
                h.setDonGia(donGiaMoi);
        }

        public List<HangHoa> getDanhSach()
        {
            return ds;
        }
    }
}