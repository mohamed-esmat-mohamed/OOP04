using Smart_Delivery;
using System;
using System.Collections.Generic;
using System.Text;



namespace Smart_Delivery
{
    // Update
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine();
            Console.WriteLine("Tracking Code : " + TrackingCode);
            Console.WriteLine("Description   : " + Description);
            Console.WriteLine("Estimated Cost: " + EstimatedCost + " EGP");
        }

        // Q 4
        public string GetTrackingStatus()
        {
            return "Shipment " + TrackingCode + " is Ready.";
        }

        // Q5
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}