using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Drop
    {
        private string Real_Drop_Adress { get; set; }
        private string Estimated_Drop_Adress { get; set; }
        private double Mistake_Distance { get; set; }
        private DateTime Drop_time { get; set; }
        // private  string Drop_name { get; set; }
        private struct Lat_Long {public double Latitude;  public double Longitude;}  
       private  string GPS_Coordinates { get; set; }
       private List <Report> Reports { get; set; }
    }
}
