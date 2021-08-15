//Day 10: Binary Numbers

public static void Main(string[] args)
{
        
  int decimalNumber = int.Parse(Console.ReadLine());

  int remainder;
  string result = string.Empty;
  while (decimalNumber > 0)
  {
    remainder = decimalNumber % 2;
    decimalNumber /= 2;
    result = remainder.ToString() + result;
  }
            
   string[] subs = result.ToString().Split('0');
            
    Console.WriteLine(subs.OrderByDescending(s => s.Length).Select(s=>s.Length).First());
}
