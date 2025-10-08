// Chuyển đổi thời gian từ phút sang giờ và phút
// Yêu cầu người dùng nhập vào một số phút và chuyển đổi số phút này thành giờ và phút. Ví dụ, nếu người dùng nhập vào 130 phút, kết quả sẽ là 2 giờ và 10 phút.

// input: số phút
Console.Write($@"Nhập vào số phút cần chuyển: ");
int phut = Convert.ToInt32(Console.ReadLine());
// process
int gio = phut / 60;
int phutDu = phut % 60;
// ouput: đổi sang giờ và phút dư
Console.WriteLine($@"{phut} phút = {gio} Giờ, {phutDu} phút");