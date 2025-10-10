// Bài 6: Tính tiền điện cho hộ gia đình
// •	Tình huống: Xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình.
// •	Yêu cầu (Tính tiền điện phải trả theo biểu giá đơn giản hóa, dựa trên mức tiêu thụ kWh): 
// o	Mức tiêu thụ Dưới 100 kWh: Đơn giá 1.500 VND/kWh.
// o	Mức tiêu thụ Từ 100 đến 200 kWh: Đơn giá 2.000 VND/kWh.
// o	Mức tiêu thụ Trên 200 kWh: Đơn giá 2.500 VND/kWh.

// INPUT
Console.Write($@"Nhập số điện đã tiêu thụ (Kwh): ");
double soKwh = double.Parse(Console.ReadLine());
double tienDien = 0;

// PROCESS
if (soKwh < 100)
    tienDien = soKwh * 1500;
else if (soKwh <= 200)
    tienDien = soKwh * 2000;
else
    tienDien = soKwh * 2500;

// OUTPUT
Console.WriteLine($@"Tiền điện: {tienDien:0,0} VND");