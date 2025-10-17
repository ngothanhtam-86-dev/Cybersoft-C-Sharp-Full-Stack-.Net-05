// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Bài tập 7. Loại bỏ ký tự đặc biệt
// Đề bài: Cho một chuỗi s chứa các từ và ký tự đặc biệt, hãy loại bỏ tất cả các ký tự đặc biệt và trả về chuỗi chỉ
// chứa các từ và khoảng trắng.
// Ví dụ:
// Input: "he@llo! worl#d"
// Output: "hello world"


Console.Write($@"Nhập vào chuỗi cần kiểm tra: ");
string input = Console.ReadLine();

string output = LoaiBoKiTuDB(input);

static string LoaiBoKiTuDB(string chuoi)
{
    string result="";
    foreach (char c in chuoi)
    {
        // Chỉ giữ lại chữ cái, chữ số và khoảng trắng
        if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
        {
            result +=c;
        }
    }

    return result;
}

Console.WriteLine($@"Đã loại ký tự đặt biệt: {output}");


