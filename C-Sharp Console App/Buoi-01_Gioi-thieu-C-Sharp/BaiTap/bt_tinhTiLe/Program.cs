// Tính tỷ lệ phần trăm
// Yêu cầu người dùng nhập vào một số và một tổng số, sau đó tính và in ra tỷ lệ phần trăm của số đó trong tổng số

// Input: số con và số tổng
Console.Write($@"Nhập số con ");
double soCon = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập số tổng ");
double soTong = Convert.ToDouble(Console.ReadLine());

// Process
double tinhPhanTram = soCon / soTong * 100;

// Output: tính tỉ lệ % số con so với số tổng
Console.WriteLine($@"{soCon:N0} so với {soTong:N0} chiếm {tinhPhanTram} (%)");
