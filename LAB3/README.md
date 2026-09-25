# LAB3 - QUẢN LÝ KHÁCH SẠN

## 1. Giới thiệu

LAB3 là bài thực hành môn **Phát triển phần mềm hướng đối tượng (OOSD)**, xây dựng ứng dụng quản lý khách sạn bằng **C#** và **Windows Forms**.

## 2. Công nghệ sử dụng

- **C#**
- **Windows Forms**
- **.NET**
- **SQL Server**
- **ADO.NET**
- **Visual Studio**
- **Git/GitHub**

## 3. Cấu trúc thư mục

```text
LAB3/
├── README.md
└── QuanLyKhachSan/
    ├── QuanLyKhachSan.sln
    ├── QuanLyKhachSan/
    └── QuanLyKhachSan.sql
```

## 4. Cách tải và chạy chương trình

### 4.1. Tải source code

Clone repository về máy bằng Git:

## Tải riêng một bài Lab

Repository chứa nhiều bài Lab. Nếu chỉ muốn tải một bài Lab cụ thể, có thể sử dụng Git Sparse Checkout.

Ví dụ, để tải riêng LAB3:

```bash
git clone --no-checkout https://github.com/Minh2395/LAB_OOSD.git
cd LAB_OOSD
git sparse-checkout init --cone
git sparse-checkout set LAB3
git checkout
```

### 4.2. Mở project

Mở thư mục `QuanLyKhachSan` và mở file **`QuanLyKhachSan.sln`** bằng Visual Studio.

Hoặc mở Visual Studio, chọn:

**File → Open → Project/Solution**

Sau đó chọn file `QuanLyKhachSan.sln`.

### 4.3. Tạo cơ sở dữ liệu

Mở **SQL Server Management Studio (SSMS)** và kết nối đến SQL Server.

Mở file **`QuanLyKhachSan.sql`** trong thư mục `QuanLyKhachSan` và thực thi toàn bộ câu lệnh SQL để tạo cơ sở dữ liệu và các bảng cần thiết.

### 4.4. Cấu hình kết nối cơ sở dữ liệu

Mở file **`App.config`** trong project và kiểm tra chuỗi kết nối đến SQL Server.

Nếu tên SQL Server trên máy khác với cấu hình hiện tại, thay đổi giá trị `Data Source` cho phù hợp.

Ví dụ:

```xml
<connectionStrings>
    <add name="QuanLyKhachSanDB"
         connectionString="Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyKhachSanDB;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 4.5. Chạy chương trình

Trong Visual Studio:

1. Chọn project **`QuanLyKhachSan`** làm **Startup Project**.
2. Chọn **Build → Build Solution** để build project.
3. Nhấn **F5** hoặc chọn **Debug → Start Debugging** để chạy chương trình.

Nếu cấu hình đúng, ứng dụng quản lý thư viện sẽ được khởi chạy.

### 4.6. Lưu ý

- Cần cài đặt **Visual Studio** và **SQL Server** trước khi chạy chương trình.
- Cần thực thi file **`SQLQuery1.sql`** để tạo cơ sở dữ liệu.
- Kiểm tra lại `Data Source` trong **`App.config`** nếu chương trình không kết nối được với SQL Server.
- Đảm bảo **SQL Server đang hoạt động** trước khi chạy chương trình.
