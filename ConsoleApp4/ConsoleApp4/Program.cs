
//Bai 1:
Console.Write("Diem toan: "); 
double toan = double.Parse(Console.ReadLine());
Console.Write("Diem ly: ");
double ly = double.Parse(Console.ReadLine());
Console.Write("Diem hoa: ");
double hoa = double.Parse(Console.ReadLine());

double score=(toan+ly+hoa)/3;
score = Math.Round(score, 2);
Console.WriteLine($"Diem trung binh: {score}");
if(score>=8.0) Console.WriteLine("Xep loai: Gioi");
if(score>=6.5 && score<8) Console.WriteLine("Xep loai: Kha");
if(score>=5.0&& score<6.5) Console.WriteLine("Xep loai: Trung Binh");
if(score<5.0) Console.WriteLine("xep loai: Yeu");
//Bai 2:
Console.Write("Nhap so tien USD: ");
double sotienUSD=double.Parse(Console.ReadLine());
Console.WriteLine($"So tien USD: {sotienUSD}");
double sotienVND = sotienUSD * 25300;
Console.WriteLine($"So tien VND: {sotienVND}");
double Phichuyenkhoan=sotienVND * 0.005;
Console.WriteLine($"So tien KH: {Phichuyenkhoan}");
double totalMoney=sotienVND+Phichuyenkhoan;
Console.WriteLine($"Tong tien tra lai : {totalMoney}VND");
//Bai 3:
Console.Write("chieu dai hinh 1:  ");
double b1=double.Parse(Console.ReadLine());
Console.Write("chieu rong hinh 1:  ");
double a1=double.Parse(Console.ReadLine());
Console.Write("chieu dai hinh 2:  ");
double b2=double.Parse(Console.ReadLine());
Console.Write("chieu rong hinh 2:  ");
double a2=double.Parse(Console.ReadLine());
Console.WriteLine("Hinh chu nhat 1: ");
double S1=b1*a1;
Console.WriteLine($"dien tich: {S1} ");
double C1 = 2 * (a1 + b1);
Console.WriteLine("Hinh chu nhat 2: ");
Console.WriteLine($"chu vi: {C1}");
double S2=b2*a2;
Console.WriteLine($"dien tich: {S2}");
double C2 = 2 * (a2 + b2);
Console.WriteLine($"chu vi: {C2}");
if(S1>S2) Console.WriteLine("Hinh chu nhat 1 co dien tich lon hon");
if(S1==S2) Console.WriteLine("Hinh chu nhat 1 va hinh chu nhat 2 co dien tich bang nhau");
if(S1<S2) Console.WriteLine("Hinh chu nhat 2 co dien tich lon hon");

