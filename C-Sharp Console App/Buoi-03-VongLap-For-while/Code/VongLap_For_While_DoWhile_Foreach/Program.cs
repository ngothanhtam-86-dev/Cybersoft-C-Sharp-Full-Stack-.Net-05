#region Giới thiệu về vòng lặp

// Vòng lặp (loop) cho phép chương trình lặp lại một đoạn mã nhiều lần cho đến khi điều kiện dừng được thỏa mãn.

// in 5 dòng cybersoft -> 05 lệnh Console.WriteLine("cybersoft"); -> sử dụng vòng lặp để ngắn gọn code
for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine("cybersoft");

}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ

// Vòng lặp For: Dùng khi biết trước số lần lặp.
// for (khởi_tạo; điều_kiện; bước_nhảy)
// {
//     // khối lệnh
// }
// -> khởi tạo i =1; điều kiện i<=5 để chạy 5 lần, bước nhảy là 1 đơn vị i++
// Ví dụ
for (int iFor = 0; iFor < 10; iFor++)
{
    Console.WriteLine("Giá trị i = " + iFor);
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ


// Vòng lặp while: Dùng khi chưa biết trước số lần lặp, nhưng có điều kiện dừng rõ ràng.
// while (điều_kiện)
// {
//     // khối lệnh
// }
int iWhile = 1;
while (iWhile <= 5)
{
    Console.WriteLine(iWhile);
    iWhile++;
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ

// Vòng lặp do...while: Dù điều kiện sai, vẫn thực hiện ít nhất 1 lần.
// do
// {
//     // khối lệnh
// } while (điều_kiện);
int iDoWhile = 1;
do
{
    Console.WriteLine(iDoWhile);
    iDoWhile++;
} while (iDoWhile <= 5);
Console.WriteLine();  //-> Xuống dòng để tách ví dụ

// Vòng lặp foreach: Dùng để duyệt qua mảng hoặc danh sách.
// foreach (var item in collection)
// {
//     // khối lệnh
// }
string[] fruits = { "Táo", "Cam", "Chuối" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ

// Câu lệnh điều khiển vòng lặp "break": Thoát khỏi vòng lặp ngay lập tức.
for (int iBreak = 0; iBreak < 10; iBreak++)
{
    if (iBreak == 5)
        break;
    Console.WriteLine(iBreak);
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ

// Câu lệnh điều khiển vòng lặp "continue": Bỏ qua phần còn lại của vòng lặp hiện tại.
for (int iContinue = 0; iContinue < 10; iContinue++)
{
    if (iContinue % 2 == 0)
        continue;
    Console.WriteLine(iContinue);
} //-> chỉ in ra số lẻ
Console.WriteLine();  //-> Xuống dòng để tách ví dụ

// Vòng lặp lồng nhau (Nested Loop) — nền tảng cho nhiều bài toán như in hình, ma trận, thuật toán sắp xếp, v.v.
// Vòng lặp lồng nhau nghĩa là một vòng lặp nằm bên trong vòng lặp khác.
// Cấu trúc tổng quát:
// for (int i = 1; i <= m; i++)          // vòng lặp ngoài
// {
//     for (int j = 1; j <= n; j++)      // vòng lặp trong
//     {
//         // khối lệnh bên trong
//     }
// }
// Khi vòng lặp ngoài chạy 1 lần → vòng lặp trong chạy toàn bộ n lần.

// Ví dụ đơn giản
// In ma trận 3 hàng, 5 cột
for (int iHang = 1; iHang <= 3; iHang++)       // 3 hàng
{
    for (int jCot = 1; jCot <= 5; jCot++)   // 5 cột
    {
        Console.Write(jCot + " ");
    }
    Console.WriteLine();           // xuống dòng sau mỗi hàng
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ
// Output
// 1 2 3 4 5
// 1 2 3 4 5
// 1 2 3 4 5

// In hình dạng bằng sao (*) -> Tam giác vuông
int nTamGiacVuong = 5;
for (int iTamGiacVuong = 1; iTamGiacVuong <= nTamGiacVuong; iTamGiacVuong++)
{
    for (int jTamGiacVuong = 1; jTamGiacVuong <= iTamGiacVuong; jTamGiacVuong++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ
// Output:
// *
// **
// ***
// ****
// *****

// In hình dạng bằng sao (*) -> Tam giác ngược
int nTamGiacNguoc = 5;
for (int iTamGiacNguoc = nTamGiacNguoc; iTamGiacNguoc >= 1; iTamGiacNguoc--)
{
    for (int jTamGiacNguoc = 1; jTamGiacNguoc <= iTamGiacNguoc; jTamGiacNguoc++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
Console.WriteLine();  //-> Xuống dòng để tách ví dụ
// Output:
// *****
// ****
// ***
// **
// *

#endregion

