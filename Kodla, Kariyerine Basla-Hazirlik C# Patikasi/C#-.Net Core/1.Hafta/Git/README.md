[Eğitim Video Linki-1](https://www.youtube.com/watch?v=Ke26wrLhBHo)

---

Eğitmen: Hakan Yalçınkaya

---

# Visual Studio Code ve Git SCM Kurulumu

## Visual Studio Code Kurulumu

* https://code.visualstudio.com/download

* Tavsiye: Open With Code özelliğini hem klasör yönetiminde hemde dosya menüsünde aktif etmeniz tavsiye edilir.

* Add to PATH yapınız ! 

---

## Git SCM (Versiyon Kontrol Sistemi) Kurulumu

* Visual Studio Code içerisinde Source Control Kısmından Git Yüklümü bakınız.

* https://git-scm.com/downloads

* Tavsiye: Editör olarak Vim'i kullanmanız tavsiye edilir.

* Git'i 3. Parti Uygulamalarla birlikte kullanabilme seçeneğini seçin

* OpenSSL kullanımını aktif edin.

* **Git Bash** bize bir çok web sayfasındaki linux komutlarını windowsda kullanabilmemizi sağlayacak.

***

### CMD (windows) Komutları

    * dir
        * Klasörleri listeler.

    * cd klasöradı
        * İlgili klasöre girer.

    * mkdir deneme
        * deneme adında klösör oluşturur.
    
    * code .
        * Bulunduğunuz dizindeki klasörü visual studio code'da açmanızı sağlar.


***
***
***

[Eğitim Video Linki-2](https://www.youtube.com/watch?v=DVUfB5Iw5js)

***

# Git Versiyon Kontrol Sistemi Nedir?

## GIT Nedir?

"git" Kelimesinin Anlamı
Cambridge Sözlüğe göre; aptal, hoş olmayan kişi anlamına geliyor. [2]

Bu isimlendirme Torvalds'a sorulduğunda kendisi espirili şekilde şu cevabı veriyor:

"Ben bir egoistim ve projelerime kendi ismimi veriyorum. Önceki Linux, şimdiki git." Torvalds, alternatif olarak kelimenin ruh halinize göre aşağıdaki anlamlara da gelebileceğinden bahsediyor;

Yaygın bir UNIX komutu tarafından kullanılmayan, telaffuz edilebilir, rastgele üç harfli bir kombinasyon.
Sözlükteki argo anlamı ile; Aptal, Aşağılık ve Basit.
"Küresel bilgi izleyici" (Global information Tracker).
"Kahrolası aptal kamyon dolusu pislik" (Goddamn Idiotic Truckload of sh*t)."

[Detaylı Bilgi İçin](https://git.wiki.kernel.org/index.php/GitFaq#Why_the_.27Git.27_name.3F)

Görüldüğü üzere aslında çok da kesin bir anlamı yok. Özgür yazılım dünyası sizi burada da özgür bırakmış.

## GIT'in Tarihsel Gelişimi
Linux'un mimarı Linus Torvalds, çok sayıda kişi ile birlikte Linux çekirdeğini geliştirirken projenin yönetimi için o dönem piyasada bulunan BitKeeper adındaki versiyon kontrol sistemini tercih etmiş. Fakat BitKeeper'in telif haklarını elinde bulunduran kişi ile yaşanan yasal sorunlardan ötürü bu kullanımdan vazgeçilmiş.

O günlerde piyasada bulunan versiyon kontrol sistemlerinin hiçbiri aslında Torvalds'ın beklentilerini karşılamıyormuş.

Bu sebeple ihtiyaçlarına çözüm için kolları sıvayan Torvalds, piyasadaki sistemleri inceleyerek kendi versiyon kontrol sistemini yazmaya başlamış. İlk sürüm 2005 yılında piyasaya sürülmüş.

Yayınlanmasından günümüze kadar geçen sürede ise GIT büyük bir pazar hacmine ulaştı.

## GIT Versiyon Kontrol Sistemi Nedir?
GIT nedir? diye sorduğunuzda versiyon kontrol sistemi cevabını almışsınızdır. İyi de versiyon kontrol sistemi nedir?

Projemi geliştirirken "proje", "projee", "projee_son", "projee_son_5" şeklinde klasörlesem olmaz mı? GIT öğrenmeden olmaz mı? - OLMAZ!

Son sorudan başlayayım. Eğer profesyonel işler yapacaksanız GIT öğrenmek zorundasınız. Klasör isminin sonuna fazladan harfler, rakamlar ekleyerek proje geliştirmek ilerleyen süreçlerde başa çıkılabilecek bir yöntem değildir.

Versiyon Kontrol Sistemi Nedir? sorusuna gelirsek; Bir döküman (yazılım projesi, ofis belgesi vb.) üzerinde yaptığınız degişiklikleri adım adım izleyen, istediğinizde kayıt eden ve isterseniz bunu internet üzerindeki bir bilgisayarda veya yerel bir cihazda (respository / repo / depo) saklamanızı ve yönetmenizi sağlayan bir sistemdir.

Versiyon Kontrol Sistemi yerine Kaynak Kod Yönetim Sistemi ifadesini de duymuş olabilirsiniz. İkisi de aynı şeyi ifade etmektedir.

## GIT Bize Ne Sağlar?
Birden fazla yerde (dağıtık olarak) dosyalarınızı ve versiyon kontrol bilgilerinizi depolayabilirsiniz. Böylelikle cihaz bağımsız olarak dosyalarınıza erişebilirsiniz.

"commit" yaparak SnapShot (anlık görüntü) özelliği ile istediğiniz zaman proje veya dosyaların o anki halini kayıt altına alabilirsiniz. Böylelikle ileride bir hata ile karşılaşırsanız herhangi bir zamandaki herhangi bir versiyona dönüş yapabilirsiniz.

SnapShot alındıktan sonra değişiklik yapılan dosyaları görebilirsiniz.
Takımların aynı projede beraber çalışmasına imkan verir. Kim neyi düzenledi? Ne ekledi? Ne çıkarttı? Son değişiklik ne zaman yapıldı? gibi bilgilere erişebilirsiniz. Bu sayede topluluk ile proje geliştirme süreçlerini kolaylaştırabilirisiniz.

Projede verisyonlanmasını istemediğiniz dosyaları belirtebilirsiniz. (node_modules, .mp4, .log, .env gibi)

    * Dağıtık Versiyon Kontrol Sistemi
    * Takımların aynı proje ortamında çalışmasını kolaylaştırır.
    * Kim düzenledi? Ne Değişti ? ve Ne Zaman Değişti? Bilgilerini Tutar
    * Herhangi bir dosyaya veya versiyona her zaman geri dönüş yapılabilir
    * Yerel bilgisayarda ve uzak bilgisayarlarda çalışır
    * Proje içindeki tüm dökümanları izler
    * İstenilen çalışma anında projenin veya dosyaların SnapShot özelliği ile o anki halini alabilirsiniz(commit)
    * Her zaman SnapShot'ları inceleyebilir veya geri dönüş yapabilirsiniz
    * Hangi dosyaların SnapShot aldıktan sonra değiştiğini görebilirsiniz
    * Projende versiyonlanmamasını istediğin dosyaları, dosya tiplerini(*.log, *.mp4) veya klasörleri belirtebilirsin

### GIT-SCM En çok Kullanılan Komutlar
    * git init  
        * İlk defa Projeyi oluştururken kullanılır.
    * git add
        * Herhangi bir dosya veya klasörü versiyon kontrol sistemine takip için ekler
    * git commit
        * SnapShot almamızı sağlar dosyayı onaylamak için kullanılan yapı
    * git status
        * Neler Değişmiş görmek için kullanılır
    * git push
        * Uzak Sunucuya gönder
    * git pull
        * Uzak Bilgisayardan çek
    * git clone
        * Projeyi klonlamak için kullanılır
    * git checkout
        * Branchler arası geçiş için kullanılır
    * git rm
        * Dosya veya klasörleri silmek için kullanılır.

## GIT'i Anladım Fakat GitHub, GitLab, BitBucket Nedir?

En sade şekilde GIT versiyon kontrol sistemini kullanan depolama servisleri diyebiliriz.

## GitHub

Yazılımcılar için bir kod kütüphanesi ve bir çeşit sosyal medya ortamıdır.

Yazılım geliştiriciler projelerini halka açık veya özel olarak saklayabilir. Ücretli ve ücretsiz paket seçenekleri mevcuttur.

## GitLab

GitHub gibi bir GIT servisidir. Farklı olarak firmalara GitLab'ı kendi sunucularına kurma imkanı verildiği için genelde kurumsal tarafta kullanılır. GitLab ile firmalar kendi içerisinde GIT hizmetlerinden faydalanabilir.

## BitBucket

Genelde kişisel kullanıma yöneliktir. GitHub tarafındaki açık kaynak projeler ve sosyal medya ortamı burada gelişmemiştir.

* Yukarıda açıkladığımız servisler haricinde GitKraken, SourceTree gibi irili ufaklı farklı servisler de mevcuttur.

***
***
***

[Eğitim Video Linki-3](https://www.youtube.com/watch?v=Mn3lljT-nIY)

***

# Git Bash ile GIT Temel Komutları

    git config --global user.name "devrimmehmet"   
        Git kullanıcı adı tanımlama

    git config --global user.email "devrimmehmet@gmail.com"
        Git E-mail tanımlama

    git init  
        İlk defa Projeyi oluştururken kullanılır.
            Bir gizli klasör oluşturur .git adında.
    
    git add
        Herhangi bir dosya veya klasörü versiyon kontrol sistemine takip için ekler
            git add index.html sadece index.html dosyasını takipe başlatmak için
            git add .   hepsini takip etmesi için.
            git rm --cached index.html  istenilen dosyayı takipten çıkarmak için kullanılır

    git commit
        SnapShot almamızı sağlar dosyayı onaylamak için kullanılan yapı
        git commit dediğimizde eğer giti ilk defa kullanıyorsak tanımlama yapmak gerekiyor
            git config --global user.email "devrimmehmet@gmail.com"
            git config --global user.name "Devrim Mehmet"
        ilk yaptığımızda bizi yönlendirdiği renkli terminalden çıkmak için :q demek yeterli.
        git commit -m 'First Commit'

    git diff 
        en son committen sonraki değişiklikleri gösterir
        git diff index.html deyip sadece index.htmldeki değişiklikleri görebiliriz.

    git status
        Neler Değişmiş görmek için kullanılır
            takip edilip edilmeyen klasörleri gösteriyor.
    
    git push
        Uzak Sunucuya gönder
    
    git pull
        Uzak Bilgisayardan çek
    
    git clone
        Projeyi klonlamak için kullanılır
    
    git checkout
        Branchler arası geçiş için kullanılır
    
    git rm
        Dosya veya klasörleri silmek için kullanılır.

***
***
***

[Eğitim Video Linki-4](https://www.youtube.com/watch?v=FxN-NlTCWZ0)

***

# VS Code içinde Terminal Kullanarak GIT Temel Komutları

* git --version  // git varmı kontrol et.

* git init // git add index.html 

* git status // dosyanın duruma bak

* git commit -m 'index düzenlendi'

* q ya basarak çıkılır


***
***
***

[Eğitim Video Linki-5](https://www.youtube.com/watch?v=5Lnjbkj-4ac)

***

# VS Code içerisinde Terminal Kullanmadan GIT Temel Komutları

***
***
***

[Eğitim Video Linki-6](https://www.youtube.com/watch?v=QF99zzvhgUs)

***

# .gitignore Dosyası Ne İşe Yarar? Nasıl Kullanırız?

Versiyonlamak istenmeyen dosyalar;

* görseller
* videolar
* logolar
* paket yöneticisi ile kurulmuş dosyalar olabilir ??

bunu yapabilmek için

    .gitignore diye dosya açılır klasör içinde.

genel bilgi sahibi olabilmek için google'da aşağıdaki başlıklar gibi aramalar yapılabilir. 

    gitignore C# 
    gitignore .net core 

## IDE - VSCode

    .vscode/*
    !.vscode/settings.json
    !.vscode/task.json
    !.vscode/launch.json
    !.vscode/extensions.json

## img
    *.jpg
    *.png
    img/

## videos

    *.mp4    

## packages

## log

    *.log

password.txt

***
***
***

[Eğitim Video Linki-7](https://www.youtube.com/watch?v=TP2K4cx3Asw&t=2s)

***

# GIT - Proje İçindeki Birden Fazla Dosyanın Versiyon Kontrol Sistemine Eklenebilmesi

Yeni bir branch açıp oradan farklı bir sistemle ilerleyip deneme yapabilirsiniz

ilerleyen süreçte bu branchleri birleştirebilir yada birini iptal edebilirsiniz.

    * git branch deneme
    * işlemlerimi yapıp bitirdikten sonra birleştirmek istersem
    * commit işlemini bu branchtayken yaparız
    * git checkout master yapıp mastere geçerim
    * git merge deneme yapıp masterin içinde denemeyi mastere dahil etmiş olurum.

* **Commit işlemi yapmadan "git push" yapmaya çalışırsak hiçbir hata göstermez fakat dosyalar aktarılmaz**

