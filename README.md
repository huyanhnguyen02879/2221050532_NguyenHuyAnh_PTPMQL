# 2221050532_NguyenHuyAnh_PTPMQL
# 1. Khái niệm và cấu trúc project MVC
    MVC = Model View Controller
    Model: - Chứa các lớp đại diện cho CSDL của ứng dụng

    View: - Thư mục chứa các thành phần hiển thị giao diện người dùng
          - Không xử lý các logic phức tạp, chỉ nhận dữ liệu từ Controller, hiển thị ra HTML

    Controller: - Thư mục chứa các controller (code để xử lý yêu cầu từ View gửi về)
                - Nhiệm vụ: Xử lý các yêu cầu của người dùng gửi từ View
                            Truy xuất dữ liệu trong CSDL
                            Gọi các mẫu View và trả về dữ liệu
# 2. Định tuyến trong MVC
    - MVC sẽ gọi bộ điều khiển (Controller) và các hành động bên trong (Action) thông qua URL
    - Logic định tuyến MVC sử dụng dạng: xxx.com/Controller/Action/(Parameters)