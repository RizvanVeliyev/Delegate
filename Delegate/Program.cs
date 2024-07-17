namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(15);
            list.Add(2);
            list.Add(34);
            list.Add(2);

            Console.WriteLine("Our list:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine();


            int found = list.Find(3);

            Console.WriteLine($"Found: {found}");
            Console.WriteLine();
            Console.WriteLine();

            List<int> foundAll = list.FindAll(2);
            Console.WriteLine("Find all 2:");
            foreach (int num in foundAll)
            {
                Console.Write(num+" ");
            }
            Console.WriteLine();
            Console.WriteLine();

            list.Remove(3);
            Console.WriteLine("List after removing element 3:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            list.RemoveAll(2);
            Console.WriteLine("List after remove all 2:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]+" ");
            }
        }
    }
}