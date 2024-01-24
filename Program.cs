// Captcha uygulaması
// 4 basamaklı bir captcha oluşturulacak, 1. ve 3. basamaklar sayı
//2. ve 4. basamaklar harf olacak

int d1, d2, d3, d4;
Random rnd = new Random();
d1 = rnd.Next(0,10);
d2 = rnd.Next(0,10);
d3 = rnd.Next(0,10);
d4 = rnd.Next(0,10);
System.Console.WriteLine(d1);
System.Console.WriteLine(d2);
System.Console.WriteLine(d3);
System.Console.WriteLine(d4);

string []karakterler = {"a","A","b","B","c","C","d","D","e","E"};
System.Console.WriteLine(d1 + karakterler[d2] + d3 + karakterler[d4] );

