Tính số ngày trong tuần và số ngày lẻ
Yêu cầu người dùng nhập số ngày và tính toán bao nhiêu tuần và bao nhiêu ngày lẻ còn lại. Ví dụ, nếu người dùng nhập vào 10 ngày, kết quả sẽ là 1 tuần và 3 ngày

// input: số ngày
Console.Write($@"Số ngày cần tính: ");
int soNgay = Convert.ToInt32(Console.ReadLine());

// process: số tuần = số ngày / 7; số ngày lẻ = số ngày % 7
int soTuan = soNgay / 7;
int soNgayLe = soNgay % 7;

// output: số tuần, số ngày lẻ
Console.WriteLine($@"{soNgay} ngày, thì bằng: {soTuan} tuần, {soNgayLe} ngày.
");
