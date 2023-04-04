int sayi1, sayi2;

Console.Write("1. Sayıyı Giriniz: ");
sayi1= Convert.ToInt32(Console.ReadLine());
Console.Write("2. Sayıyı Giriniz: ");
sayi2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sayi1+" + "+sayi2+" = "+(sayi1+sayi2));
Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, (sayi1+sayi2));

