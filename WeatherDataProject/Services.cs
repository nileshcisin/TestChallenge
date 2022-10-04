using CommonCodeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherDataProject
{
    public  class WeatherServices  
    {
        //private string _weather_filepath = @"C:\Users\cis\Desktop\test\weather.dat";

 
        //public List<WeatherClass> GetWeatherData()
        //{

        //    List<WeatherClass> WeatherListData = new List<WeatherClass>();
        //    string[] filedata = CommonCodeProject.Utility.GetUtilityInstant.ReadTxtFile(_weather_filepath);
            
        //    foreach (var  line in filedata)
        //    {
        //        if (line != filedata[0]) {
        //            WeatherClass w =  new WeatherClass();
        //            w.DayNumber  =  Convert.ToInt32( line.Substring(2, 2).Trim());
        //            w.Max = Convert.ToInt32(line.Substring(6, 2).Trim());
        //            w.Min= Convert.ToInt32(line.Substring(12, 2).Trim());
        //            w.Spread = Math.Abs( w.Max - w.Min);
        //            WeatherListData.Add(w);
        //        }
                
        //    }
                 
            
        //    return WeatherListData;

        //}

    }
}
