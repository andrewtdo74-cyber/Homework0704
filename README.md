Đề Bài

Bài 1: Tính điểm trung bình và xếp loại (Dễ - 10 phút)
Yêu cầu:
Viết chương trình cho phép nhập điểm của 3 môn: Toán, Lý, Hóa (kiểu double).
Sau đó thực hiện:

Tính điểm trung bình (làm tròn 2 chữ số thập phân)
Xếp loại theo quy tắc sau:
≥ 8.0 → Giỏi
≥ 6.5 → Khá
≥ 5.0 → Trung bình
< 5.0 → Yếu


Yêu cầu output:
Điểm Toán: 7.5
Điểm Lý: 8.0
Điểm Hóa: 6.5
Điểm trung bình: 7.33
Xếp loại: Khá
Gợi ý: Dùng double, toán tử + /, Math.Round() hoặc format :F2, và if-else.


Bài 2: Chuyển đổi tiền tệ và tính phí (Trung bình - 12 phút)
Yêu cầu:
Viết chương trình quy đổi từ USD sang VND và tính phí chuyển khoản.

Nhập số tiền USD (kiểu decimal)
Tỷ giá: 1 USD = 25.300 VND (cứng)
Phí chuyển khoản = 0.5% số tiền VND sau khi quy đổi
In ra:
Số tiền USD
Số tiền VND sau quy đổi
Phí chuyển khoản
Tổng tiền phải trả (VND)


Ví dụ output:
Nhập số tiền USD: 100
Số tiền USD: 100
Số tiền VND: 2,530,000
Phí chuyển khoản: 12,650
Tổng tiền phải trả: 2,542,650 VND
Gợi ý: Dùng decimal cho tất cả phép tính tiền, toán tử * / %, format :N0 hoặc :C0.

Bài 3: Tính diện tích và chu vi hình chữ nhật + so sánh (Khó hơn - 15 phút)
Yêu cầu:
Viết chương trình tính diện tích và chu vi của 2 hình chữ nhật.

Nhập chiều dài và chiều rộng của hình chữ nhật 1 (double)
Nhập chiều dài và chiều rộng của hình chữ nhật 2 (double)
Tính:
Diện tích và chu vi của từng hình
So sánh diện tích của 2 hình (hình nào lớn hơn hoặc bằng nhau)

In ra tất cả thông tin một cách rõ ràng, dễ đọc.

Ví dụ output:
Hình chữ nhật 1:
Diện tích: 24.5 m²
Chu vi: 22 m

Hình chữ nhật 2:
Diện tích: 30 m²
Chu vi: 26 m

Kết luận: Hình chữ nhật 2 có diện tích lớn hơn.
Gợi ý: Dùng biến có ý nghĩa (dai1, rong1, dai2, rong2, dienTich1...), toán tử * +, và if-else để so sánh.

