// Hinh 1
Console.Write("Nhap chieu dai hinh 1: ");
double dai1 = double.Parse(Console.ReadLine());

Console.Write("Nhap chieu rong hinh 1: ");
double rong1 = double.Parse(Console.ReadLine());

// Hình 2
Console.Write("Nhap chieu dai hinh 2: ");
double dai2 = double.Parse(Console.ReadLine());

Console.Write("Nhap chieu rong hinh 2: ");
double rong2 = double.Parse(Console.ReadLine());

// Tính hình 1
double dienTich1 = dai1 * rong1;
double chuVi1 = (dai1 + rong1) * 2;

// Tính Hình 2
double dienTich2 = dai2 * rong2;
double chuVi2 = (dai2 + rong2) * 2;

// In kết quả
Console.WriteLine("Dien Tinh Hinh 1: " + dienTich1);
Console.WriteLine("Dien Tinh Hinh 2: " + dienTich2);
Console.WriteLine("Chu Vi Hinh 1: " + chuVi1);
Console.WriteLine("Chu Vi Hinh 2: " + chuVi2);

// So Sánh
if (dienTich1 > dienTich2)
    Console.WriteLine("Hinh 1 lon hon Hinh 2:");
else if (dienTich1 < dienTich2)
    Console.WriteLine("Hinh 2 lon hon Hinh 1:");
else if (dienTich1 == dienTich2)
    Console.WriteLine("2 Hinh bang nhau:");