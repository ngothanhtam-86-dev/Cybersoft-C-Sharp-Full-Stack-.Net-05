// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Bài 8. Tách từ và trả về từ dài nhất có chứa số
// Đề bài: Cho một chuỗi s chứa các từ cách nhau bởi khoảng trắng, trong đó có các từ chứa cả chữ cái và chữ
// số. Viết hàm trả về từ dài nhất có chứa ít nhất một số. Nếu không có từ nào chứa số, trả về chuỗi rỗng.
// Ví dụ:
// Input: "abc123 def45 ghi6789"
// Output: "ghi6789"


Console.Write($@"Nhập vào chuỗi cần kiểm tra: ");
string input = Console.ReadLine();

string output = TimTuDaiNhatCoSo(input);

static string TimTuDaiNhatCoSo(string chuoi)
{
    string result = "";

    // Tách chuỗi thành mảng từ
    string[] mangTu = chuoi.Split(' ', StringSplitOptions.RemoveEmptyEntries);

    // Duyệt từng từ
    foreach (string tu in mangTu)
    {
        // Kiểm tra xem từ có chứa số hay không
        if (tu.Any(char.IsDigit))
        {
            // Cập nhật nếu là từ dài hơn
            if (tu.Length > result.Length)
            {
                result = tu;
            }
        }
    }

    return result;
}

Console.WriteLine($@"Từ dài nhất có chứa số: {output}");