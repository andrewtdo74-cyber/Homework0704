Console.WriteLine("Diem Toan =");
double toan =  double.Parse(Console.ReadLine());

Console.WriteLine("Diem Ly =");
double ly = double.Parse(Console.ReadLine());

Console.WriteLine("Diem Hoa =");
double hoa = double.Parse(Console.ReadLine());

double dtb = (toan +  ly + hoa) / 3;
Console.WriteLine("Diem Trung Binh =" + dtb);

string XepLoai;

if (dtb >= 8.0)
    XepLoai = "Gioi";
else if (dtb >= 6.5)
    XepLoai = "Kha";
else if (dtb >= 5.0)
    XepLoai = "Trung binh";
else
    XepLoai = "Yeu";
    
Console.WriteLine("Xep Loai =" + XepLoai);