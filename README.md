# Đề tài: QUẢN LÝ ĐIỂM SINH VIÊN THEO HỆ TÍN CHỈ
### Môn: CƠ SỞ DỮ LIỆU PHÂN TÁN
### Trong thư mục gồm có:
- Database của đề tài.
- SP dùng để phân tán từ site chủ xuống 
### Yêu cầu: 
Giả sử trường có 2 khoa: công nghệ thông tin (CNTT),  và viễn thông (VT)  
Phân tán cơ sở dữ liệu QLDSV_HTC ra làm 3 mảnh với điều kiện sau: 
-	QLDSV được đặt trên server1: chứa thông tin của các sinh viên thuộc khoa công nghệ thông tin
-	QLDSV được đặt trên server2:  chứa thông tin của các sinh viên thuộc khoa viễn thông.
-	QLDSV được đặt trên server3:  chứa thông tin đóng học phí của các sinh viên của trường  
#### Lưu ý: 
-	Lớp tín chỉ do khoa nào quản lý thì chỉ cho sinh viên khoa đó đăng ký. 
-	Một giảng viên có thể dạy các lớp tín chỉ thuộc cả 2 khoa

Viết chương trình thực hiện các công việc sau trên từng khoa:
