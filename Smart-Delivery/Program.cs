namespace Smart_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryAddress addr1 = new DeliveryAddress("Cairo", "Egypt");
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 2, 95, addr1);
            DeliveryAddress addr2 = new DeliveryAddress("Alexandria", "Egypt");
            ExpressShipment express = new ExpressShipment("SH002", "Phone", 1, 70, 30, addr2);

            DeliveryAddress addr3 = new DeliveryAddress("Berlin", "Germany");
            InternationalShipment international = new InternationalShipment("SH003", "Books", 5, 260, "Germany", addr3);
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            deliveryCenter.AddShipment(standard);
            deliveryCenter.AddShipment(express);
            deliveryCenter.AddShipment(international);

            Console.WriteLine("=============================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("=============================================");
            Console.WriteLine();

            deliveryCenter.PrintAllShipments();

            Console.WriteLine("Tracking Status");
            Console.WriteLine();

            deliveryCenter.PrintTrackingStatuses();

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Insurance");
            Console.WriteLine();

            IInsurable[] insurables = new IInsurable[] { standard, express, international };
            foreach (IInsurable insurable in insurables)
            {
                DeliveryReport.PrintInsurance(insurable);
            }

            Console.WriteLine("=============================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");

            Console.ReadLine();
        }
    }
}
