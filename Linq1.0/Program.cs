/*
//Sayının rakamları toplamnını bulan program

Console.Write("Rakamlarının toplamını görmek istediğiniz bir sayı giriniz: ");
string input = Console.ReadLine();
int[] rakamlar = new int[input.Length];

int toplam = 0;

for(int i=0; i < input.Length; i++)
{
    rakamlar[i] = Convert.ToInt32(input[i].ToString()); // input[i] char tipinde olduğu için stringe çevirip int'e çeviriyoruz.
    toplam += rakamlar[i];   
}

Console.WriteLine($"Toplam: {toplam}");

*/


/*   
//Konsolda şartlara uygun sayı girilene kadar tekrar isteyen program
Console.Write("10 ile 100 arasında bir sayı giriniz: ");
int girilenSayi = Convert.ToInt32(Console.ReadLine());

while (true)
{
    if (girilenSayi >= 10 && girilenSayi <= 100)
        Console.WriteLine("Girilen sayı şartlara uygun.");

    else
        while (true)
        {
            if (girilenSayi >= 10 && girilenSayi <= 100)
                Console.WriteLine("Girilen sayı şartlara uygun.");

            else
                Console.Write("Şartlara uygun sayı giriniz:");
                int girilenSayi2 = Convert.ToInt32(Console.ReadLine());
                girilenSayi = girilenSayi2;
        }
}
*/


/*
//Yaşa göre kategorileri belirleyen program
int[] ages = new int[] 
    {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
    20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39,
    40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59,
    60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79,
    80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };

foreach (int age in ages)
{
    if (age < 0)
        Console.WriteLine("Hatalı yaş girişi");
    else if (age >=0 && age <=12)
        Console.WriteLine($"{age} yaşındaki kişinin kategorisi: Çocuk");
    else if (age >= 13 && age <= 19)
        Console.WriteLine($"{age} yaşındaki kişinin kategorisi: Genç");
    else if (age >= 20 && age <= 64)
        Console.WriteLine($"{age} yaşındaki kişinin kategorisi: Yetişkin");
    else
        Console.WriteLine($"{age} yaşındaki kişinin kategorisi: Yaşlı");
}

*/

/*
//Dizideki elemanların birbirleriyle eşit olup olmadığını kontrol eden program
int[] arr = new int[] { 1, 2, 3, 1, 5, 6, 7, 8, 9, 1 };

for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if(arr[i] == arr[j])
            Console.WriteLine($"{i+1}. eleman {j+1}. eleman eşittir.");
        else
            Console.WriteLine($"{i+1}. eleman {j+1}. eleman eşit değildir.");
    }
}
*/

/*
//Dizideki en uzun ve en kısa ismi bulan program
string[] names = new string[] {"Gizem Alptekin", "Halil Yıldırım", "Ahmet", "Hüseyin"};
string longName = "";
string shortName = names[0];

foreach (var name in names)
{
    if (name.Length > longName.Length)
        longName = name;
    else if (name.Length < shortName.Length)
        shortName = name;
}

Console.WriteLine($"En uzun kelime: {longName}");
Console.WriteLine($"En kısa kelime: {shortName}");
*/


/*
//Cümlenin kelimelerini alfabetik sıraya dizen program
Console.Write("Cümle giriniz: ");
string inputCumle = Console.ReadLine();

string[] bolunmusCumleninKelimeleri = inputCumle.Split(" ");
Array.Sort(bolunmusCumleninKelimeleri);

foreach (string kelime in bolunmusCumleninKelimeleri)
{
    Console.WriteLine(kelime);
}
*/

/*
//Dinamik olarak diziye kelime ekleyen ve diziyi genişleten program
string[] itemler = new string[2];
string dinamikEkle;
int elemanSayisi = 0;


while (true)
{
    Console.WriteLine("Dinamik olarak eklemek istediğiniz kelimeyi giriniz (Çıkmak için 'exit' yazın):");
    dinamikEkle = Console.ReadLine();

    if (dinamikEkle.ToLower() == "exit")
    {
        break;
    }

   
    else if (elemanSayisi >= itemler.Length)
    {
        Array.Resize(ref itemler, itemler.Length + 1);
    }

    itemler[elemanSayisi] = dinamikEkle;
    elemanSayisi++;
}

Console.WriteLine("\nEklenen Kelimeler:");
foreach (var item in itemler)
{
    Console.WriteLine(item);
}
*/


/*
//Listedeki kelimeleri ters çeviren program
List<string> kelimeler = new List<string>();

Console.WriteLine("Listeye eklemek istediğiniz kelimeleri giriniz.(Çıkmak için 'exit' yazınız.)");
Console.WriteLine("Eklediğiniz kelimeler tersten sıralanacaktır.");
for (int i = 0; i <= kelimeler.Count; i++)
{
    string input = Console.ReadLine();      
    
    if (input.ToLower() == "exit")
        break;
    
    else
        kelimeler.Add(input);
}

kelimeler.Reverse();
Console.WriteLine("Reverse edilmiş dizi:");

foreach (string kelime in kelimeler)
{
    
    Console.WriteLine(kelime);
}
*/


/*
//Kullanıcıdan ratgele sayılar alıp listeye ekleyen,bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritma
List<int> sayilar = new List<int>();

Console.WriteLine("Listeye eklemek istediğiniz sayıları giriniz.(Çıkmak için '000' yazınız.)");
for (int i = 0; i <= sayilar.Count; i++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    if (input == -1)
        break;
    else
        sayilar.Add(input);
}

Console.WriteLine($"Sayıların Ortalaması: {sayilar.Average()}");

sayilar.Sort();
Console.WriteLine("Sayıların küçükten büyüğe sırası: ");
foreach (int sayi in sayilar)
{
    Console.Write(sayi);
}
*/



//Kullanıcıdan alınan sayıları listeye ekleyen ve bu sayıların 10'dan küçük olanlarını silen program
List<int> sayilar = new List<int>();

while(true)
{
    Console.WriteLine("Sayı giriniz: ");
    int input = Convert.ToInt32(Console.ReadLine());
    
    sayilar.Add(input);
    
    if (input == -1)
        break;

}

sayilar.RemoveAll(n => n < 10); //RemoveAll metodu direk listeyi değiştirir bazı LİNQ metodları ise yeni bir liste döndürür. Bu yüzden tekrar "sayilar" listesine atamaya gerek kalmadı.

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}


List<int> sayilar = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

sayilar = sayilar.Select(n => n < 50 ? 50 : n).ToList();//Select metodu listeyi değiştirmez. Yepyeni bir liste döndürür. Bu yüzden tekrar listeye atamamız gerekiyor. DEFFERED QUERY(GECİKMELİ SORGU) GERÇEKLEŞTİRMEK İÇİN TOLIST KULLANDIK.

foreach (int sayi in sayilar)
{
    Console.WriteLine(sayi);
}