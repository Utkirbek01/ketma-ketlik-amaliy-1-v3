using System.Globalization;

// 1-vazifa: Doira yuzi va aylana uzunligini hisoblash
Console.WriteLine("=== 1. Doira yuzi va aylana uzunligi ===");
Console.Write("radius=");
double radius = double.Parse(Console.ReadLine()!.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
double S = Math.PI * Math.Pow(radius, 2);   // S = pi * radius^2
double L = 2 * Math.PI * radius;            // L = 2 * pi * radius
Console.WriteLine($"S={S.ToString("G15", CultureInfo.InvariantCulture)}, L={L.ToString("G15", CultureInfo.InvariantCulture)}");

// 2-vazifa: Valyuta konvertri
Console.WriteLine("\n=== 2. Valyuta konvertri ===");
Console.Write("qiymat=");
decimal qiymat = decimal.Parse(Console.ReadLine()!.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
Console.Write("kurs (so'm)=");
decimal kurs = decimal.Parse(Console.ReadLine()!.Trim().Replace(',', '.'), CultureInfo.InvariantCulture);
decimal natija = qiymat * kurs;
Console.WriteLine($"{natija.ToString("0.##", CultureInfo.InvariantCulture)} so'm");

// 3-vazifa: Yoshni kunlarda hisoblash (kabisa yili hisobga olinmaydi)
Console.WriteLine("\n=== 3. Yoshni hisoblash ===");
Console.Write("x=");
int x = int.Parse(Console.ReadLine()!.Trim());
const int joriyYil = 2023; // topshiriq namunalari 2023-yil asosida (2004 -> 6935, 1996 -> 9855)
int kunlar = (joriyYil - x) * 365;
Console.WriteLine(kunlar);
