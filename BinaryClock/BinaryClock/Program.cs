//Scrieti un program C# care afiseaza in timp real un ceas digital. 

while(true)
{   
    DateTime now = DateTime.Now;
    string h1 = Convert.ToString((now.Hour)/10 , 2).PadLeft(4,'0');
    string h2 = Convert.ToString((now.Hour)%10 , 2).PadLeft(4,'0');
    string m1 = Convert.ToString((now.Minute)/10 , 2).PadLeft(4,'0');
    string m2 = Convert.ToString((now.Minute)%10 , 2).PadLeft(4,'0');
    string s1 = Convert.ToString((now.Second)/10 , 2).PadLeft(4,'0');
    string s2 = Convert.ToString((now.Second)%10 , 2).PadLeft(4,'0');
    Console.Clear();

    Console.WriteLine($"{ now: HH: mm: ss}");
    
    for(int i=0;i<=3;i++)
    {
        Console.WriteLine($"{8/Math.Pow(2,i)} | {h1[i]} {h2[i]} | {m1[i]} {m2[i]} | {s1[i]} {s2[i]} ");
    }
    Thread.Sleep(1000);
}