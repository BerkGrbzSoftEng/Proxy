# Proxy
## Proxy Design Pattern Nedir?
Proxy Pattern, nesne temelli yazılım mimarilerinde belirlenmiş temel tasarım kalıplarından biridir. Var olan bir nesneye ulaşılmak istendiğinde vekil kalıp oluşturulur. Nesneyle istemci arasına yeni bir katman koyarak nesnenin kontrollü bir şekilde paylaşılması sağlanır. Böylece istemci, işlem yapan sınıfla doğrudan temasa geçmemiş olur. Bu durum sayesinde işlemin yapılma performansında bir düşüklük olmaması sağlanır. Bu yüzden vekil kalıp fazla yük getiren işlemlerde kullanılır. Mesela; bir film sitesinden film izlenirken, filmin indirilmesi beklenmez. Arka tarafta vekil tasarım kalıbı oluşturularak parça parça işlem yapılır ve zaman kaybı önlenmiş olur. Burada film realsubject, izlenen ise proxy olur.

### Proxy Design Pattern Ne Zaman Kullanılır?
1. Oluşturulması zaman alan bir nesne yaratılması gerektiğinde
2. Uzaktan erişilerek bir nesne yaratılması gerektiğinde
3. Nesneye erişmeden önce bazı kontroller yapılması gerektiğinde
4. Nesneye erişimin kısıtlı olduğunda yararlı olabilir.

 ### Proxy UML Diyagramı
![Singleton UML](https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Proxy_pattern_diagram.svg/439px-Proxy_pattern_diagram.svg.png)
