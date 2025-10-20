// Bài tập 5: Thời điểm tốt nhất để Mua và Bán Cổ phiếu
// Bài toán: Cho một mảng prices (giá cổ phiếu mỗi ngày). 
// Bạn chỉ được mua 1 lần và bán 1 lần.
// Tìm lợi nhuận lớn nhất bạn có thể có
// nput: prices = [7,1,5,3,6,4]
// Output: 5 (Mua ngày 2 giá 1, Bán ngày 5 giá 6. Lợi nhuận: 6 - 1 = 5)

// Hàm Tính lợi nhuận lớn nhất
static int TinhLoiNhuanLonNhat(int[] giaCoPhieu)
{
    if (giaCoPhieu.Length == 0) return 0;

    int giaThapNhat = giaCoPhieu[0];
    int loiNhuanCaoNhat = 0;

    for (int i = 1; i < giaCoPhieu.Length; i++)
    {
        // Nếu bán hôm nay → tính lợi nhuận
        int loiNhuanHomNay = giaCoPhieu[i] - giaThapNhat;

        // Cập nhật lợi nhuận cao nhất
        if (loiNhuanHomNay > loiNhuanCaoNhat)
            loiNhuanCaoNhat = loiNhuanHomNay;

        // Cập nhật giá thấp nhất nếu tìm thấy giá thấp hơn
        if (giaCoPhieu[i] < giaThapNhat)
            giaThapNhat = giaCoPhieu[i];
    }

    return loiNhuanCaoNhat;
}

int[] giaCoPhieu = { 7, 1, 5, 3, 6, 4 };

int loiNhuan = TinhLoiNhuanLonNhat(giaCoPhieu);

Console.Write($@"----- Kết quả -----------
Lịch sử giao dịch: {string.Join(", ", giaCoPhieu)}
Loi nhuan lon nhat co the dat duoc: " + loiNhuan);
System.Console.WriteLine();