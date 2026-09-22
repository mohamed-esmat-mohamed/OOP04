using Smart_Delivery;
using System;
using System.Collections.Generic;
using System.Text;

namespace Smart_Delivery

{
    //Update 12%
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry { get; set; }

        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine();
            Console.WriteLine("Tracking Code       : " + TrackingCode);
            Console.WriteLine("Destination Country : " + DestinationCountry);
            Console.WriteLine("Estimated Cost      : " + EstimatedCost + " EGP");
        }

        public string GetTrackingStatus()
        {
            return "Shipment " + TrackingCode + " has been Delivered.";
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}