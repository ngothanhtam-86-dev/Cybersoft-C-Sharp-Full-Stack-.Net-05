// See https://aka.ms/new-console-template for more information
// Viết chương trình cho phép người dùng nhập vào độ C
// in ra màng hình độ F tương úng
// input: doC
Console.Write($@"Nhập vào độ C: ");
double doC = Convert.ToDouble(Console.ReadLine());
// process: doF = doC * 9 /5 + 32 
double doF = doC * 9 / 5 + 32;
// output: doF
Console.WriteLine($@"Độ C: {doC} chuyển qua độ F là {doF}");

