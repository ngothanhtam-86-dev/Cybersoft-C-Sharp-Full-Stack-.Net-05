#region Ví dụ 4
/*
BÀI TẬP VÒNG LẶP 4: Tính Tổng Bình Phương
◦ Mô tả: Để tính bình phương của 1 số (ví dụ: $1^2$), ta có thể dùng cú pháp $1**2$.
◦ Nhập (Input): Số nguyên dương "n".
◦ Xuất (Output): Tổng bình phương của các số từ 1 đến n: $\mathbf{S = 1^2 + 2^2 + \ldots + n^2}$.
◦ Ví dụ: Nếu Input $n = 3$, Output $S = 14$ ($1^2 + 2^2 + 3^2 = 14$).
*/

Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
int S = 0;
int i = 1;

// dùng For
for (i = 1; i <= n; i++)
{
    S += i * i; // i^2
}

// dung while
// while (i <= n)
// {
//     S += i * i;
//     i++;
// }

// dùng do..while
// do
// {
//     S += i * i;
//     i++;
// } while (i <= n);

Console.WriteLine($"Tổng bình phương từ 1 đến {n} là: {S}");


#endregion