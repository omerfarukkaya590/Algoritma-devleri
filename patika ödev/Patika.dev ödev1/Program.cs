Console.WriteLine("-------------------------------");
Console.WriteLine("Lütfen bir sayı giriniz!");
Console.WriteLine("-------------------------------");


try
{
    int sayı1 = int.Parse(Console.ReadLine());
    
    
    int i=1;
    while ( i <= sayı1)
    {
        Console.Write($"Lütfen sayı giriniz!");
       int sayılar= int.Parse(Console.ReadLine());
       int[] sayılar2;
      
       sayılar2=new int [sayı1];
       sayılar2[i]=sayılar;
       if(sayılar% 2 == 0)
       {
          System.Console.WriteLine(sayılar2[i]);
       }
       
        i++;
        
    }
}
catch 
{
    Console.WriteLine("Geçersiz sembol.Lütfen sayfayı yenileyiniz.");
    return;
}
