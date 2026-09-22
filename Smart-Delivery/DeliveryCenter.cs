using Smart_Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery

{
    public class DeliveryCenter
    {
        private List<Shipment> items = new List<Shipment>();

        public void AddShipment(Shipment shipment)
        {
            items.Add(shipment);
        }

        public void PrintAllShipments()
        {
            foreach (Shipment s in items)
            {
                s.PrintShipment();
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine();
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (ITrackable t in items)
            {
                Console.WriteLine(t.GetTrackingStatus());
                Console.WriteLine();
            }
        }
    }
}