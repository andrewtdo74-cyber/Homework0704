Console.WriteLine("Nhap So Tien USD");
decimal USD = decimal.Parse(Console.ReadLine());

decimal TyGia = 25300;

decimal VND = USD * TyGia;

decimal phi = VND * 0.005m;

decimal Tong = VND + phi;

Console.WriteLine("Ty Gia " + TyGia);
Console.WriteLine("So Tien VND " + VND);
Console.WriteLine("Phi Chuyen Doi "  + phi);
Console.WriteLine("Tong So Tien " + Tong);