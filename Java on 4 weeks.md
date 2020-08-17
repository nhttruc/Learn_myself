# Java cơ bản trong 4 tuần

## Bài 1: GIỚI THIỆU NGÔN NGỮ LẬP TRÌNH `Java`

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

## Bài 2: CÁC CÔNG CỤ LẬP TRÌNH VỚI JAVA

--- 

## Bài 3: CÀI ĐẶT JDK

---

## Bài 4: CÀI ĐẶT BIẾN MÔI TRƯỜNG CHO JAVA

---

## Bài 5: CÁCH CHẠY CHƯƠNG TRÌNH JAVA BẰNG LỆNH COMMAND LINE

--- 

## Bài 6: CÁCH CÀI ĐẶT VÀ SỬ DỤNG CÔNG CỤ ECLIPSE

---

## Bài 7: CÁCH XUẤT DỮ LIỆU RA MÀN HÌNH

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

## Bài 8: CÁCH GHI CHÚ LỆNH QUAN TRỌNG TRONG JAVA

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

## Bài 9: KIỂU DỮ LIỆU TRONG JAVA

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

## Bài 10: ÉP KIỂU DỮ LIỆU TRONG JAVA

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

## Bài 11: KHAI BÁO BIẾN TRONG JAVA

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

### Bài 12: CÁC PHÉP TOÁN TRONG JAVA

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
|                                                                                        |
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

### Bài 13: NHẬP DỮ LIỆU TỪ BÀN PHÍM VỚI SCANNER

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

## Bài 14: CẤU TRÚC IF, IF ELSE, CẤU TRÚC 3 NGÔI

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

## Bài 15: CẤU TRÚC SWITCH

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

## Bài 16: VÒNG LẶP WHILE

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

## Bài 17: VÒNG LẶP DO ... WHILE

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

## Bài 18: VÒNG LẶP FOR

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

## Bài 19: Ý NGHĨA VÀ CÁCH SỬ DỤNG BREAK VÀ CONTINUE TRONG CÁC VÒNG LẶP

### 1. Cách dùng break

❖ ``break`` dùng để thoát khỏi vòng lặp chứa nó trực tiếp (không làm bất kỳ dòng lệnh nào bên dưới nữa). Thường khi ta đạt được giới hạn nào đó hoặc muốn thoát khỏi vòng lặp vĩnh cửu ta sẽ dùng ``break``

### 2. Cách dùng continue

❖ ``continue`` dùng để bỏ qua các lệnh bên dưới và chuyển qua lần lặp tiếp theo

---

## Bài 20: BÀI TẬP RÈN LUYỆN GIẢI PHƯƠNG TRÌNH BẬC 2

---

## Bài 21: BÀI TẬP RÈN LUYỆN 2 GIẢI TOÁN HỌC

---

## Bài 22: BÀI TẬP RÈN LUYỆN 3 TÍNH DÃY TOÁN HỌC

---

## Bài 23: DANH SÁCH CÁC BÀI TẬP TỰ RÈN LUYỆN 1

---

## Bài 24: KHÁI NIỆM VỀ BIỆT LỆ

### 1. Tại sao phải xử lý biệt lệ

❖ Trong quá trình thực thi phần mềm sẽ có những lỗi phát sinh mà trong quá trình coding ta đã dự đoán (dự đoán được rồi mà chưa biết cách sửa chẳng hạn) hoặc chưa dự đoán được

❖ Việc kiểm soát các biệt lệ giúp cho phần mềm tiếp tục hoạt động nếu lỗi xảy ra hoặc cũng đưa ra các gợi ý bên phía User Problem

### 2. Các cấp độ lỗi

### 3. Cách hành xử với lỗi

❖ Unchecked error: thấy lỗi nhưng không quan tâm

❖ Checked error: có lỗi xảy ra và ta kiểm soát lỗi đó (nên)

---

## Bài 25: HỌC CÁCH SỬ DỤNG TRY ... CATCH

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

## Bài 26: Ý NGHĨA CỦA TỪ KHOÁ FINALLY

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

## Bài 27: Ý NGHĨA CỦA THROW

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

## Bài 28: GỠ LỖI BẰNG CÔNG CỤ DEBUG

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

## Bài 29: THƯ VIỆN XỬ LÝ DỮ LIỆU SỐ

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

## Bài 30: THƯ VIỆN XỬ LÝ NGÀY THÁNG

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

## Bài 31: THƯ VIỆN TOÁN HỌC

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

## Bài 32: THƯ VIỆN XỬ LÝ SỐ NGẪU NHIÊN

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

## Bài 33: THƯ VIỆN XỬ LÝ CHUỖI

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
```



☆❖→
