// Đề Bài: Xây dựng một ứng dụng chuyển đổi tiền tệ, cho phép tính giá trị tiền VNĐ dựa trên một tỉ giá cho trước và giá trị tiền USD được nhập vào.
long Tygia = 23000;
Console.WriteLine("Ty Gia: " + Tygia);

Console.Write("Nhap tien USD: ");
long USD = long.Parse(Console.ReadLine());

long VND = USD * Tygia;
Console.Write("Tien VND: " + VND);