// Bài tập 2: Tìm hai số có tổng bằng Target
// Bài toán: Tìm hai số trong một danh sách số nguyên sao cho tổng của chúng bằng một giá trị target cho trước. Trả về chỉ số (index) của hai số đó.
// Input: nums = [2, 7, 11, 15], target = 9 
// Output: [0, 1] (vì nums[0] + nums[1] = 2 + 7 = 9).

// khai báo ouput 
int[] output = new int[2];

// input: n phần tử -> nhập phần tử
Console.Write($@"-- Bài tập 2: Tìm hai số có tổng bằng target:
---------- Xác định số có trong mảng ----------
Mảng cần kiểm tra có n số = ");
int n = 0;

// kiểm tra lỗi nhập liệu
while (int.TryParse(Console.ReadLine(), out n) == false || n <= 0)
{
    Console.Write($@"Giá trị không hợp lệ!
    Hãy nhập số nguyên lớn hơn 0, n = ");
}

// tạo mảng cần tính tổng
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

int target = 0;
Console.Write($@"-------- Nhập Target cần tìm tổng --------
Target Tổng (target) = ");

// kiểm tra lỗi nhập liệu
while (int.TryParse(Console.ReadLine(), out target) == false || n <= 0)
{
    Console.Write($@"Giá trị không hợp lệ!
    Hãy nhập số nguyên lớn hơn 0, n = ");
}

for (int j = 0; j < n; j++)
{
    // lấy số kiểm tra
    output[0] = j;
    int soCanTim = target - lstNumber[j];; // số cần tìm
    int viTri = Array.IndexOf(lstNumber, soCanTim); // tìm vị trí số cần tìm có trong mảng

    // tìm được số phù hợp thì lưu vị trí: khác vị trí đã lưu (j), vị trí tìm thấy -> khác -1
    // nếu không tìm thấy thì output = 0, 0
    if (viTri != j && viTri != -1)
    {
        output[1] = viTri;
        break;
    }
    else
    {
        output[1] = 0;
    }
}

Console.Write($@"--------Kết quả --------
Mảng đã nhập là {string.Join(", ", lstNumber)}
");

if (output[0] == 0 && output[0] == 0)
{
    Console.WriteLine($@"Không tìm thấy tổng hai giá trị bằng {target}");
}
else
{
    Console.WriteLine($@"Tìm thấy tổng hai giá trị, tại vị trí {output[0]} và vị trí {output[1]}");
}
