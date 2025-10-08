// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Lệnh Output: Console.WriteLine("Chuỗi");
// Console.WriteLine("Helllo Tâm!");
Console.Write("Nhập vào họ tên:");
// Lệnh Input
string name = Console.ReadLine();
Console.WriteLine($"Xin chào: {name}");

// khai báo biến: <kiểu_dữ_liệu> <tên_biến> = <giá_trị_khởi_tạo>;
int so = 10;
string name_new = "Tâm";
double pi = 3.14;
// Quy tắc đặt tên biến:
// - Bắt đầu bằng chữ cái hoặc _.
// - Không chứa khoảng trắng, không trùng từ khóa.
// - Nên dùng camelCase trong C#.

// Kiểu giá trị (Value Types) → lưu trực tiếp giá trị
// - Số nguyên: int, long, short, byte
// - Số thực: float, double, decimal
// - Ký tự: char
// - Luận lý: bool (true/false)
// - Struct, enum cũng thuộc nhóm này.
// Kiểu tham chiếu (Reference Types) → lưu địa chỉ tham chiếu
// - string (chuỗi ký tự)
// - object (kiểu cơ sở của mọi kiểu dữ liệu trong C#)
// - Mảng (int[], string[]), Class.
// Các kiểu giá trị thường sử dụng: int, double, string, bool

#region Giới thiệu về các toán tử
/*
    Các toán tử cơ bản
    +	Cộng	a + b
    -	Trừ	a - b
    *	Nhân	a * b
    /	Chia	a / b
    %	Chia lấy dư	a % b
    ++	Tăng 1	a++ hoặc ++a
    --	Giảm 1	a-- hoặc --a
*/
int a = 5;
int b = 10;
int tong = a + b;
Console.WriteLine(tong);
int hieu = a - b;
Console.WriteLine(hieu);
int tich = a * b;
Console.WriteLine(tich);
int thuong = a / b;
Console.WriteLine(thuong);
int du = a % b;
Console.WriteLine(du);

// --- gán kết hợp
int c = 15;
int d = 10;
// c = c +1
c++;
System.Console.WriteLine(c);
// ++biến: tiền tố: thực hiện phép tính rồi mới in màn hình
// biến++: hậu tố: in ra sau đó mới thực hiện phép tính
System.Console.WriteLine(d++);
System.Console.WriteLine(++d);
System.Console.WriteLine(d);

d *= 2; // d = d * 2;
System.Console.WriteLine(d);

// ---- Phép tính trên chuỗi -----
string mess = "Hello ";
string user = "Tâm";
System.Console.WriteLine(mess + user);

// ---- format string ----
int age = 18;
Console.WriteLine($@"
Helllo: {user}
Age: {age}
");

// ---- ép kiểu -----
// Tường minh
double dtb = 9.2;
int diemTrungBinh = (int)dtb;
Console.WriteLine($@"Điểm trung bình: {diemTrungBinh}");

// ngầm định
int luong = 1000;
double luongCB = luong + 1000.5;
Console.WriteLine($@"{luongCB}");

// convert: sử dụng nhiều nhất để chuyển đổi từ chuỗi sang số
string luongCoBan = "10000";
int iLuong = Convert.ToInt32(luongCoBan) * 2;
Console.WriteLine($@"Lương cơ bản: {iLuong}");

// chuyển đổi từ số về chuỗi
string sLuong = iLuong.ToString("N0"); // -> xem thêm các định dạng chuỗi
Console.WriteLine($@"{sLuong}");

// nghiên cứu thêm: typeof sizeof, default

#endregion

