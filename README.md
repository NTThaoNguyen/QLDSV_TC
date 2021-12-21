# Đề tài: QUẢN LÝ ĐIỂM SINH VIÊN THEO HỆ TÍN CHỈ
### Môn: CƠ SỞ DỮ LIỆU PHÂN TÁN
### Thành viên:
1. Châu Văn Hậu
2. Nguyễn Thị Thảo Nguyên
### Trong thư mục gồm có:
- Database của đề tài được giao
- SP nhóm viết dùng để phân tán từ site chủ xuống phục vụ các chức năng đề tài yêu cầu
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
### Nhập liệu: gồm các công việc sau
- **Nhập danh mục lớp:** Form có các chức năng sau Thêm, Xóa, Ghi, Phục hồi, Thoát; Lớp thuộc khoa nào thì khoa đó nhập. Trên từng khoa ta chỉ thấy được danh sách lớp thuộc khoa đó.
- **Nhập danh sách sinh viên:** dưới dạng SubForm. Yêu cầu: giống như lớp
- **Nhập môn học:** trên form Nhập môn học có các nút lệnh : Thêm, Xóa,  Ghi, Phục hồi, Thoát
- **Mở Lớp tín chỉ:** có các chức năng Thêm, Xóa, Ghi, Phục hồi thông tin của lớp tín chỉ
- **Đăng ký lớp tín chỉ:** user nhập vào mã sinh viên của mình, chương trình tự động in ra các thông tin của sinh viên (họ, tên, mã lớp).  Kế tiếp, user nhập vào Niên khóa, Học kỳ, chương trình sẽ tự động lọc ra các lớp tín chỉ đã mở trong niên khóa, học kỳ đó để sinh viên đăng ký (chưa hủy). Dữ liệu in ra gồm : MAMH, TENMH, nhóm, Hoten GV giảng, , số sv đã đăng ký;
- **Nhập điểm:**  Điểm thuộc khoa nào thì khoa đó nhập hoặc PGV nhập. User nhập vào Niên khóa, Học kỳ, môn học, nhóm; click nút lệnh Bắt đầu thì chương trình tự động lọc ra các sinh viên có đăng ký trên lớp tín chỉ đó theo dạng sau, sau đó user chỉ nhập điểm vào.  				
**Điểm hết môn** = Điểm CC * 0.1 + ĐCK * 0.6   
    Sau khi nhập điểm thi xong, click nút lệnh ‘Ghi điểm’ thì mới ghi hết điểm về CSDL. 
- **Đóng học phí:** login thuộc nhóm PkeToan mới được quyền vào module này. (Form này trình bày theo dạng SubForm). Khi user chọn 1 dòng trên lưới, thì sẽ tự động lọc ra chi tiết đóng học phí của niên khóa, học kỳ đó.
User nhập vào mã SV, chương trình tự động load lên họ tên, mã lớp và 1 bảng chứa tòan bộ thông tin đóng học phí của sinh viên ( theo thứ tự Niên khóa, học kỳ):
Trên form này, User thêm vào thông tin niên khóa, học kỳ, học phí cả học kỳ, sau đó click nút Ghi để ghi dữ liệu vào DB; chi tiết đóng học phí sẽ có dạng sau:
### Phân quyền 
Chương trình có các nhóm : PGV (phòng giáo vụ), KHOA, SV, PKT (phòng kế toán)
-  Nếu login thuộc nhóm PGV thì login đó có thể chọn bất kỳ khoa nào để toàn quyền làm việc bằng cách chọn tên khoa, và tìm dữ liệu trên phân mảnh tương ứng. Login nhóm này được tạo tài khoản cho nhóm PGV, Khoa.  
-  Nếu login thuộc nhóm Khoa thì ta chỉ cho phép toàn quyền làm việc trên khoa đã đăng nhập   và tìm dữ liệu trên phân mảnh tương ứng để in. Login này được tạo tài khoản cho nhóm Khoa.
- Nhóm SV chỉ được đăng ký lớp tín chỉ. Tất cả sinh viên đều dùng chung 1 login đăng nhập.  
- Nếu login thuộc nhóm PKT thì chỉ được quyền cập nhật dữ liệu đóng học phí của sinh viên, chỉ được tạo tài khoản mới thuộc cùng nhóm.  
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn tương ứng. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh. 
	

