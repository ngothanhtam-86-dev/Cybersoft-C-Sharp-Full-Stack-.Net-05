#region Ví dụ 7
/*
Bài: Tìm số nguyên tố trong khoảng
▪ Yêu cầu: Viết chương trình sử dụng vòng lặp for để tìm tất cả các số nguyên tố trong một khoảng từ 1 đến số người dùng nhập vào (ví dụ: 50)
▪ Gợi ý: Sử dụng một vòng lặp for để lặp qua các số từ 2 đến n. Trong mỗi lần lặp, sử dụng một vòng lặp for khác để kiểm tra tính nguyên tố của số đó.
*/

Console.Write("Nhập số nguyên n: ");
int n;

// Ứng dụng while Kiểm tra đầu vào hợp lệ
while (!int.TryParse(Console.ReadLine(), out n) || n < 2) // -> ép thất bại (tryParse) = false -> !false = true -> vòng lặp thực hiện bắt nhập lại; dk 2: số nguyên luôn lớp hơn 1 (<2)
{
    Console.Write("Vui lòng nhập số nguyên lớn hơn hoặc bằng 2: ");
}

Console.Write($"\nCác số nguyên tố trong khoảng từ 1 đến {n} là: ");

// Vòng lặp duyệt qua từng số từ 2 đến n
for (int i = 2; i <= n; i++)
{
    bool laNguyenTo = true;

    // Kiểm tra i có phải là số nguyên tố
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            laNguyenTo = false;
            break; // không cần kiểm tra tiếp
        }
    }

    if (laNguyenTo)
    {
        Console.Write(i + " ");
    }
}

#endregion