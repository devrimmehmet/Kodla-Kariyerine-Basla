# Algoritma Analizine Giriş

* A noktasından B noktasına gitmek istiyorum birden çok yolla gidebilirim.Süre yolun ücreti gibi parametreleri değerlendiririm. Benim için en uygun yolu seçerim.

* Algoritmalar içinde bu geçerli. Bir problemi çözen birden çok algoritma olabilir. Biz elimizdeki kaynaklara göre bizim için en uygun olanı kullanacağız.
    
    * Programın harcadığı süre
    
    * Kullanılan hafıza
    
    * Programın çalışma zamanı

* Algoritma analizi yaptığımız bilgisayarın özelleriklerinden ve programlama dillerinden bağımsız olmalı ki genellenebilir olsun.

* Diyelim ki kendi bilgisayarımızda A algoritmasını çalıştırdık 3 dakikada çalıştı, başka birisi B algoritmasını denemiş ve 4 dakikada çalışmış. Bunların hangisini seçmek mantıklı ?

* Belki A algoritması daha iyi ama B algoritmasını deneyenin bilgisayarı daha hızlı bizimkinden belki biz kendi bilgisayarımızda B algoritmasını denesek 5 dakikada çalışacaktı.

* Aynı şey programlama dili içinde geçerli belki algoritma A daha iyi ama B daha hızlı bir programlama dilinde denendi, hangisi daha hızlı bunları karşılaştıramam.

* Bu yüzden bilgisayar özelliklerinden ve programlama dillerinden bağımsız bir analiz yapmak istiyorum.

## Bu analizi nasıl yapabilirim?

* Çalışma Süresi (Executing Time) Programlama dilinden ve kullanılan bilgisayarın özelliklerinden etkileniyor, o yüzden genellenebilir değil

* İfade sayısı: Programda kaç tane ifadenin çalıştığı (Bunu yap, bunları topla, vs. gibi) programlama diline göre aynı işlem için çalışan ifade sayısı değişebilir genellenebilir değil.

* Büyüme hızı (Rate of Growth): Programa verdiğimiz input (girdi) boyutu ile çalışma zamanını fonksiyonel olarak birbirine bağlarsak bilgisayarlara ve programlama dillerine bağlı olmayan bir yapı  oluşturmuş oluruz.


---
---

# RAM Modeli

* Genellenebilir bir analiz yapmak için, her algoritmayı aynı bilgisayar ile test ediyor gibi yapacağız.

* Bu hayali makinaya RAM(Random Access Machine) diyeceğiz.

## RAM'in özellikleri

* Her basit işlem (+,-,and,or gibi) 1 birim zaman alır.

* Döngüler 1 birim zaman değil, içerisinde kaç defa işlem oluyorsa iterasyon sayısı * işlem sayısı kadar birim zaman alır.

* Hafızadan her okuma işlemi 1 birim zaman alır.

---
---

# Time Complexity

* Kullanacağımız algoritmayı, analiz etmek istiyoruz problem aynı olsada farklı inputlar için algoritmamız farklı performans senaryoları üretebilir.

* Diyelim ki bir kelimenin anlamını sözlükte arıyorum. Arama için sayafalara tek tek bakıyorum. Burada algoritmam *sayfalara tek tek bakmak*, input da *aradığım kelime*

* Aradığım kelimenin boyutu aynı olsa da hangi harfle başladığına göre yapacağım işlem (sayfa çevirme sayısı) değişebilir.Yani input algoritmanın yapacağı işlem sayısını etkileyebiliyor.

* Bu yüzden analizimizi 3 ana başlık altında yapabiliriz.
    * Worst Case
    * Average Case
    * Best Case

* **Worst Case**: Vereceğimiz inputun algoritmamızı en yavaş (en fazla işlem yapacak) şekilde çalıştırdığı durum. Aradığımız kelimenin "Z" harfi ile başlaması gibi.
    * Her algoritmaya göre worst case farklı sözlüğe baştan değil sondan bakmaya başlasaydım "Z" ile başlaması worst case olmazdı.

* **Average Case**: Genel olarak beklediğimiz durum

* **Best Case** : Vereceğimiz inputun algoritmamızı en hızlı şekilde çalıştırdığı durum

Algoritmamızın çalışmasını en iyi yansıtan average case, ama bu durumu analiz etmek diğerlerine göre çok daha zor. Inputların geldiği dağılımı bilip ona göre analiz etmek gerekiyor.
    * Worst Case'e göre analiz yaparsak, performansımız için üst sınır çizmiş oluruz.Böylece worst case için bizi tatmin eden bir algoritmamız varsa, average case zaten bundan daha iyi (veya aynı) performansı vereceği için oda bizi tatmin edecektir.
 
---
---

# Big O Notation

* İki farklı arama yöntemi düşünelim

* A algoritması tek tek sayfalara bakıyor.

* B algoritması sözlüğün alfabetik sıralanmış olduğundan en başta en ortadaki sayfayı açıyor, eğer bu sayfadaki harfler aradığım kelimeden alfabetik olarak daha ilerideyse sol tarafta aynısını yoksa sağ tarafa aynısını yapıyor.

* Böylece problem her seferinde yarı boyutuna inmiş oluyor.

* Bir kaç durum üzerinden konuşalım. Diyelimki 100 sayfalık bir sözlüğüm var. A algoritması en kötü durumda (aradığım en son sayfadaysa) kaç işlem yapacak ? (100 işlem)

* B algoritması en kötü durumda kaç işlem yapar? (2^n =100)

* Bu örneğe bakarak B algoritmasının A algoritmasından daha hızlı olduğunu görebiliyoruz. 100/7 den yaklaşık 15 katı hızında diyebilirmiyiz? Bu genellenebilir bir şeymidir?

* Pek diyemiyoruz. Şöyle düşünelim, sözlüğüm 10.000 elemanlı olsa, A algoritması en kötü durumda 10.000 işlem yapar ama B algoritması 2^x = 10.000 yaklaşık 13 işlem yapar. 10.000/13 yaklaşık 770 katı hızında gözüküyor.

* Bu yüzden algoritmaların sadece 1 input boyutuna göre karşılaştırılmalarına bakıp karar veremeyiz. Genel yapısını bize gösterecek bir analize ihtiyacımız var, işte burada Big O Notation devreye giriyor.

* Big O Notation algoritmanın ne kadar sürede çalışacağını söylemeyecek. Bize algoritmamızın çalışma zamanının inputun boyutu ile nasıl değişeceğini söyleyecek.

* Mesela sözlük örneğimizde input size'ımızın n dersek, algoritmamızın en kötü durumdan n işlem yaptığını söyleyebiliriz. Inputum n boyutunda olunca çalışma süremin de en kötü durumda n olmasını O(n) diye göstereceğim. Aynı şekilde B algoritması için O(logn)

* Big O Notation'da yapılacak toplam işlem sayısının input size ile nasıl scale olacağına bakıyoruz. Benim için bu fonksiyonun yapısı önemli.

* İşlem sayısı input size ile linear mi artıyor, karesi ile mi ortantılı artıyor, logaritmik mi?

* Karakteristiği önemsemediğimiz için 2n işlem yapan algoritmaya da n işlem yapan algoritmaya da O(n) diyoruz, ikisi de linear bir şekilde artıyor. Big O Notation bakarken katsayılar önemli değil.

* Analizimin sonucu **2n^2 + 3n + 2** gibi bir şey çıktı diyelim. "n" büyüdükçe, 3n +2 nin etkisi 2n^2 nin yanında önemsiz kalacak.  O yüzden dominant olanı Big O notation olarak yazabiliriz.(**O(n^2)**) 

### O(nlogn) diye bir gösterimi yoktur.