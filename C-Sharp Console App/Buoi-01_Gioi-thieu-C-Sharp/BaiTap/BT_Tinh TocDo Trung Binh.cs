// Tính tốc độ trung bình
// Yêu cầu người dùng nhập vào quãng đường đã đi (km) và thời gian đã đi (giờ). Tính và in ra tốc độ trung bình (km/h)

// Input: quãng đường, thời gian
Console.Write($@"Quãng đường đã đi (Km): ");
double quangDuong = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập thời gian đã đi (giờ): ");
double gio = Convert.ToDouble(Console.ReadLine());

// Process tính tốc độ trung bình
double tinhTocDoTrungBinh = quangDuong / gio;
// Output: tốc độ trung bình
Console.WriteLine($@"Đã đi {quangDuong} km, trong {gio} giờ, tốc độ trung bình đi là {tinhTocDoTrungBinh} (Km/h) ");