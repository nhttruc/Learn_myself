# Study Web in Mimo <img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/10/14-16-38-29-210-2106993_mimo-learn-to-code-logo.png" title="" alt="2102106993mimolearntocodelogopng" width="50">

## ![icons8_html_40px.png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/10/14-16-41-45-icons8_html_40px.png) HTML BASICS

### I. Khám phá HTML và Tags

* HTML là ngôn ngữ máy tính cấu trúc nên tất cả trang web trên internet
  
  HTML cho các trình duyệt web biết cách hiển thị các nội dung như hình ảnh, liên kết và văn bản trên một trang web

* **Element** (phần tử) là cách gọi những gì có **opening tag**, **closing tag**, và code ở giữa, ví dụ như `<button>Hello Word</button>` là một element nhưng chỉ <button> không thì không phải

* #### Element để tạo nên một trang web HTML:
  
  Cấu trúc của nó là `<html> </html` 
  
  * `<html>` : opening tag
  
  * `</html>` : closing tag
  
  * Toàn bộ các code ta viết sẽ phải nằm ở giữa cấu trúc này nha
  
  #### Element để xác định phần nội dung (**body**) của một trang web:
  
  Cấu trúc của nó là `<body> </body>`
  
  * Cũng tương tự mấy cái kia nó có thẻ mở, thẻ đóng ở giữa là phần ta ghi code
  
  ##### → `html` và `body` tạo nên cấu trúc của một trang web, ta đặt các yếu tố ta muốn hiển thị ở bên trong `body` , ta đặt chúng ở vị trí như sau
  
  ```html
  <html>
      <body>
      code ở đây
      </body>
  </html>
  ```

* #### Cách tạo một đoạn văn :
  
  Sử dụng cấu trúc `<p> </p>` với : 
  
  * `<p>` : opening tag
  
  * `</p>` : closing tag
  
  * Và ta cũng nhập vào văn bản ta muốn hiển thị ở giữa **opening tag** và **closing tag**

* #### Cách tạo phần mở đầu (**heading**) :
  
  Ta có thể tạo phần mở đầu với nhiều kích cỡ khác nhau, tạo kích thước lớn nhất là cấu trúc `<h1> </h1>` các kích cỡ còn lại thì cũng có cấu trúc tương tự chỉ thay đổi số, số càng tăng thì kích thước càng nhỏ dần

### II. Cấu trúc văn bản với các thẻ

* Đôi khi chúng ta muốn định dạng đoạn văn bảng với ngắt dòng

* #### Chúng ta có thể chia các dòng với sự giúp đỡ của thẻ ngắt dòng (**line break tag**) : `<br>`
  
  * `<br>` là một thẻ rỗng (**empty tag**). Thẻ rỗng là thẻ không có closing tag và không có nội dung

* #### Phần tử tạo điểm nhấn cho văn bản là phần tử `<em>` :
  
  Cấu trúc của nó như sau `<em> </em>` 
  
  * Cái này làm nghiêng phần văn bản ở giữa nó

* #### Để xác định các chuỗi là quan trọng :
  
  Sử dụng cấu trúc như sau : `<strong> </strong>`

* #### Phần tử `head` :
  
  Cấu trúc như sau : `<head> </head>`
  
  * Đây là vùng chứa thông tin của một trang web, như tiêu đề của nó, nó đi trước thẻ `body` , như sau nè 
    
    ```html
    <html>
        <head>
        ...
        </head>
        <body>
        ...
        </body>
    </html>
    ```

* #### `title` :
  
  Phần tiêu đề của một trang web xuất hiện trong tab hoặc cửa sổ của trình duyệt web
  
  Để có một tiêu đề cho trang web, ta sử dụng cấu trúc `<title> </title>` ở trong thẻ `head` 
  
  ```html
  <html>
      <head>
          <title>My webpage</title>
      </head>
      <body>
      ...
      </body>
  </html>
  
  → Tiêu đề trang web này là My webpage
  ```

* #### `doctype` :
  
  Phần `doctype` cho trình duyệt web biết mình đang sử dụng phiên bản HTML nào. Nếu không có nó, trình duyệt có thể không hiển thị trang chính xác
  
  Ta sử dụng cấu trúc `<!doctype html>` 
  
  Cái này trông như một thẻ trống với một thuộc tính trống

### III. Xây dựng nút

- Ta sử dụng cấu trúc `<button> </button>` với:
  
  - `<button>` là thẻ mở (**opening tag**) , nó giúp trình duyệt biết ta muốn bắt đầu hiển thị một nút bấm
  
  - `</button>` : thẻ đóng (**closing tag**)
  
  - Ta sẽ nhập ở giữa cấu trúc này thứ mà ta muốn nó hiển thị

❖ <u>Ví dụ :</u>

```html
<button>Hello!</button>

→ Nó sẽ hiển thị ra một nút bấm có chữ Hello!
```

### IV. Tạo liên kết

* Để bắt đầu tạo nên một liên kết, ta thêm văn bản ở giữa cấu trúc `<a> </a>`. Thao tác này chưa làm nổi bật văn bản

* Sau đó để liên kết văn bản với trang web, ta thêm `href=""`  cùng với một cái liên kết. Ví dụ : `href="https://getmimo.com"` 
  
  `href` là một thuộc tính. Tất cả các thuộc tính đều có hai điểm chung: chúng cung cấp thêm thông tin và chúng đi vào bên trong thẻ mở (**opening tag**)
  
  Ta liên kết đến một trang web bằng cách thêm dấu `=` sau thuộc tính và URL làm giá trị ở giữa các dấu ngoặc kép
  
  ```html
  <a href="https://getmimo.com>Mimo</a>
  ```

---

## ![icons8_html_40px.png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/10/14-16-41-45-icons8_html_40px.png) HTML INTERMEDIATE

### I. Thêm hình ảnh

* Bên cạnh việc liên kết đến các trang khác, ta cũng có thể sử dụng URLs để thêm hình ảnh vào trang web

* #### Để thêm hình ảnh vào trang web, ta bắt đầu với thẻ `<img>`
  
  Cũng như `<br>`, `<img>` là một thẻ rỗng. Có nghĩa là nó không có thẻ đóng
  
  Để hiển thị một hình ảnh, thẻ `img` cần thuộc tính `src`, `src` là viết tắt của `source` (nguồn)
  
  Ta đặt hình ảnh mình muốn hiển thị bằng dấu `=` và địa chỉ của hình ảnh giữa dấu ngoặc kép
  
  ```html
  <img src="https://mimo.app/i/earth.png">
  ```
  
  * Cũng có thuộc tính thay đổi kích thước của hình ảnh. Ví dụ: thuộc tính `width` điều chỉnh chiều rộng của hình ảnh và `height` điều chỉnh chiều cao của hình ảnh, ta viết liền vào luôn
  
  ```html
  <img src="https://mimo.app/i/earth.png" width="200" height="200"> 
  ```

* #### Ví dụ với cái này :
  
  ```html
  <img src="https://mimo.app/r/earth.png">
  ```
  
  * `https://mimo.app/` trỏ vào máy tính
  
  * `/r` là một thư mục được lưu trữ trên máy tính
  
  * `earth.png` là tên của thư mục
  
  Để truy cập tệp cục bộ hoặc tệp tồn tại trên thiết bị của chúng tôi, ta bỏ phần `https://mimo.app` từ URL và chỉ viết `/r/earth.png` 
  
  Tuy nhiên ta đã thêm hình ảnh vào một thư mục cục bộ có tên `img`. điều đó có nghĩa là chúng ta có thể truy cập hình ảnh chỉ bằng cách gõ `/img/` trước tên hình ảnh
  
  ##### → Từ bây giờ chúng ta sẽ sử dụng `/img/` để truy cập hình ảnh cục bộ, trong đó `img` là viết tắt của `images` (hình ảnh)

### II. Input

* #### Ta tạo phần tử đàu vào bằng cách sử dụng thẻ rỗng `<input>`
  
  Thuộc tính `placeholder` giúp gợi ý những gì người dùng nên nhập vào
  
  ##### ⚠ Như `button`, `input` cần `<br>` để đặt cái này dưới cái khác

* #### Thuộc tính `type` chỉ định loại đầu vào. Ví dụ: ta có thể ẩn những gì người dùng nhập để bảo mật tốt hơn với `type="password"`
  
  Giá trị mặc định của `type` là `text` cho phép người dùng nhập văn bản mà họ có thể thấy
  
  ❖ <u>Ví dụ:</u>
  
  ```html
  <input type="text" placeholder="Email">
  ```

* #### Có những đầu vào `type` thường dùng sau :
  
  * `text` và `password` đã được giới thiệu ở trên
  
  * `range` : tạo ra một thanh kéo ngang, ví dụ như thanh kéo âm thanh
  
  * `checkbox` : tạo ra một hộp để đánh dấu check
  
  * `date` : để nhập vào chọn ngày
  
  * `color` : hiện hộp để chọn màu

### III. Nhóm các phần tử

* Để tạo nên nhóm của phần tử, ta bao quanh các phần tử với `<div> </div>` 
  
  Thẻ `<div> </div>` và phần tử ở giữa tạo một nhóm trên trang web, còn được gọi là phần tử `<div>` 
  
  Ta gọi các phần tử bên trong các phần tử khác là phần tử lồng (**nested elements**). Ví dụ :
  
  ```html
  <div>
      <h1>Thanh Trúc</h1> // đây là phần tử lồng
  </div>
  ```

### IV. Xây dựng danh sách

* #### Một loại danh sách là danh sách có thứ tự.
  
  Danh sách có thứ tự hiển thị danh sách các mục được đánh số. Giống như kết quả của cuộc đua
  
  Cấu trúc của nó như sau : `<ol> </ol>` . ol là viết tắt của ordered list

* #### list item
  
  Để thêm một mục danh sách, ta thêm văn bản ở giữa cấu trúc `<li> </li>`. li là viết tắt của list item
  
  Để danh sách xuất hiện đúng, thì vị trí của `li` phải đặt lồng trong `ol`
  
  ```html
  <ol>
      <li>Tuấn Kiệt</li>
  </ol>
  ```
  
  Có thể có bất kỳ số lượng mục nào trong danh sách. Thể thêm một mục thì ta thêm một cái `li` nữa vào `ol` , nó sẽ tự đánh thêm số theo thứ tự
  
  ```html
  <ol>
      <li>Tuấn Kiệt</li>
      <li>Thanh Trúc</li>
  </ol>
  ```

* #### Danh sách không có thứ tự:
  
  Danh sách này không hiện đánh số như danh sách có thứ tự, mà nó hiển thị ở dạng cách chấm
  
  Cấu trúc của nó là `<ul> </ul>` , ul là viết tắt của unordered list
  
  Cái này chỉ khác với danh sách có thứ tự ở cấu trúc và cách nó hiển thị ra thôi, còn lại cách dùng và cách thêm một mục y như danh sách có thứ tự thôi, cũng sử dụng thêm mục bằng `li` 

* #### Các mục danh sách có thể chứa nhiều hơn chỉ là văn bản. chúng cũng có thể chứa hình ảnh hoặc liên kết

### V. Liên kết các trang web

* Ta đã học cách liên kết đến các trang web trên các máy tính khác nhau

* #### Ta có thể truy cập các trang web cục bộ như `trail.html` bằng cách thêm `/` và tên tệp, giống như với các hình ảnh cục bộ

* #### Trang web là các tệp `.html` và trang web chính, hoặc trang chủ, thường được đặt tên là `index.html`. bạn thường có thể thấy trang này trong thanh tìm kiếm
  
  Để giữ cho tên tệp `.html` dễ đọc, ta viết thường từng từ và đặt dấu gạch ngang `-` ở giữa
  
  ```html
  <a href="/index.html">Homepage</a>
  ```

---

## ![icons8_css_40px.png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/10/14-19-37-47-icons8_css_40px.png) CSS BASICS



## 









☆❖→✿❀⚠
