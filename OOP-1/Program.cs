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
            public string Destination(DeliveryAddress address)
            {
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
