using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercies
{
  
        public class GiaoDich
        {
            protected string maGiaoDich;
            protected DateTime ngayGiaoDich;
            protected double donGia;
            protected int soLuong;

            public string getMaGiaoDich()
            {
                return maGiaoDich;
            }

            public void setMaGiaoDich(string maGiaoDich)
            {
                this.maGiaoDich = maGiaoDich;
            }

            public DateTime getNgayGiaoDich()
            {
                return ngayGiaoDich;
            }

            public void setNgayGiaoDich(DateTime ngayGiaoDich)
            {
                this.ngayGiaoDich = ngayGiaoDich;
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

            public GiaoDich(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong)
            {
                this.maGiaoDich = maGiaoDich;
                this.ngayGiaoDich = ngayGiaoDich;
                this.donGia = donGia;
                this.soLuong = soLuong;
            }

            public virtual double getThanhTien()
            {
                return soLuong * donGia;
            }

            public override string ToString()
            {
                return "Ma giao dich: " + maGiaoDich +
                       ", Ngay giao dich: " + ngayGiaoDich.ToString("dd/MM/yyyy") +
                       ", Don gia: " + donGia +
                       ", So luong: " + soLuong +
                       ", Thanh tien: " + getThanhTien();
            }
        }

        public class GiaoDichVang : GiaoDich
        {
            private string loaiVang;

            public string getLoaiVang()
            {
                return loaiVang;
            }

            public void setLoaiVang(string loaiVang)
            {
                this.loaiVang = loaiVang;
            }

            public GiaoDichVang(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, string loaiVang)
                : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
            {
                this.loaiVang = loaiVang;
            }

            public override double getThanhTien()
            {
                return soLuong * donGia;
            }

            public override string ToString()
            {
                return base.ToString() + ", Loai vang: " + loaiVang;
            }
        }

        public class GiaoDichTienTe : GiaoDich
        {
            private double tiGia;
            private string loaiTienTe;

            public double getTiGia()
            {
                return tiGia;
            }

            public void setTiGia(double tiGia)
            {
                this.tiGia = tiGia;
            }

            public string getLoaiTienTe()
            {
                return loaiTienTe;
            }

            public void setLoaiTienTe(string loaiTienTe)
            {
                this.loaiTienTe = loaiTienTe;
            }

            public GiaoDichTienTe(string maGiaoDich, DateTime ngayGiaoDich, double donGia, int soLuong, double tiGia, string loaiTienTe)
                : base(maGiaoDich, ngayGiaoDich, donGia, soLuong)
            {
                this.tiGia = tiGia;
                this.loaiTienTe = loaiTienTe;
            }

            public override double getThanhTien()
            {
                if (loaiTienTe == "USD" || loaiTienTe == "Euro")
                    return soLuong * donGia * tiGia;
                else
                    return soLuong * donGia;
            }

            public override string ToString()
            {
                return base.ToString() +
                       ", Ti gia: " + tiGia +
                       ", Loai tien te: " + loaiTienTe;
            }
        }

        public class Tinhtien1
        {
            public static int tinhTongSoLuongVang(List<GiaoDich> ds)
            {
                int tong = 0;

                foreach (GiaoDich gd in ds)
                {
                    if (gd is GiaoDichVang)
                        tong += gd.getSoLuong();
                }

                return tong;
            }

            public static int tinhTongSoLuongTienTe(List<GiaoDich> ds)
            {
                int tong = 0;

                foreach (GiaoDich gd in ds)
                {
                    if (gd is GiaoDichTienTe)
                        tong += gd.getSoLuong();
                }

                return tong;
            }

            public static double tinhTrungBinhThanhTienTienTe(List<GiaoDich> ds)
            {
                double tong = 0;
                int dem = 0;

                foreach (GiaoDich gd in ds)
                {
                    if (gd is GiaoDichTienTe)
                    {
                        tong += gd.getThanhTien();
                        dem++;
                    }
                }

                if (dem == 0)
                    return 0;

                return tong / dem;
            }

            public static List<GiaoDich> timGiaoDichDonGiaLonHon1Ty(List<GiaoDich> ds)
            {
                List<GiaoDich> ketQua = new List<GiaoDich>();

                foreach (GiaoDich gd in ds)
                {
                    if (gd.getDonGia() > 1000000000)
                        ketQua.Add(gd);
                }

                return ketQua;
            }
        }
    }
