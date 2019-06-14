using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.DataUnit
{
    public interface IUnit { }

    public class CustomerRouteUnit : IUnit
    {
        public string CustomerId { get; set; }
        public string RouteId { get; set; }
        public string RouteCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
    }

    public class RouteUnit : IUnit
    {
        public string RouteId { get; set; }
        public string RouteCode { get; set; }
        public string Description { get; set; }
    }

    public class RouteScheduleUnit : IUnit
    {
        public string RouteId { get; set; }
        public string RouteDate { get; set; }
        public string VehicleId { get; set; }
    }
}