# 👩🏼‍💻 DESIGN PATTERNS | TASARIM KALIPLARI

Murat Yücedağ'ın [.Net Core ile Design Patterns](https://www.udemy.com/course/aspnet-core-6-ile-design-patterns-15-farkl-tasarm-deseni/) online kursundan, tasarım kalıpları üzerine eğitim aldığım, öğrenirken yaptığım projelerin reposudur.

###### [Sertifika için tıklayınız](https://drive.google.com/file/d/128PjcuC3HB0axMUU9EwLV4JuOFkuK8pu/view?usp=drive_link)

***

Desing Pattern, yani tasarım deseni, yazılım geliştirme sürecinde karşılaşılan yaygın sorunlara çözüm sunan, tekrar kullanılabilir ve denenmiş çözüm önerileridir. Tasarım desenleri, nesne yönelimli programlamada belirli durumların için en iti pratikleri ve yöntemleri içerir, böylece yazılımın esnek, anlaşılır ve sürdürebilir olmasını sağlar.

###### Tasarım desenleri genellikle üç ana gruba ayrılır:
1. Yaratıcı (Creational) Desenler
Yaratıcı desenler, nesne oluşturma sürecini düzenleyerek, kodun bağımlılığını azaltır ve esnekliği artırır. Bu desenler, yeni nesneler yaratmak yerine, yeniden kullanılabilir nesneler oluşturmayı ve yönetmeyi amaçlar.

+ `Singleton:` Uygulama boyunca yalnızca bir nesne örneği olmasını sağlar.
+ `Factory Method:` Alt sınıfların, oluşturulacak nesne türünü belirlemesine olanak tanır.
+ `Abstract Factory:` İlgili nesne ailesini oluşturmak için bir arayüz sunar, fakat alt sınıflar bu nesnelerin somut sınıflarını belirler.
+ `Builder:` Karmaşık nesne yapım sürecini adım adım gerçekleştirir.
+ `Prototype:` Bir nesnenin klonlanarak yeni bir nesne oluşturulmasını sağlar.

2. Yapısal (Structural) Desenler:
Yapısal desenler, nesneler arasındaki ilişkileri ve yapıları yöneterek daha büyük yapıların kurulmasına yardımcı olur. Nesnelerin birbiriyle nasıl işbirliği yapacağını tanımlar.

+ `Adapter:` Uyumsuz arayüzleri uyumlu hale getirir.
+ `Bridge:` Bir nesnenin soyutlaması ile uygulamasını birbirinden ayırarak, bağımsız olarak geliştirilmelerini sağlar.
+ `Composite:` Nesneleri ağaç yapısında hiyerarşik olarak organize eder; tekil nesneleri ve nesne gruplarını aynı şekilde işleme imkânı sunar.
+ `Decorator:` Nesneye dinamik olarak yeni işlevler eklemeye imkân tanır.
+ `Facade:` Birden çok sınıfa erişim gerektiren bir sistemi basitleştiren, tek bir arayüz sunar.
+ `Flyweight:` Hafızadan tasarruf etmek için, çok sayıda küçük nesne paylaşımı yapılmasını sağlar.
+ `Proxy:` Bir nesneye erişimi kontrol etmek için bir vekil nesne kullanır.

3. Davranışsal (Behavioral) Desenler:
Davranışsal desenler, nesneler arasındaki iletişimi ve işbirliğini düzenleyerek, belirli bir davranış sergilemelerini sağlar. Böylece yazılım daha esnek ve yönetilebilir hale gelir.

+ `Chain of Responsibility:` Bir istek bir dizi işlemciden geçer ve işlemcilerden biri isteği işleyebilir.
+ `Command:` İşlemleri nesneler olarak temsil eder ve işlemleri sıralamak, geri almak gibi işlemler sağlar.,
+ `Interpreter:` Bir dili veya ifadenin yorumlanmasını sağlar.
+ `Iterator:` Nesne koleksiyonlarında gezinme işlevi sunar.
+ `Mediator:` Nesneler arasındaki iletişimi merkezi bir aracı nesne üzerinden gerçekleştirir.
+ `Memento:` Bir nesnenin geçmiş durumunu saklar ve gerektiğinde geri yüklenmesine olanak tanır.
+ `Observer:` Nesneler arasında bir "yayınla-izle" ilişkisi kurarak, bir nesnedeki değişikliklerin bağımlı nesnelere bildirilmesini sağlar.
+ `State:` Nesnenin durumuna göre davranışını değiştirmesini sağlar.
+ `Strategy:` Bir işlemi gerçekleştirmek için kullanılacak algoritmaları birbirinin yerine kullanılabilir şekilde soyutlar.
+ `Template Method:` Bir algoritmanın iskeletini tanımlar ve alt sınıfların belirli adımları değiştirmesine olanak tanır.
+ `Visitor:` Nesnelerin veri yapısına yeni işlemler eklemeyi sağlar, nesneleri değiştirmeden veri yapısına yeni işlevler eklemeye olanak tanır.

> Tasarım desenleri, yeni baştan çözüm üretmek yerine, daha önce başarılı sonuçlar alınmış ve denenmiş çözüm yollarını kullanmayı sağlar. Bu sayede hem geliştirme süreci hızlanır hem de kod kalitesi artar.

***

#### ✨Design Pattern ve SOLID Prensipleri, yazılım geliştirme sürecinde kaliteyi artırmaya yönelik yaklaşımlardır, ancak farklı amaçlar ve yapılarla kullanılırlar.

| Özellik | Desing Pattner | SOLID Prensipleri|
|---------|----------------|------------------|
| Amaç | Belirli yazılım problemleri için yapılandırılmış çözümler sunar | İyi bir nesne yönelimli tasarım yapısı oluşturur |
| Kapsam | Farklı problem türlerine göre kategorize edilen çeşitli desenler içerir | Beş temel prensipten oluşur |
| Uygulama Alanı | Yaratıcı, Yapısal ve Davranışsal olmak üzere üç ana kategoride kullanılır | Tüm nesne yönelimli tasarım sürecine rehberlik eder |
| Esneklik | Uygulanan desene göre esneklik sağlar | Kodun sürdürülebilirliğini ve genişletilebilirliğini artırır |
|Kullanım Amacı | Yeniden kullanılabilir, optimize edilmiş çözümler sunmak | Kodun daha anlaşılır, modüler ve bakımının kolay olmasını sağlamak |

#### ✨Design Pattern ve SOLID Prensiplerinin Birlikte Kullanımı
Design Pattern ve SOLID prensipleri genellikle birlikte kullanılır, çünkü ikisi de kodun esnekliğini ve sürdürülebilirliğini artırmayı amaçlar. Örneğin:

+ Factory Pattern ile Single Responsibility Principle birleştirilebilir, çünkü Factory Pattern, nesne oluşturma işini sınıflardan ayırır ve tek sorumluluk ilkesiyle uyum sağlar.
+ Observer Pattern ile Dependency Inversion Principle birlikte kullanılabilir. Observer, bağımlılıkları azaltırken aynı zamanda yüksek seviyeli ve düşük seviyeli bileşenlerin bağımsızlığını sağlar.

> SOLID prensiplerine uygun olarak yazılmış bir kod, Design Pattern’leri daha rahat ve verimli bir şekilde uygulamayı kolaylaştırır. Bu iki yaklaşım birlikte kullanıldığında, yazılımın esneklik, ölçeklenebilirlik ve bakım kolaylığı sağlama olasılığı artar.
