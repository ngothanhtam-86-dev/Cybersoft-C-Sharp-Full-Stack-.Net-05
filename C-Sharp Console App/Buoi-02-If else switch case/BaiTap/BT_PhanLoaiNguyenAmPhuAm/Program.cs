// Bài 9: Phân loại chữ cái: nguyên âm hay phụ âm
// •	Tình huống: Phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em.
// •	Yêu cầu: Khi người dùng nhập vào một ký tự, chương trình sẽ tự động phân loại: 
// o	Nếu ký tự là nguyên âm (a, e, i, o, u – không phân biệt hoa/thường) → in ra “Là nguyên âm”.
// o	Ngược lại → in “Là phụ âm”.

// INPUT
Console.Write($@"Nhập một ký tự: ");
string kyTu = Console.ReadLine();
string ketQua = "";

// PROCESS với IF-ELSE
string kyTuThuong = kyTu.ToLower();
if (kyTuThuong == "a" || kyTuThuong == "e" || kyTuThuong == "i" ||
    kyTuThuong == "o" || kyTuThuong == "u")
{
    ketQua = "Là nguyên âm";
}
else
{
    ketQua = "Là phụ âm";
}

// OUTPUT
Console.WriteLine($@"{kyTu} là {ketQua}");
