// Bài 10: Xác định tiện ích theo loại vé máy bay
// •	Tình huống: Xây dựng một hệ thống đặt vé máy bay online.
// •	Yêu cầu: Khi hành khách chọn loại vé (Economy, Business hoặc First Class), hệ thống cần hiển thị tiện ích tương ứng.
// •	Tiện ích đi kèm theo Loại vé: 
// o	Economy: Ghế thường.
// o	Business: Ghế rộng.
// o	First Class: Ghế sang trọng.

Console.Write($@"Có các loại vé máy bay :
1. Economy
2. Business
3. First Class
Bạn chọn loại nào (1-3): ");
int loaiVe = int.Parse(Console.ReadLine());

// PROCESS, OUTPUT - Dùng SWITCH CASE
switch (loaiVe)
{
    case 1:
        Console.WriteLine($@"Economy: Ghế thường");
        break;
    case 2:
        Console.WriteLine($@"Business: Ghế rộng");
        break;
    case 3:
        Console.WriteLine($@"First Class: Ghế sang trọng");
        break;
    default:
        Console.WriteLine($@"Loại vé không hợp lệ");
        break;
}

