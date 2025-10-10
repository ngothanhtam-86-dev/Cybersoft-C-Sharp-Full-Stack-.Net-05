// Bài 4: Kiểm tra độ tuổi tham gia nghĩa vụ quân sự
// •	Tình huống: Xây dựng chương trình hỗ trợ cán bộ xã trong việc rà soát danh sách thanh niên đủ điều kiện tham gia nghĩa vụ quân sự.
// •	Yêu cầu (Phân loại kết quả dựa trên tuổi công dân nhập vào): 
// o	Nếu dưới 18 tuổi → Chưa đủ tuổi tham gia NVQS.
// o	Nếu từ 18 đến 27 tuổi → Đủ tuổi tham gia NVQS.
// o	Nếu trên 27 tuổi → Quá tuổi tham gia NVQS.

// INPUT
Console.Write($@"Nhập tuổi cần kiểm tra: ");
int tuoi = int.Parse(Console.ReadLine());

// PROCESS & OUTPUT
if (tuoi < 18)
    Console.WriteLine($@"Chưa đủ tuổi tham gia NVQS");
else if (tuoi <= 27)
    Console.WriteLine($@"Đủ tuổi tham gia NVQS");
else
    Console.WriteLine($@"Quá tuổi tham gia NVQS");
