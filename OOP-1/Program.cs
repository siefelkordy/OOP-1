namespace OOP_1
{
    internal class Program
    {
        //Part 01 : Theoretical Questions//
        //Q1a) When the copy is modified no change happens to the originalvalue as the struct is value type
        //Q1b) When the copy is modified the original value also changes as the class is reference type
        //Q2a)
        //1. You can acccess the fields of the struct from main code
        //2. No maintainability without encapsulation
        //3. No data validation without encapsulation
        //Q2b) Private fields are used to encapsulate the data and protect it from being accessed or modified directly from outside the struct
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
