

class Solution
{
    public static void Main(string[] args)
    {
       string S = Console.ReadLine();

        try {
            Console.WriteLine(int.Parse(S));
        }
        catch(FormatException) {
            Console.WriteLine("Bad String");
        }
    }
}
