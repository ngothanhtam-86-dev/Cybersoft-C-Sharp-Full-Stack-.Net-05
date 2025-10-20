// Bài tập 1: Tính tổng các số trong một mảng
// Bài toán: Bạn được cung cấp một mảng số nguyên lstNumber. Nhiệm vụ của bạn là tính tổng của tất cả các số trong mảng này.
// Input: lstNumber = [20,81,97,63,72,11,20,15,33,15,41,20] 
// Output: Trả về tổng của tất cả các số.

// input: n phần tử -> nhập phần tử
Console.Write($@"-- Bài tập 1: Tính tổng mảng (nhập liệu):
Bạn muốn nhập bao nhiêu số để tính tổng (n) = ");
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
    while (int.TryParse(Console.ReadLine(), out lstNumber[i])== false)
    {
        Console.Write($@"Giá trị không hợp lệ!
    Hãy nhập số nguyên, Số thứ {i + 1} = ");
    }

}

int output = 0;
foreach (int so in lstNumber)
{
    output += so;
}

Console.Write($@"----------------
Mảng nhập là {string.Join(", ", lstNumber)}
Tổng mảng là: {output}
");

