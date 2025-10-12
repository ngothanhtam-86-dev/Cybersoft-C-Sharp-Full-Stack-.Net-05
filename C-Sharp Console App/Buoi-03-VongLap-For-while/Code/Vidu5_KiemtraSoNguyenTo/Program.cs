#region Ví dụ 5
/*
 BÀI TẬP VÒNG LẶP 5: Kiểm tra Số Nguyên Tố
◦ Mô tả: Số nguyên tố là số có đúng 2 ước số (các số mà số đó chia hết).
◦ Nhập (Input): Số nguyên dương "n".
◦ Xuất (Output): Thông báo n là số nguyên tố hoặc n không phải là số nguyên tố.
◦ Ví dụ: Nếu Input $n = 7$, Output là 7 là số nguyên tố; Nếu Input $n = 10$, Output là 10 không phải là số nguyên tố.
*/

Console.Write("Nhập n: ");
int n = int.Parse(Console.ReadLine());
bool laNguyenTo = true;
int i;
if (n < 2)
{
    laNguyenTo = false;
}
else
{
    // dùng for
    for (i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            laNguyenTo = false;
            break;
        }
    }

    // dùng while
    // while (i <= Math.Sqrt(n))
    // {
    //     if (n % i == 0)
    //     {
    //         laNguyenTo = false;
    //         break;
    //     }
    //     i++;
    // }

    // dùng do..while
    // do
    // {
    //     if (n % i == 0)
    //     {
    //         laNguyenTo = false;
    //         break;
    //     }
    //     i++;
    // }
    // while (i <= Math.Sqrt(n));

}

if (laNguyenTo)
    Console.WriteLine($"{n} là số nguyên tố.");
else
    Console.WriteLine($"{n} không phải là số nguyên tố.");


#endregion