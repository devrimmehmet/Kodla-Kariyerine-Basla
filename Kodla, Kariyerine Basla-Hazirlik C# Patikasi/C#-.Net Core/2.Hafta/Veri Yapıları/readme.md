[Eğitim Video Linki-1](https://www.youtube.com/watch?v=GRYu7xbGYDg)

---
Eğitmen: Engin Deniz ALPMAN

---

# Array

- Hafızalarda ard arda tutma mantığı çalışır.

- Kutucuklar yan yana olmak zorunda.

* Dinamik Array (Hafızada yer tutma)
    - Hafızada gereksiz yer tutulabilir bu olumsuz bir durumdur.
    - Tuttuğum hafızadan fazla yer ihtiyacı olursa yine aynı işlemi yapmk zorunda kalırız.
    - Olumlu yanıda bir elemana erişmek istediğinizde anında erişebilirsiniz.
    - Gerekirse kutucuk silinebilir


***
***
[Eğitim Video Linki-2](https://www.youtube.com/watch?v=RyQZm9GbGg4)
***
# Linked List

- Verileri yan yana tutmak yerine hafızada dağılmış şekilde tutmaya yarar.
    - Bunu yapma sebebimiz bütün elemanları taşımak zorunda kalmamak için.
    - Bir veri birde adres tutar bir sonraki veriye ait
    
***
***
[Eğitim Video Linki-3](https://www.youtube.com/watch?v=9AwLy7qCwQs)
***

# Linked List vs Array

![LinkedList-vs-Array](https://github.com/devrimmehmet/Kodla-Kariyerine-Basla/blob/master/Kodla,%20Kariyerine%20Ba%C5%9Fla-Haz%C4%B1rl%C4%B1k%20C%23%20Patikas%C4%B1/C%23-.Net%20Core/2.Hafta/Veri%20Yap%C4%B1lar%C4%B1/img/linkedlist-vs-array1.png?raw=true)

***
***
[Eğitim Video Linki-4](https://www.youtube.com/watch?v=jAK9v-rpIbs)
***
# Linked List Eleman Ekleme/Silme
- Arraylere göre daha kolay ve hızlıdır.
- Bir sonraki verinin adresini tuttuğu için oraya gider ve orası boşsa oraya değilse ordaki adresi alıp bir sonrakine giderek adres kısmı null olan eğeri bulana kadar arar ve uygun yeri bulur.
- Bir düğüm kendinden bir sonraki düğümün adresini tutar.
- Yeni bir eleman eklemek listeyi bozmaz.
- Listeden eleman çıkarırsak bir önceği düğümün adresini bir sonraki düğümün adresine yönlendirdiğimizde sorun çıkmaz. Yani eleman çıkarmak mümkündür.

***
***
[Eğitim Video Linki-5](https://www.youtube.com/watch?v=wnbqiwW_C6Q)
***
# Stack

* LIFO (Last in First Out) En son giren ilk çıkar.
* Push : Stack'e eleman eklemek (En son elemanın üzerine eleman eklemek)
* Pop  : Stack'ten eleman almak.(En son elemanı çıkarmak)

* Ortasından eleman eklemek çıkarmak mümkün değildir.

***
***
[Eğitim Video Linki-6](https://www.youtube.com/watch?v=XLZbYvi5pvs)
***
# Queue

* FIFO (First in First Out) İlk giren ilk çıkar.
* Enqueue: Yani elemanın Queue'ya eklenmesi 
* Dequeue: Elemanın queue'dan çıkarılması

* Ortaya eleman ekleme ve çıkarma yoktur. En başından eklenir en sonundan çıkar.


***
***
[Eğitim Video Linki-7](https://www.youtube.com/watch?v=jhc-KG3htrM)
***
# Hash Table

- Array a[0] 1.elemanı getirir.
- Çoğu programlama dili 0 bazlı indexi kullanır fakat farklı 1 bazlı gibi kullanımlarda var.

## Hash Table

* Hash Table ürünlerin fiyatını ezbere bilen çalışan gibidir.
* Ürünlerin isimlerini ve fiyatlarını array'in elemanları olarak tutup
sorunu çözebilirdik ama ürünleri array'de tek tek aramak istemiyorum, anında aradığım ürünün fiyatını bulmak istiyorum.

### Bunu nasıl çözebilirim?

- İlk eleman sayısı ürün sayısına eşit bir array oluşturacağız.
- Ürünlerin isimlerini bir fonksiyona sokup alacağız.
- Fonksiyonun çıktılarını oluşturduğumuz array'in index'i olarak kullanıp, ürünlerin fiyatlarını bu indexlerde tutacağız.
- Array'ler bize kaçıncı eleman olursa olsun sabit sürede istenen lokasyondaki elemanı verebiliyordu.
- Bu sabit sürede erişmeyi lokasyon bazlı değil, tanım bazlı kullanmak istiyorum. Bana 3.elemanı getir değil, bana elmaya karşılık gelen elemanı/fiyatı getir demek istiyorum.
- Biri bize bir ürünün fiyatını sorduğunda bu ürünü oluşturduğumuz fonksiyona besleyip arraydeki indexi neredeymiş onu bulacağız.
- Bu fonksiyona Hash Function, Hash Function + Array yapısına da Hash Table deniyor.

**Hash Table, key value prensibine dayanın bir array kümesidir. Key olarak çağırdığınız elemanın değerini (value) yansıtır.

***
***
[Eğitim Video Linki-8](https://www.youtube.com/watch?v=ZX-1qPSYC_k)
***
# Hash Function

- Hash Function her seferinde aynı girdiye aynı sonucu vermeli

- Farklı girdilere farklı çıktılar versin istiyoruz.

- Hash Function'ın çıktılarının sınırlarında (range) olmalı array'in boyutu.

** Maalesef her seferinde aynı girdiye farklı sonuç veremiyor Hash Function, bu duruma Collision deniyor.
 
***
***
[Eğitim Video Linki-9](https://www.youtube.com/watch?v=FD7nKLnrguE)
***
# Hash Collision

* Hash Table yaratabilmek için hash function kaliteli olmalı collisionu en az seviyede tutmalı.
* Aynı inputu aynı outputa get etmesi lazım.
* Hash functionlar aynı değeri iki farklı değere atabilirler!
