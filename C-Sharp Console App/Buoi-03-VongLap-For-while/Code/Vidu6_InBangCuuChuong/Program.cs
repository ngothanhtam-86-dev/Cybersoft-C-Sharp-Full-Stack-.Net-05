#region Ví dụ 6
/*
Bài 1: In bảng cửu chương
▪ Yêu cầu: Viết chương trình sử dụng vòng lặp for để in bảng cửu chương của một số bất kỳ (ví dụ: 5).
▪ Gợi ý: Yêu cầu người dùng nhập số nguyên n, sau đó sử dụng vòng lặp for để in bảng cửu chương của số đó từ 1 đến 10
*/

Console.Write("Nhập số nguyên n để in bảng cửu chương: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"\n--- Bảng cửu chương của {n} ---");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} x {i} = {n * i}");
}


#endregion