// Chuyển đổi đơn vị tiền tệ
// Yêu cầu người dùng nhập vào một số tiền bằng USD và tỷ giá chuyển đổi từ USD sang VND. Tính và in ra số tiền tương ứng bằng VND

// Input: số tiền USD cần chuyển, tỉ giá USD -> VND
Console.Write($@"Số tiền USD cần đổi sang VND (USD): ");
double soTien = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Tỉ giá: ");
double tiGia = Convert.ToDouble(Console.ReadLine());

// Process: tính VND
double soTienDoi = soTien * tiGia;

// Output: số tiền đã chuyển
Console.WriteLine($@"{soTien:N0} USD = {soTienDoi:N0} VND");