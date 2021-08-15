//Day 8: Dictionaries and Maps

static void Main(string[] args)
{
   int n = Int32.Parse(Console.ReadLine());
   Dictionary<string,string> phonebook = new Dictionary<string,string>();

   for (int i = 0; i < n; i++)
   {
     string[] phonebookItem = Console.ReadLine().Split(' ');
     phonebook[phonebookItem[0]] = phonebookItem[1];
   }

           
   for(int i=0;i<n;i++)
   {
     string name = Console.ReadLine();
     if (phonebook.ContainsKey(name))
     {
        Console.WriteLine(name + "=" + phonebook[name]);
     }
     else
     {
        Console.WriteLine("Not found");
     }
   }          
}
