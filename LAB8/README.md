LAB8 - HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT

1. Giới thiệu
   LAB8 là bài thực hành môn Phát triển phần mềm hướng đối tượng (OOSD), xây dựng ứng dụng Hệ thống quản lý cửa hàng nước giải khát bằng C# Windows Forms.

Ứng dụng hỗ trợ cửa hàng quản lý danh mục nước giải khát, sản phẩm, nhà cung cấp, khách hàng, nhân viên, nhập hàng, bán hàng, hóa đơn, tồn kho và thống kê doanh thu. Hệ thống giúp theo dõi số lượng hàng hóa, hạn sử dụng và các giao dịch phát sinh trong quá trình kinh doanh.

Dữ liệu được lưu trữ và quản lý bằng SQL Server, sử dụng cơ sở dữ liệu QL_CuaHangNuocGiaiKhat. Chương trình sử dụng ADO.NET để kết nối và thao tác với cơ sở dữ liệu.

Hệ thống hướng đến việc đơn giản hóa quy trình quản lý cửa hàng, từ nhập hàng từ nhà cung cấp, cập nhật tồn kho đến lập hóa đơn bán hàng và tổng hợp kết quả kinh doanh. 2. Công nghệ sử dụng

- C#
- Windows Forms
- .NET Framework
- SQL Server
- SQL Server Management Studio (SSMS)
- Visual Studio
- ADO.NET
- Git/GitHub

3. Chức năng chính
   Quản lý danh mục và sản phẩm

- Thêm, sửa, xóa và tra cứu danh mục nước giải khát.
- Quản lý thông tin sản phẩm: mã sản phẩm, tên sản phẩm, đơn vị tính, dung tích hoặc quy cách đóng gói.
- Quản lý giá nhập, giá bán và trạng thái kinh doanh của sản phẩm.
- Tìm kiếm sản phẩm theo mã, tên hoặc danh mục.
- Theo dõi hạn sử dụng và thông tin lô hàng nếu cửa hàng có quản lý theo lô.
  Quản lý nhà cung cấp
- Lưu thông tin nhà cung cấp gồm mã, tên, địa chỉ, số điện thoại và email.
- Thêm, sửa, tra cứu thông tin nhà cung cấp.
- Theo dõi lịch sử nhập hàng theo từng nhà cung cấp.
- Kiểm tra thông tin nhà cung cấp trước khi lập phiếu nhập.
  Quản lý nhập hàng
- Lập phiếu nhập hàng từ nhà cung cấp.
- Ghi nhận ngày nhập, nhân viên lập phiếu và thông tin nhà cung cấp.
- Thêm các sản phẩm, số lượng và đơn giá nhập vào chi tiết phiếu nhập.
- Tự động tính thành tiền và tổng tiền phiếu nhập.
- Cập nhật số lượng tồn kho sau khi phiếu nhập được xác nhận.
- Tra cứu lịch sử nhập hàng theo thời gian hoặc nhà cung cấp.
  Quản lý bán hàng và hóa đơn
- Tạo hóa đơn bán hàng cho khách.
- Ghi nhận nhân viên lập hóa đơn, thời gian bán và thông tin khách hàng nếu có.
- Thêm sản phẩm vào hóa đơn, nhập số lượng và áp dụng giá bán hiện hành.
- Tự động tính thành tiền từng sản phẩm, tổng tiền hóa đơn và tiền khách thanh toán.
- Ghi nhận giảm giá hoặc chiết khấu nếu cửa hàng hỗ trợ.
- In hoặc xem lại hóa đơn bán hàng.
- Tra cứu hóa đơn theo mã, ngày bán, nhân viên hoặc khách hàng.
  Quản lý tồn kho
- Theo dõi số lượng tồn của từng sản phẩm.
- Tăng tồn kho khi nhập hàng được xác nhận.
- Giảm tồn kho khi hóa đơn bán hàng được xác nhận.
- Cảnh báo sản phẩm sắp hết hàng theo mức tồn tối thiểu được thiết lập.
- Kiểm tra số lượng tồn trước khi cho phép bán.
- Hỗ trợ kiểm kê và ghi nhận chênh lệch tồn kho nếu chức năng này được triển khai.
- Theo dõi hàng hết hạn hoặc sắp hết hạn nếu có quản lý hạn sử dụng.
  Quản lý khách hàng
- Lưu thông tin khách hàng gồm mã khách hàng, họ tên, số điện thoại và địa chỉ.
- Thêm, sửa và tra cứu thông tin khách hàng.
- Xem lịch sử mua hàng theo khách hàng.
- Hỗ trợ lưu thông tin khách hàng khi lập hóa đơn; có thể cho phép bán hàng không cần lưu thông tin khách đối với giao dịch thông thường.
  Quản lý nhân viên và tài khoản
- Quản lý thông tin nhân viên: mã nhân viên, họ tên, số điện thoại, địa chỉ và trạng thái làm việc.
- Tạo và quản lý tài khoản đăng nhập.
- Phân quyền theo vai trò, chẳng hạn quản lý và nhân viên bán hàng.
- Giới hạn quyền thực hiện các chức năng như quản lý danh mục, nhập hàng, bán hàng, chỉnh sửa tồn kho và xem báo cáo.
- Lưu thông tin nhân viên thực hiện các giao dịch để phục vụ tra cứu.
  Thống kê và báo cáo
- Thống kê doanh thu theo ngày, tháng hoặc khoảng thời gian.
- Tổng hợp số lượng hóa đơn và giá trị bán hàng.
- Thống kê sản phẩm bán chạy.
- Thống kê tình hình nhập hàng theo nhà cung cấp.
- Báo cáo số lượng tồn kho và danh sách sản phẩm sắp hết hàng.
- Thống kê hàng hết hạn hoặc sắp hết hạn nếu có dữ liệu hạn sử dụng.
- Hỗ trợ tra cứu theo khoảng thời gian và các tiêu chí được chọn.

4. Quy tắc nghiệp vụ

- Mỗi sản phẩm phải có mã sản phẩm duy nhất và thông tin tên sản phẩm hợp lệ.
- Giá nhập, giá bán và số lượng phải là giá trị hợp lệ; số lượng nhập hoặc bán không được âm.
- Không cho phép xác nhận hóa đơn bán hàng nếu số lượng tồn không đủ đáp ứng số lượng cần bán.
- Khi phiếu nhập hàng được xác nhận, số lượng tồn kho của các sản phẩm tương ứng được tăng theo chi tiết phiếu nhập.
- Khi hóa đơn bán hàng được xác nhận, số lượng tồn kho được giảm theo chi tiết hóa đơn.
- Tổng tiền phiếu nhập và hóa đơn phải được tính từ các dòng chi tiết, không nhập tùy ý nếu hệ thống tự tính.
- Các thao tác lưu phiếu và cập nhật tồn kho nên được thực hiện trong cùng một transaction để tránh dữ liệu giao dịch và tồn kho bị lệch.
- Không được xóa sản phẩm đang được tham chiếu bởi phiếu nhập hoặc hóa đơn; nên chuyển sản phẩm sang trạng thái ngừng kinh doanh.
- Mã hóa đơn và mã phiếu nhập phải duy nhất.
- Chỉ người dùng có quyền phù hợp mới được thực hiện chức năng quản lý, điều chỉnh dữ liệu hoặc xem báo cáo được phân quyền.
- Việc hủy hóa đơn hoặc phiếu nhập đã xác nhận phải có quy trình xử lý rõ ràng và cập nhật lại tồn kho tương ứng; không xóa dữ liệu giao dịch tùy tiện.
- Nếu quản lý theo lô, cần kiểm tra hạn sử dụng và ưu tiên xuất bán lô có hạn sử dụng gần hơn theo quy định của cửa hàng.
- Các báo cáo doanh thu phải dựa trên các hóa đơn hợp lệ theo quy định của hệ thống, không tính trùng hóa đơn đã hủy.

5. Cấu trúc thư mục
   LAB_OOSD/
   ├── README.md
   └── LAB8/
   ├── LAB8.sln
   ├── QL_CuaHangNuocGiaiKhat.sql
   └── LAB8/
   ├── App.config
   ├── Program.cs
   ├── Db.cs
   ├── Session.cs
   ├── FrmLogin.cs
   ├── ...
   └── ...
   Lưu ý: Cấu trúc trên mang tính minh họa. Cần điều chỉnh tên thư mục, solution, form và các tệp cấu hình cho khớp với mã nguồn thực tế của dự án.
6. Cách tải và chạy chương trình
   6.1. Tải source code
   Clone repository:
   git clone https://github.com/Minh2395/LAB_OOSD.git
   cd LAB_OOSD/LAB8
   Nếu LAB8 nằm trong thư mục con khác, hãy điều chỉnh đường dẫn cho phù hợp với cấu trúc repository.
   6.2. Mở project
7. Mở Visual Studio.
8. Chọn File → Open → Project/Solution.
9. Mở file solution của dự án, ví dụ LAB8.sln.
10. Chờ Visual Studio tải project và các thành phần liên quan.
    6.3. Tạo cơ sở dữ liệu
11. Mở SQL Server Management Studio (SSMS).
12. Kết nối đến SQL Server hoặc SQL Server LocalDB theo cấu hình của dự án.
13. Mở file QL_CuaHangNuocGiaiKhat.sql.
14. Kiểm tra nội dung script để xác định cách tạo cơ sở dữ liệu và các bảng.
15. Thực thi script SQL.
16. Kiểm tra cơ sở dữ liệu QL_CuaHangNuocGiaiKhat, các bảng và dữ liệu mẫu đã được tạo thành công.
    Lưu ý: Nếu script SQL đã bao gồm lệnh tạo database, hãy thực thi theo đúng thứ tự trong script. Nếu chưa có database, cần tạo database trước khi tạo các bảng.
    6.4. Cấu hình kết nối cơ sở dữ liệu
    Kiểm tra chuỗi kết nối trong Db.cs hoặc App.config và điều chỉnh theo máy đang sử dụng.

Ví dụ kết nối SQL Server LocalDB:
public static string ConnectionString { get; set; } =
@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QL_CuaHangNuocGiaiKhat;Integrated Security=True;TrustServerCertificate=True;";
Nếu dự án sử dụng SQL Server thông thường, có thể cấu hình theo mẫu:
public static string ConnectionString { get; set; } =
@"Data Source=SERVER_NAME;Initial Catalog=QL_CuaHangNuocGiaiKhat;Integrated Security=True;TrustServerCertificate=True;";
Thay SERVER_NAME bằng tên máy chủ SQL Server thực tế.

Nếu sử dụng App.config, cấu hình có thể được khai báo như sau:

<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <connectionStrings>
        <add name="QL_CuaHangNuocGiaiKhat"
             connectionString="Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QL_CuaHangNuocGiaiKhat;Integrated Security=True;TrustServerCertificate=True;"
             providerName="System.Data.SqlClient" />
    </connectionStrings>
</configuration>
Lưu ý: Đây là cấu hình mẫu. Cần kiểm tra cách lớp kết nối trong mã nguồn đọc chuỗi kết nối trước khi áp dụng. Không sử dụng đồng thời hai cấu hình khác nhau nếu chương trình chỉ đọc một nguồn.
6.5. Build và chạy chương trình
Trong Visual Studio:
1. Chọn project WinForms làm Startup Project.
2. Chọn Build → Build Solution.
3. Kiểm tra và xử lý các lỗi biên dịch nếu có.
4. Nhấn F5 hoặc chọn Debug → Start Debugging để chạy chương trình.
Nếu cấu hình đúng, ứng dụng quản lý cửa hàng nước giải khát sẽ khởi động và hiển thị màn hình đầu tiên được thiết lập trong chương trình.
7. Kiểm tra kết nối cơ sở dữ liệu
Nếu lớp Db có phương thức TestConnection(), có thể sử dụng phương thức này để kiểm tra kết nối:
string error;

if (Db.TestConnection(out error))
{
MessageBox.Show("Kết nối cơ sở dữ liệu thành công.");
}
else
{
MessageBox.Show("Không thể kết nối cơ sở dữ liệu: " + error);
}
Nếu chưa có phương thức TestConnection(), cần kiểm tra tên máy chủ, tên database, quyền truy cập và chuỗi kết nối đang được chương trình sử dụng. 8. Yêu cầu phi chức năng

- Tiện dụng: Giao diện dễ sử dụng, hỗ trợ tìm kiếm nhanh sản phẩm, hóa đơn, khách hàng và nhà cung cấp.
- Hiệu quả: Tối ưu truy vấn dữ liệu, chỉ tải dữ liệu cần thiết và hạn chế thao tác truy vấn không cần thiết.
- Bảo mật: Phân quyền theo vai trò; giới hạn quyền truy cập chức năng quản lý, chỉnh sửa tồn kho và xem báo cáo.
- Tin cậy: Kiểm tra tính hợp lệ của dữ liệu, tránh trùng mã, số lượng tồn âm và sai lệch giữa giao dịch với tồn kho.
- Toàn vẹn dữ liệu: Các thao tác cập nhật hóa đơn, phiếu nhập và tồn kho cần được xử lý nhất quán, ưu tiên sử dụng transaction.
- Dễ bảo trì và mở rộng: Phân chia chức năng theo từng nghiệp vụ, thuận tiện bổ sung chương trình khuyến mãi, quản lý lô hàng, hạn sử dụng hoặc báo cáo mới.

9. Lưu ý

- Cần cài đặt Visual Studio và phiên bản SQL Server tương thích với dự án.
- Phải tạo database QL_CuaHangNuocGiaiKhat và các bảng cần thiết trước khi chạy ứng dụng.
- Kiểm tra chuỗi kết nối trong Db.cs hoặc App.config nếu chương trình không kết nối được.
- Tên bảng, tên form, tài khoản mẫu và dữ liệu mẫu phải khớp với script SQL và mã nguồn thực tế.
- Các nghiệp vụ nhập hàng, bán hàng, hủy giao dịch và cập nhật tồn kho cần tuân thủ quy tắc nghiệp vụ đã xác định.
- Cấu trúc thư mục và tên tệp trong README cần được cập nhật theo mã nguồn thực tế trước khi nộp bài.
