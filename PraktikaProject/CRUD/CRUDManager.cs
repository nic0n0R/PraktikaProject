using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraktikaProject.CRUD
{
    public class CRUDManager
    {
        public int LastClickedButton { get; set; }
    }

    public enum Tables
    {
        None,
        Employee,
        Brigade,
        Road, 
        Noda,
        Station,
        Depo,
        Lokomitiv_serial,
        Lokomotiv,
        Route,
        Follow_up,
        Lokomotiv_changed_state,
        Route_timing,
        Lokomotive_crew_passengers,
        Drain_energy,
        ALCN_and_traffic_lights
    }
}
