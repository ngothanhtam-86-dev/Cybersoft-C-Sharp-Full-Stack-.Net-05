CẤU TRÚC RẺ NHÁNH IF ELSE, SWITCH CASE, ... BÀI TẬP ÔN TẬP

Bài 1: Cảnh báo thời tiết
•	Tình huống: Xây dựng một ứng dụng ghi lại nhiệt độ trong ngày để hỗ trợ cảnh báo thời tiết.
•	Yêu cầu (Phản hồi khi người dùng nhập nhiệt độ theo °C): 
o	Nếu nhiệt độ lớn hơn 0 → hiển thị “🌤 Trời ấm”.
o	Nếu nhiệt độ nhỏ hơn 0 → hiển thị “❄ Trời lạnh, có thể có băng giá!”.
o	Nếu nhiệt độ bằng 0 → hiển thị “🌫 Trời rất lạnh, đúng 0°C!”.

Bài 2: Tính thuế thu nhập cho người đi làm
•	Tình huống: Xây dựng một phần mềm nhỏ hỗ trợ kế toán công ty tính toán nhanh thuế thu nhập cá nhân cho nhân viên mỗi tháng.
•	Yêu cầu (Tính thuế phải nộp dựa trên số tiền thu nhập hàng tháng): 
o	Nếu thu nhập ≤ 5 triệu đồng → ✅ Miễn thuế.
o	Nếu thu nhập > 5 triệu và ≤ 10 triệu đồng → 💰 Thuế 10%.
o	Nếu thu nhập > 10 triệu đồng → 💸 Thuế 20%.

Bài 3: Xác định mùa trong năm từ số tháng
•	Tình huống: Xây dựng một chức năng cho ứng dụng lịch Việt Nam, cho phép chương trình xác định tháng đó thuộc mùa nào trong năm khi người dùng nhập vào số tháng (từ 1 đến 12).
•	Yêu cầu (Phân loại mùa): 
o	Xuân: Tháng 1, 2, 3.
o	Hạ: Tháng 4, 5, 6.
o	Thu: Tháng 7, 8, 9.
o	Đông: Tháng 10, 11, 12.

Bài 4: Kiểm tra độ tuổi tham gia nghĩa vụ quân sự
•	Tình huống: Xây dựng chương trình hỗ trợ cán bộ xã trong việc rà soát danh sách thanh niên đủ điều kiện tham gia nghĩa vụ quân sự.
•	Yêu cầu (Phân loại kết quả dựa trên tuổi công dân nhập vào): 
o	Nếu dưới 18 tuổi → ❌ Chưa đủ tuổi tham gia NVQS.
o	Nếu từ 18 đến 27 tuổi → ✅ Đủ tuổi tham gia NVQS.
o	Nếu trên 27 tuổi → ⛔ Quá tuổi tham gia NVQS.

Bài 5: Lọc số đặc biệt cho hệ thống bảo mật (Kiểm tra số nguyên tố)
•	Tình huống: Phát triển một hệ thống tạo mật khẩu bảo mật, trong đó chỉ chấp nhận những con số “đặc biệt” – tức là số nguyên tố.
•	Yêu cầu: Viết một chương trình giúp kiểm tra xem một số nguyên người dùng nhập vào có phải là số nguyên tố hay không.

Bài 6: Tính tiền điện cho hộ gia đình
•	Tình huống: Xây dựng một chương trình hỗ trợ tính tiền điện hàng tháng cho các hộ gia đình.
•	Yêu cầu (Tính tiền điện phải trả theo biểu giá đơn giản hóa, dựa trên mức tiêu thụ kWh): 
o	Mức tiêu thụ Dưới 100 kWh: Đơn giá 1.500 VND/kWh.
o	Mức tiêu thụ Từ 100 đến 200 kWh: Đơn giá 2.000 VND/kWh.
o	Mức tiêu thụ Trên 200 kWh: Đơn giá 2.500 VND/kWh.

Bài 7: Hệ thống đặt vé rạp chiếu phim
•	Tình huống: Phát triển một ứng dụng đặt vé xem phim online.
•	Yêu cầu: Khi người dùng chọn hạng vé (Standard, Premium, VIP), hệ thống sẽ hiển thị thông tin về tiện ích kèm theo vé.
•	Tiện ích kèm theo: 
o	Standard: Ghế ngồi thường, không có đồ uống.
o	Premium: Ghế ngồi thoải mái, có đồ uống miễn phí.
o	VIP: Ghế ngồi hạng sang, có đồ uống và bỏng ngô miễn phí.

Bài 8: Tính tiền taxi cho khách hàng
•	Tình huống: Viết một ứng dụng cho hãng taxi giúp tự động tính tiền cước dựa vào số km mà khách đã đi.
•	Yêu cầu (Biểu giá tính cước): 
o	1 km đầu tiên: 10.000 VND.
o	Từ km thứ 2 đến km thứ 5: 8.000 VND/km.
o	Từ km thứ 6 trở đi: 6.000 VND/km.

Bài 9: Phân loại chữ cái: nguyên âm hay phụ âm
•	Tình huống: Phát triển một trò chơi học chữ cái tiếng Anh cho trẻ em.
•	Yêu cầu: Khi người dùng nhập vào một ký tự, chương trình sẽ tự động phân loại: 
o	Nếu ký tự là nguyên âm (a, e, i, o, u – không phân biệt hoa/thường) → in ra “✅ Là nguyên âm”.
o	Ngược lại → in “🔠 Là phụ âm”.

Bài 10: Xác định tiện ích theo loại vé máy bay
•	Tình huống: Xây dựng một hệ thống đặt vé máy bay online.
•	Yêu cầu: Khi hành khách chọn loại vé (Economy, Business hoặc First Class), hệ thống cần hiển thị tiện ích tương ứng.
•	Tiện ích đi kèm theo Loại vé: 
o	Economy: Ghế thường.
o	Business: Ghế rộng.
o	First Class: Ghế sang trọng.

