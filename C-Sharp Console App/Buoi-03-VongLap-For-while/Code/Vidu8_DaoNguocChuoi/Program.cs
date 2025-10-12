#region Ví dụ 8
/*
Bài 3: Đảo ngược chuỗi
 ▪ Yêu cầu: Viết chương trình sử dụng vòng lặp for để đảo ngược một chuỗi.
 ▪ Gợi ý: Yêu cầu người dùng nhập vào một chuỗi. Sử dụng vòng lặp for để lặp qua từng ký tự của chuỗi từ cuối đến đầu. Tạo một chuỗi mới chứa các ký tự đảo ngược và in ra kết quả. (Bài tập này là một ứng dụng của vòng lặp trong xử lý chuỗi).
*/

Console.Write("Nhập vào một chuỗi: ");
string input = Console.ReadLine();

string reversed = ""; // Chuỗi đảo ngược

// Duyệt chuỗi từ cuối về đầu
for (int i = input.Length - 1; i >= 0; i--)
{
    reversed += input[i];
}

Console.WriteLine($"\nChuỗi sau khi đảo ngược là: {reversed}");

#endregion