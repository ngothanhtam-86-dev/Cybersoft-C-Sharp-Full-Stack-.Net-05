// Cấu trúc điều kiện là gì?
// Dùng để ra quyết định trong chương trình — thực hiện các khối lệnh khác nhau tùy theo điều kiện đúng/sai.

// Cú pháp cơ bản:
// if (điều_kiện)
// {
//     // khối lệnh nếu điều kiện đúng
// }
int age = 20;
if (age >= 18)
{
    Console.WriteLine("Bạn đã đủ tuổi trưởng thành.");
}

// Lệnh if...else
// if (điều_kiện)
// {
//     // khi điều kiện đúng
// }
// else
// {
//     // khi điều kiện sai
// }
int number = 5;
if (number % 2 == 0)
{
    Console.WriteLine("Số chẵn");
}
else
{
    Console.WriteLine("Số lẻ");
}

// Lệnh if...else if...else Dùng để kiểm tra nhiều điều kiện khác nhau.
// if (điều_kiện_1)
// {
//     // khối 1
// }
// else if (điều_kiện_2)
// {
//     // khối 2
// }
// else
// {
//     // mặc định nếu tất cả đều sai
// }

int score = 85;
if (score >= 90)
    Console.WriteLine("Xuất sắc");
else if (score >= 75)
    Console.WriteLine("Khá");
else if (score >= 50)
    Console.WriteLine("Trung bình");
else
    Console.WriteLine("Yếu");

// Lệnh switch...case Dùng để so sánh giá trị của một biến với nhiều trường hợp cố định.
// switch (biến)
// {
//     case giá_trị_1:
//         // khối lệnh
//         break;
//     case giá_trị_2:
//         // khối lệnh
//         break;
//     default:
//         // khi không trùng case nào
//         break;
// }
int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Thứ Hai");
        break;
    case 2:
        Console.WriteLine("Thứ Ba");
        break;
    case 3:
        Console.WriteLine("Thứ Tư");
        break;
    default:
        Console.WriteLine("Không hợp lệ");
        break;
}

// Cú pháp cũ (switch-case) khá dài dòn. Với switch expression, bạn có thể viết ngắn gọn hơn nhiều:
// string result = option switch
// {
//     1 => "Tính tổng",
//     2 => "Tính hiệu",
//     _ => "Không hợp lệ"
// };
// x switch { ... } là biểu thức.
// Mỗi nhánh có dạng giá_trị => kết_quả.
// Dấu gạch dưới _ là mặc định (default) — tương đương với default: trong switch-case.
// Switch expression trả về giá trị, nên bạn có thể gán trực tiếp vào biến.
// Ví dụ 1: Chuyển số ngày trong tuần thành tên tiếng Việt
Console.Write("Nhập ngày (1–7): ");
int ngay = Convert.ToInt32(Console.ReadLine());
string dayName = ngay switch
{
    1 => "Thứ Hai",
    2 => "Thứ Ba",
    3 => "Thứ Tư",
    4 => "Thứ Năm",
    5 => "Thứ Sáu",
    6 => "Thứ Bảy",
    7 => "Chủ Nhật",
    _ => "Không hợp lệ"
};
Console.WriteLine($"Hôm nay là: {dayName}");

// Ví dụ 2: Xếp loại học sinh bằng switch expression
Console.Write("Nhập điểm trung bình: ");
double diem = Convert.ToDouble(Console.ReadLine());

string grade = diem switch
{
    >= 8.0 => "Giỏi",
    >= 6.5 => "Khá",
    >= 5.0 => "Trung bình",
    _ => "Yếu"};

Console.WriteLine($"Xếp loại: {grade}");

// Ví dụ 3: Kiểm tra lựa chọn menu
Console.Write("Chọn chức năng (1 - 3): ");
int option = Convert.ToInt32(Console.ReadLine());
string action = option switch
{
    1 => "Thêm mới dữ liệu",
    2 => "Cập nhật dữ liệu",
    3 => "Xóa dữ liệu",
    _ => "Lựa chọn không hợp lệ"
};

Console.WriteLine($"👉 {action}");

// Mở rộng — switch expression kết hợp với tuple
// Ví dụ: Tính kết quả dựa trên hai điều kiện cùng lúc:
(int x, int y) point = (3, 5);

string position = point switch
{
    (0, 0) => "Gốc tọa độ",
    (_, 0) => "Trên trục X",
    (0, _) => "Trên trục Y",
    _ => "Trong mặt phẳng"
};
Console.WriteLine(position);


// Biểu thức ba ngôi (ternary operator) là toán tử điều kiện rút gọn trong C#.
// Biểu thức ba ngôi là một cách viết gọn của câu lệnh if...else.
// Cú pháp: condition ? expression1 : expression2;
// Nếu condition đúng (true), expression1 sẽ được thực thi; nếu không, expression2 sẽ được thực thi.
// Ví dụ 1: Kiểm tra số chẵn/lẻ
int n = 5;
string result = (n % 2 == 0) ? "Số chẵn" : "Số lẻ";
Console.WriteLine(result);
// Biểu thức ba ngôi lồng nhau
// Khi cần kiểm tra nhiều điều kiện, bạn có thể lồng nhiều dấu ? : lại (nhưng nên dùng cẩn thận để tránh rối mắt).
int diemNew = 75;
string rank = (diemNew >= 90) ? "Xuất sắc"
            : (diemNew >= 75) ? "Khá"
            : (diemNew >= 50) ? "Trung bình"
            : "Yếu";

Console.WriteLine($"Xếp loại: {rank}");

// Dùng với kiểu dữ liệu khác
// Kiểm tra biến boolean
bool isOnline = true;
string status = isOnline ? "Đang hoạt động" : "Ngoại tuyến";
Console.WriteLine(status);

// Dùng để gán giá trị số
int a = 10, b = 20;
int max = (a > b) ? a : b;
Console.WriteLine($"Số lớn hơn là: {max}");

// Toán tử Null-coalescing (??) — giúp xử lý giá trị null một cách an toàn, ngắn gọn và dễ đọc.
// Trong C#, khi làm việc với biến có thể null (nullable type hoặc chuỗi), ta thường muốn dùng giá trị mặc định nếu biến đó null.
// Thay vì viết dài dòng:
string ten;

if (ten != null)
    Console.WriteLine(ten);
else
    Console.WriteLine("Không có tên");
// Ta có thể viết ngắn gọn bằng:
Console.WriteLine(ten ?? "Không có tên");


// Toán tử ??= là một phiên bản rút gọn của việc gán giá trị mặc định khi biến đang là null.
// Cú pháp: x ??= y;
// Ý nghĩa:
// Nếu x đang khác null, giữ nguyên giá trị.
// Nếu x đang là null, thì gán giá trị y cho x.
// Ví dụ 1: Kiểm tra và gán giá trị mặc định
string nguoiDung = null;
nguoiDung ??= "Người dùng mặc định";
Console.WriteLine(nguoiDung);
// Ban đầu nguoiDung = null -> Câu lệnh nguoiDung ??= "Người dùng mặc định" sẽ gán chuỗi này cho nguoiDung
// Nếu nguoiDung đã có giá trị trước đó, nó sẽ không bị thay đổi.


// Luyện tập 1:
// Hãy viết một chương trình C# cho phép người dùng nhập vào một số nguyên bất kỳ. Chương trình sẽ kiểm tra và in ra kết quả:
// - "Đây là số chẵn" nếu số chia hết cho 2.
// - "Đây là số lẻ" nếu không chia hết cho 2.
// Input: số nguyên bất kỳ
Console.Write($@"Nhập vào số nguyên bất kỳ: ");
int soNguyen = int.Parse(Console.ReadLine());
// Process: thực hiện phép toán lấy dư cho 2
int check = soNguyen % 2;
// Ouput: số chẵn (dư 0), số lẻ (dư 1)
if (check == 0)
{
    Console.WriteLine($@"{soNguyen} là số chẵn");
}
else
{
    Console.WriteLine($@"{soNguyen} là số lẻ");
}

// Luyện tập 2
// Viết chương trình C# nhận vào mã thời tiết (số nguyên từ bàn phím), sau đó in ra gợi ý trang phục phù hợp.
// 1: Nắng
// 2: Mưa
// 3: Lạnh
// 4: Tuyết
// Các giá trị khác: Không xác định

// Input: số nguyên (1,2,3,4,bất kỳ)
Console.Write($@"Nhập vào số nguyên bất kỳ: ");
int maThoiTiet = int.Parse(Console.ReadLine());
// Ouput: thời tiết
if (maThoiTiet == 1)
{
    Console.WriteLine($@"Trời đang nắng");
}
else
{
    if (maThoiTiet == 2)
    {
        Console.WriteLine($@"Trời đang mưa");
    }
    else
    {
        if (maThoiTiet == 3)
        {
            Console.WriteLine($@"Trời đang lạnh");
        }
        else
        {
            if (maThoiTiet == 4)
            {
                Console.WriteLine($@"Trời đang có tuyết");
            }
            else
            {
                Console.WriteLine($@"Thời tiết không xác định");
            }
        }
    }
}

// Luyện tập 3: Bạn hãy viết chương trình C# cho phép người dùng nhập vào:
// Lương cơ bản theo giờ (kiểu double)
// Số giờ làm việc trong tuần (kiểu double)
// Sau đó, chương trình sẽ tính và hiển thị ra lương thực tế của nhân viên.
// Yêu cầu: Một công ty trả lương cho nhân viên theo quy định sau:
// Lương cơ bản được tính theo giờ làm việc.
// Nếu nhân viên làm trên 40 giờ trong tuần, phần vượt quá 40 giờ sẽ được tính là tăng ca, với mức lương gấp 1.5 lần lương cơ bản.

// Input: lương cơ bản và số giờ làm việc
Console.Write($@"Lương cơ bản (giờ): ");
double luongCB = Convert.ToDouble(Console.ReadLine());
Console.Write("Số giờ làm việc: ");
double soGioLam = Convert.ToDouble(Console.ReadLine());
// Process: tính lương
double luong = 0;
if (soGioLam > 40)
{
    luong = luongCB * 40 + luongCB * (soGioLam - 40) * 1.5;

}
else
{
    luong = luongCB * soGioLam;
}
// Ouput lương
Console.WriteLine($@"Bảng lương:
- Lương cơ bản (giờ): {luongCB}
- Số giờ làm: {soGioLam}
- Lương thực lĩnh: {luong:N0}");

// Luyện tập 4: Viết chương trình C# tính điểm trung bình 03 môn Toán, Lý, Hóa và dựa vào đó để đánh giá kết quả học tập:
// Giỏi >= 8.0
// Khá: >=6.5 < 8.0
// Trung binh: >=5.0 < 6.5
// Yếu: < 5.0
// Yêu cầu:
// Nhập vào 03 điểm toán lý Hóa
// Người dùng phải nhập vào trong khoảng hợp lệ từ 0 đến 10 -> chưa phù hợp vì cần sử dụng vòng lặp thì mới tối ưu -> bỏ không thực hiện

// input
double diemToan, diemLy, diemHoa;
Console.Write($@"Nhập điểm Toán: ");
diemToan = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập điểm Lý: ");
diemLy = Convert.ToDouble(Console.ReadLine());
Console.Write($@"Nhập điểm Hóa: ");
diemHoa = Convert.ToDouble(Console.ReadLine());
// process
double diemTrungBinh = (diemHoa + diemLy + diemHoa) / 3;
// output
switch (diemTrungBinh)
{
    case >= 8:
        Console.WriteLine($@"Điểm trung bình là {diemTrungBinh} -> bạn là học sinh giỏi");
        break;
    case >= 6.5 and < 8:
        Console.WriteLine($@"Điểm trung bình là {diemTrungBinh} -> bạn là học sinh khá");
        break;
    case >= 5 and < 6.5:
        Console.WriteLine($@"Điểm trung bình là {diemTrungBinh} -> bạn là học sinh trung bình");
        break;
    case < 5:
        Console.WriteLine($@"Điểm trung bình là {diemTrungBinh} -> bạn là học sinh yếu");
        break;
}

// Luyện tập 5: Bạn đang xây dựng một mini game tính nhanh dành cho trẻ em. 
// Luật chơi yêu cầu người chơi nhập vào một số có đúng 3 chữ số (ví dụ: 123, 456, 987...). 
// Hệ thống sẽ tự động táchvà tính tổng từng chữ số trong số đó.
// Yêu cầu:
// 1.Nhập vào một số nguyên từ bàn phím.
// 2.Nếu số không có đúng 3 chữ số (tức < 100 hoặc > 999), in ra: "Số không hợp lệ. Vui lòng nhập số có đúng 3 chữ số." -> sử dụng vòng lặp thì hợp lý hơn -> không thực hiện
// 3.Nếu hợp lệ, tách từng chữ số và tính tổng, sau đó in kết quả theo định dạng: Kết quả: 9 + 8 + 7 = 24

// Luyện tập 6: Bạn đang lập trình một tính năng nhỏ cho một ứng dụng quản lý công việc cá nhân. 
// Khi người dùng nhập vào một số từ 1 đến 7, hệ thống sẽ hiển thị tên ngày trong tuần tương ứng để phục vụ sắp xếp lịch.
// Hãy viết chương trình C# cho phép người dùng:
// 1.Nhập vào một số nguyên từ 1 đến 7.
// 2.In ra tên ngày trong tuần tương ứng
// 3.Nếu người dùng nhập số ngoài phạm vi 1–7, hiển thị thông báo: "Giá trị không hợp lệ. Vui lòng nhập số từ 1 đến 7".

// Luyện tập 7: Bài tập: Xây dựng chương trình quản lý điểm học sinh
// Mô tả: Bạn cần xây dựng một chương trình nhận điểm số của học sinh và in ra xếp loại tương ứng dựa trên thang điểm chữ. Cụ thể: Điểm A: Từ 90 đến 100
// Điểm B: Từ 80 đến 89
// Điểm C: Từ 70 đến 79
// Điểm D: Từ 60 đến 69
// Điểm F: Dưới 60
// Yêu cầu:
// 1.Chương trình sẽ nhận vào một điểm số từ 0 đến 100.
// 2.Sử dụng switch...case để xác định xếp loại (A, B, C, D, F) dựa trên điểm số.
// 3.In ra kết quả xếp loại của học sinh.

