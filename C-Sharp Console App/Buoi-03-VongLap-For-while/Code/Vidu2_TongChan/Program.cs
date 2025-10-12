#region Ví dụ 2
/*
BÀI TẬP VÒNG LẶP 2: Tính Tổng Dãy Số Chẵn
    ◦ Nhập (Input): Số nguyên dương "n".
    ◦ Xuất (Output): Tổng "S" của dãy số từ 2 đến "2n".
    ◦ Ví dụ: Nếu Input $n = 5$, Output $S = 30$ (tức là $S = 2 + 4 + 6 + 8 + 10$).
*/
Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
int S = 0;
int i = 2;

// Dùng vòng lặp For
for (i = 2; i <= 2 * n; i += 2)
{
    S += i;
}

// dùng vòng lặp while
// while (i <= 2 * n)
// {
//     S += i;
//     i += 2;
// }

// dùng vòng lặp do...while
// do
// {
//     S += i;
//     i += 2;
// }
// while (i <= 2 * n);

Console.WriteLine($"Tổng dãy số chẵn từ 2 đến {2 * n} là: {S}");


#endregion