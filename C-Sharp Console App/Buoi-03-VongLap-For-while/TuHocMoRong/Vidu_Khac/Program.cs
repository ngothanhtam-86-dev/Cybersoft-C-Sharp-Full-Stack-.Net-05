while (true)
{
    Console.Clear(); // Xoá màn hình mỗi lần hiển thị lại menu
    Console.WriteLine("==== MENU CHƯƠNG TRÌNH VÍ DỤ VÒNG LẶP KHÁC ====");
    Console.WriteLine("1. In bảng cửu chương -> vòng lặp lồng nhau");
    Console.WriteLine("2. Đếm chữ số của một số nguyên");
    Console.WriteLine("3. Tính tổng các chữ số");
    Console.WriteLine("4. Tính dãy Fibonacci");
    Console.WriteLine("5. Tìm phần tử lớn nhất và nhỏ nhất trong mảng");
    Console.WriteLine("6. Tính trung bình cộng của mảng số");
    Console.WriteLine("7. Vẽ hình kim tự tháp sao");
    Console.WriteLine("8. Kiểm tra mảng có sắp xếp tăng dần không");
    Console.WriteLine("9. Đếm số lần xuất hiện của ký tự trong chuỗi");
    Console.WriteLine("10. In tam giác Pascal -> vòng lặp lồng nhau và tính nhị thức Newton");
    Console.WriteLine("11. In hình vuông rỗng bằng dấu *");
    Console.WriteLine("12. Tìm số Fibonacci lớn nhất nhỏ hơn n");
    Console.WriteLine("13. In bảng số nguyên tố theo dạng lưới");
    Console.WriteLine("0. Thoát");
    Console.Write("Nhập lựa chọn của bạn: ");

    int choice;
    if (!int.TryParse(Console.ReadLine(), out choice))
        choice = -1;

    Console.Clear();

    switch (choice)
    {
        case 1:
            InBangCuuChuong();
            break;
        case 2:
            DemChuSo();
            break;
        case 3:
            TongChuSo();
            break;
        case 4:
            DayFibonacci();
            break;
        case 5:
            TimMaxMin();
            break;
        case 6:
            TrungBinhCong();
            break;
        case 7:
            KimTuThapSao();
            break;
        case 8:
            KiemTraTangDan();
            break;
        case 9:
            DemKyTu();
            break;
        case 10:
            TamGiacPascal();
            break;
        case 11:
            HinhVuongRong();
            break;
        case 12:
            FibonacciNhoHonN();
            break;
        case 13:
            BangSoNguyenTo();
            break;
        case 0:
            Console.WriteLine("Thoát chương trình...");
            return;
        default:
            Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại!");
            break;
    }

    Console.WriteLine("\nNhấn phím bất kỳ để quay lại menu...");
    Console.ReadKey();
}

// === CÁC HÀM BÀI TẬP ===

static void InBangCuuChuong()
{
    for (int i = 2; i <= 9; i++)
    {
        Console.WriteLine($"\nBảng cửu chương {i}:");
        for (int j = 1; j <= 10; j++)
            Console.WriteLine($"{i} x {j} = {i * j}");
    }
}

static void DemChuSo()
{
    Console.Write("Nhập số nguyên: ");
    int n = int.Parse(Console.ReadLine());
    int count = 0;
    while (n > 0)
    {
        count++;
        n /= 10;
    }
    Console.WriteLine($"Số có {count} chữ số.");
}

static void TongChuSo()
{
    Console.Write("Nhập số nguyên: ");
    int n = int.Parse(Console.ReadLine());
    int sum = 0;
    while (n > 0)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Tổng các chữ số là: {sum}");
}

static void DayFibonacci()
{
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine());
    int a = 0, b = 1;
    Console.Write($"{a} {b} ");
    for (int i = 3; i <= n; i++)
    {
        int c = a + b;
        Console.Write(c + " ");
        a = b;
        b = c;
    }
}

static void TimMaxMin()
{
    // Bước 1: Nhập số phần tử của mảng
    Console.Write("Nhập số phần tử của mảng: ");
    int n = int.Parse(Console.ReadLine());

    // Bước 2: Khai báo và nhập giá trị cho mảng
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập phần tử arr[{i}]: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    // Bước 3: Giả định phần tử đầu tiên là max và min
    int max = arr[0];
    int min = arr[0];

    // Bước 4: Duyệt mảng để tìm max và min
    for (int i = 1; i < n; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }

    // Bước 5: In kết quả
    Console.WriteLine("\nKết quả:");
    Console.WriteLine($"Phần tử lớn nhất trong mảng: {max}");
    Console.WriteLine($"Phần tử nhỏ nhất trong mảng: {min}");
}

static void TrungBinhCong()
{
    // Bước 1: Nhập số phần tử của mảng
    Console.Write("Nhập số phần tử của mảng: ");
    int n = int.Parse(Console.ReadLine());

    // Bước 2: Khai báo và nhập giá trị cho mảng
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập phần tử arr[{i}]: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    // Bước 3: Tính tổng các phần tử trong mảng
    int tong = 0;
    for (int i = 0; i < n; i++)
    {
        tong += arr[i];
    }

    // Bước 4: Tính trung bình cộng
    double tbc = (double)tong / n;

    // Bước 5: In kết quả
    Console.WriteLine("\nKết quả:");
    Console.WriteLine($"Tổng các phần tử = {tong}");
    Console.WriteLine($"Trung bình cộng = {tbc:F2}");
}

static void KimTuThapSao()
{
    Console.Write("Nhập chiều cao: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = i; j < n; j++) Console.Write(" ");
        for (int k = 1; k <= 2 * i - 1; k++) Console.Write("*");
        Console.WriteLine();
    }
}

static void KiemTraTangDan()
{
    // Bước 1: Nhập số phần tử
    Console.Write("Nhập số phần tử của mảng: ");
    int n = int.Parse(Console.ReadLine());

    // Bước 2: Khai báo và nhập mảng
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Nhập phần tử arr[{i}]: ");
        arr[i] = int.Parse(Console.ReadLine());
    }

    // Bước 3: Kiểm tra tăng dần
    bool tangDan = true;
    for (int i = 0; i < n - 1; i++)
    {
        if (arr[i] > arr[i + 1])
        {
            tangDan = false;
            break; // chỉ cần phát hiện 1 cặp sai là dừng
        }
    }

    // Bước 4: Xuất kết quả
    Console.WriteLine("\nKết quả kiểm tra:");
    if (tangDan)
        Console.WriteLine("Mảng được sắp xếp tăng dần.");
    else
        Console.WriteLine("Mảng KHÔNG được sắp xếp tăng dần.");
}

static void DemKyTu()
{
    Console.Write("Nhập chuỗi: ");
    string s = Console.ReadLine();
    Console.Write("Nhập ký tự cần đếm: ");
    char c = Console.ReadLine()[0];
    int count = 0;
    for (int i = 0; i < s.Length; i++)
        if (s[i] == c) count++;
    Console.WriteLine($"Ký tự '{c}' xuất hiện {count} lần.");
}

static void TamGiacPascal()
{
    Console.Write("Nhập số dòng: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        int num = 1;
        for (int j = 0; j < n - i; j++) Console.Write(" ");
        for (int k = 0; k <= i; k++)
        {
            Console.Write(num + " ");
            num = num * (i - k) / (k + 1);
        }
        Console.WriteLine();
    }
}

static void HinhVuongRong()
{
    Console.Write("Nhập cạnh hình vuông: ");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= n; j++)
        {
            if (i == 1 || i == n || j == 1 || j == n)
                Console.Write("*");
            else
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}

static void FibonacciNhoHonN()
{
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine());
    int a = 0, b = 1;
    while (b < n)
    {
        int c = a + b;
        a = b;
        b = c;
    }
    Console.WriteLine($"Số Fibonacci lớn nhất nhỏ hơn {n} là {a}");
}

static void BangSoNguyenTo()
{
    Console.Write("Nhập n: ");
    int n = int.Parse(Console.ReadLine());
    int count = 0;
    for (int i = 2; i <= n; i++)
    {
        bool prime = true;
        for (int j = 2; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                prime = false;
                break;
            }
        }
        if (prime)
        {
            Console.Write($"{i,5}");
            count++;
            if (count % 10 == 0) Console.WriteLine();
        }
    }
}
