# Tip Dönüşümleri

[Eğitim Video Linki](https://www.youtube.com/watch?v=YSh7qk2JpKw)

---

Bir değişken tanımlaması yaptığımızda bellekten o değişkenin tipine bağlı olarak bir alan tesis etmiş oluruz. Dolayısıyla tanımladığımız bu değişkene farklı veri tipinde bir değer atanması bellekte işlerin karışmasına neden olabilir.

Çoğu zaman uygulama yazarken farklı veri tipleri ile çalılmak durumunda kalabiliriz. Bellekte işleri yoluna koyabilmek için bu tip durumlarda tip dönüşümü yapmamız gerekir.

Tip dönüşümleri 2 şekilde yapılabilir.

* Implicit Conversion (Bilinçsiz ya da kapalı dönüşüm)
* Explicit Conversion (Bilinçli ya da açık dönüşüm)

## Implicit Conversion

Bir değişkenin kendinen daha yüksek kapasiteli bir değişkene atanmasıdır. Hedef değişkenin veri tipi bellekte yeterli alana sahip olacağından, bu dönüşümde bir veri kaybı sözkonusu olmayacaktır. Dolayısıyla bu dönüşüm kendiliğinden yapılabilir.

**Örnek:**

float a; int b = 25; a = b;

**Örnek:**

short x = 10; int y; y = x;
Yukarıdaki örnek sorunsuz çalışır. Çünkü float integer'a, integer da short veri tipine göre daha büyük sayıları saklayabiliyor.

## Explicit Conversion

Bu yöntemde dönüşümleri developer'ın yapıyor olması gerekiyor. Dönüşüm için farklı yöntemler mevcut.