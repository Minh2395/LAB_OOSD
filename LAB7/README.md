# LAB7 - QUẢN LÝ NHÂN SỰ VÀ TIỀN LƯƠNG

## 1. Giới thiệu

LAB7 là bài thực hành môn **Phát triển phần mềm hướng đối tượng (OOSD)**, xây dựng ứng dụng **Quản lý nhân sự và tiền lương** bằng **C# Windows Forms**.

Ứng dụng hỗ trợ quản lý hồ sơ nhân viên, tuyển dụng, thử việc, hợp đồng lao động, quyết định nhân sự, quyết định lương và phụ cấp, hồ sơ bảo hiểm, chấm công, giờ phụ trội, tính lương hằng tháng, khen thưởng, kỷ luật và thống kê hoạt động nhân sự.

Dữ liệu được lưu trữ và quản lý bằng **SQL Server**, sử dụng cơ sở dữ liệu `QL_NhanSu`. Chương trình sử dụng ADO.NET để kết nối và thao tác với cơ sở dữ liệu.

Hệ thống được xây dựng nhằm hỗ trợ doanh nghiệp quản lý xuyên suốt quá trình làm việc của nhân viên, từ khi tuyển dụng đến khi ký hợp đồng chính thức, điều chỉnh lương, theo dõi chấm công và thực hiện các chế độ liên quan.

## 2. Công nghệ sử dụng

- C#
- Windows Forms
- .NET Framework
- SQL Server
- SQL Server Management Studio (SSMS)
- Visual Studio
- ADO.NET
- Git/GitHub

## 3. Chức năng chính

**Quản lý tuyển dụng và thử việc**

- Quản lý thông tin hồ sơ ứng tuyển.
- Ghi nhận phòng ban có nhu cầu tuyển dụng.
- Lập quyết định tuyển dụng, thời gian thử việc và mức lương thử việc.
- Lưu các điều khoản giữa nhà tuyển dụng và người được tuyển dụng.
- Theo dõi quá trình thử việc và kết quả đánh giá.
- Chỉ chuyển sang ký hợp đồng chính thức khi nhân viên đạt yêu cầu thử việc.
- Yêu cầu người được tuyển dụng đủ 18 tuổi khi bắt đầu thử việc.

**Quản lý hợp đồng lao động**

- Lập và quản lý hợp đồng lao động ngắn hạn, dài hạn.
- Ghi nhận ngày ký, ngày hiệu lực, thời hạn và điều khoản hợp đồng.
- Theo dõi trạng thái và lịch sử hợp đồng của nhân viên.
- Không cho phép ký hợp đồng chồng lấn với hợp đồng còn hiệu lực.
- Đối với hợp đồng dài hạn, không khai báo ngày kết thúc.
- Bắt buộc có đủ hai hồ sơ bảo hiểm y tế (BHYT) và bảo hiểm xã hội (BHXH) đối với nhân viên thuộc hợp đồng dài hạn.

**Quản lý quyết định nhân sự**

- Lập và lưu trữ quyết định bổ nhiệm, điều chuyển và thay đổi chức vụ.
- Ghi nhận ngày hiệu lực và nội dung quyết định.
- Quản lý quyết định lương, phụ cấp lương, phụ cấp chức vụ và phụ cấp độc hại.
- Theo dõi lịch sử thay đổi chức vụ, mức lương và các khoản phụ cấp.
- Ghi nhận người ký quyết định theo chức vụ Giám đốc có hiệu lực tại thời điểm ký.

**Quản lý bảo hiểm**

- Quản lý hồ sơ BHYT và BHXH của nhân viên.
- Theo dõi loại hợp đồng và mức lương làm căn cứ đóng bảo hiểm.
- Xác định các khoản bảo hiểm cần trích trừ theo mức đóng.
- Tổng hợp các khoản khấu trừ bảo hiểm trong bảng lương hằng tháng.

**Quản lý chấm công và giờ phụ trội**

- Ghi nhận bảng chấm công theo nhân viên, ngày làm việc và ca làm việc.
- Quản lý ngày công, thời gian làm việc và ngày nghỉ.
- Lập kế hoạch phân công nhân viên theo ca làm việc hằng tuần.
- Lập phiếu ghi nhận giờ phụ trội, bao gồm số phiếu, ngày phụ trội, số giờ và hình thức phụ trội.
- Ghi nhận chi tiết từng nhân viên tham gia phụ trội.
- Quản lý các hình thức phụ trội: tăng ca, ngày lễ và ngày nghỉ.
- Tính giờ phụ trội theo hệ số 1,5 lần giờ lao động bình thường.
- Tổng hợp dữ liệu chấm công và giờ phụ trội để phục vụ tính lương.

**Quản lý tiền lương và phụ cấp**

- Lập quyết định lương theo từng thời kỳ.
- Ghi nhận mức lương cơ bản, phụ cấp lương, phụ cấp chức vụ và phụ cấp độc hại.
- Tính lương hằng tháng dựa trên quyết định lương, quyết định chức vụ, bảng chấm công và phiếu phụ trội.
- Ghi nhận các khoản cộng, trừ liên quan như bảo hiểm, tiền thưởng và tiền phạt.
- Lưu trữ và tra cứu lịch sử lương của nhân viên.
- Tổng hợp bảng lương theo tháng và nhân viên.

**Quản lý khen thưởng và kỷ luật**

- Lập quyết định khen thưởng đối với cá nhân hoặc tập thể phòng ban.
- Ghi nhận lý do, hình thức và số tiền thưởng.
- Quản lý phiếu chi khen thưởng.
- Lập quyết định kỷ luật và ghi nhận số tiền phạt.
- Quản lý phiếu thu nộp phạt hoặc khoản phạt được trừ trực tiếp trong bảng lương.
- Quản lý thưởng ngày lễ, thưởng cuối năm và lương tháng 13 theo quyết định do Giám đốc ký.

**Thống kê và báo cáo**

- Thống kê nhân viên tuyển dụng mới.
- Tổng hợp danh sách nhân viên theo phòng ban, chức vụ và loại hợp đồng.
- Thống kê tình hình hợp đồng và biến động nhân sự.
- Tổng hợp bảng chấm công và giờ phụ trội.
- Thống kê bảng lương, chi phí lương và các khoản phụ cấp.
- Báo cáo tình hình bảo hiểm, khen thưởng và kỷ luật.
- Hỗ trợ tra cứu dữ liệu theo khoảng thời gian và các tiêu chí được chọn.

**Quản lý tài khoản và phân quyền**

- Đăng nhập hệ thống.
- Quản lý tài khoản người dùng.
- Phân quyền theo vai trò và phạm vi công việc.
- Kiểm soát quyền lập, sửa và phê duyệt quyết định nhân sự.
- Bảo vệ thông tin cá nhân, hợp đồng và dữ liệu tiền lương.
- Hỗ trợ quản lý và bảo trì dữ liệu hệ thống.

## 4. Quy tắc nghiệp vụ

- Nhân viên mới phải có quyết định tuyển dụng, trong đó ghi rõ thời gian thử việc, phòng ban, mức lương thử việc và điều khoản liên quan.
- Người được tuyển dụng phải đủ 18 tuổi khi bắt đầu thử việc.
- Kết quả thử việc chỉ được xác định là đạt khi đã hết thời gian thử việc. Trường hợp không đạt, nhân viên được chuyển sang trạng thái nghỉ việc.
- Chỉ ký hợp đồng chính thức khi nhân viên thử việc đạt yêu cầu và ngày hiệu lực hợp đồng sau ngày kết thúc thử việc.
- Không cho phép ký hợp đồng chồng lên hợp đồng còn hiệu lực.
- Việc lưu hợp đồng, hồ sơ bảo hiểm và chuyển trạng thái nhân viên sang chính thức phải được thực hiện trong cùng một transaction.
- Hợp đồng lao động dài hạn không có ngày kết thúc và bắt buộc có hai hồ sơ BHYT, BHXH.
- Tăng lương và bổ nhiệm chức vụ phải được ghi nhận bằng quyết định tương ứng, đồng thời lưu lịch sử thay đổi.
- Tiền lương hằng tháng được tính dựa trên quyết định lương, quyết định chức vụ, bảng chấm công, giờ phụ trội và các khoản cộng trừ liên quan.
- Giờ phụ trội được quy đổi theo hệ số 1,5 lần giờ lao động bình thường.
- Quyết định khen thưởng và kỷ luật có thể áp dụng cho cá nhân hoặc tập thể phòng ban.
- Khen thưởng được chi qua phiếu chi; tiền phạt được thu qua phiếu thu hoặc khấu trừ trong bảng lương theo quy định.
- Thưởng ngày lễ, thưởng cuối năm và lương tháng 13 phải có quyết định khen thưởng do Giám đốc ký.
- Người ký quyết định được xác định theo người giữ chức vụ Giám đốc tại ngày quyết định hoặc ngày ký, căn cứ quyết định chức vụ có hiệu lực gần nhất.

## 5. Cấu trúc thư mục

```text
LAB_OOSD/
├── README.md
└── LAB7/
    ├── LAB7.sln
    ├── QL_NhanSu.sql
    └── LAB7/
        ├── App.config
        ├── Program.cs
        ├── Db.cs
        ├── Session.cs
        ├── FrmLogin.cs
        ├── ...
        └── ...
```

_Lưu ý: Cấu trúc trên mang tính minh họa. Cần điều chỉnh tên thư mục, solution, form và các tệp cấu hình cho khớp với mã nguồn thực tế của LAB7._

## 6. Cách tải và chạy chương trình

### 6.1. Tải source code

Clone repository:

```bash
git clone https://github.com/Minh2395/LAB_OOSD.git
cd LAB_OOSD/LAB7
```

Nếu LAB7 nằm trong thư mục con khác, hãy điều chỉnh đường dẫn cho phù hợp với cấu trúc repository.

### 6.2. Mở project

1. Mở Visual Studio.
2. Chọn **File → Open → Project/Solution**.
3. Mở file solution của LAB7, ví dụ `LAB7.sln`.
4. Chờ Visual Studio tải project và các thành phần liên quan.

### 6.3. Tạo cơ sở dữ liệu

1. Mở SQL Server Management Studio (SSMS).
2. Kết nối đến SQL Server hoặc SQL Server LocalDB theo cấu hình của dự án.
3. Mở file `QL_NhanSu.sql`.
4. Kiểm tra nội dung script để xác định cách tạo cơ sở dữ liệu và các bảng.
5. Thực thi script SQL.
6. Kiểm tra cơ sở dữ liệu `QL_NhanSu`, các bảng và dữ liệu mẫu đã được tạo thành công.

**Lưu ý:** Nếu script SQL đã bao gồm lệnh tạo database, hãy thực thi theo đúng thứ tự trong script. Nếu chưa có database, cần tạo database trước khi tạo các bảng.

### 6.4. Cấu hình kết nối cơ sở dữ liệu

Kiểm tra chuỗi kết nối trong `Db.cs` hoặc `App.config` và điều chỉnh theo máy đang sử dụng.

Ví dụ kết nối SQL Server LocalDB:

```csharp
public static string ConnectionString { get; set; } =
    @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QL_NhanSu;Integrated Security=True;TrustServerCertificate=True;";
```

Nếu dự án sử dụng SQL Server thông thường, có thể cấu hình theo mẫu:

```csharp
public static string ConnectionString { get; set; } =
    @"Data Source=SERVER_NAME;Initial Catalog=QL_NhanSu;Integrated Security=True;TrustServerCertificate=True;";
```

Thay `SERVER_NAME` bằng tên máy chủ SQL Server thực tế.

Nếu sử dụng `App.config`, cấu hình có thể được khai báo như sau:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <connectionStrings>
        <add name="QL_NhanSu"
             connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QL_NhanSu;Integrated Security=True;TrustServerCertificate=True;"
             providerName="System.Data.SqlClient" />
    </connectionStrings>
</configuration>
```

**Lưu ý:** Đây là cấu hình mẫu. Cần kiểm tra cách lớp kết nối trong mã nguồn đọc chuỗi kết nối trước khi áp dụng. Không sử dụng đồng thời hai cấu hình khác nhau nếu chương trình chỉ đọc một nguồn.

### 6.5. Build và chạy chương trình

Trong Visual Studio:

1. Chọn project WinForms làm **Startup Project**.
2. Chọn **Build → Build Solution**.
3. Kiểm tra và xử lý các lỗi biên dịch nếu có.
4. Nhấn **F5** hoặc chọn **Debug → Start Debugging** để chạy chương trình.

Nếu cấu hình đúng, ứng dụng Quản lý nhân sự và tiền lương sẽ khởi động và hiển thị màn hình đầu tiên được thiết lập trong chương trình.

## 7. Kiểm tra kết nối cơ sở dữ liệu

Nếu lớp `Db` có phương thức `TestConnection()`, có thể sử dụng phương thức này để kiểm tra kết nối:

```csharp
string error;

if (Db.TestConnection(out error))
{
    MessageBox.Show("Kết nối cơ sở dữ liệu thành công.");
}
else
{
    MessageBox.Show("Không thể kết nối cơ sở dữ liệu: " + error);
}
```

Nếu chưa có phương thức `TestConnection()`, cần kiểm tra tên máy chủ, tên database, quyền truy cập và chuỗi kết nối đang được chương trình sử dụng.

## 8. Yêu cầu phi chức năng

- **Tiện dụng:** Giao diện được tổ chức theo quy trình quản lý nhân sự và tiền lương, hỗ trợ tra cứu nhanh theo mã nhân viên, họ tên, CCCD, phòng ban, loại hợp đồng và chức vụ.
- **Hiệu quả:** Tối ưu truy vấn dữ liệu, chỉ tải dữ liệu cần thiết và sử dụng transaction cho các nghiệp vụ cập nhật nhiều bảng.
- **Bảo mật:** Phân quyền theo vai trò; giới hạn quyền tạo, sửa và phê duyệt quyết định; bảo vệ thông tin nhân viên, hợp đồng và tiền lương.
- **Tin cậy:** Kiểm tra tính hợp lệ của dữ liệu, tránh trùng mã nhân viên, trùng hợp đồng còn hiệu lực và sai lệch dữ liệu chấm công, quyết định lương hoặc bảng lương.
- **Dễ bảo trì và mở rộng:** Phân chia chức năng theo từng nghiệp vụ, thuận tiện bổ sung phòng ban, loại phụ cấp, hình thức thưởng phạt và báo cáo thống kê.

## 9. Lưu ý

- Cần cài đặt Visual Studio và phiên bản SQL Server tương thích với dự án.
- Phải tạo database `QL_NhanSu` và các bảng cần thiết trước khi chạy ứng dụng.
- Kiểm tra chuỗi kết nối trong `Db.cs` hoặc `App.config` nếu chương trình không kết nối được.
- Đảm bảo dữ liệu quyết định nhân sự, hợp đồng, bảo hiểm, chấm công và bảng lương tuân thủ các quy tắc nghiệp vụ.
- Các nghiệp vụ cập nhật nhiều bảng nên sử dụng transaction để bảo đảm tính nhất quán dữ liệu.
- Tài khoản đăng nhập, mật khẩu mẫu và quyền sử dụng phải căn cứ vào dữ liệu thực tế trong script SQL hoặc mã nguồn của dự án.
- Cấu trúc thư mục, tên form và phương thức kết nối cần được cập nhật theo mã nguồn thực tế trước khi hoàn thiện README.
