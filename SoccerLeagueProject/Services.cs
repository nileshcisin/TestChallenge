using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLeagueProject
{
    public  class SoccerLeagueServices
    {
        //private string _football_filepath oo= @"C:\Users\cis\Desktop\test\football.dat";

        //public List<SoccerLeagueClass> GetSoccerData()
        //{

        //    List<SoccerLeagueClass> SoccerListData = new List<SoccerLeagueClass>();
        //    string[] filedata = CommonCodeProject.Utility.GetUtilityInstant.ReadTxtFile(_football_filepath);
            
        //    foreach (var  line in filedata)
        //    {
        //        if (line != filedata[0]) {
        //            SoccerLeagueClass s =  new SoccerLeagueClass();
        //            s.TeamName = line.Substring(7, 16).Trim();
        //            s.For = Convert.ToInt32( line.Substring(40, 6).Trim()); 
        //            s.Against = Convert.ToInt32(line.Substring(48, 7).Trim());
        //            s.Difference = Math.Abs(s.For - s.Against );
        //            SoccerListData.Add(s);
        //        }
                
        //    }                 
            
        //    return SoccerListData;

        //}

    }
}