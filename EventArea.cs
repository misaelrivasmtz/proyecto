using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
     public class EventArea
    {
        public int AreaID { get; set; }
        public string Area { get; set; }

        public EventArea()
        {
            AreaID = 0;
            Area = "";
        }

        public EventArea(int areaID, string area)
        {
            AreaID = areaID;
            Area = area;
        }
    }
}
