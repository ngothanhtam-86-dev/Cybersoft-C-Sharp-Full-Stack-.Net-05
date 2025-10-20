// Bài tập 3: Loại bỏ phần tử trùng lặp (Mảng đã sắp xếp)
// Bài toán: Loại bỏ các phần tử trùng lặp từ một mảng đã sắp xếp và trả về chiều dài của mảng mới (chỉ chứa các phần tử duy nhất).
// Input: nums = [1,1,2,2,2,3,4,4,5] 
// Output: 5 (và mảng nums 5 phần tử đầu tiên sẽ là [1, 2, 3, 4, 5]).

//int[] lstNumber = [1, 1, 2, 2, 2, 3, 4, 4, 5]; -> tạo mặc định để test

// input: n phần tử -> nhập phần tử
Console.Write($@"-- Bài tập 3: Loại phần tử trùng trong mảng
---------- Xác định số phần tử có trong mảng cần kiểm tra ----------
Mảng cần kiểm tra có n số = ");
int n = 0;

// kiểm tra lỗi nhập liệu
while (int.TryParse(Console.ReadLine(), out n) == false || n <= 0)
{
    Console.Write($@"Giá trị không hợp lệ!
    Hãy nhập số nguyên lớn hơn 0, n = ");
}

// tạo mảng cần kiểm tra
int[] lstNumber = new int[n];

// input phần tử
for (int i = 0; i < n; i++)
{
    Console.Write($@"Số thứ {i + 1} = ");

    // kiểm tra lỗi nhập liệu
    while (int.TryParse(Console.ReadLine(), out lstNumber[i]) == false)
    {
        Console.Write($@"Giá trị không hợp lệ!
    Hãy nhập số nguyên, Số thứ {i + 1} = ");
    }
}
Array.Sort(lstNumber); // sắp xếp mảng tăng dần

int vitriDuyNhat = 0;
// duyệt từ phần tử thứ 2 đến hết
for (int j = 1; j < lstNumber.Length; j++)
{
    if (lstNumber[j] != lstNumber[vitriDuyNhat])
    {
        vitriDuyNhat++;
        lstNumber[vitriDuyNhat] = lstNumber[j];
    }
}

int length = vitriDuyNhat + 1; // số phần tử duy nhất

Console.Write($@"-------Kết quả ------
Mảng cần kiểm tra: {string.Join(", ", lstNumber)}
Số phần tử duy nhất: {length}
Mảng mới sau khi loại trùng:");
for (int k = 0; k < length; k++)
{
    Console.Write($@"{lstNumber[k]}, ");
}