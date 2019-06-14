namespace TMS.DataUnit
{
    public class TripUnit
    {
        public string TripId { get; set; }
        public string VehicleId { get; set; }
        public string plateno { get; set; }
        public string Incharge { get; set; }
        public string ExpectedStart { get; set; }
        public string ExpectedEnd { get; set; }
        public string ActualStart { get; set; }
        public string ActualEnd { get; set; }
        public string Cost { get; set; }
        public string RouteId { get; set; }
        public string LastUpdated { get; set; }
        public string Driver { get; set; }
        public string Helper1 { get; set; }
        public string Helper2 { get; set; }
        public string Helper3 { get; set; }
    }

    public class TripOrderUnit
    {
        public string TripId { get; set; }
        public string OrderId { get; set; }
        public string ClientId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerDeliveryAddress { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string Reference { get; set; }
        public string ReferenceDate { get; set; }
        public string OrderManagementSystem { get; set; }
        public string DocumentValue { get; set; }
        public string DropSequence { get; set; }
    }

    public class TripOrderDetailUnit
    {
        public string TripId { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ExpectedQuantity { get; set; }
        public string ReceivedQuantity { get; set; }
        public string DeliveredQuantity { get; set; }
        public string ReturnedQuantity { get; set; }
        public string UndeliveredQuantity { get; set; }
    }

    public class TripOrderDetailDetailsUnit
    {
        public string TripId { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string UnitOfMeasure { get; set; }
        public string LotNumber { get; set; }
        public string Expiry { get; set; }
        public string ExpectedQuantity { get; set; }
        public string ReceivedQuantity { get; set; }
        public string DeliveredQuantity { get; set; }
        public string ReturnedQuantity { get; set; }
        public string UndeliveredQuantity { get; set; }
    }
}