#region Ví dụ 1
/*
    Viết chương trình cho phép người dùng nhập vào số n (số năm làm việc)
    Yêu cầu:
    Tính từ tổng từ 1 đến n
    Láy ví dụ n =5
    tổng n = 1 +2 + 3 + 4 +5;
    Lưu ý: không dùng công thức không sử dụng vòng lặp
    tong = (n x (n+1))/2;    
*/

// Nhập số năm làm việc
Console.Write("Nhập số năm làm việc (n): ");
int n = int.Parse(Console.ReadLine());

int tong = 0; // khởi tạo tổng ban đầu = 0

// Dùng vòng lặp for để tính tổng
int iFor; // khởi tạo biến đếm
for (iFor = 1; iFor <= n; iFor++)
{
    tong += iFor; // cộng dồn giá trị i vào biến tong
}

// --- Vòng lặp while để tính tổng ---
tong = 0; // set tổng lại = 0
int iWhile = 1; // khởi tạo biến đếm
while (iWhile <= n)
{
    tong += iWhile;
    iWhile++;
}

// --- Vòng lặp do .. while để tính tổng ---

tong = 0; // set tổng lại = 0
int iDoWhile = 1; // khởi tạo biến đếm
do
{
    tong += iDoWhile;
    iDoWhile++;
} while (iDoWhile <= n);


// Xuất kết quả
Console.WriteLine($"Tổng từ 1 đến {n} là: {tong}");

#endregion