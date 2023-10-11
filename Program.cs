namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> integers = new ArrayList<int>();
            integers.Add(112);
            integers.Add(114);
             
            int element = integers.RemoveAt(1);
            int c1=integers.Count(1);

            Console.WriteLine("Integers: {0}", string.Join(" ", c1));
            

           /* ArrayList<string> strings = new ArrayList<string>();
            strings.Add("Hello");
            strings.Add("World");
            Console.WriteLine("Strings: {0}", string.Join(" ", strings)); */
        }
    }
}