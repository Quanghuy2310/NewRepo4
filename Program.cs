using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo24_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Kiểu Dữ Liệu ");
            byte a = 123;
            int b = 7; //
            long c = 10000000;
            float d = 14.99999F;
            double e = 14.999999999D;
            string chuoi = " kiểu dữ liệu chuỗi ";
            char f = 'A';
            bool g = true;
            bool h = false;
            DateTime dt = DateTime.Now;

            Console.WriteLine($"Byte : {a}");
            Console.WriteLine($"Int : {b}");
            Console.WriteLine($"Long : {c}");
            Console.WriteLine($"Float : {d}");
            Console.WriteLine($"Double: {e}");
            Console.WriteLine($"String : {chuoi}");
            Console.WriteLine($"Char : {f}");
            Console.WriteLine($"Bool : {g} / {h}");
            Console.WriteLine("1 + 1 = ?");
            int x;
            x = int.Parse(Console.ReadLine());
            string kqua = (x == 2) ? $"{g}" : $"{h}";
            Console.WriteLine(kqua);
            Console.WriteLine($"Date : {dt:D}");

            Console.WriteLine("Thứ tự chuỗi từ bé -> lớn : char -> int -> long -> float ->double");

            Console.WriteLine($"d = {d} Convert d = {Convert.ToInt32(d)} ");
            // arrays

            int[] arrays1 = { 1, 3, 5, 7, 8, 10, 12 };

            Console.WriteLine("Arrays : ");
            foreach (int number in arrays1)
            {
                Console.Write("{0} | ", number);
            }
            Console.WriteLine("\n \n List Info");
            Console.WriteLine("Nhập Tên");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập Tuổi");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập Giới Tính");
            string gioitinh = Console.ReadLine();

            string[] thongtin = { $"{ ten}", $"{tuoi}", $"{gioitinh}" };
            foreach (string text in thongtin)
            {
                Console.Write("{0} | ", text);
            }

            Console.WriteLine("\n \n Class");
            Connguoi A = new Connguoi();
            A.Ten = "Huy";
            A.Tuoi = 20; // vì để private nên ko use dc 
            A.Gioitinh = "nam";
            A.Nghenghiep = "tự do";
            A.Thongtin();

            // extends
            Nhanvien B = new Nhanvien();
            B.Ten = "Nga";
            B.Gioitinh = "Nữ";
            B.Nghenghiep = "Văn Phòng";
            B.Thongtin();


            // abstract
            Connguoi Connguoi = new Connguoi();
            Connguoi Nhanvien = new Nhanvien();
            Connguoi Nhanvienthuviec = new Nhanvienthuviec();
            Connguoi.Mautoc();
            Nhanvien.Mautoc();
            Nhanvienthuviec.Mautoc();



            Console.ReadKey();
        }

    }
    class Connguoi
    {
        protected string ten;
        private int tuoi;
        protected string gioitinh;
        protected string nghenghiep;

        public string Ten { get => ten; set => ten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }

        public void Thongtin()
        {
            Console.WriteLine(" Tên " + Ten + " Giới Tính " + Gioitinh + " Nghề Nghiệp " + Nghenghiep);
        }

        public virtual void Mautoc()
        {
            Console.WriteLine("Con Người Tóc thẳng");
        }


    }

    class Nhanvien : Connguoi
    {
        public Nhanvien()
        {

        }
        public override void Mautoc()
        {
            Console.WriteLine("Nhân Viên Tóc xoăn");
        }
    }

    class Nhanvienthuviec : Connguoi
    {
        public Nhanvienthuviec()
        {

        }
        public override void Mautoc()
        {
            Console.WriteLine("Nhân Viên Thử Việc Tóc ngắn");
        }
    }

}
