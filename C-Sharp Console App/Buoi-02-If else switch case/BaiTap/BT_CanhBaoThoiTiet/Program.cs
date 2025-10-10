// Bài 1: Cảnh báo thời tiết
// •	Tình huống: Xây dựng một ứng dụng ghi lại nhiệt độ trong ngày để hỗ trợ cảnh báo thời tiết.
// •	Yêu cầu (Phản hồi khi người dùng nhập nhiệt độ theo °C): 
// o	Nếu nhiệt độ lớn hơn 0 → hiển thị “🌤 Trời ấm”.
// o	Nếu nhiệt độ nhỏ hơn 0 → hiển thị “❄ Trời lạnh, có thể có băng giá!”.
// o	Nếu nhiệt độ bằng 0 → hiển thị “🌫 Trời rất lạnh, đúng 0°C!”.

// INPUT: nhiệt độ
Console.Write($@"Hãy nhập nhiệt độ: ");
double nhietDo = double.Parse(Console.ReadLine());

// PROCESS & OUTPUT
if (nhietDo > 0)
    Console.WriteLine($@"Trời ấm");
else if (nhietDo < 0)
    Console.WriteLine($@"Trời lạnh, có thể có băng giá!");
else
    Console.WriteLine($@"Trời rất lạnh, đúng 0°C!");