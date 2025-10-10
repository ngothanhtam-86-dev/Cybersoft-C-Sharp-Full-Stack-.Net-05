// Bài 2: Tính thuế thu nhập cho người đi làm
// •	Tình huống: Xây dựng một phần mềm nhỏ hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân cho nhân viên mỗi tháng.
// •	Yêu cầu (Tính thuế phải nộp dựa trên số tiền thu nhập hàng tháng): 
// o	Nếu thu nhập ≤ 5 triệu đồng → Miễn thuế.
// o	Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → Thuế 10%.
// o	Nếu thu nhập > 10 triệu đồng → Thuế 20%.

// INPUT
Console.Write($@"Nhập số tiền thu nhập hàng tháng: ");
double thuNhap = double.Parse(Console.ReadLine());
double thue = 0;

// PROCESS
if (thuNhap <= 5000000)
    thue = 0;
else if (thuNhap <= 10000000)
    thue = thuNhap * 0.1;
else
    thue = thuNhap * 0.2;

// OUTPUT
if (thue == 0)
    Console.WriteLine($@"Bạn được miễn thuế thu nhập");
else
    Console.WriteLine($@"Thuế phải nộp: {thue:0,0} VND");