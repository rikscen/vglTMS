using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMS.DataUnit;

namespace TMS.DataManager
{
    public class VehicleManager : DataSupport
    {
        public static void Insert(VehicleUnit unit)
        {
            var param = new Dictionary<string, object>();
            param.Add("vehicle_id", unit.VehicleId);
            param.Add("type", unit.VehicleType);
            param.Add("plate_no", unit.PlateNumber);
            RunNonQuery(GetInsert("Vehicles", param));
        }

        public static void Update(VehicleUnit unit, string pk, string pkValue)
        {
            var param = new Dictionary<string, object>();
            param.Add("vehicle_id", unit.VehicleId);
            param.Add("type", unit.VehicleType);
            param.Add("plate_no", unit.PlateNumber);
            RunNonQuery(GetUpdate("Vehicles", param, pk));
        }
    }
}