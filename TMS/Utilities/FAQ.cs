using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Framework;
using System.IO;
using TMS;

public class FAQ
{
    public static int GetSequence(String trip_id)
    {
        for (int i = 1; i < 1000; i++)
        {
            DataTable dt = DataSupport.RunDataSet($"SELECT drop_sequence FROM TripOrders WHERE trip = '{ trip_id }' AND drop_sequence='{ i }'").Tables[0];
            if (dt.Rows.Count == 0)
                return i;
        }
        return 999;
    }

    public static decimal GetDocValue(String out_shipment_id)
    {
        decimal result = 0;
        DataSupport oms_dh = Connection.GetOMSConnection;
        DataTable dt = oms_dh.ExecuteDataSet("SELECT client, product, uom, expected_qty, price FROM OutgoingShipmentRequestDetails " +
                                             $"INNER JOIN OutgoingShipmentRequests ON out_shipment = out_shipment_id WHERE out_shipment = '{ out_shipment_id }';").Tables[0];
        foreach (DataRow row in dt.Rows)
        {
            var price = GetPrice(row["client"].ToString(), row["product"].ToString(), row["uom"].ToString());
            var amount = price * decimal.Parse(row["expected_qty"].ToString());
            result += amount;
        }

        return result;
    }

    public static decimal GetPrice(String client, String product, String uom)
    {
        decimal result = 0;
        // Check Promo Price Lists (to be done later)

        // Check Default Price List
        DataSupport oms = Connection.GetOMSConnection;
        result = decimal.Parse(oms.ExecuteDataSet($"SELECT price FROM itemPrice WHERE client = '{client}'  product = '{product}' AND uom ='{uom}'").Tables[0].Rows[0][0].ToString());

        return result;
    }

    public static String GetRoute(String customer, String oms)
    {
        DataTable dt = DataSupport.RunDataSet($"SELECT route FROM Customers WHERE customer_id = '{ customer }'").Tables[0];
        if (dt.Rows.Count > 0)
            return dt.Rows[0][0].ToString();
        return "";
    }

    public static bool IsDatesBlocked(string vehicle, DateTime start, DateTime end, ref string message)
    {
        // The date is blocked
        {
            DataTable dt = DataSupport.RunDataSet($"SELECT vehicle FROM VehicleBlocking WHERE  (vehicle = '{vehicle}' OR vehicle = 'ALL') AND date >= '{start}' AND date <= '{end}'").Tables[0];
            if (dt.Rows.Count > 0)
            {
                message = "Vehicle is blocked";
                return true;
            }
        }

        // The date is in conflict with another trip
        {
            var param = new Dictionary<string, object>();
            param.Add("@vehicle", vehicle);

            for (DateTime i = start; i <= end; i = i.AddDays(1))
            {
                param.Add("@date", i);
                if ((bool)Connection.GetTMSConnection.ExecuteScalar("SP_IsTripScheduleConflict", param))
                {
                    message = "Vehicle has conflict schedule";
                    return true;
                }

                param.Remove("@date");
            }
        }

        //{
        //    var param = new Dictionary<string, object>();
        //    for (DateTime i = start; i <= end; i = i.AddDays(1))
        //    {
        //        DataTable dt = DataSupport.RunDataSet("SELECT vehicle FROM Trips WHERE vehicle ='" + vehicle + "' AND '" + i + "' >= expected_start AND '" + i + "' <=expected_end ").Tables[0];
        //        if (dt.Rows.Count > 0)
        //            return true;
        //    }
        //}

        return false;
    }
}