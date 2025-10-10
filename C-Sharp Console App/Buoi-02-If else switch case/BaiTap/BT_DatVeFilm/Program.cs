// Bài 7: Hệ thống đặt vé rạp chiếu phim
// •	Tình huống: Phát triển một ứng dụng đặt vé xem phim online.
// •	Yêu cầu: Khi người dùng chọn hạng vé (Standard, Premium, VIP), hệ thống sẽ hiển thị thông tin về tiện ích kèm theo vé.
// •	Tiện ích kèm theo: 
// o	Standard: Ghế ngồi thường, không có đồ uống.
// o	Premium: Ghế ngồi thoải mái, có đồ uống miễn phí.
// o	VIP: Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí.

// INPUT

Console.Write($@"Có các loại vé :
1. Standard
2. Premium
3. VIP
Bạn chọn loại nào (1-3): ");
int loaiVe = int.Parse(Console.ReadLine());

// PROCESS, OUTPUT - Dùng SWITCH CASE
switch (loaiVe)
{
    case 1:
        Console.WriteLine($@"Standard: Ghế ngồi thường, không có đồ uống.");
        break;
    case 2:
        Console.WriteLine($@"Premium: Ghế ngồi thoải mái, có đồ uống miễn phí.");
        break;
    case 3:
        Console.WriteLine($@"VIP: Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí.");
        break;
    default:
        Console.WriteLine($@"Loại vé không hợp lệ");
        break;
}
