System.Console.WriteLine("lütfen iki sayı giriniz!");



try
{
    int n= int.Parse(Console.ReadLine());
    int m= int.Parse(Console.ReadLine());
    System.Console.WriteLine($"Lütfen {n} adet sayı giriniz");
    
      string[] dizi;
        dizi =new string[n];
        int a=1;

    int i=1;
    while (i<=n)
    {
      int sayı = int.Parse(Console.ReadLine());
      

        if (m % sayı == 0)
        {
            string yy = sayı.ToString();
            dizi[a]=yy;
            a++;
        }

        i++;

    }
foreach (var item in dizi) {
            Console.WriteLine(item);
        }


}
catch
{
    System.Console.WriteLine("Lütfen sayfayı yenileyiniz");
    throw;
}

