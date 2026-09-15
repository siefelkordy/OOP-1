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
        public struct Shipment
        {
            string TrackingCode;
            string Description;
            int Weight;
            decimal DeliveryFee;

            DeliveryAddress destination;
            public string Destination(DeliveryAddress address)
            {
                destination = address;
                return address.GetFullAddress();
            }
            //Constructor 1
            public Shipment(string trackingcode)
            {
                TrackingCode = trackingcode;
                Description = "Unknown";
                Weight = 1;
                DeliveryFee = 50;
                Destination(new DeliveryAddress("Nasr city", "Mostafa El Nahhas", 10));//Default address
            }
            //Constructor 2
            public Shipment(string trackingcode, string description, int weight, decimal deliveryfee, DeliveryAddress destination)
            {
                TrackingCode = trackingcode;
                Description = description;
                Weight = weight;
                DeliveryFee = deliveryfee;
                Destination(destination);
            }
            //Tracking code property
            ////////////////////////
            //Tracking code Setter
            public void SetTrackingCode(string trackingcode)
            {
                if(trackingcode == null || trackingcode == "")
                {
                    throw new ArgumentException("Tracking code cannot be null or empty.");
                }
                TrackingCode = trackingcode;
            }
            //Tracking code Getter
            public string GetTrackingCode()
            {
                return TrackingCode;
            }
            ////////////////////////
            //Description property
            ////////////////////////
            //Description Setter
            public void SetDescription(string description)
            {
                if (description == null || description == "")
                {
                    throw new ArgumentException("Description cannot be null or empty.");
                }
                Description = description;
            }
            //Description Getter
            public string GetDescription()
            {
                return Description;
            }
            ///////////////////////
            //Weight property
            ///////////////////////
            //Weight Setter
            public void SetWeight(int weight)
            {
                if (weight <= 0)
                {
                    throw new ArgumentException("Weight must be greater than zero.");
                }
                Weight = weight;
            }
            //Weight Getter
            public int GetWeight()
            {
                return Weight;
            }
            ///////////////////////
            //DeliveryFee property
            //////////////////////
            //DeliveryFee Setter
            public void SetDeliveryFee(decimal deliveryfee)
            {
                if (deliveryfee < 0)
                {
                    throw new ArgumentException("Delivery fee cannot be negative.");
                }
                DeliveryFee = deliveryfee;
            }
            //DeliveryFee Getter
            public decimal GetDeliveryFee()
            {
                return DeliveryFee;
            }
            ////////////////////////
            //EstimatedCost property
            ////////////////////////
            //EstimatedCost Getter
            public decimal GetEstimatedCost()
            {
                return DeliveryFee + (Weight * 5);
            }
            //Update Delivery Fee method
            public void UpdateDeliveryFee(decimal newDeliveryFee)
            {
                if (newDeliveryFee < 0)
                {
                    throw new ArgumentException("Delivery fee cannot be negative.");
                }
                DeliveryFee = newDeliveryFee;
            }
            //Print Shipment Details method
            public void PrintShipmentDetails()
            {
                Console.WriteLine("////////////////////////////////\nShipment Details:");
                Console.WriteLine($"Tracking Code: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Weight: {Weight} kg");
                Console.WriteLine($"Delivery Fee: ${DeliveryFee}");
                Console.WriteLine($"Destination: {destination.GetFullAddress()}");
                Console.WriteLine($"Estimated Cost: ${GetEstimatedCost()}");
                Console.WriteLine("----------------------------------\n");
                
            }

        }

        static void Main(string[] args)
        {
            //deliveryaddress address = new deliveryaddress("nasr city", "mostafa al nahhas", 10);
            //deliveryaddress addresscopy = address; //a copy of the struct
            //addresscopy = new deliveryaddress("giza", "tahrir", 5); //modifying the copy
            //console.writeline(address.getfulladdress());
            //console.writeline(addresscopy.getfulladdress());

            //creating a shipment using the first constructor
            //shipment shipment1 = new shipment("abc123");
            //shipment1.printshipmentdetails();
            //creating a shipment using the second constructor
            //shipment shipment2 = new shipment("xyz789", "electronics", 2, 100, new deliveryaddress("cairo", "tahrir", 5));
            //shipment2.printshipmentdetails();
            //shipment shipment3 = new shipment("lmn456", "books", 3, 75, new deliveryaddress("alexandria", "corniche", 15));
            //shipment3.printshipmentdetails();

            //Input for shipments taken from the user
            //Using constructor 1
            Console.WriteLine("Enter Shipment 1 Data:");
            Console.WriteLine("Tracking Code:");
            string trackingCode1 = Console.ReadLine();
            Shipment shipment1 = new Shipment(trackingCode1);
            //Using constructor 2
            Console.WriteLine("Enter Shipment 2 Data:");
            Console.WriteLine("Tracking Code:");
            string trackingCode2 = Console.ReadLine();
            Console.WriteLine("Description:");
            string description2 = Console.ReadLine();
            Console.WriteLine("Weight:");
            int weight2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Delivery Fee:");
            decimal deliveryFee2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Destination Address:");
            Console.WriteLine("City:");
            string city2 = Console.ReadLine();
            Console.WriteLine("Street:");
            string street2 = Console.ReadLine();
            Console.WriteLine("Building Number:");
            int buildingNumber2 = int.Parse(Console.ReadLine());
            Shipment shipment2 = new Shipment(trackingCode2, description2, weight2, deliveryFee2, new DeliveryAddress(city2, street2, buildingNumber2));
            shipment2.SetTrackingCode(trackingCode2);
            shipment2.SetDescription(description2);
            shipment2.SetWeight(weight2);
            shipment2.SetDeliveryFee(deliveryFee2);
            //Using constructor 3
            Console.WriteLine("Enter Shipment 3 Data:");
            Console.WriteLine("Tracking Code:");
            string trackingCode3 = Console.ReadLine();
            Console.WriteLine("Description:");
            string description3 = Console.ReadLine();
            Console.WriteLine("Weight:");
            int weight3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Delivery Fee:");
            decimal deliveryFee3 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Destination Address:");
            Console.WriteLine("City:");
            string city3 = Console.ReadLine();
            Console.WriteLine("Street:");
            string street3 = Console.ReadLine();
            Console.WriteLine("Building Number:");
            int buildingNumber3 = int.Parse(Console.ReadLine());
            Shipment shipment3 = new Shipment(trackingCode3, description3, weight3, deliveryFee3, new DeliveryAddress(city3, street3, buildingNumber3));
            shipment3.SetTrackingCode(trackingCode3);
            shipment3.SetDescription(description3);
            shipment3.SetWeight(weight3);
            shipment3.SetDeliveryFee(deliveryFee3);
            //Print Shipment Details

            shipment1.PrintShipmentDetails();
            shipment2.PrintShipmentDetails();
            shipment3.PrintShipmentDetails();






        }
    }
}
