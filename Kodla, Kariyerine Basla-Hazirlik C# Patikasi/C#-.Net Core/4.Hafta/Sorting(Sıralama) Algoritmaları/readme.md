# Sorting Nedir?

Sorting, kendinden sıralama algoritmaları olarak bahsetmektedir. Sorting, bir eleman dizisini, belirli sıralama kurallarına göre sıralama yapar.

![Sorting-ilk-bakış]()

Searching yöntemini kullanarak elemanlarımızı sıraladık. Bunun sebebi, eleman ararken işimizin kolaylaşmasını istiyoruz.

Closest Pair yöntemini kullanarak birbirine yakın sayıları gruplandırdık ki arama yaparken zamanımızı efektif bir şekilde kullanalım.

Aynı eleman kontrolü: birbiriyle aynı olan sayıları örüntü içerisinde kaç tane aynı eleman varsa sayısını öğrenebilirim.

Mode bulma: eleman dizisini search ettikten sonra elemanların yan yana olanları sayarsam daha hızlı mode bulabilirim.

### Kaynaklar
[Sorting-algorithms-full](https://www.geeksforgeeks.org/sorting-algorithms/)

[Types-of-Sorting](https://www.interviewbit.com/tutorial/sorting-algorithms/)

[Sıralama-Algoritmaları](https://www.halildurmus.com/2021/02/22/siralama-algoritmalari-sorting-algorithms/)


---
---

## Insertion Sort
En basit sorting algoritmalarından biridir.

![insertion-sort]()

Verilen örüntüye ait en küçük elemanı buluyor ve en baştaki sayı ile yer değiştiriyor. Peki ya devamı? İkinci en küçük elemanı buluyor ve 2. sıra ile değiştiriyor. Baktın ki 2.sıradaki eleman en küçük hiç dokunma!!!. Hemen 3. sıraya geç. 4, 5 derken dizi bitti. İşte insertion sortun temel çalışma prensibini öğrendin.

![big-o-insertion]()

### Kaynaklar

[insertion-sort-with-code](https://www.geeksforgeeks.org/insertion-sort/)

[insertion-sort-with-data-structure](https://www.tutorialspoint.com/data_structures_algorithms/insertion_sort_algorithm.htm)

[insertion-sort-nedir](https://www.mobilhanem.com/algoritma-dersleri-insertion-sort/)

[insertion-sort-detay](http://cagataykiziltan.net/algoritmalar/1-siralama-algoritmalari/1-araya-sokma-siralamasi/)

---
---

## Merge Sort


Insertion Sort'da, Big-O gösteriminden dolayı inputum arttığında n^2 olduğunda dolayı çalışma zamanı artıyor.

Peki daha hızlı bir şekilde sıralama yapılabilir mi? Evet, Merge Sort burada yardımımıza koşuyor. Bir listeyi her adımda parçaya ayırıp tek eleman kalıncaya kadar bölüyor. Böldükten sonra sıralı bir şekilde bize sunuyor (Performans).

![merge-sort]()

![big-o-merge]()

Insertion sort'da, time complexity n^2 olduğundan ötürü çalışma zamanımız artıyordu. Merge sort'da ise nlogn olduğu için açık ara performans olarak daha iyi diyebiliriz.

### Kaynaklar

[merge-sort-detail-with-code](https://www.programiz.com/dsa/merge-sort)

[merge-sort-article](https://www.khanacademy.org/computing/computer-science/algorithms/merge-sort/a/overview-of-merge-sort)

[merge-sort-nedir-kod-dökümanı](http://cagataykiziltan.net/algoritmalar/1-siralama-algoritmalari/4-birlestirmeli-siralama/)

[merge-sort-wiki](https://tr.wikipedia.org/wiki/Birle%C5%9Ftirmeli_s%C4%B1ralama)

---
---

## Quick Sort

Hızlı sıralama günümüzde çok yaygın olarak kullanılan bir sıralama algoritmasıdır. N tane sayıyı average case e göre big-o nlogn, worst case e göre big-o n^2 karmaşıklığı ile sıralanır.

![QuickSort]()

İlk olarak bir pivot belirler bu pivota göre pivottan küçük ve eşitler sol kısmına, pivottan büyük ve eşitler sağ kısmına yazılır. Parçalanmış kısımlar yeni bir pivot belirlenerek parça pinçik edilir.

### Kaynaklar

[quick-sort-nedir](https://tr.wikipedia.org/wiki/H%C4%B1zl%C4%B1_s%C4%B1ralama)

[quick-sort](https://www.mobilhanem.com/algoritma-dersleri-quick-sort/)