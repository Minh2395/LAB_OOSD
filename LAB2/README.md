# LAB2 - QUẢN LÝ THƯ VIỆN

## 1. Giới thiệu

LAB2 là bài thực hành môn **Phát triển phần mềm hướng đối tượng (OOSD)**, xây dựng ứng dụng quản lý thư viện bằng **C#** và **Windows Forms**.

Ứng dụng cung cấp các chức năng quản lý thông tin thư viện như độc giả, nhân viên, sách, thể loại, nhà xuất bản và hoạt động mượn trả sách. Dữ liệu được lưu trữ và quản lý trên **SQL Server**.

## 2. Công nghệ sử dụng

- **C#**
- **Windows Forms**
- **.NET**
- **SQL Server**
- **ADO.NET**
- **Visual Studio**
- **Git/GitHub**

## 3. Chức năng chính

- Quản lý độc giả.
- Quản lý nhân viên.
- Quản lý sách.
- Quản lý thể loại.
- Quản lý nhà xuất bản.
- Quản lý mượn và trả sách.
- Tìm kiếm và hiển thị thông tin.
- Kết nối và thao tác với cơ sở dữ liệu SQL Server.

## 4. Cấu trúc thư mục

```text
LAB2/
├── README.md
└── QuanLyThuVien/
    ├── QuanLyThuVien.sln
    ├── QuanLyThuVien/
    └── SQLQuery1.sql
```

## 5. Cách tải và chạy chương trình

### 5.1. Tải source code

Clone repository về máy bằng Git:

## Tải riêng một bài Lab

Repository chứa nhiều bài Lab. Nếu chỉ muốn tải một bài Lab cụ thể, có thể sử dụng Git Sparse Checkout.

Ví dụ, để tải riêng LAB2:

```bash
git clone --no-checkout https://github.com/Minh2395/LAB_OOSD.git
cd LAB_OOSD
git sparse-checkout init --cone
git sparse-checkout set LAB2
git checkout
```

### 5.2. Mở project

Mở thư mục `QuanLyThuVien` và mở file **`QuanLyThuVien.sln`** bằng Visual Studio.

Hoặc mở Visual Studio, chọn:

**File → Open → Project/Solution**

Sau đó chọn file `QuanLyThuVien.sln`.

### 5.3. Tạo cơ sở dữ liệu

Mở **SQL Server Management Studio (SSMS)** và kết nối đến SQL Server.

Mở file **`SQLQuery1.sql`** trong thư mục `QuanLyThuVien` và thực thi toàn bộ câu lệnh SQL để tạo cơ sở dữ liệu và các bảng cần thiết.

### 5.4. Cấu hình kết nối cơ sở dữ liệu

Mở file **`App.config`** trong project và kiểm tra chuỗi kết nối đến SQL Server.

Nếu tên SQL Server trên máy khác với cấu hình hiện tại, thay đổi giá trị `Data Source` cho phù hợp.

Ví dụ:

```xml
<connectionStrings>
    <add name="QuanLyThuVienDB"
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyThuVienDB;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 5.5. Chạy chương trình

Trong Visual Studio:

1. Chọn project **`QuanLyThuVien`** làm **Startup Project**.
2. Chọn **Build → Build Solution** để build project.
3. Nhấn **F5** hoặc chọn **Debug → Start Debugging** để chạy chương trình.

Nếu cấu hình đúng, ứng dụng quản lý thư viện sẽ được khởi chạy.

### 5.6. Lưu ý

- Cần cài đặt **Visual Studio** và **SQL Server** trước khi chạy chương trình.
- Cần thực thi file **`SQLQuery1.sql`** để tạo cơ sở dữ liệu.
- Kiểm tra lại `Data Source` trong **`App.config`** nếu chương trình không kết nối được với SQL Server.
- Đảm bảo **SQL Server đang hoạt động** trước khi chạy chương trình.
