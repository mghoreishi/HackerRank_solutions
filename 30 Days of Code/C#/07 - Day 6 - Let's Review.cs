//Day 6: Let's Review


static void Main(String[] args) 
 {
     /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your   class should be named Solution */
     int n = Convert.ToInt32(Console.ReadLine());
     List<string> input = new List<string>();
     for(int i=0;i<n;i++)
     {
        string s = Console.ReadLine();
        input.Add(s);
     }

     for(int j=0;j<input.Count;j++)
     {
        var evens =string.Concat(input[j].Where((c, i) => i % 2 == 0));
        var odds = string.Concat(input[j].Where((c, i) => i % 2 != 0));
              
        Console.WriteLine(evens + " " + odds);
      }
 }
