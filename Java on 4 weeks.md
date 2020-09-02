# ![icons8java48px1png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/23-15-44-20-icons8_java_48px_1.png) Java cơ bản trong 4 tuần

## ✿ Bài 1: GIỚI THIỆU NGÔN NGỮ LẬP TRÌNH `Java`

### 1. Lịch sử ra đời

- Do hãng **Sun Microsystem** xây dựng và phát triển

- **Java** được xây dựng dựa trên ngôn ngữ [C](https://vi.wikipedia.org/wiki/C) và [C++](https://vi.wikipedia.org/wiki/C%2B%2B)

- **Java** là ngôn ngữ lập trình hướng đối tượng và độc lập nền tảng
  
  * [Java version history](https://en.wikipedia.orCg/wiki/Java_version_history)
  
  <img title="" src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/09-23-18-17-1.jpg" alt="1.jpg" data-align="center">

<img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/09-23-26-52-dsadadasdasd.jpg" title="" alt="dsadadasdasd.jpg" data-align="center">

### 2. Các đặc trưng điểm mạnh của `Java`

- Hướng đối tượng (OOP)

- Độc lập nền tảng

- Mạnh mẽ

- An toàn

- Phân tán

- Đa luồng

- Động

- Kiến trúc trung lập

- Khả chuyển

- Hiệu suất cao

### 3. Tại sao nên lập trình Java

<img title="" src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/09-23-27-04-gjuiewhrtw.jpg" alt="gjuiewhrtw.jpg" width="389" data-align="center">

[Top programing languages 2020](https://spectrum.ieee.org/at-work/tech-careers/top-programming-language-2020)

- Viết một lần xài mọi nền tảng

- Cộng đồng hỗ trợ **Java** khổng lồ

- Nhu cầu tuyển dụng nhiều

- Ngôn ngữ lập trình cho **Android** đã nổi tiếng (là nền tảng của **Android**). 

---

## ✿ Bài 2: CÁC CÔNG CỤ LẬP TRÌNH VỚI JAVA

### 1. Notepad

❖ Là công cụ đơn giản nhất để soạn thảo coding Java

### 2. Eclipse

❖ Là một trong những công cụ nổi tiếng nhất hiện nay để lập trình Java

### 3. Netbean

### 4. Android Studio

❖ Là công cụ rất nổi tiếng để lập trình Adroid, viết mã nguồn bằng Java

--- 

## ✿ Bài 3: CÀI ĐẶT JDK

---

## ✿ Bài 4: CÀI ĐẶT BIẾN MÔI TRƯỜNG CHO JAVA

---

## ✿ Bài 5: CÁCH CHẠY CHƯƠNG TRÌNH JAVA BẰNG LỆNH COMMAND LINE

--- 

## ✿ Bài 6: CÁCH CÀI ĐẶT VÀ SỬ DỤNG CÔNG CỤ ECLIPSE

![icons8_reminder_50px.png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/25-17-40-39-icons8_reminder_50px.png)**1 Workspace sẽ có nhiều Project, 1 Project sẽ có nhiều Package, 1 Package sẽ có nhiều lớp (class)**

### 1. Cách tạo Workspace

* Khi lần đầu tiên khởi động, Eclipse sẽ yêu cầu chúng ta chọn Workspace (là nơi lưu trữ các Project). Ta nên tạo ngay Workspace khác ổ C (tránh khi máy có vấn đề bị mất hết dữ liệu)

* Nhấn vào `Use this as the default and do not ask again` (để lựa chọn vị trí vừa chọn là mặc định lần sau mở lên nó không hỏi nữa) rồi bấm `OK`

⚠ Ngoài ra muốn đổi Workspace mới ta có thể: vào `File` → `Switch Workspace` → `Other` sau đó có thể chọn `Browse` để chọn đường dẫn khác. Sau khi chọn Workspace khác rồi bấm `OK`, đợi Eclipse restar lại thì ta sẽ có Workpace mới

### 2. Cách tạo các Project

* Project là một dự án cụ thể nào đó, được lưu vào Workspace (1 Workspace sẽ có nhiều Project)

* Vào `File` → `New` → `Java Project` → nó sẽ hiển thị 1 cửa sổ cho ta tạo Project mới
  
  - Project name : đặt tên cho Project
  
  - Chọn Use a Project specific JRE
  
  - Sau đó bấm Finish để tạo Project

### 3. Cách tạo package

* package bản chất là cây thư mục để tổ chức sắp xếp phân loại các lớp, giúp cho việc bảo trì dự án được tốt hơn. **Package trong Java yêu cầu phải viết thường hết**. Nó được phân cấp theo dạng thư mục cha con (dựa vào dấu `.` lúc tạo package, trước dấu `.` là thư mục cha, sau dấu `.` là thư mục con)

* Đặt package thế nào là do Lập trình viên quyết định

* Tạo như sau : bấm chuột phải vào `src` → `New` → `Package` → ra một cửa sổ để tạo Package. Name: đặt tên cho package. Ví dụ đặt communityuni.com thì thư mục cha là communityuni, thư mục con là com

* Ngoài việc tổ chức sắp xếp phân loại lớp, package còn có ý nghĩa :
  
  - Thường gắn liền với domain của cá nhân, tổ chức. Nhưng không có nghĩa nó phải tồn tại
  
  - Như tên tui là Thanh Trúc thì tui đặt là thanhtruc.edu.vn cũng được dù thanhtruc.edu.vn hoàn toàn không tồn tại

### 4. Cách tạo class

* Bấm chuột phải vào package vừa tạo → `New` → `Class` → hiển thị ra cửa sổ mới
  
  - Name : nhập vào tên lớp, ký tự đầu tiên của các từ phải viết hoa
  
  - Check vào public static void main để tự phát sinh ra hàm main (nếu quên thì khi vào code gõ `main` → `Ctrl+Space` để nó hiện ra)
  
  - Sau đó bấm `Finish` để kết thúc

### 5. Cách biên dịch và thực thi dự án

* Để biên dịch và chạy ta chọn `Run` → `Run` hoặc `Ctrl+F11` hoặc nhấn vào biểu tượng giống vầy <img title="" src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/25-18-03-16-icons8_play_64px.png" alt="icons8_play_64px.png" width="50"> trên toolbar

### 6. Cấu hình lưu dấu tiếng Việt trong Eclipse

* Nếu không cấu hình thì các chữ bằng tiếng Việt sẽ bị bể hết không đọc được

* Vào `Project` → `Properties` → Hiện 1 cửa sổ mới lên → Ở phần **Resource** chỗ `Other` đổi thành `UTF - 8` → `OK` 

---

## ✿ Bài 7: CÁCH XUẤT DỮ LIỆU RA MÀN HÌNH

### 1. Thư viện xuất dữ liệu trong

    Thư viện xuất dữ liệu trong Java là :              ``java.lang``

    Vì nó mặc định nên không thấy đưa vào ứng dụng

### 2. Xuất dữ liệu trên các dòng khác nhau

```java
                    System.out.println("Hello World !");
```

Có thể viết tắt là ``sysout`` rồi gõ tổ hợp phím ``ctrl`` + ``space`` để nó tự động xuất hiện

### 3. Xuất dữ liệu trên cùng một dòng

```java
                    System.out.print("Hello World !");
```

### 4. Các ký tự đặc biệt

* ``\n``  → Xuống dòng

* ``\t``  → Thụt đầu dòng

*  ``\"`` → Trích dẫn

           **Ví dụ:**

<img title="" src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/10-16-46-38-v%C3%AD%20d%E1%BB%A5%20k%C3%BD%20t%E1%BB%B1%20%C4%91%E1%BA%B7c%20bi%E1%BB%87t.jpg" alt="ví dụ ký tự đặc biệt.jpg" data-align="center">

---

## ✿ Bài 8: CÁCH GHI CHÚ LỆNH QUAN TRỌNG TRONG JAVA

### 1. Ghi chú một dòng

```java
        // đây là ghi chú một dòng
```

### 2. Ghi chú nhiều dòng

```java
/*
 * Đây là ví dụ
 * ghi chú nhiều dòng
 */
```

    Thật ra chỉ cần gõ ``/*`` rồi bấm ``Enter`` sẽ hiện ra mẫu ghi chú nhiều dòng 

### 3. Ghi chú dạng **Javadocs**

    Thông thường được sử dụng cho ghi chú các lớp hoặc các hàm

* **Ví dụ như sau:**

```java
/**
 * Đây là hàm giải phương trình bậc 1 ax+b=0
 * @param a - hệ số a
 * @param b - hệ số b
 */
public static void ptb1 (double a, double b)
{
    if (a == 0 && b == 0)
        System.out.println("Phương trình vô số nghiệm");
    else if (a == 0 && b != 0)
        System.out.println("Phương trình vô nghiệm");
    else 
        System.out.println("Phương trình có nghiệm x = "+(-b/a));
}
public static void main (String[] args)
{
    ptb1(7,2);
}
```

    Khi có ghi chú dạng *Javadocs* ở trước hàm, khi rê chuột chỉ vào tên hàm trong hàm main ta sẽ thấy hiện thị ghi chú cho từng giá trị của hàm như sau:

<img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/10-17-22-49-vd.PNG" title="" alt="vd.PNG" data-align="center">

    Thật ra ở trước hàm ta chỉ cần gõ ``/**`` sau đó nhấn ``Enter`` sẽ hiện ra mẫu để ghi chú cũng như các thông số của hàm.

---

## ✿ Bài 9: KIỂU DỮ LIỆU TRONG JAVA

### 1. Các kiểu dữ liệu cơ sở

- Kiểu luận lý : ``boolean`` - lưu trữ 2 giá trị *``true``* và *``false``* 

- Kiểu ký tự : ``char`` - dùng lưu trữ một ký tự duy nhất nằm trong dấu nháy đơn `''`  

- Kiểu số: 

        - Kiểu số nguyên: ``byte``, ``short`` , ``int`` , ``long``

        - Kiểu số thực: ``float``, ``double`` ( khả năng lưu trữ của float < double )

            * ***<u>Lưu ý :</u>*** tất cả các số có dấu chấm thập phân mặc định máy hiểu là kiểu double, do đó muốn nó được hiểu là float thì thêm ``f`` đằng sau nó ( Ví dụ: ``3.5`` sẽ được hiểu là **double** nhưng ``3.5f`` sẽ được hiểu là **float** )

### 2. Wrapper Class

| Kiểu cơ sở | Wrapper class |
| ---------- | ------------- |
| boolean    | **B**oolean   |
| char       | **Character** |
| byte       | **B**yte      |
| short      | **S**hort     |
| int        | **Integer**   |
| long       | **L**ong      |
| float      | **F**loat     |
| double     | **D**ouble    |

* **Ý nghĩa Wrapper Class :** đồng thời vừa lưu trữ giá trị, đồng thời cung cấp các thuộc tính cũng như các phương thức để dễ dàng tương tác trên dữ liệu đó

* **Kiểm tra khả năng lưu trữ tối đa - tối thiểu của các kiểu cơ sở :**

```java
* Tối đa: 
System.out.println("Max của int = "+Integer.MAX_VALUE);
System.out.println("Max của double = "+Double.MAX_VALUE);
* Tối thiểu:
System.out.println("Min của int = "+Integer.MIN_VALUE);
System.out.println("Min của double = "+Double.MIN_VALUE);
```

=> Kết quả chương trình hiển thị:

<img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/13-22-46-22-wrapper%20class.PNG" title="" alt="wrapper class.PNG" data-align="center">

---

## ✿ Bài 10: ÉP KIỂU DỮ LIỆU TRONG JAVA

Trong quá trình tính toán đôi khi kết quả trả về không giống với kiểu dữ liệu mong muốn nên ta cần ép kiểu

### 1. Ép kiểu rộng

Đưa từ kiểu có vùng lưu trữ nhỏ lên kiểu có vùng lưu trữ lớn → không sợ mất mát dữ liệu

* Ví dụ: int → long → float → double

double x = (double)1 / 2;

double x = 1.0 / 2;

### 2. Ép kiểu hẹp

Đưa từ kiểu có vùng lưu trữ lớn về kiểu có vùng lưu trữ nhỏ → có thể bị mất dữ liệu

* Ví dụ: double → float → long → int

int x = (int) 1.0 / 2;

---

## ✿ Bài 11: KHAI BÁO BIẾN TRONG JAVA

### 1. Khái niệm về biến

- Biến là đơn vị lưu trữ cơ bản trong lập trình Java

- Biến là các thành phần xác định dữ liệu và được dùng để tham chiếu các giá trị xác định được tạo ra trong chương trình 

- Tất cả các biến khi sử dụng phải được khởi tạo trước

### 2. Cách thức và quy tắc đặt tên biến

**❖ <u>Cách mô tả biến</u> :**

[``datatype``] [``tên biến`` ];              ( Ví dụ: int x; )

Trong đó:

* Datatype : kiểu dữ liệu của biến

* Tên biến: tên biến cần sử dụng

❖ Nếu giá trị của biến không thay đổi trong suốt quá trình hoạt động thì gọi là hằng

**❖ <u>Quy tắc đặt tên biến</u> :** 

* Có thể sử dụng ký tự chữ, ký tự số, dấu gạch dưới ``_`` , và dấu ``$``

* Phải bắt đầu bằng ký tự chữ 

* Không được trùng với từ khoá và từ dành riêng của Java

* Có phân biệt chữ hoa - thường ( Ví dụ: int x; khác int X; nhưng không nên đặt như vầy, dễ gây lộn xộn và nhầm lẫn)

### 3. Khai báo hằng số

* Hằng số sẽ không bị đổi giá trị trong suốt quá trình thực thi phần mềm

* Sử dụng từ khoá là ``final``

☆ Ví dụ :            

```java
final double PI = 3.14;  → máy sẽ tự hiểu PI = 3.14 là một hằng số
```

lúc này nếu ta khai báo cho PI = 3.15; thì sẽ bị báo lỗi, vì PI đã được khai báo là 1 hằng số và hằng số sẽ không bị thay đổi trong suốt quá trình thực thi.

---

## ✿ Bài 12: CÁC PHÉP TOÁN TRONG JAVA

### 1. Phép gán

| Ký hiệu |
|:-------:|
| =       |
| +=      |
| -=      |
| *=      |
| /=      |

### 2. Phép toán học cơ bản

| Toán tử | Mô tả            |
|:-------:|:----------------:|
| +       | Cộng             |
| -       | Trừ              |
| *       | Nhân             |
| /       | Chia             |
| %       | Chia lấy phần dư |

### 3. Phép toán so sánh

| Toán tử |
|:-------:|
| ==      |
| !=      |
| >       |
| >=      |
| <       |
| <=      |

### 4. Phép toán logic

| Toán tử                                                                                |
|:--------------------------------------------------------------------------------------:|
| !  (Đúng thành sai, sai thành đúng)                                                    |
| &&                                                                                     |
| toán tử hoặc là 2 dấu gạch đứng                                                        |
| ?:  (Toán tử điều kiện hay toán tử ba ngôi, đúng thì làm cái này, sai thì làm cái kia) |

### 5. Phép toán tăng dần ++, giảm dần --

| Toán tử | Mô tả            |
|:-------:|:----------------:|
| ++      | Tăng một giá trị |
| --      | Giảm một giá trị |

☆ Dấu ++ hoặc -- đứng trước biến (Ví dụ: ++x, --y) : gọi là ``Prefix``

☆ Dấu ++ hoặc -- đứng sau biến (Ví dụ: x++, y--) : gọi là `Postfix` 

❖ Tuỳ vào dấu đứng trước hay sau biến mà ta thực hiện tính toán và gán giá trị

* Dấu đứng trước biến: thực hiện tính toán trước rồi mới gán giá trị mới cho biến

* Dấu đứng sau biến: ngược lại

❖ Ví dụ:

<img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/14-22-56-31-d%E1%BA%A5u%20t%C4%83ng%20gi%E1%BA%A3m%20gi%C3%A1%20tr%E1%BB%8B.PNG" title="" alt="dấu tăng giảm giá trị.PNG" data-align="center">

---

## ✿ Bài 13: NHẬP DỮ LIỆU TỪ BÀN PHÍM VỚI SCANNER

### 1. Cách import thư viện

☆ Ta gõ vài ký tự: ``Scan`` rồi tổ hợp phím ``Ctrl + Space`` → Eclipse hiển thị ra danh mục các lớp tương đương → ta chọn Scanner của java.until

### 2. Cách nhập dữ liệu từ Scanner

**❖ Đầu tiên phải tạo đối tượng Scanner để nhập liệu:**

```java
Scanner sc = new Scanner(System.in);
// sc là tên biến nên muốn đặt gì cũng được
```

**❖ Nhập số nguyên (int):**

```java
System.out.print("Nhập số nguyên:");
int a = sc.nextInt();
```

**❖ Nhập số thực (double, float):**

```java
System.out.println("Nhập số thực double: ");
double d = sc.nextDouble();
System.out.println("Nhập số thực float: ");
float f = sc.nextFloat();
```

**❖ Nhập chuỗi:**

```java
System.out.println("Mời bạn nhập một chuỗi: ");
String chuoi = sc.nextLine();
```

**❖ Nhập chuỗi và số hoặc các chuỗi liên tục:** ( gây lỗi không nhập được )

Không thể sử dụng chung một Scanner mà mỗi lần vậy nên tạo một Scanner riêng ví dụ như sau: 

```java
String s = new Scanner(System.in).nextLine();
int x = new Scanner(System.in).nextInt();
```

---

## ✿ Bài 14: CẤU TRÚC IF, IF ELSE, CẤU TRÚC 3 NGÔI

### 1. Cấu trúc if

```java
☆ if (<expression>)
{
    <statement>;
}
```

* expression: biểu thức điều kiện nào đó để kiểm tra nó đúng hoặc sai

* statement : tập các lệnh nằm trong if

<img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/15-21-48-21-s%C6%A1%20%C4%91%E1%BB%93%20kh%E1%BB%91i%20c%E1%BB%A7a%20if.PNG" title="" alt="sơ đồ khối của if.PNG" data-align="center">

### 2. Cấu trúc if - else

```java
☆ 
if (<expression>)
{
    <statement 1>;
}
else
{
    <statement 2>;  
}
```

<img src="https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/15-21-54-25-if%20else.PNG" title="" alt="if else.PNG" data-align="center">

### 3. Cấu trúc 3 ngôi

❖ Có dạng: 

```java
☆
<Điều kiện> ? <Biểu thức 1> : <Biểu thức 2>
```

Nếu ``<Điều kiện>`` đúng thì ``<Biểu thức 1>`` thực hiện, ngược lại ``<Biểu thức 2>`` thực hiện

❖ Là dạng rút gọn của if - else

---

## ✿ Bài 15: CẤU TRÚC SWITCH

### 1. Cấu trúc switch tổng quát

```java
☆ 
switch (<biến cần kiểm tra>)
{
    case <giá trị 1>:
            <công việc 1>;
            break;
    case <giá trị 2>:
            <công việc 2>;
            break;
    ...
    default:
            <công việc nếu không thuộc trường hợp nào ở trên>;
            break;
}
```

### 2. Cấu trúc switch biến thể

❖ Trong trường hợp các case nó cùng thực hiện một công việc nào đó thì ta có thể gom nhóm các case này lại thành một

```java
☆ 
switch (<biến cần kiểm tra>)
{
    case <giá trị 1>:
    case <giá trị 2>:
            <công việc X>;
            break;
    case <giá trị 3>:
    case <giá trị 4>:
            <công việc Y>;
            break;
    ...
    defaul:
            <công việc nếu không thuộc trường hợp nào ở trên>;
            break;
}
```

---

## ✿ Bài 16: VÒNG LẶP WHILE

### Vòng lặp while

**❖ Cú pháp:**

```java
☆ 
while (expression)
{
    statement;
}
```

❖ Để thoát vòng lặp dùng ``break``

❖ Để kết thúc sớm 1 vòng lặp dùng ``continue``

❖ Lệnh trong while có thể không được thực hiện lần nào

---

## ✿ Bài 17: VÒNG LẶP DO ... WHILE

### Vòng lặp do ... while

**❖ Cú pháp :**

```java
☆ 
do
{
    statement;
}
while (expression);
```

❖ Để thoát vòng lặp dùng ``break``

❖ Để kết thúc sớm 1 vòng lặp dùng ``continue``

❖ Nhận xét: vòng lặp được chạy ít nhất 1 lần

---

## ✿ Bài 18: VÒNG LẶP FOR

### Vòng lặp for

**❖ Cú pháp:** 

```java
☆
for (Exp1; Exp2; Exp3)
{
    statement;
}
```

❖ Để thoát vòng lặp dùng ``break``

❖ Để kết thúc sớm 1 vòng lặp dùng ``continue``

---

## ✿ Bài 19: Ý NGHĨA VÀ CÁCH SỬ DỤNG BREAK VÀ CONTINUE TRONG CÁC VÒNG LẶP

### 1. Cách dùng break

❖ ``break`` dùng để thoát khỏi vòng lặp chứa nó trực tiếp (không làm bất kỳ dòng lệnh nào bên dưới nữa). Thường khi ta đạt được giới hạn nào đó hoặc muốn thoát khỏi vòng lặp vĩnh cửu ta sẽ dùng ``break``

### 2. Cách dùng continue

❖ ``continue`` dùng để bỏ qua các lệnh bên dưới và chuyển qua lần lặp tiếp theo

---

## ✿ Bài 20: BÀI TẬP RÈN LUYỆN GIẢI PHƯƠNG TRÌNH BẬC 2

---

## ✿ Bài 21: BÀI TẬP RÈN LUYỆN 2 GIẢI TOÁN HỌC

⚠ Để nhập vào hay lấy 1 ký tự thôi thì dùng `charAt()`

```java
char ch = new Scanner(System.in).nextLine().charAt(0);
```

---

## ✿ Bài 22: BÀI TẬP RÈN LUYỆN 3 TÍNH DÃY TOÁN HỌC

---

## ✿ Bài 23: DANH SÁCH CÁC BÀI TẬP TỰ RÈN LUYỆN 1

---

## ✿ Bài 24: KHÁI NIỆM VỀ BIỆT LỆ

### 1. Tại sao phải xử lý biệt lệ

❖ Trong quá trình thực thi phần mềm sẽ có những lỗi phát sinh mà trong quá trình coding ta đã dự đoán (dự đoán được rồi mà chưa biết cách sửa chẳng hạn) hoặc chưa dự đoán được

❖ Việc kiểm soát các biệt lệ giúp cho phần mềm tiếp tục hoạt động nếu lỗi xảy ra hoặc cũng đưa ra các gợi ý bên phía User Problem

### 2. Các cấp độ lỗi

### 3. Cách hành xử với lỗi

❖ Unchecked error: thấy lỗi nhưng không quan tâm

❖ Checked error: có lỗi xảy ra và ta kiểm soát lỗi đó (nên)

---

## ✿ Bài 25: HỌC CÁCH SỬ DỤNG TRY ... CATCH

### **Cú pháp**

```java
☆
try 
{
    // lệnh
}
catch (Exception ex)
{
    ex.printStackTrace();
}
```

❖ Khi có lỗi xảy ra vẫn tiếp tục mà không tắt ngang phần mềm, nếu có câu lệnh phía sau ``try ... catch`` thì vẫn chạy bình thường

❖ ``try ... catch`` là trường hợp chung, giúp hiển thị tất cả các lỗi

---

## ✿ Bài 26: Ý NGHĨA CỦA TỪ KHOÁ FINALLY

``finally`` nối đuôi phía sau ``try ... catch``

```java
☆ 
try
{
    // lệnh
}
catch (Exception ex)
{
    ex.printStackTrace();
}
finally
{
    System.out.println("finally"); // câu này chỉ là ví dụ chứ không bắt buộc ghi
}
```

❖ Cho dù quá trình có lỗi hay không lỗi xảy ra thì ``finally`` vẫn được thực thi

---

## ✿ Bài 27: Ý NGHĨA CỦA THROW

```java
☆
public static void func() throws Exception // func() là hàm ví dụ
{
    try 
    {
    // lệnh
    }
    catch (Exception ex)
    {
        throw ex;
    }
}
```

❖ Sử dụng ví dụ trên để gọi cho dễ trong hàm **func()** phải gọi ``try ... catch``  ở hàm main khi gọi hàm **func()** cũng phải gọi ``try ... catch`` lần nữa.

❖ Bài này hơi khó hiểu, nếu cần thì xem clip lại cho dễ

---

## ✿ Bài 28: GỠ LỖI BẰNG CÔNG CỤ DEBUG

### 1. Cách đặt break point

❖ Muốn dừng lại kiểm tra lệnh ở dòng nào thì tạo break point ở dòng đó bằng cách đặt con trỏ văn bản đến bất kỳ vị trí nào ở dòng ta muốn đặt break point → trên thanh công cụ chọn ``Run`` → ``Toggle Breakpoint`` hoặc nhấn tổ hợp phím ``Ctrl + Shift + B``

### 2. Cách debug từng dòng

❖ Vào ``Run`` → ``Debug`` hoặc nhấn ``F11`` (phải tạo break point trước mới debug được, ko thì debug vô nghĩa)

❖ Chương trình sẽ dừng ngay dòng có break point

❖ Ý nghĩa các phím:

* ``F5`` (Step Into) : đi sâu vào từng dòng lệnh bên trong (nếu có hàm thì đi sâu vào từng dòng lệnh của hàm)

* ``F6`` (Step Over) : đi ngang qua (nếu có hàm thì đi ngang qua hàm)

* ``F8`` (Resume) : ngưng debug, quay trở lại chương trình chính

### 3. Cách xem giá trị trong khi debug

❖ Bôi đen biến cần xem → chuột phải → chọn ``Watch`` → hiển thị cho ta cửa sổ bên phải màn hình để xem giá trị của biến (ở cửa sổ này có nút ``Add new expression`` có thể nhấn vào và gõ bất kỳ biểu thức hay biến nào bạn muốn kiểm tra)

---

## ✿ Bài 29: THƯ VIỆN XỬ LÝ DỮ LIỆU SỐ

 ❖ Thư viện xử lý dữ liệu số : ``DecimalFormat``

* Ví dụ cách làm : 

```java
DecimalFormat dcf = new DecimalFormat("#.##") // lấy 2 số lẻ sau dấu chấm
double x = 3.0/8;
System.out.println(x); // trường hợp này x hiển thị ra bình thường có thể có nhiều số lẻ sau dấu chấm
System.out.println(dcf.format(x)); // x hiển thị lấy 2 số lẻ sau dấu chấm
```

❖ Làm ngăn cách chữ số:

* Ví dụ cứ 3 chữ số ngăn cách nhau bởi một dấu phẩy :

```java
DecimalFormat dcf = new DecimalFormat("#,###");
DecimalFormatSymbols dfs = new DecimalFormatSymbols(Locale.getDefault());
dfs.setGroupingSeparator(','); // muốn thay dấu khác thì thay ở đây
int x = 1243532523;
dcf.setDecimalFormatSymbols(dfs);
System.out.println(dcf.format(x));
```

---

## ✿ Bài 30: THƯ VIỆN XỬ LÝ NGÀY THÁNG

### 1. Calendar

❖ Lấy ngày tháng năm hiện tại :

```java
Calendar cal = Calendar.getInstance(); // giúp truy xuất được ngày tháng năm hiện tại của máy tính 
```

❖ Lấy từng tiêu chí:

```java
cal.get(Calendar.YEAR); // lấy năm
cal.get(Calendar.MONTH); // lấy tháng
cal.get(Calendar.DAY_OF_MONTH); // lấy ngày
```

❖ Thay đổi tiêu chí:

```java
cal.set(Calendar.YEAR,2001); // đổi năm _ tương tự với mấy cái khác
```

❖Lấy ngày tháng năm:

```java
Date t = cal.getTime();
```

### 2. SimpleDateFormat

❖ Dùng để định dạng cách hiển thị ngày tháng năm

* Ví dụ :

```java
☆
Calendar cal = Calendar.getInstance();
Date t = cal.getTime();
SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
System.out.println(sdf.format(t));
```

❖ Ngoài ra còn có định dạng giờ phút giây:

* ``HH`` : định dạng 24 giờ

* ``hh`` : định dạng 12 giờ

* ``mm`` : phút

* ``ss`` : giây

* ``aaa`` : giúp hiện thị AM hay PM của giờ

### 3. Code để tính tuổi

☆

```java
Calendar cal = Calendar.getInstance();
int yearNow = cal.get(Calendar.YEAR);

System.out.println("Mời bạn nhập năm sinh (dd/MM/yy) : ");
String ns = new Scanner(System.in).nextLine();

SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
try
{
    Date birthday = sdf.parse(ns);
    cal.setTime(birthday);
    int yearNs = cal.get(Calendar.YEAR);

    int tuoi = yearNow - yearNs;
    System.out.println("Bạn "+tuoi+" tuổi");
}
catch (ParseException e)
{
    e.printStackTrace();
}
```

---

## ✿ Bài 31: THƯ VIỆN TOÁN HỌC

| Tên phương thức | Mô tả                                  |
| --------------- | -------------------------------------- |
| PI              | Trả về giá trị PI                      |
| abs(a)          | Trị tuyệt đối của a                    |
| max(a, b)       | Trả về giá trị lớn nhất giữa a và b    |
| min(a, b)       | Trả về giá trị nhỏ nhất giữa a và b    |
| sqrt(a)         | Căn bậc 2 của a                        |
| pow(x, y)       | Luỹ thừa x mũ y                        |
| sin(radian)     | Tính sin, radian = Math.PI * góc / 180 |
| cos(radian)     | Tính cos                               |
| tan(radian)     | Tính tan                               |

**❖ Cú pháp:**        ``Math.<tên phương thức>``

---

## ✿ Bài 32: THƯ VIỆN XỬ LÝ SỐ NGẪU NHIÊN

**❖ Random : số nguyên**

```java
☆
Random rd = new Random();
int x = rd.nextInt(n);
❖ Sẽ trả về số ngẫu nhiên từ [0...n-1]
❖ Ví dụ:
[0...100] → rd.nextInt(101)
[-100...100] → -100 + rd.nextInt(201) // lý giải như sau: ta có maximum của 201 là 200, 200 - 100 = 100 là bằng giới hạn dưới; minimum của 201 là 0, 0 + (-100) = -100 bằng với giới hạn trên
[-100...-50] → -100 + rd.nextInt(51)
```

**❖ Random : số thực `[0 ... 1)`**

```java
☆
Random rd = new Random();
double x = rd.nextDouble();
❖ Ví dụ: 
[0...10) → rd.nextDouble()*10;
```

---

## ✿ Bài 33: THƯ VIỆN XỬ LÝ CHUỖI

### 1. StringBuilder

❖ Là một lớp dùng quản lý chuỗi có thể thay đổi kích thước và nội dung

```java
☆ Khởi tạo:
StringBuilder() // khởi tạo mặc định, không đối số. Có thể lưu giữ được 16 ký tự
StringBuilder(int capacity) // Tạo ra một đối tượng. Có thể lưu giữ được capacity ký tự
StringBuilder(String s) // Tạo ra một đối tượng. Lấy thông tin từ chuỗi s

☆ Phương thức:
append() // nối chuỗi
insert() // chèn chuỗi 
delete() // xoá chuỗi
reverse() // đảo chuỗi

Còn có thêm 1 cái toString() là để lấy chuỗi ra
```

❖ Ví dụ cách dùng:

```java
StringBuilder sb = new StringBuilder(); // khởi tạo vầy nè
sb.append("Welcome to "); // rồi muốn gọi phải làm vầy nè, chứ không có append() không đâu
sb.append("Java "); 
sb.append("world");
String s = sb.toString();
System.out.println(s);
* hoặc xuất làm vầy cũng được:
System.out.println(sb.toString());
* hoặc 
System.out.println(sb);

→ Kết quả sẽ là : Welcome to Java world
```

```java
❖ Đối với insert(): 
sb.insert(11, "xxx"); 
/* 
có nghĩa là ở vị trí thứ 11 của chuỗi hiện tại, ta chèn ký tự xxx vào 
(như trong chuỗi thì ký tự đầu tiên sẽ là 0 chứ không phải 1) 
Lấy ví dụ trên thì xxx sẽ được thêm vào như sau Welcome to xxx
*/
❖ Đối với delete():
sb.delete(11, 14);
/*
có nghĩa là xoá từ 3 phần tử từ 11
Như trên sẽ xoá được xxx
*/ 
```

### 2. StringTokenizer

❖ Là một lớp được dùng để tách chuỗi theo một yêu cầu nào đó

```java
❖ Ví dụ tách chuỗi theo khoảng trắng:
String s = "Lập trình Java";
StingTokenizer st = new StringTokenizer(s); // mặc định không có đối số thứ 2 thì tách theo khoảng trắng
while (st.hasMoreTokens())
    System.out.println(sr.nextToken());

❖ Ví dụ tách chuỗi theo yêu cầu khác khoảng trắng, ở đây là dấu chấm phẩy:
s = "Lập;trình;Java";
st = new StringTokenizer(s, ";");
while (st.hasMoreTokens())
    System.out.println(sr.nextToken());

❖ Ở đối số thứ 2 ta không chỉ có thể tách theo 1 quy luật, mà ta có thể tách theo nhiều quy luật khác nhau:
Ví dụ như vừa tách theo dấu ";" vừa tách theo dấu "!" ta làm như sau:
String s = "Obama;Putin;Kim Jong Un!Thanh Truc";
StringTokenizer token2 = new StringTokenizer(s,";!"); // ở đối số thứ 2 cứ khai báo 2 dấu là được, không có gì khó khăn
while (token2.hasMoreTokens())
{
    String value = token2.nextToken();
    System.out.println(value);
}
/*
Tương tự như ví dụ trên, nếu ta muốn thêm tách nhau bằng khoảng trắng 
thì ở đối số thứ 2 ta thêm vào (s, ";! ") 
vậy là xong
*/
```

---

## ✿ Bài 34: GIỚI THIỆU CHUỖI TRONG JAVA

### 1. Cách khai báo và sử dụng chuỗi

❖ Khai báo chuỗi :

* Trong Java, String là lớp quản lý dữ liệu văn bản

* Khai báo:

```java
☆
String s1 = new String(); // tạo ra 1 đối tượng s1 có khả năng lưu chuỗi
String s = "OBAMA";
* s sẽ quản lý phần tử đầu tiên, ví dụ như trên, s quản lý phần tử đầu tiên là O
```

### 2. Kiểm tra chiều dài chuỗi

❖ Ví dụ: 

```java
☆
String s = "OBAMA";
int len = s.length(); // len sẽ bằng 5
* khoảng trắng trong chuỗi thì cũng được xem như một ký tự
```

### 3. Ví dụ chạy chương trình

❖ Ta chạy chương trình như sau: (xem kỹ hơn ở clip 34)

* **<u>Ví dụ 1 : </u>**

```java
☆
String s1 = new String();
String s2 = new String("Obama ");
String s3 = "Obama";
System.out.println("Chiều dài của s1 = "+s1.length());
System.out.println("Chiều dài của s2 = "+s2.length());
System.out.println("Chiều dài của s3 = "+s3.length());

→ Kết quả chương trình khi chạy hiển thị:
Chiều dài của s1 = 0
Chiều dài của s2 = 6
Chiều dài của s3 = 5
```

* **<u>Ví dụ 2 :</u>**

```java
☆
String s1 = new String();
String s2 = new String("Obama");
String s3 = "Obama";
System.out.println("Chiều dài của s1 = "+s1.length());
System.out.println("Chiều dài của s2 = "+s2.length());
System.out.println("Chiều dài của s3 = "+s3.length());
if (s2 == s3)
{
    System.out.println("s2 bằng s3");
}
else 
{
    System.out.println("s2 không bằng s3");
}

→ Kết quả là:
Chiều dài của s1 = 0
Chiều dài của s2 = 5
Chiều dài của s3 = 5
s2 không bằng s3
```

→ Ta thấy là chuỗi s2 và s3 đều có cùng giá trị là ``Obama`` , tuy nhiên kết quả lại là s2 không bằng s3, lý giải như sau: vì đây là 2 đối tượng nằm trên 2 ô nhớ khác nhau nên nó khác nhau hoàn toàn

* Ta làm như vầy thì khác nè:

```java
☆
String s1 = new String();
String s2 = new String("Obama");
String s3 = "Obama";
System.out.println("Chiều dài của s1 = "+s1.length());
System.out.println("Chiều dài của s2 = "+s2.length());
System.out.println("Chiều dài của s3 = "+s3.length());
if (s2 == s3)
{
    System.out.println("s2 bằng s3");
}
else 
{
    System.out.println("s2 không bằng s3");
}
if (s2.equals(s3))
{
    System.out.println("giá trị s2 bằng s3");
}
else 
{
    System.out.println("giá trị s2 không bằng s3");    
}

→ Kết quả là:
Chiều dài của s1 = 0
Chiều dài của s2 = 5
Chiều dài của s3 = 5
s2 không bằng s3
giá trị s2 bằng s3
```

→ Ta thấy giá trị của s2 bằng s3 nhưng s2 không bằng s3 do nó nằm trên 2 ô nhớ khác nhau

→ Muốn so sánh giá trị ta dùng hàm ``equals``

---

## ✿ Bài 35: HÀM TÌM CHUỖI

### 1. indexOf

❖ Trả về vị trí đầu tiên tìm thấy, không tìm thấy trả về `-1`

```java
☆
String s = "Hello everybody !";
int i = 0
i = s.indexOf("e"); // trả về i = 1 (vị trí đầu tiên tìm thấy e)
```

### 2. lastIndexOf

❖ Trả về vị trí cuối cùng tìm thấy, không thấy cũng trả về `-1`

```java
☆
String s = "Hello everybody !";
int i = 0;
i = s.lastIndexOf("e"); // trả về i = 8
```

* Lưu ý là không chỉ tìm được ký tự mà ta cũng tìm được 1 từ ví dụ như trong chuỗi s tìm "body" thì vẫn được, nó sẽ trả về vị trí của từ đầu tiên trong chuỗi ta tìm, ví dụ như từ "body" thì trả về vị trí của từ b trong body

### 3. contains

❖ Kiểm tra chuỗi con có tồn tại trong chuỗi s, có trả về `true` , không trả về `false`

```java
☆
String s = "Taurus love Zen";
if (s.contains("love") == true)
    System.out.println("có chữ love trong chuỗi");
else
    System.out.println("không có chữ love trong chuỗi");

→ Kết quả sẽ là:
có chữ love trong chuỗi
```

### 4. Cách tìm số lượng từ bất kỳ có trong chuỗi

❖ Sử dụng StringTokenizer: 

* Với `contains`:

```java
☆
String s = "Lê Tuấn Kiệt, Thanh Trúc yêu anh yêu anh yêu anh !!!";
StringTokenizer token = new StringTokenizer(s);
int dem = 0;
while (token.hasMoreTokens())
{
    String value = token.nextToken();
    if (value.contains("anh"))
    {
        dem++;
    }
}
System.out.println("Tìm thấy "+dem+" lần từ [anh]");

→ Kết quả hiển thị :
Tìm thấy 4 lần từ [anh]
```

* Với `equals`: 

```java
```java
☆
String s = "Lê Tuấn Kiệt, Thanh Trúc yêu anh yêu anh yêu anh !!!";
StringTokenizer token = new StringTokenizer(s);
int dem = 0;
while (token.hasMoreTokens())
{
    String value = token.nextToken();
    if (value.equals("anh"))
    {
        dem++;
    }
}
System.out.println("Tìm thấy "+dem+" lần từ [anh]");

→ Kết quả hiển thị :
Tìm thấy 3 lần từ [anh]
```

→ Kết quả trên là dễ hiểu vì với `contains` giúp ta tìm được cả chuỗi con có tồn tại trong chuỗi (trong từ "Thanh" có tồn tại từ "anh" cần tìm ), nhưng với `equals` nó chỉ tìm đúng từ "anh" mà nó cần tìm 

---

## ✿ Bài 36: HÀM TRÍCH LỌC CHUỖI

### **❖ subString**

1. **Một đối số :** Lấy bên phải chuỗi

```java
☆
String s = "Xin chào Obama! Tui là Putin";
String s2 = s.substring(9);
System.out.println(s2);

→ Kết quả hiển thị :
Obama! Tui là Putin

* Từ vị trí số 9 là vị trị của O lấy đến hết chuỗi
* Cẩn thận nếu vượt quá giới hạn chuỗi thì sẽ bị báo lỗi ngay, ví dụ như chuỗi dài 11 nhưng lại lấy subString(13) là không được liền
```

2. **Hai đối số :** Lọc giữa chuỗi

```java
☆
String s = "Xin chào Obama! Tui là Putin";
String s3 = s.substring(9,14); → có nghĩa là lấy muốn lấy 5 ký tự thì 14 - 9 = 5
System.out.println(s3);

→ Kết quả hiển thị :
Obama
```

---

## ✿ Bài 37: HÀM ĐỔI CHUỖI

### 1. replace

Đổi tất cả chuỗi bên trong thoả mãn một tính chất nào đó thành chuỗi mới

```java
☆
String s = "Xin chào Obama! Tui là Putin";
s = s.replace("Obama", "Kim Jong Un"); // đối số đầu tiên là chuỗi cũ, đối số thứ 2 là chuỗi mới
System.out.println(s);

→ Kết quả hiển thị:
Xin chào Kim Jong Un! Tui là Putin
```

* Nếu trong chuỗi này có nhiều chữ Obama thì tất cả đều được đổi thành Kim Jong Un

### 2. replaceFirst

Chỉ đổi chuổi đầu tiên thoả mãn tính chất thành chuỗi mới

```java
☆
String s = "Obama Xin chào Michelle Obama";
s = s.replaceFirst("Obama", "Putin"); // phải gán chuỗi mới cho s nè, không thì nó cũng như không hà
System.out.println(s);

→ Kết quả hiển thị:
Putin Xin chào Michelle Obama
```

---

## ✿ Bài 38: HÀM XOÁ KHOẢNG TRẮNG DƯ THỪA

### ❖ trim : xoá khoảng trắng dư thừa bên trái và bên phải chuỗi

```java
String s = "       Nguyễn Huỳnh Thanh Trúc         ";
System.out.println(s);
System.out.println("=> Chiều dài = " +s.length());
s = s.trim();
System.out.println(s);
System.out.println("=> Chiều dài = " +s.length());

→ Kết quả hiển thị: 
       Nguyễn Huỳnh Thanh Trúc         
=> Chiều dài = 39
Nguyễn Huỳnh Thanh Trúc
=> Chiều dài = 23
```

Thật sự là nó chỉ xoá khoảng trắng bên phải và trái chuỗi thôi, không xoá giữa chuỗi, ví dụ như có khoảng trắng ở giữa chuỗi nó vẫn giữ nguyên nha, như sau: 

```java
String s = "       Nguyễn      Huỳnh       Thanh     Trúc         ";
System.out.println(s);
System.out.println("=> Chiều dài = " +s.length());
s = s.trim();
System.out.println(s);
System.out.println("=> Chiều dài = " +s.length());

→ Kết quả hiển thị:
       Nguyễn      Huỳnh       Thanh     Trúc         
=> Chiều dài = 54
Nguyễn      Huỳnh       Thanh     Trúc
=> Chiều dài = 38
```

### ❖ Xoá khoảng trắng bên trái hoặc bên phải

* **Xoá khoảng trắng bên trái :**

```java
String s = "     Nguyễn Huỳnh Thanh Trúc        ";
int vtLeft = 0;
int i = 0; // khai báo i ở ngoài vì có thể i không đúng để chạy vòng for luôn, nên có giá trị i = 0 ở ngoài nha
for (i = 0; i < s.length(); i++)
{
    char c = s.charAt(i); // charAt() là lệnh để lấy ký tự
    if (c == ' ')
        vtLeft = i;
    else 
        break;
}
s = s.substring(i);
System.out.println(s);
```

* **Xoá khoảng trắng bên phải :**

```java
String s = "     Nguyễn Huỳnh Thanh Trúc        ";
int vtRight = 0;
int i = 0; // khai báo i ở ngoài vì có thể i không đúng để chạy vòng for luôn, nên có giá trị i = 0 ở ngoài nha
for (i = s.length(); i >= 0; i--)
{
    char c = s.charAt(i); // charAt() là lệnh để lấy ký tự
    if (c == ' ')
        vtRight = i;
    else 
        break;
}
s = s.substring(0, vtRight);
System.out.println(s);
```

---

## ✿ Bài 39: HÀM SO SÁNH CHUỖI

### 1. compareTo

❖ So sánh có phân biệt chữ hoa - thường

```java
☆
String s1 = "Tuấn Kiệt";
String s2 = "Thanh Trúc";
int x = s1.compareTo(s2);

→ 
* Bằng 0 khi s1 = s2
* >0 khi s1 > s2
* <0 khi s1 < s2
```

### 2. compareToIgnoreCase

❖ So sánh không phân biệt hoa - thường

```java
Tương tự như cái kia thôi:
* Bằng 0 khi s1 = s2
* >0 khi s1 > s2
* <0 khi s1 < s2
```

---

## ✿ Bài 40: CÁCH NỐI VÀ CHÈN CHUỖI

### 1. Cách nỗi chuỗi bằng dấu +

```java
String s = "Obama";
s = s+" Putin";
System.out.println(s);

→ Obama Putin
```

* **Lưu ý :** trong quá trình lập trình mà xử lý chuỗi, nối chuỗi nhiều như lấy dữ liệu từ internet hay đọc dữ liệu từ một file thì ta không nên dùng dấu cộng. Vì mỗi khi dùng dấu cộng nó sẽ phát sinh ra một đối tượng chuỗi => rất tốn bộ nhớ, chạy rất chậm (test trên tập dữ liệu lớn sẽ thấy được sự bất lợi)

* Ta có giải pháp khắc phục này chính là ở phần 2

### 2. Cách nối chuỗi bằng StringBuilder : append()

( Bài 33 học rồi)

### 3. Cách chèn chuỗi: insert()

(Ở bài 33 có luôn)

---

## ✿ Bài 41: CÁCH TÁCH CHUỖI

### 1. Cách tách chuỗi với split (công dụng tương tự StringTokenizer)

❖ Các version JDk >= 1.4 có hỗ trợ split để tách chuỗi

```java
☆
String s = "Obama;Putin;Kim Jong Un";
String []arr = s.split(";"); // ở đây có thể ghi theo kiểu arr[] (học kỹ hơn ở bài mảng)
for (String name: arr)  // name là một tên biến thôi, đặt gì khác cũng được
    System.out.println(name);

→ 
Obama
Putin
Kim Jong Un
```

### 2. Cách tách chuỗi với StringTokenizer

❖ Các version JDK < 1.4 thì sử dụng StringTokenizer (đã học ở bài 33: Thư viện xử lý chuỗi)

### 3. Bài chạy ví dụ

```java
☆
String s = "36;Nguyễn Huỳnh Thanh Trúc;12B2"; 
String []arr = s.split(";");
if (arr.length == 3)
{
    System.out.println("Số thứ tự: "+arr[0]);
    System.out.println("Tên: "+arr[1]);
    System.out.println("Lớp: "+arr[2]);
}
System.out.println("-----------------------------------");
for(int i = 0; i < arr.length; i++)
    System.out.println(arr[i]);
System.out.println("-----------------------------------");
for (String x : arr)
    System.out.println(x);

→
Số thứ tự: 36
Tên: Nguyễn Huỳnh Thanh Trúc
Lớp: 12B2
-----------------------------------
36
Nguyễn Huỳnh Thanh Trúc
12B2
-----------------------------------
36
Nguyễn Huỳnh Thanh Trúc
12B2
```

### ⚠ Trường hợp đặc biệt trong dùng split: chuỗi chứa ký tự đặc biệt

* **Ví dụ:**

```java
☆ Khi sử dụng tách bởi dấu chấm: 
        String s = "36.Nguyễn Huỳnh Thanh Trúc.12B2"; 
        String []arr = s.split(".");
        if (arr.length == 3)
        {
            System.out.println("Số thứ tự: "+arr[0]);
            System.out.println("Tên: "+arr[1]);
            System.out.println("Lớp: "+arr[2]);
        }
        System.out.println("-----------------------------------");
        for(int i = 0; i < arr.length; i++)
            System.out.println(arr[i]);
        System.out.println("-----------------------------------");
        for (String x : arr)
            System.out.println(x);

→ Kết quả hiển thị: 
-----------------------------------
-----------------------------------
```

→ Vì dấu chấm như là một ký tự đặc biệt , ta khắc phục như sau: 

```java
☆
String s = "36.Nguyễn Huỳnh Thanh Trúc.12B2"; 
String []arr = s.split("\\.");
if (arr.length == 3)
{
    System.out.println("Số thứ tự: "+arr[0]);
    System.out.println("Tên: "+arr[1]);
    System.out.println("Lớp: "+arr[2]);
}
System.out.println("-----------------------------------");
for(int i = 0; i < arr.length; i++)
    System.out.println(arr[i]);
System.out.println("-----------------------------------");
for (String x : arr)
    System.out.println(x);

→ Kết quả hiển thị đúng mong muốn: 
Số thứ tự: 36
Tên: Nguyễn Huỳnh Thanh Trúc
Lớp: 12B2
-----------------------------------
36
Nguyễn Huỳnh Thanh Trúc
12B2
-----------------------------------
36
Nguyễn Huỳnh Thanh Trúc
12B2
```

→ Nếu như ta bị nối bởi một ký tự đặc biệt nào đó thì ta phải để ký tự `\\` đằng trước nó  để máy tính hiểu rằng đây là một ký tự tách chuỗi bình thường của chúng ta

⚠ Nếu cẩn thận , trong mọi trường hợp bạn nên thêm `\\` đằng trước để bảo đảm không bị sai

---

## ✿ Bài 42: HÀM ĐỔI CHỮ HOA - THƯỜNG

### 1. toUpper

❖ Đổi chữ thường thành chữ hoa (chữ đã hoa rồi thì giữ nguyên thôi)

❖ Sử dụng lệnh toUpperCase()

```java
☆ 
String s = "obama".toUpperCase();
System.out.println(s);

→ OBAMA
```

### 2. toLower

❖ Đổi chữ thường thành hoa

❖ Sử dụng lệnh toLowerCase()

```java
String s = "PUTIN".toLowerCase();
System.out.println(s);

→ putin
```

### ⚠ Biến đổi chữ đầu tiên trong chuỗi thành chữ hoa sử dụng hàm replaceFirst() :

```java
String s = "thanh Trúc";
s = s.replaceFirst((s.charAt(0)+""), (s.charAt(0)+"").toUpperCase());
System.out.println(s);

→ Thanh Trúc
```

* **<u>Lý giải đoạn code như sau :</u>** vì hàm replaceFirst() chỉ xử lý chuỗi cho nên ta nối thêm dấu nháy đôi vào để đưa ký tự mà ta lấy ra trở thành chuỗi 

---

## ✿ Bài 43: BÀI TẬP RÈN LUYỆN TÁCH LẤY TÊN BÀI HÁT

---

## ✿ Bài 44: BÀI TẬP RÈN LUYỆN KIỂM TRA CHUỖI PANLYNDRONME

❖ Chuỗi panlyndrome là chuỗi dù đọc ngược hay đọc xuôi cũng có kết quả y như nhau. Ví dụ: madam, radar,..

---

## ✿ Bài 45: BÀI TẬP RÈN LUYỆN TỐI ƯU CHUỖI

---

## ✿ Bài 46: CÁC BÀI TẬP RÈN LUYỆN TỰ GIẢI

---

## ✿ Bài 47: KHÁI NIỆM VỀ MẢNG

### 1. Khái niệm về mảng

❖ Là một loại biến đặc biệt, bao gồm một dãy các ô nhớ có nhiều ô nhớ con cho phép biểu diễn thông tin dạng danh sách trong thực tế

❖ Các phần tử trong mảng có cùng kiểu dữ liệu với nhau

❖ Một số mảng khác: Số thực , mảng chuỗi

❖ Thông thường muốn tạo mảng ta phải biết được khả năng lưu trữ tối đa của nó

### 2. Mục đích dùng mảng

❖ Là cách tốt nhất để quản lý nhiều phần tử dữ liệu có cùng kiểu tại một thời điểm

---

## ✿ Bài 48: CÁCH KHAI BÁO VÀ CẤP PHÁT BỘ NHỚ CHO MẢNG

### 1. Khai báo mảng như thế nào

❖ Khai báo không khởi tạo kích thước và giá trị :

```java
☆ Kiểu dữ liệu []Tên mảng;
☆ Kiểu đữ liệu Tên mảng[];
Ví dụ:
int []M;
int M[];
```

### 2. Cấp phát bộ nhớ sử dụng mảng

❖ Khai báo và khởi tạo kích thước nhưng không có giá trị ban đầu

```java
☆ Kiểu dữ liệu []Tên mảng = new Kiểu dữ liệu[Số phần tử];
☆ Kiểu dữ liệu Tên mảng[] = new Kiểu dữ liệu[Số phần tử];
Ví dụ:
int []a = new int[5];
int a[] = new int[5];
```

⚠ Khai báo `int []M;` rồi cho người dùng nhập vào số phần tử n của mảng rồi cấp phát `M = new int [n];` cũng được

❖ Khai báo có khởi tạo kích thước và khởi tạo giá trị ban đầu:

```java
☆ Kiểu dữ liệu []Tên mảng = new Kiểu dữ liệu[]{giá trị 1, giá trị 2, giá trị 3, ...};
☆ Kiểu dữ liệu []Tên mảng = {giá trị 1, giá trị 2, giá trị 3, ...};
Ví dụ:
int []a = new int[]{2,3,5,11};
int []a = {2,3,4,11};
```

⚠ Nhớ là khai báo kiểu String nếu muốn ghi một chuỗi như Trúc thì phải đặt trong dấu ngoặc kép:

```java
String []M = {"Trúc", "Kiệt", "Thạnh", "My", "Kiên"};
```

---

## ✿ Bài 49: TRUY XUẤT VÀ THAO TÁC TRÊN MẢNG

### 1. Cách lấy đữ liệu từ mảng

* Truy xuất giá trị một phần tử:
  
  `TênMảng [vị_trí_i]`
  
  * Vị trí của 1 phần tử bắt đầu từ 0
  
  * vị_trí_i có giá trị trong khoảng từ `0` đến `số phần tử -1`

### 2. Cách thay đổi dữ liệu trên mảng

* Ví dụ ban đầu mảng có `M[3] = 0`, muốn thay đổi giá trị 0 thành 304 thì đơn giản: `M[3] = 304` , vậy là xong

* Tổng quát : `M[i] = value`

### 3. Cách xuất dữ liệu mảng: for, for giá trị

**❖ Có 2 cách phổ biến :**

* Cách 1:  
  
  ```java
  for (int i = 0; i < TênMảng.length; i++)
  {
      // Xử lý phần tử TênMảng[i]
  }
  ```

* Cách 2:  Java có hỗ trợ một lệnh for mới, đó là duyệt từng giá trị trong một danh sách nào đó
  
  ```java
  for (int i : TênMảng)
  {
      // Xử lý phần tử i
  }
  ```
  
  * Ví dụ: 
    
    ```java
    int []M = {1, 2, 3, 4, 5};
    for (int i : M)
        System.out.println(i);
    ```

⚠ Kiểu dữ liệu và i ở Cách 1 và Cách 2 có ý nghĩa khác nhau: 

* Ở cách 1: i mang kiểu đữ liệu int vì nó thể hiện cho <u>**vị trí**</u>

* Ở cách 2: i mang kiểu dữ liệu int thể hiện cho từng **<u>giá trị</u>** trong mảng, có nghĩa kiểu dữ liệu của nó phụ thuộc vào kiểu dữ liệu của mảng, i đại điện cho từng **<u>giá trị</u>** trong mảng

⚠Cách sử dụng cho phù hợp: 

* Nếu chỉ đơn thuần xuất thông tin ra mà không quan tâm đến chỉ số cũng không muốn thay đổi thông tin thì nên dùng for ở `Cách 2`

* Khi duyệt mảng vừa lấy giá trị, vừa lấy chỉ số và muốn thay đổi các thông tin nên dùng for ở `Cách 1`

---

## ✿ Bài 50: TÌM KIẾM TRÊN MẢNG

Xem clip `Bài 50` để biết 2 cách tìm kiếm trên mảng (cũng dễ hiểu lắm):

* Tìm xem phần tử muốn tìm có xuất hiện trong mảng hay không

* Tìm xem phần tử cần tìm có trong mảng hay không, xuất hiện trong mảng bao nhiêu lần, ở đâu

---

## ✿ Bài 51: Sắp xếp mảng

### 1. Sắp xếp mảng dùng các giải thuật sắp xếp

Ở đây chỉ giới thiệu code cho biết và tham khảo, học kỹ hơn ở môn `Cấu trúc dữ liệu và giải thuật`

* BubbleSort:
  
  ```java
  void BubbleSort (int []M)
  {
      int i, j;
      for (i = 0; i < M.length - 1; i++)
      {
          for (j = M.length - 1; j > i; j--)
          {
              if (M[j] < M[j - 1]) // nếu có nghịch thế
              {
                  int temp = M[j];
                  M[j] = M[j - 1];
                  M[j - 1] = temp;
              }
          }
      }
  }
  ```

* SelectionSort:
  
  ```java
  void SelectionSort (int []M)
  {
      int min;
      for (int i = 0; i < M.length - 1; i++)
      {
          min = i;
          for (int j = i + 1; j < M.length; j++)
          {
              if (M[j] < M[min])
                  min = j;
          }
          if (min != 1)
          {
              int temp = M[i];
              M[i] = M[min];
              M[min] = temp;
          }
      }
  }
  ```

* QuickSort: (khó)
  
  ```java
  void QuickSort (int []M, int left, int right)
  {
      if (left >= right) return;
      int pivot = M[(left + right) / 2];
      int i = left, j = right;
      do
      {
          while (M[i] < pivot) i++;
          while (M[j] > pivot) j--;
          if (i <= j)
          {
              int temp = M[i];
              M[i] = M[j];
              M[j] = temp;
              i++;
              j--;
          }
      }
      while (i < j);
      QuickSort(M, left, j);
      QuickSort(M, i, right);
  }
  
  Khi gọi hàm truyền đối số: QuickSort(M, 0, M.length - 1)
  ```

### 2. Sắp xếp mảng dựa vào các thư viện có sẵn

Dùng `Arrays.sort(TênMảng);`

* Ví dụ: 
  
  ```java
  int M[] = {2, 5, -2, 6, -3, 8, 0, 7, -9, 4};
  Arrays.sort(M);
  ```

---

## ✿ Bài 52: CÁC HẠN CHẾ CỦA MẢNG

* Mảng có kích cỡ và số chiều cố định nên khó khăn trong việc mở rộng ứng dụng

* Các phần tử được đặt và tham chiếu một cách liên tiếp nhau trong bộ nhớ nên khó khăn cho việc xoá một phần tử ra khỏi mảng

* Giải thích khó khăn trong trường hợp xoá, chèn giữa, thêm vượt quá kích thước mảng 

---

## ✿ Bài 53: BÀI TẬP RÈN LUYỆN VỀ MẢNG

⚠ Xuất hiện thêm câu lệnh: 

`System.err.println("")` và `System.exit(0)`

---

## ✿ Bài 54: CÁC BÀI TẬP TỰ RÈN LUYỆN VỀ MẢNG

![bài 54.1.PNG](https://raw.githubusercontent.com/nhttruc/Image/master/2020/09/02-13-46-06-b%C3%A0i%2054.1.PNG)

![bài 54.2.PNG](https://raw.githubusercontent.com/nhttruc/Image/master/2020/09/02-13-46-37-b%C3%A0i%2054.2.PNG)

---

## ✿ Bài 55: LÝ DO SỬ DỤNG COLLECTION

s





☆❖→✿❀⚠![icons8_java_32px.png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/23-15-46-06-icons8_java_32px.png)![icons8_java_48px_1.png](https://raw.githubusercontent.com/nhttruc/Image/master/2020/08/23-15-44-20-icons8_java_48px_1.png)
