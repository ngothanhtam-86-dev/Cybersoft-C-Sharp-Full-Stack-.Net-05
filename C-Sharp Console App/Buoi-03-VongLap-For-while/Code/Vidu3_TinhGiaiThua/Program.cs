#region Ví dụ 3
/*
BÀI TẬP VÒNG LẶP 3: Tính Giai Thừa
◦ Mô tả: Giai thừa của một số là tích các số từ 1 đến số đó. Trường hợp đặc biệt là 0! = 1.
◦ Nhập (Input): Số nguyên dương "n".
◦ Xuất (Output): Giai thừa số đó, tính bằng công thức: $\mathbf{n! = 1 \times 2 \times 3 \times \ldots \times n}$.
◦ Ví dụ: Nếu Input $n = 5$, Output $5! = 120$.
*/
Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
long giaiThua = 1;
int i = 1;

// Dùng For
for (i = 1; i <= n; i++)
{
    giaiThua *= i;
}

// Dùng While
// while (i <= n)
// {
//     giaiThua *= i;
//     i++;
// }

// Dùng do..while
// do
// {
//     giaiThua *= i;
//     i++;
// }
// while (i <= n);


Console.WriteLine($"{n}! = {giaiThua}");


#endregion