MỞ RỘNG VỀ VÒNG LẶP TRONG C#
1. Tạo Menu bằng vòng lặp và điều kiện switch-case
2. Menu có 13 chức năng mở rộng ứng dụng vòng lặp, gồm:
3. 
Ví dụ 1: In bảng cửu chương (vòng lặp lồng nhau)
Mô tả:
In toàn bộ bảng cửu chương từ 2 đến 9 hoặc một bảng cụ thể do người dùng chọn.
Vòng lặp sử dụng:
for lồng nhau.
Kết quả:
5 x 1 = 5
5 x 2 = 10
...
5 x 10 = 50

Ví dụ 2: Đếm chữ số của một số nguyên
Mô tả:
Nhập số nguyên n, đếm xem số đó có bao nhiêu chữ số.
Cách làm:
Dùng while (n > 0) và chia n /= 10 sau mỗi bước.
Ví dụ:
n = 1234 → Kết quả: có 4 chữ số.

Ví dụ 3: Tính tổng các chữ số
Mô tả:
Nhập số nguyên n, tính tổng các chữ số trong số đó.
Cách làm:
Dùng vòng while:
tong += n % 10;
n /= 10;
Ví dụ:
n = 1234 → S = 10.

Ví dụ 4: Tính dãy Fibonacci
Mô tả:
Nhập n, in ra n số đầu tiên trong dãy Fibonacci:
0, 1, 1, 2, 3, 5, 8, ...
Cách làm:
Dùng vòng for, cập nhật 2 biến a và b liên tục.

Ví dụ 5: Tìm phần tử lớn nhất và nhỏ nhất trong mảng
Mô tả:
Nhập n, nhập n phần tử mảng.
Duyệt mảng bằng vòng for để tìm max và min.
Ví dụ:
Mảng [3, 9, 1, 7] → Max = 9, Min = 1.

Ví dụ 6: Tính trung bình cộng của mảng số
Mô tả:
Nhập mảng số, tính trung bình cộng:
TBC = (tổng các phần tử) / n.
Cách làm:
Duyệt for cộng dồn, rồi chia cho n.

Ví dụ 7: Vẽ hình kim tự tháp sao
Mô tả:
Nhập n, in hình kim tự tháp có n tầng bằng dấu *.
Vòng lặp:
Lồng nhau (for trong for).
Ví dụ (n = 4):
   *
  ***
 *****
*******

Ví dụ 8: Kiểm tra mảng có sắp xếp tăng dần không
Mô tả:
Nhập mảng, kiểm tra xem các phần tử có tăng dần không.
Cách làm:
So sánh arr[i] và arr[i+1] trong vòng for.
Kết quả:
“Mảng tăng dần” hoặc “Mảng không tăng dần”.

Ví dụ 9: Đếm số lần xuất hiện của ký tự trong chuỗi
Mô tả:
Nhập một chuỗi và một ký tự.
Duyệt qua từng ký tự bằng vòng for, đếm số lần trùng.
Ví dụ:
"hello", ký tự 'l' → xuất hiện 2 lần.

Ví dụ 10: In tam giác Pascal (vòng lặp lồng nhau + nhị thức Newton)
Mô tả:
In tam giác Pascal với n dòng:
1
1 1
1 2 1
1 3 3 1
...
Cách làm:
Dùng công thức kết hợp:
C(k, j) = C(k-1, j-1) + C(k-1, j)
(hoặc dùng giai thừa).

Ví dụ 11: In hình vuông rỗng bằng dấu ***
Mô tả:
Nhập cạnh n, in hình vuông rỗng kích thước n x n.
Ví dụ (n = 5):
*****
*   *
*   *
*   *
*****
Vòng lặp:
for lồng nhau, điều kiện i == 0 || i == n-1 || j == 0 || j == n-1.

Ví dụ 12: Tìm số Fibonacci lớn nhất nhỏ hơn n
Mô tả:
Nhập n, tìm số Fibonacci lớn nhất nhỏ hơn hoặc bằng n.
Ví dụ:
n = 20 → số Fibonacci gần nhất là 13.

Ví dụ 13: In bảng số nguyên tố theo dạng lưới
Mô tả:
In các số nguyên tố từ 2 đến n, sắp xếp thành dạng lưới (mỗi hàng có 10 số).
Cách làm:
Dùng vòng for ngoài để lặp qua các số, vòng trong để kiểm tra số nguyên tố.
Mỗi 10 số, xuống dòng một lần.
