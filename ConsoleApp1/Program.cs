namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt listInt = new ListInt();

            listInt.Add(5);
            listInt.Add(10);
            listInt.Add(15);
            listInt.Add(20);

            Console.WriteLine("Element 2: " + listInt[2]); 

            listInt[2] = 25;

            Console.WriteLine("Element 2: " + listInt[2]);  

            listInt.AddRange(30, 35, 40);

            Console.WriteLine("Cem: " + listInt.Sum());  

            listInt.Remove(25);

            Console.WriteLine("Contains 25: " + listInt.Contains(25));  

            listInt.RemoveRange(30, 40);

            Console.WriteLine(listInt.ToString());  
        }
    }
   
}