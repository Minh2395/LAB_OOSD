# LAB5 - QUẢN LÝ TOUR DU LỊCH

## 1. Giới thiệu

LAB5 là bài thực hành môn **Phát triển phần mềm hướng đối tượng (OOSD)**, xây dựng ứng dụng **Quản lý tour du lịch** bằng **C#** và **Windows Forms**.

Ứng dụng hỗ trợ công ty du lịch quản lý tour, chuyến đi, đăng ký của khách đoàn và khách lẻ, phân công hướng dẫn viên, thanh toán, tính lương và thống kê. Dữ liệu được lưu trên **SQL Server** với cơ sở dữ liệu **QuanLyTour**.

Chương trình được tổ chức theo nhiều tầng: giao diện (Forms), nghiệp vụ (Services), mô hình dữ liệu (Models) và truy cập dữ liệu (Data).

## 2. Công nghệ sử dụng

- C#
- Windows Forms
- .NET Framework
- SQL Server (Stored Procedure)
- ADO.NET
- Visual Studio
- Git/GitHub

## 3. Chức năng chính

**Quản lý danh mục**

- Quản lý tour (mã, tên, số ngày, số đêm, đơn giá, phương tiện).
- Quản lý nơi dừng chân (đổi phương tiện, nơi ăn, khách sạn 2-5 sao).
- Quản lý điểm tham quan và liên kết điểm tham quan với tour.

**Đặt tour và đăng ký**

- Đặt tour, tự phân loại khách đoàn (trên 12 người) hoặc khách lẻ (dưới 12 người).
- Đăng ký khách đoàn: thông tin cơ quan, người đại diện, bảo hiểm, danh sách người đi, tiền đặt cọc.
- Đăng ký khách lẻ theo chuyến, chống đăng ký trùng.
- Quản lý chuyến đi (ngày đi, ngày về, tình trạng).

**Phân công và thanh toán**

- Phân công hướng dẫn viên, không cho phép lịch chồng chéo.
- Thanh toán vé tour: khách lẻ thanh toán tiền vé, khách đoàn quyết toán sau khi kết thúc chuyến và trừ tiền đặt cọc.
- Thanh toán lương hướng dẫn viên theo tháng (lương cơ bản + lương theo từng tour).

**Khác**

- Ghi nhận phiếu khảo sát khách hàng sau chuyến đi.
- Lập phiếu đền bù khi hư hỏng hoặc mất mát.
- Thống kê tour, dịch vụ, số lượng khách, doanh thu và số tour của nhân viên theo khoảng thời gian; xuất file CSV.
- Đăng nhập và phân quyền theo vai trò: Lễ tân, Nhân viên hướng dẫn du lịch, Thanh toán, Quản lý tour.

## 4. Cấu trúc thư mục

```text
LAB5/
├── README.md
└── LAB5/
    ├── LAB5.sln
    ├── Lab05_QuanLyTour.sql        # Script tạo CSDL, bảng, stored procedure, dữ liệu mẫu
    └── LAB5/
        ├── App.config          # Chuỗi kết nối CSDL
        ├── Program.cs
        ├── Data/
        │   └── Db.cs           # Truy cập CSDL (ADO.NET)
        ├── Models/
        │   └── Models.cs       # Các lớp thực thể
        ├── Services/           # Xử lý nghiệp vụ (TourService, ChuyenService, ...)
        └── Forms/              # Giao diện (FrmMain, FrmTour, FrmDatTour, ...)
```

## 5. Cách tải và chạy chương trình

### 5.1. Tải source code

#### 5.1.1. Tải toàn bộ repository

```bash
git clone https://github.com/Minh2395/LAB_OOSD.git
cd LAB_OOSD/LAB5
```

#### 5.1.2. Tải riêng một bài Lab

Repository chứa nhiều bài Lab. Nếu chỉ muốn tải một bài cụ thể, có thể dùng Git Sparse Checkout.

Ví dụ, để tải riêng LAB5:

```bash
git clone --no-checkout https://github.com/Minh2395/LAB_OOSD.git
cd LAB_OOSD
git sparse-checkout init --cone
git sparse-checkout set LAB5
git checkout
```

### 5.2. Mở project

Mở thư mục `LAB5` và mở file `LAB5.sln` bằng Visual Studio.

Hoặc mở Visual Studio, chọn **File → Open → Project/Solution**, sau đó chọn file `LAB5.sln`.

### 5.3. Tạo cơ sở dữ liệu

1. Mở **SQL Server Management Studio (SSMS)** và kết nối đến SQL Server.
2. Mở file `Lab05_QuanLyTour.sql`.
3. Thực thi toàn bộ câu lệnh để tạo cơ sở dữ liệu `QuanLyTour`, các bảng, stored procedure và dữ liệu mẫu.

### 5.4. Cấu hình kết nối cơ sở dữ liệu

Mở file `App.config` trong project và kiểm tra chuỗi kết nối đến SQL Server.

Nếu tên SQL Server trên máy khác với cấu hình hiện tại, hãy thay đổi giá trị `Data Source` cho phù hợp.

Ví dụ:

```xml
<connectionStrings>
    <add name="QuanLyTour"
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyTour;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Tên kết nối phải là `QuanLyTour` vì lớp `Db` đọc đúng tên này.

### 5.5. Chạy chương trình

Trong Visual Studio:

1. Chọn project `LAB5` làm **Startup Project**.
2. Chọn **Build → Build Solution** để build project.
3. Nhấn **F5** hoặc chọn **Debug → Start Debugging** để chạy chương trình.

Nếu cấu hình đúng, màn hình đăng nhập của ứng dụng Quản lý tour du lịch sẽ xuất hiện.

### 5.6. Tài khoản đăng nhập mẫu

Mật khẩu của tất cả tài khoản mẫu là `123456`.

| Tên đăng nhập | Vai trò                     |
| ------------- | --------------------------- |
| `admin`       | Quản lý tour                |
| `letan`       | Lễ tân                      |
| `ketoan`      | Thanh toán                  |
| `hdv1`        | Nhân viên hướng dẫn du lịch |

Khi đăng nhập, chọn đúng vai trò tương ứng với tài khoản.

### 5.7. Lưu ý

- Cần cài đặt **Visual Studio** và **SQL Server** trước khi chạy chương trình.
- Cần thực thi file `Lab05_QuanLyTour.sql` để tạo cơ sở dữ liệu trước khi chạy ứng dụng.
- Kiểm tra lại `Data Source` trong `App.config` nếu chương trình không kết nối được với SQL Server.
- Cần thêm reference `System.Configuration` cho project để đọc `App.config`.
- Đảm bảo **SQL Server đang hoạt động** trước khi chạy chương trình.
- Trường hợp đúng 12 người chưa được đề bài quy định, hệ thống sẽ báo cần thống nhất với đơn vị sử dụng.
