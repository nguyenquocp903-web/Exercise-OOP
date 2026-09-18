
using Excercies;

using System;



public class Program
{
    static void Main(string[] args)
    {

        //Excercise 1
        /*
     double tongNoiThanh = 0;
        double tongNgoaiThanh = 0;
   
        ChuyenXeNoiThanh chuyenXeNoiThanh = new ChuyenXeNoiThanh("NT001", "Nguyen Van A", "29A-12345", 500000, 1, 10);

        ChuyenXeNgoaiThanh chuyenXeNgoaiThanh = new ChuyenXeNgoaiThanh("NT03", "Le Thi Hoa", "50A-11111","Da Lat", 3, 5000000);

        tongNgoaiThanh += chuyenXeNgoaiThanh.DoanhThu;
        tongNoiThanh += chuyenXeNoiThanh.DoanhThu;

        double tongTatCa = tongNgoaiThanh + tongNoiThanh;

        Console.WriteLine("Tong doanh thu tat ca chuyen xe: " + tongTatCa);
        Console.WriteLine("Tong doanh thu chuyen xe noi thanh: " + tongNoiThanh);
        Console.WriteLine("Tong doanh thu chuyen xe ngoai thanh: " + tongNgoaiThanh);
        */


        //Excercise 2
        /*   List<Sach> ds = new List<Sach>();

           ds.Add(new SachGiaoKhoa("SGK01", new DateTime(2026, 1, 10), 50000, 10, "NXB A", true));
           ds.Add(new SachGiaoKhoa("SGK02", new DateTime(2026, 2, 15), 60000, 5, "NXB B", false));
           ds.Add(new SachGiaoKhoa("SGK03", new DateTime(2026, 3, 20), 70000, 8, "NXB A", true));

           ds.Add(new SachThamKhao("STK01", new DateTime(2026, 1, 12), 80000, 5, "NXB A", 10000));
           ds.Add(new SachThamKhao("STK02", new DateTime(2026, 2, 18), 90000, 4, "NXB C", 15000));
           ds.Add(new SachThamKhao("STK03", new DateTime(2026, 3, 25), 100000, 3, "NXB B", 20000));

           Console.WriteLine("DANH SACH CAC LOAI SACH");
           Console.WriteLine();

           foreach (Sach s in ds)
           {
               Console.WriteLine(s);
           }

           Console.WriteLine();
           Console.WriteLine("Tong thanh tien sach giao khoa: " + Tinhtien.tinhTongThanhTienSGK(ds));
           Console.WriteLine("Tong thanh tien sach tham khao: " + Tinhtien.tinhTongThanhTienSTK(ds));

           Console.WriteLine();
           Console.Write("Nhap nha xuat ban K: ");
           string k = Console.ReadLine() ;

           List<Sach> ketQua = Tinhtien.timSachGiaoKhoaTheoNXB(ds, k);

           Console.WriteLine();
           Console.WriteLine("Sach giao khoa cua nha xuat ban " + k + ":");

           foreach (Sach s in ketQua)
           {
               Console.WriteLine(s);
           }
           Console.WriteLine();
           Console.WriteLine("Thanh tien cao nhat: " + Tinhtien.timThanhTienCaoNhat(ds));

           Console.ReadKey();
        */
        //Exercise 3
        /* List<GiaoDich> ds = new List<GiaoDich>();

         ds.Add(new GiaoDichVang("V001", new DateTime(2026, 1, 10), 2000000, 5, "Vang 9999"));
         ds.Add(new GiaoDichVang("V002", new DateTime(2026, 2, 15), 3000000, 10, "Vang 24K"));
         ds.Add(new GiaoDichVang("V003", new DateTime(2026, 3, 20), 1500000, 8, "Vang 18K"));

         ds.Add(new GiaoDichTienTe("T001", new DateTime(2026, 1, 12), 2500000000, 2, 25000, "USD"));
         ds.Add(new GiaoDichTienTe("T002", new DateTime(2026, 2, 18), 1800000000, 3, 29000, "Euro"));
         ds.Add(new GiaoDichTienTe("T003", new DateTime(2026, 3, 25), 900000000, 4, 1, "VN"));

         Console.WriteLine("DANH SACH CAC GIAO DICH");
         Console.WriteLine();

         foreach (GiaoDich gd in ds)
         {
             Console.WriteLine(gd);
         }

         Console.WriteLine();
         Console.WriteLine("Tong so luong giao dich vang: " + Tinhtien1.tinhTongSoLuongVang(ds));
         Console.WriteLine("Tong so luong giao dich tien te: " + Tinhtien1.tinhTongSoLuongTienTe(ds));

         Console.WriteLine();
         Console.WriteLine("Trung binh thanh tien giao dich tien te: " + Tinhtien1.tinhTrungBinhThanhTienTienTe(ds));

         Console.WriteLine();
         Console.WriteLine("CAC GIAO DICH CO DON GIA > 1 TY:");

         List<GiaoDich> ketQua = Tinhtien1.timGiaoDichDonGiaLonHon1Ty(ds);

         foreach (GiaoDich gd in ketQua)
         {
             Console.WriteLine(gd);
         }

         Console.ReadKey();*/

        //Exercise 4
        /*   List<Employee> ds = new List<Employee>();

           ds.Add(new SalariedEmployee("Nguyen Van A", "001", 10000000));

           ds.Add(new HourlyEmployee("Tran Van B", "002", 40, 200000));

           ds.Add(new CommissionEmployee("Le Thi C", "003", 50000000, 0.1));

           ds.Add(new BasePlusCommissionEmployee("Pham Van D", "004", 80000000, 0.1, 5000000));

           Console.WriteLine("DANH SACH NHAN VIEN");
           Console.WriteLine();

           foreach (Employee nv in ds)
           {
               Console.WriteLine(nv);
               Console.WriteLine("Luong: " + nv.Earnings());
               Console.WriteLine();
           }

           Console.WriteLine("DANH SACH NHAN VIEN VA LUONG");
           Console.WriteLine();

           foreach (Employee nv in ds)
           {
               Console.WriteLine(nv);
               Console.WriteLine("Luong: " + nv.Earnings());
               Console.WriteLine();
           }

           Console.ReadKey();*/

        //Exercise 5
        QuanLyHangHoa ql = new QuanLyHangHoa(0);

        ql.themHangHoa(new HangThucPham(
            "TP01",
            "Sua tuoi",
            30000,
            100,
            "Vinamilk",
            new DateTime(2026, 8, 1),
            new DateTime(2026, 9, 10)));

        ql.themHangHoa(new HangThucPham(
            "TP02",
            "Banh mi",
            15000,
            50,
            "ABC",
            new DateTime(2026, 9, 1),
            new DateTime(2026, 9, 5)));

        ql.themHangHoa(new HangThucPham(
            "TP03",
            "Nuoc ngot",
            10000,
            30,
            "Coca",
            new DateTime(2026, 9, 1),
            new DateTime(2026, 12, 1)));

        ql.themHangHoa(new HangDienMay(
            "DM01",
            "Tu lanh",
            15000000,
            2,
            24,
            1.5));

        ql.themHangHoa(new HangDienMay(
            "DM02",
            "May giat",
            12000000,
            10,
            24,
            2));

        ql.themHangHoa(new HangDienMay(
            "DM03",
            "Tivi",
            20000000,
            1,
            36,
            0.5));

        ql.themHangHoa(new HangSanhSu(
            "SS01",
            "Chen su",
            50000,
            100,
            "Bat Trang",
            new DateTime(2026, 9, 1)));

        ql.themHangHoa(new HangSanhSu(
            "SS02",
            "Binh hoa",
            200000,
            60,
            "Bat Trang",
            new DateTime(2026, 9, 1)));

        ql.themHangHoa(new HangSanhSu(
            "SS03",
            "Ly su",
            30000,
            20,
            "Minh Long",
            new DateTime(2026, 9, 15)));

        int chon;

        do
        {
            Console.WriteLine();
            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Xuat toan bo danh sach");
            Console.WriteLine("2. Xuat hang thuc pham");
            Console.WriteLine("3. Xuat hang dien may");
            Console.WriteLine("4. Xuat hang sanh su");
            Console.WriteLine("5. Tim hang theo ma");
            Console.WriteLine("6. Sap xep theo ten tang dan");
            Console.WriteLine("7. Sap xep theo so luong ton giam dan");
            Console.WriteLine("8. Xuat hang kho ban");
            Console.WriteLine("9. Xoa hang theo ma");
            Console.WriteLine("10. Sua don gia");
            Console.WriteLine("0. Thoat");
            Console.Write("Nhap lua chon: ");

            int.TryParse(Console.ReadLine(), out chon);

            Console.WriteLine();

            switch (chon)
            {
                case 1:
                    ql.layThongTinToanBo();
                    break;

                case 2:
                    ql.layThongTinHangThucPham();
                    break;

                case 3:
                    ql.layThongTinHangDienMay();
                    break;

                case 4:
                    ql.layThongTinHangSanhSu();
                    break;

                case 5:
                    Console.Write("Nhap ma hang can tim: ");
                    string maTim = Console.ReadLine() ?? "";

                    HangHoa h = ql.timKiemHangHoa(maTim);

                    if (h != null)
                        Console.WriteLine(h);
                    else
                        Console.WriteLine("Khong tim thay hang");
                    break;

                case 6:
                    ql.sapXepTheoTenTangDan();
                    Console.WriteLine("Da sap xep theo ten tang dan");
                    ql.layThongTinToanBo();
                    break;

                case 7:
                    ql.sapXepTheoSoLuongTonGiamDan();
                    Console.WriteLine("Da sap xep theo so luong ton giam dan");
                    ql.layThongTinToanBo();
                    break;

                case 8:
                    ql.layThongTinHangKhoBan();
                    break;

                case 9:
                    Console.Write("Nhap ma hang can xoa: ");
                    string maXoa = Console.ReadLine() ?? "";

                    ql.xoaHangHoa(maXoa);

                    Console.WriteLine("Da xu ly xoa hang");
                    break;

                case 10:
                    Console.Write("Nhap ma hang: ");
                    string maSua = Console.ReadLine() ?? "";

                    Console.Write("Nhap don gia moi: ");
                    double donGiaMoi;

                    double.TryParse(Console.ReadLine(), out donGiaMoi);

                    ql.suaDonGia(maSua, donGiaMoi);

                    Console.WriteLine("Da sua don gia");
                    break;

                case 0:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }

        } while (chon != 0);

        Console.ReadKey();
    }

}
