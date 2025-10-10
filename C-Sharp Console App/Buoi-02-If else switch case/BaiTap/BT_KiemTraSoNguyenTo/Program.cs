// Bài 5: Lọc số đặc biệt cho hệ thống bảo mật (Kiểm tra số nguyên tố)
// •	Tình huống: Phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt” – tức là số nguyên tố.
// •	Yêu cầu: Viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập vào có phải là số nguyên tố hay không.

// INPUT
Console.Write($@"Nhập vào số cần kiểm tra: ");
int n = int.Parse(Console.ReadLine());
bool laSoNguyenTo = true;

// PROCESS -> ứng dụng vòng lặp để kiểm tra tốt nhất -> nếu chỉ dung if else sẽ không đảm bảo chính xác
if (n < 2)
    laSoNguyenTo = false;
else
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            laSoNguyenTo = false;
            break;
        }
    }
}

// OUTPUT
if (laSoNguyenTo)
    Console.WriteLine($@"{n} là số nguyên tố");
else
    Console.WriteLine($@"{n} không phải là số nguyên tố");