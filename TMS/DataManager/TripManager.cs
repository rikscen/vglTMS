using Framework;
using System.Collections.Generic;
using System.Text;
using TMS.DataUnit;
using TMS.Utilities;

namespace TMS.DataManager
{
    public class TripManager
    {
        private StringBuilder TMSSqlScript;
        private StringBuilder WMSSqlScript;
        private StringBuilder OMSSqlScript;

        public TripManager()
        {
            TMSSqlScript = new StringBuilder();
            WMSSqlScript = new StringBuilder();
            OMSSqlScript = new StringBuilder();
        }

        public void InsertTrip(TripUnit unit)
        {
            var param = new Dictionary<string, object>
            {
                { "trip_id", unit.TripId },
                { "vehicle", unit.VehicleId },
                { "in_charge", unit.Incharge },
                { "expected_start", unit.ExpectedStart },
                { "expected_end", unit.ExpectedEnd },
                { "actual_start", unit.ActualStart },
                { "actual_end", unit.ActualEnd },
                { "cost", unit.Cost },
                { "route", unit.RouteId },
                { "last_updated_on", unit.LastUpdated }
            };

            TMSSqlScript.AppendLine(DataSupport.GetUpsert("Trips", param, "trip_id"));
        }

        public void UpdateTrip()
        {
        }

        public void InsertTripOrder(TripOrderUnit unit)
        {
            var param = new Dictionary<string, object>
            {
                { "trip", unit.TripId },
                { "order_id", unit.OrderId },
                { "client", unit.ClientId },
                { "customer", unit.CustomerId },
                { "customer_delivery_address", unit.CustomerDeliveryAddress },
                { "status", unit.Status },
                { "remarks", unit.Remarks },
                { "reference", unit.Reference },
                { "reference_date", unit.ReferenceDate },
                { "oms", unit.OrderManagementSystem },
                { "doc_value", unit.DocumentValue },
                { "drop_sequence", unit.DropSequence },
            };

            TMSSqlScript.AppendLine(DataSupport.GetUpsert("TripOrders", param, "trip", "order_id"));
        }

        public void UpdateOutgoingShipmentRequest(string pk, string pkValue)
        {
            var param = new Dictionary<string, object>();
            List<string> pv = new List<string> { pkValue };

            param.Add("out_shipment_id", pkValue);
            param.Add("status", "FOR RELEASING");

            OMSSqlScript.AppendLine(DataSupport.GetUpdate("OutgoingShipmentRequests", param, pk));
        }

        public void WMSHeaderInsert(string tripId, string incharge)
        {
            var param = new Dictionary<string, object>();

            param.Add("trip_id", tripId);
            param.Add("authorized_receiver", incharge);
            param.Add("tms_name", DataSupport.GetTMSCode());
            WMSSqlScript.AppendLine(DataSupport.GetUpsert("ReleaseTrips", param, "trip_id"));
        }

        public void WMSDetailsInsert(string tripId, string orderId, string dropSequence, string expectedStart)
        {
            var param = new Dictionary<string, object>();

            List<string> pk = new List<string>
            {
                "order_id",
                "status"
            };

            List<string> pv = new List<string>
            {
                orderId,
                "FOR SCHEDULING"
            };

            param.Add("trip", tripId);
            param.Add("order_id", orderId);
            param.Add("drop_sequence", dropSequence);
            WMSSqlScript.AppendLine(DataSupport.GetUpsert("ReleaseTripDetails", param, "trip"));
            param.Clear();

            param.Add("status", "FOR PICKING");
            param.Add("order_id", orderId);
            param.Add("scheduled_release_date", expectedStart);
            WMSSqlScript.AppendLine(DataSupport.GetUpdate("ReleaseOrders", param, pk, pv));
            param.Clear();

            //WMSSqlScript.AppendLine(DataSupport.GetDelete("ReleaseTripDetails", "trip", tripId));
            //WMSSqlScript.AppendLine(DataSupport.GetDelete("ReleaseTrips", "trip_id", tripId));
        }

        public string GetSqlScript()
        {
            return $"{ TMSSqlScript.ToString() } { OMSSqlScript.ToString() }  { WMSSqlScript.ToString() }";
        }

        public int RunScript()
        {
            if (!string.IsNullOrEmpty(OMSSqlScript.ToString()) && !string.IsNullOrEmpty(WMSSqlScript.ToString()))
                return Connection.GetTMSConnection.ExecuteNonQuery(TMSSqlScript.ToString()) + Connection.GetOMSConnection.ExecuteNonQuery(OMSSqlScript.ToString()) + Connection.GetWMSConnection.ExecuteNonQuery(WMSSqlScript.ToString());

            return Connection.GetTMSConnection.ExecuteNonQuery(TMSSqlScript.ToString());
        }
    }
}