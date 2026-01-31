using System;  
  
namespace MyNamespace;  
  
class Program  
{
    static void Main(string[] args)
    {
        List<int> numbs = new List<int>()
        {
            1, //0
            2, //1
            3, //2
            4, //3
            5, //4
        };
        List<string> names = new List<string>();
        

        foreach (var num in numbs)
        {
            Console.WriteLine(num);
        }

        numbs.Add(66); //5 element
        
        numbs.Add(77); //6
        
        numbs.Remove(numbs[numbs.Count - 1]);
        
        foreach (var num in numbs)
        {
            Console.WriteLine(num);
        }
        
        bool cx = numbs.Contains(numbs[numbs.Count - 1]);
        
        Console.WriteLine("---------------------------------");
        Console.WriteLine(cx);
        
        
        names.Add("John"); //0
        names.Add("Jane"); //1
        names.Add("Tania"); //2

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        
        Console.WriteLine("------------------------------------------------");


        Dictionary<int, char> dic = new Dictionary<int, char>()
        {
            { 1, 'a' },
            { 3, 'b' },
            { 4, 'c' },
            { 5, 'd' },
            { 6, 'e' },
            { 7, 'f' },
            { 100, 'g' },
        };
        dic.Add(2, 'Y');
        dic.Add(9, 'Z');
        
        bool checkKey =  dic.ContainsKey(2);
        bool checkValue = dic.ContainsValue('Y');
        
        Console.WriteLine("------------------------------------------------");        
        
        Console.WriteLine(checkKey);
        Console.WriteLine(checkValue);
        
        
        Console.Write(dic[2]);
        Console.Write(dic[9]);

        string str1 = "sdsds";
        string str2 = "sdsds";
        
        string sd = string.Concat(str1, str2);
        
        
        Console.WriteLine(sd);

        
        string ff = "                    dddddddddddd ddddddddd ddddddd                                   ";
        
  
        Console.WriteLine(ff);
        
        string result = ff.Trim();

        Console.WriteLine(result);

        string ss = result.ToUpper();
        Console.WriteLine(ss);
        
        bool s = ff.Contains("d");
        
        Console.WriteLine(s);
        

        
        
        
        

        Console.ReadKey();
        
        

    }  
}