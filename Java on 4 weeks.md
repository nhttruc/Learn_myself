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

 
