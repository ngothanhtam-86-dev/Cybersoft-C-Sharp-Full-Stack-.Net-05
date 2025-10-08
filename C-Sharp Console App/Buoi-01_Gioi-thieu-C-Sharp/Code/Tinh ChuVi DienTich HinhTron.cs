// input: double pi = 3.14, bán kính
// process: Chu Vi = 2 * pi * bán kính; diện tích = pi* bán kính * bán kính
// output: double tinhChuVi, tinhDienTich
double _pi = Math.PI;
double r = 0;
Console.Write($@"Nhập bán kính đường tròn cần tính chu vi và diện tích: ");
r = Convert.ToDouble(Console.ReadLine());
double tinhChuVi = 2 * _pi * r;
double tinhDienTich = _pi * r * r;
Console.WriteLine($@"Đường tròn có bán kính {r} có:
Chu vi = {tinhChuVi}
Diện tích {tinhDienTich}");
