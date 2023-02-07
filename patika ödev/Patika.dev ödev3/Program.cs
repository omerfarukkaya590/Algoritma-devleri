System.Console.WriteLine("Lütfen bir sayı giriniz!");




    int n= int.Parse(Console.ReadLine());
    string[] dizi= new string[n];
    int c=0;
    int i=1;
    while (i<=n)
    {
        System.Console.WriteLine("Lütfen kelime yazınız");
        string a = Console.ReadLine();
        dizi[c]=a+" ";
        c++;
        i++;
        if(c==n)
        {
            Array.Reverse(dizi);
             foreach (var item in dizi)
            {
                
                 System.Console.Write(item);
            }

 
        }
    }
   


