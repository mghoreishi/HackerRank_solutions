//Day 5: Loops

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(n.ToString()+" x "+i.ToString()+" = "+ i*n);
        }
    }
}
