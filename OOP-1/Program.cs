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

        //Part 02 : Practical Questions//
        //1.

        public struct DeliveryAddress
        {
            string City;
            string Street;
            int BuildingNumber;

            public DeliveryAddress(string city, string street, int buildingNumber)
            {
                City = city;
                Street = street;
                BuildingNumber = buildingNumber;
            }

            public string GetFullAddress()
            {
                return $"{Street} {BuildingNumber}, {City}";
            }


        }


        static void Main(string[] args)
        {
            DeliveryAddress address = new DeliveryAddress("Nasr city", "Mostafa Al Nahhas", 10);
            DeliveryAddress addressCopy = address; //a copy of the struct
            addressCopy = new DeliveryAddress("Giza", "Tahrir", 5); //modifying the copy
            Console.WriteLine(address.GetFullAddress());
            Console.WriteLine(addressCopy.GetFullAddress());
        }
    }
}
