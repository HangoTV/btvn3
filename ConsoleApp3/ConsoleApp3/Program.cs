Console.WriteLine("Hello, World!");
int x = 10;
int y = 20;
short number = 5555;
int z = 3;
Console.WriteLine("x = " + x); //hieenr thij gias trij cuar x treen màn hình
//nhúng giá trị biến trong chuỗi
float salary = 12.53f;
Console.WriteLine($"gia tri x la {x},gia tri y la {y} ");
Console.WriteLine($"so tien ban nhan duoc la {salary}");
int tong =x+y;
int hieu = x - y;
float tich = salary * x;
float thuong = y / salary;
int thuong2 = y / z;
float t = 5;
Console.WriteLine("x+y = " + tong);
Console.WriteLine("x-y="+hieu);
Console.WriteLine("salary*x="+tich);
Console.WriteLine("y/salary="+thuong);
Console.WriteLine("5.0/2=" + (5 / 2));
Console.WriteLine("5.4/2="+(5.4/2));
Console.WriteLine("y/z="+thuong2);
Console.WriteLine("5%2="+(5%2));
//chia lay du ,ktra so chan le
int num1 = 10;
Console.WriteLine("num1++="+ num1++);
Console.WriteLine("num1++="+ ++num1);
//toan tu gan
int ab=100;
z=1201;
int bien;//khai bao bien ko co gia tri ban dau
//khai bao bien nhung ko can khai bao kieu gia tri , gia tri se duoc chuong trinh tu nhan 
var ten="Hoang deptri";
var address='A';
var islog=true;
//tuy nhien trong hau het  tinh huong nen khai bao kieu gia tri ro rang
z+=1000;
int min =100;
int max =200;
Console.WriteLine("min vs max :"+(min>max));
Console.WriteLine("min vs max :"+(min <max));
int check = 6;
Console.WriteLine((check>5)&&(check<10));//2 dkien deu true thi ket qua la true
Console.WriteLine((check<5)||(check <10));//1in2 dkien true thi true
//cau lenh nhap thong tin tu ban phim
//xay dung phan mem co chuc nang :nhap ten ,dchi,sau do  hien thi
Console.Write("Nhap ten cua ban: ");
string fullName = Console.ReadLine();//doc gia tri tu ban phim sau phim enter
Console.Write("nhap dia chi cua ban: ");
string addresss=Console.ReadLine();
//du lien bien dc gan = Console.Readline(); luon co gia tri kieu string;
Console.WriteLine($"Welcome {fullName}-{addresss}");
//tinh tong 2 so x va y nhap tu ban phim
Console.Write("nhap x: ");
string soX= Console.ReadLine();
Console.Write("nhap y: ");
string soY= Console.ReadLine();
Console.WriteLine("ket qua : "+soX+soY);//5+5=55;
Console.WriteLine("ket qa :"+(int.Parse(soX)+int.Parse(soY)));
