# Lab 4 - Môn NT106 - Lập trình mạng căn bản

# 📘 Windows Forms Networking App  

Ứng dụng Windows Forms được xây dựng nhằm thực hiện 4 nhiệm vụ khác nhau liên quan đến Web, HTTP request, xử lý Header, HTML và REST API. Mỗi task có giao diện đơn giản, chức năng rõ ràng, phù hợp với mục tiêu học tập và thực hành lập trình mạng trong C#.

---

## ✅ Task 1: Lấy Header & HTML từ URL

### 🔍 Mô tả:
Người dùng nhập địa chỉ URL, chương trình sử dụng `HttpWebRequest` để gửi yêu cầu GET và lấy:
- **Header** phản hồi từ server.
- **Mã nguồn HTML** của trang web.

### ✨ Tính năng:
- Nhập URL và hiển thị nội dung HTML.
- Lấy toàn bộ Header và hiển thị lên RichTextBox.
- Xử lý lỗi URL hoặc kết nối thất bại.

### ⚙️ Công nghệ:
- `HttpWebRequest`, `HttpWebResponse`
- `StreamReader`, `Encoding.UTF8`

---

## ✅ Task 2: Chọn User-Agent và lấy HTML

### 🔍 Mô tả:
Cho phép người dùng **chọn User-Agent** trước khi gửi request, từ đó mô phỏng truy cập từ Chrome, Firefox, Edge, v.v.

### ✨ Tính năng:
- ComboBox chọn User-Agent.
- Hiển thị nội dung HTML tùy theo trình duyệt giả lập.
- Hỗ trợ thêm/sửa User-Agent dễ dàng.

### ⚙️ Công nghệ:
- `HttpWebRequest.UserAgent`
- Xử lý phản hồi HTML từ các server khác nhau.

---

## ✅ Task 3: Gửi Request tới API và đọc JSON/XML

### 🔍 Mô tả:
Kết nối tới API mock server để lấy dữ liệu JSON hoặc XML. Giao diện hiển thị rõ ràng định dạng nào được trả về.

### ✨ Tính năng:
- Chọn kiểu dữ liệu JSON hoặc XML.
- Gửi GET request đến API mẫu (ví dụ: `https://mockapi.io/`, `https://jsonplaceholder.typicode.com/`)
- Hiển thị phản hồi trả về (dạng chuỗi JSON/XML thuần).

### ⚙️ Công nghệ:
- `HttpClient`
- `HttpResponseMessage`
- Hỗ trợ phân tích dữ liệu JSON/XML sau (có thể mở rộng bằng `Json.NET`, `XmlDocument`)

---

## ✅ Task 4: Trình duyệt mini + lấy mã nguồn HTML

### 🔍 Mô tả:
Ứng dụng trình duyệt tích hợp (`WebBrowser`) và `HttpClient`, vừa cho phép duyệt web trực tiếp, vừa lấy mã nguồn HTML + Header.

### ✨ Tính năng:
- Nhập URL, trình duyệt nội dung qua `WebBrowser`.
- Lấy HTML source và các Header HTTP qua `HttpClient`.
- Xem mã nguồn trong cửa sổ mới (`RichTextBox`).
- Lưu mã nguồn HTML ra file `.html`.

### ⚙️ Công nghệ:
- `WebBrowser` control
- `HttpClient`, `SaveFileDialog`
- `HtmlAgilityPack` (có thể dùng thêm để phân tích HTML nếu mở rộng)

---

## 🗂️ Cấu trúc thư mục (dạng chuẩn)

```bash
NT106\Lab_4\
├── Task_1/
├───├──Task_1.sln
|
├── Task_2/
├───├──Task_2.sln
|
├── Task_3/
├───├──API_client
├──────├──API_client.sln
├───├──MyWebAPI
├──────├──MyWebAPI.sln
|
├── Task_4/
├───├──WebBrowser
├──────├──WebBrowser.sln

```
---

## 👤 Tác giả

- **Thành viên**:
  -   Vũ Hoàng Khôi - *[23520792]*
  -   Nguyễn Hoàng Bảo Minh - *[23520938]*   
- **Lớp**: NT106.P21.ANTN - Lập trình Mạng căn bản 
- **Trường**: Trường Đại học Công nghệ Thông tin - ĐHQG TP.HCM

---

## 📅 Ngày hoàn thành: 25/04/2025
