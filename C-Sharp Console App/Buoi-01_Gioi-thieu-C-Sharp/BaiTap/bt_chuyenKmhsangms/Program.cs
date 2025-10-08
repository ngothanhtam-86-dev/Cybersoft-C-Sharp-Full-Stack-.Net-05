// Chuyển đổi từ km/h sang m/s
// Yêu cầu người dùng nhập vào vận tốc bằng km/h và chuyển đổi nó sang m/s theo công thức: m/s = km/h ÷ 3.6. In ra kết quả sau khi chuyển đổi

// Input: vận tốc Km/h cần chuyển đổi
Console.Write($@"Nhập vận tốc (Km/h): ");
double tocKMH = Convert.ToDouble(Console.ReadLine());

// Process
double tocMS = tocKMH / 3.6;

// Output: Chuyển km/h sang m/s
Console.WriteLine($@"{tocKMH} (Km/h) = {tocMS:F2} (m/s)");