// Bài tập 4: Top K phần tử xuất hiện nhiều nhất
// Bài toán: Cho một mảng số nguyên, tìm k phần tử xuất hiện nhiều lần nhất và trả về chúng dưới dạng danh sách.
// Input: nums = [1,1,1,2,2,3], k = 2 
// Output: [1, 2]  (Vì 1 xuất hiện 3 lần, 2 xuất hiện 2 lần) .

// Hàm Sắp xếp giảm dần mảng có phần tử duy nhât để tìm Top K phần tử
static int[] TimTopKPhanTu(int[] mangGoc)
{
    int n = mangGoc.Length;
    int[] mangKhongTrung = new int[n];   // Mảng chứa các phần tử không trùng
    int[] mangDem = new int[n];           // Mảng đếm số lần xuất hiện
    int soLuongKhongTrung = 0;            // Số lượng phần tử duy nhất

    // --- B1: Tạo mảng không trùng ---
    for (int i = 0; i < n; i++)
    {
        bool daCo = false;
        for (int j = 0; j < soLuongKhongTrung; j++)
        {
            if (mangGoc[i] == mangKhongTrung[j])
            {
                daCo = true;
                break;
            }
        }

        if (!daCo)
        {
            mangKhongTrung[soLuongKhongTrung] = mangGoc[i];
            soLuongKhongTrung++;
        }
    }

    // --- B2: Đếm số lần xuất hiện ---
    for (int i = 0; i < soLuongKhongTrung; i++)
    {
        int dem = 0;
        for (int j = 0; j < n; j++)
        {
            if (mangKhongTrung[i] == mangGoc[j])
                dem++;
        }
        mangDem[i] = dem;
    }

    // --- B3: Sắp xếp giảm dần theo số lần xuất hiện ---
    for (int i = 0; i < soLuongKhongTrung - 1; i++)
    {
        for (int j = i + 1; j < soLuongKhongTrung; j++)
        {
            if (mangDem[j] > mangDem[i])
            {
                // Hoán đổi số lần xuất hiện
                int tamDem = mangDem[i];
                mangDem[i] = mangDem[j];
                mangDem[j] = tamDem;

                // Hoán đổi phần tử tương ứng
                int tamGiaTri = mangKhongTrung[i];
                mangKhongTrung[i] = mangKhongTrung[j];
                mangKhongTrung[j] = tamGiaTri;
            }
        }
    }

    // --- B4: Tạo mảng kết quả chỉ gồm phần tử đã sắp xếp ---
    int[] ketQua = new int[soLuongKhongTrung];
    for (int i = 0; i < soLuongKhongTrung; i++)
    {
        ketQua[i] = mangKhongTrung[i];
    }

    return ketQua;
}



int[] mangGoc = { 1, 1, 1, 2, 2, 3 };
int k = 2;

// Gọi hàm xử lý
int[] mangDaSapXep = TimTopKPhanTu(mangGoc);

// In k phần tử đầu tiên trong mảng đã sắp xếp
Console.Write($@"----- Kết quả ----
Mảng gốc: {string.Join(", ", mangGoc)}
Top {k} phan tu xuat hien nhieu nhat: ");
for (int i = 0; i < k && i < mangDaSapXep.Length; i++)
{
    Console.Write(mangDaSapXep[i] + " ");
}
System.Console.WriteLine();