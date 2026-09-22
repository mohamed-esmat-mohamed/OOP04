using Smart_Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery

{
    // DeliveryReport
    public static class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }

        public static void PrintInsurance(IInsurable shipment)
        {
            string typeName = shipment.GetType().Name;
            string label = typeName.Substring(0, typeName.Length - "Shipment".Length) + " Shipment";

            Console.WriteLine(label + " Insurance : " + shipment.CalculateInsurance().ToString("0.00") + " EGP");
        }
    }
}