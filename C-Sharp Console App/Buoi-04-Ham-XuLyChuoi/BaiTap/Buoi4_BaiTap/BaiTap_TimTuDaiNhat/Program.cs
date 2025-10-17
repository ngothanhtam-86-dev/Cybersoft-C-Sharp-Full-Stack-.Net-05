// Bài 6: Hàm nhận vào một chuỗi và trả về từ dài nhất.
// Nếu có nhiều từ bằng nhau, trả về từ đầu tiên. 
// Chuỗi đầu vào.
// Từ dài nhất trong chuỗi
Console.Write($@"Nhập vào chuỗi cần kiểm tra: ");
string input = Console.ReadLine();

string output = TimTuDaiNhat(input);

Console.WriteLine($@"Từ dài nhất là: {output}");

// Hàm tìm từ dài nhất
static string TimTuDaiNhat(string chuoi)
{
    string result;
    string[] tuArray = chuoi.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    result = tuArray[0];
    foreach (string s in tuArray)
    {
        if (s.Length > result.Length)
        {
            result = s;
        }
    }
    return result;
}

