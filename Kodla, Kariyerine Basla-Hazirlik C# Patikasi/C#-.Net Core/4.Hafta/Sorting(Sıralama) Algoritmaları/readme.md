# Searching nedir?

Günümüzde veriler gitgide artan bir hal alıyor. Her insanın bir bilgisayarı ve telefonu olduğunu düşünürsek, terabaytlarca veri ediyor. Arama algoritmaları ise istediğim özellikteki verinin elimdeki veri setlerinde aranıp, bulunup getirilmesi demek. Bunun hızlı olmasına önem gösterilir.

### Kaynaklar

[search-algorithm](https://en.wikipedia.org/wiki/Search_algorithm)

[why-we-need-searching-algorithms](https://www.bbc.co.uk/bitesize/guides/zgr2mp3/revision/1)

---
---

## Linear Search
Linear search, tek tek elemanları dolandıktan sonra istediğim elemanın olup olmadığına bakmaktır.

Örneğin, [20,25,46,48] veri setini ele alalım. Benim aradığım eleman 25. İlk elemana gidiyorum ve değeri 20 sen değilsin diyorum. İkinci elemana gidiyorum ve değeri 25 evet sensin diyorum. Linear search algoritmam burada bitmiş oluyor.

Big-o ya göre incelediğimizde bizim worst caseimiz neydi? Elemanın dizinin sonunda bulunmasıydı. Bu sebepten ötürü n elemanımız varsa big-o notasyonumuz otomatik olarak n oluyor.

### Kaynaklar

[BBC-linear-search](https://www.bbc.co.uk/bitesize/guides/z7kkw6f/revision/7)

[linear-search-with-code](https://www.programiz.com/dsa/linear-search)

---
---

## Binary Search
İkili arama algoritması, elimizde bulunan veri dizisini sıralı olduğunu varsayıyor, bu durumu değiştirerek sonuca varmak istiyor.

İkili arama algoritması, diziyi her seferinde ikiye bölerek ikili arama yapar. Sıralı bir listem var ise benim Big-o logn olarak karşımıza çıkıyor.

Aradığım sayı 15 ve benim değer kümem [10,15,20,16,22,36,23] diyelim. Binary Search bu diziyi manipüle ederek şu ifadeye dönüştürüyor. [10,15,16,20,22,23,36]. 36 sayısını en yüksek sayı, 10 sayısını en düşük sayı ilan ediyor. Benim aradığım sayı ile ortada kalan sayıyı kıyaslıyor eğer benim sayım büyükse kendinden küçük bütün sayıları siliyor. Ve kendine yeni bir ortanca belirliyor. Böylelikle gereksiz arama yapmaktan kurtarıyor.

![binary-search](https://github.com/devrimmehmet/Kodla-Kariyerine-Basla/blob/master/Kodla,%20Kariyerine%20Basla-Hazirlik%20C%23%20Patikasi/C%23-.Net%20Core/4.Hafta/G%C3%B6rseller/binary-search.png?raw=true)

### Kaynaklar

[binary-search](https://www.khanacademy.org/computing/computer-science/algorithms/binary-search/a/binary-search)

---
---

## Binary Search Tree
Bir düğüm her iki tarafa da referans verebiliyor. Sağ ve sol olarak. Sağ tarafından kendinden büyük elemanlar, sol tarafında ise kendinden küçük elemanlar bulunacak.

![binary-search-tree](https://github.com/devrimmehmet/Kodla-Kariyerine-Basla/blob/master/Kodla,%20Kariyerine%20Basla-Hazirlik%20C%23%20Patikasi/C%23-.Net%20Core/4.Hafta/G%C3%B6rseller/binary-search-tree.png?raw=true)

Tree'ye eleman eklemek istediğimde root'dan başlıyorum. Örnek olarak ben 26 sayısını ağaç yapısına eklemek istiyorum. Root'a soruyorum senin değerin ne 56. Baştaki açıklamamızı hatırlayalım. Sağ tarafında kendinden büyük, sol tarafında kendinden küçük elemanlar var. O yüzden sırasıyla 56 ve 30 a kadar ilerliyorum. 30 bana benim sol tarafıma geçmelisin çünkü sen benden küçüksün diyor. Karşıma 22 değerinde olan düğüm çıkıyor ve 22 den büyük olduğum için sağ tarafına bir köşe çekiyorum ve 26 sayısını bağlıyorum.

### Kaynaklar

[binary-search-tree](https://tsafaelmali.medium.com/binary-search-tree-nedir-2e6fb0621d9)

[binary-search-tree](https://www.buraksenyurt.com/post/Binary-Search-Tree-yi-Anlamak)

[binary-search-tree-english-detail](https://www.geeksforgeeks.org/binary-search-tree-data-structure/)