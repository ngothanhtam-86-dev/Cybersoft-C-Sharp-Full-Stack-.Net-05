// Bài tập tính chỉ số BMI từ chiều cao và cân nặng
// input: chiều cao, cân nặng
// process: BMI = cân nặng: (chiều cao * chiều cao)
// output: BMI
using System.Net;
using System.Runtime.Intrinsics.Arm;

// input
Console.Write($@"Hãy nhập chiều cao: ");
double chieuCao = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Hãy nhập chiều cao: ");
double canNang = Convert.ToDouble(Console.ReadLine());

// process
double bmi = canNang / (chieuCao * chieuCao);
Console.WriteLine($@"Bạn:
- Cao {chieuCao} 
- Nặng {canNang} cd
-> Chỉ số BMI là {bmi}");

