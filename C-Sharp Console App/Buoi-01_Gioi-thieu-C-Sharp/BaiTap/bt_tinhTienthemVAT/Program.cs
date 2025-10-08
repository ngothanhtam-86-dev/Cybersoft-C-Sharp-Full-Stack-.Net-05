// Tính tổng số tiền sau khi cộng thêm thuế VAT
// Yêu cầu người dùng nhập vào số tiền gốc và tỷ lệ thuế VAT (ví dụ: 10%). Tính và in ra tổng số tiền sau khi đã cộng thêm thuế.

// Input: tien goc và VAT
Console.Write($@"Nhập giá trị đơn hàng (VND): ");
double giaDonHang = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập giá trị VAT (%): ");
double VAT = Convert.ToDouble(Console.ReadLine());

// Process: tính VAT và tiền hàng
double tienVAT = giaDonHang * VAT / 100;
double tongGiaTri = giaDonHang + tienVAT;

// Output: tổng giá trị đơn hàng
Console.WriteLine($@"Đơn hàng giá: {giaDonHang:N0}
Thuế VAT: {tienVAT:N0}
Phải thanh toán: {tongGiaTri:N0}");
