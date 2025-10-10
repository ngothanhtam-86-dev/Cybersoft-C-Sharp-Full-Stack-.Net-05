// Bài 8: Tính tiền taxi cho khách hàng
// •	Tình huống: Viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi.
// •	Yêu cầu (Biểu giá tính cước): 
// o	1 km đầu tiên: 10.000 VND.
// o	Từ km thứ 2 đến km thứ 5: 8.000 VND/km.
// o	Từ km thứ 6 trở đi: 6.000 VND/km.

// INPUT
Console.Write($@"Nhập vào số Km đã chở: ");
double soKm = double.Parse(Console.ReadLine());
double tienCuoc = 0;

// PROCESS
if (soKm <= 1)
    tienCuoc = 10000;
else if (soKm <= 5)
    tienCuoc = 10000 + (soKm - 1) * 8000;
else
    tienCuoc = 10000 + 4 * 8000 + (soKm - 5) * 6000;

// OUTPUT
Console.WriteLine($@"Tiền cước taxi: {tienCuoc:0,0} VND");