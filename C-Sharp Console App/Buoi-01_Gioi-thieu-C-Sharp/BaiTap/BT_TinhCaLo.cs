// Tính lượng calo tiêu thụ
// Yêu cầu người dùng nhập vào số phút đã tập thể dục và loại hình tập thể dục (chọn từ các giá trị đã định trước như chạy, đạp xe, bơi lội). 
// Tính và in ra lượng calo tiêu thụ dựa trên số phút và loại hình tập thể dục (sử dụng hệ số calo tiêu thụ giả định cho mỗi loại hình).

// input: số phút tập thể dụng, loại hình tập thể dục (quy ước:  chạy, đạp xe, bơi lội), hệ số calo giả định
// Hệ số calo giả định
const double _calo_CHAY = 10;    // chạy bộ
const double _calo_DAPXE = 9.5;     // đạp xe
const double _calo_BOILOI = 8.5;    // bơi lội
// Nhập loại hình tập thể dục:
Console.Write($@"Bạn đang tập thể dục (1: Chạy bộ; 2: Đạp xe; 3: Bơi lội): ");
int chon = Convert.ToInt16(Console.ReadLine());

// Nhập số phút tập thể dục
Console.Write($@"Thời gian tập thể dục: ");
int soPhut = Convert.ToInt16(Console.ReadLine());


double calo = 0;
if (chon == 1)
{
    // Process: tính calo
    calo = soPhut * _calo_CHAY;

    // output: số calo
    Console.WriteLine($@"Bạn đã tập thể dục môn Chạy bộ, trong {soPhut} phút, tiêu hao {calo} calo, mức bình quân tiêu thu calo {_calo_CHAY} (calo/phút)");
}
else
{
    if (chon == 2)
    {
        // Process: tính calo
        calo = soPhut * _calo_DAPXE;

        // output: số calo
        Console.WriteLine($@"Bạn đã tập thể dục môn Đạp xe, trong {soPhut} phút, tiêu hao {calo} calo, mức bình quân tiêu thu calo {_calo_DAPXE} (calo/phút)");
    }
    else
    {
        // Process: tính calo
        calo = soPhut * _calo_BOILOI;

        // output: số calo
        Console.WriteLine($@"Bạn đã tập thể dục môn Bơi lội, trong {soPhut} phút, tiêu hao {calo} calo, mức bình quân tiêu thu calo {_calo_BOILOI} (calo/phút)");
    }
}




