using Framework;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TMS.DataUnit;
using TMS.Utilities;

namespace TMS.DataManager
{
    public class RouteManager
    {
        private StringBuilder SqlScript;

        public enum InsertType : byte
        {
            CustomerRoute,
            Route,
            RouteSchedule
        }

        public RouteManager()
        {
            SqlScript = new StringBuilder();
        }

        public void Insert(List<IUnit> units, InsertType type)
        {
            var param = new Dictionary<string, object>();

            if (type == InsertType.CustomerRoute)
            {
                foreach (CustomerRouteUnit unit in units)
                {
                    param.Add("custCode", unit.CustomerId);
                    param.Add("route", unit.RouteId);
                    param.Add("customer", unit.CustomerName);
                    param.Add("address", unit.CustomerAddress);
                    SqlScript.AppendLine(DataSupport.GetInsert("Customers", param));
                    param.Clear();
                }
            }
            else if (type == InsertType.RouteSchedule)
            {
                foreach (RouteScheduleUnit unit in units)
                {
                    param.Add("route", unit.RouteId);
                    param.Add("date", unit.RouteDate);
                    param.Add("vehicle", unit.VehicleId);
                    SqlScript.AppendLine(DataSupport.GetInsert("RouteSchedules", param));
                    param.Clear();
                }
            }
        }

        public void Update(List<IUnit> units, InsertType type)
        {
            var param = new Dictionary<string, object>();

            if (type == InsertType.CustomerRoute)
            {
                foreach (CustomerRouteUnit unit in units)
                {
                    param.Add("custCode", unit.CustomerId);
                    param.Add("route", unit.RouteId);
                    param.Add("customer", unit.CustomerName);
                    param.Add("address", unit.CustomerAddress);
                    SqlScript.AppendLine(DataSupport.GetUpdate("Customers", param, "customer_id"));
                    param.Clear();
                }
            }
            else if (type == InsertType.Route)
            {
            }
        }

        public static List<RouteUnit> GetRoutes()
        {
            List<RouteUnit> routes = new List<RouteUnit>();
            foreach (DataRow row in Connection.GetTMSConnection.ExecuteStoredProcedure("SP_GetRoutes", null).Rows)
            {
                routes.Add(new RouteUnit
                {
                    RouteId = row["route_id"].ToString(),
                    RouteCode = row["route_code"].ToString()
                });
            }
            return routes;
        }

        public static bool FindRoute(string route)
        {
            return GetRoutes().Find(x => x.RouteCode.ToUpper() == route.ToUpper()) != null;
        }

        public string GetSqlScript()
        {
            return SqlScript.ToString();
        }

        public void RunScript()
        {
            Connection.GetTMSConnection.ExecuteNonQuery(SqlScript.ToString());
        }
    }
}