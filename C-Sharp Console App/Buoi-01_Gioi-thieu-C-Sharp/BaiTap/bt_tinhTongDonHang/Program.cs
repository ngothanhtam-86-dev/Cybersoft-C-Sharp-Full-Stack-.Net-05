// Tính tổng giá trị đơn hàng sau khi áp dụng giảm giá
// Yêu cầu người dùng nhập vào giá trị của một đơn hàng và phần trăm giảm giá. Tính toán số tiền giảm giá và tổng số tiền phải thanh toán sau khi áp dụng giảm giá.

// Input: giá trị đơn hàng và % giảm giá
Console.Write($@"Nhập giá trị đơn hàng (VND): ");
double giaDonHang = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập phần trăm giảm giá (%): ");
double giaGiam = Convert.ToDouble(Console.ReadLine());

// Process
double soTienGiam = giaDonHang * giaGiam / 100;
double tongGiaTri = giaDonHang - soTienGiam;

// Output: tổng giá trị đơn hàng
Console.WriteLine($@"Đơn hàng giá: {giaDonHang:N0}
Được giảm giá: {soTienGiam:N0}
Phải thanh toán: {tongGiaTri:N0}");
