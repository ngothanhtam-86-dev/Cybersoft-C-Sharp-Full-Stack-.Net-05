// Tính số dư sau khi rút tiền từ tài khoản
// Yêu cầu người dùng nhập vào số dư tài khoản hiện tại và số tiền muốn rút. Tính và in ra số dư còn lại sau khi rút tiền (lưu ý không kiểm tra số dư âm ở bài này).

// Input: số dư hiện tại, số tiền rút
Console.Write($@"Số dư tài khoản hiện tại: ");
double tienDuHienTai = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập số tiền cần rút: ");
double tienRut = Convert.ToDouble(Console.ReadLine());

// Process: tính số dư còn lại
double tienConLai = tienDuHienTai - tienRut;

// Output: số dư sau khi rút
Console.WriteLine($@"Tài khoản có: {tienDuHienTai:N0}, đã rút: {tienRut:N0}, còn lại: {tienConLai:N0}");