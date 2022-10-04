using CommonCodeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerLeagueProject
{
    public class SoccerLeagueClass : MyAbractClass
    {

        public SoccerLeagueClass(string soccerLeague_filepath)
        {
             
            if (!System.IO.File.Exists(soccerLeague_filepath))
            {
                throw new Exception(soccerLeague_filepath + " file not found. please correct the path");
            }
            else
            {
                DataFilePath = soccerLeague_filepath;
            }
        }

        public override List<Entity> GetData()
        {
            List<Entity> ListofEntity = new List<Entity>();
            string[] filedata = CommonCodeProject.Utility.GetUtilityInstant.ReadTxtFile(DataFilePath);

            foreach (var line in filedata)
            {
                if (line != filedata[0])
                {
                    Entity w = new Entity();
                    
                    w.Name = line.Substring(7, 16).Trim();
                    w.value1 = Convert.ToInt32(line.Substring(40, 6).Trim());
                    w.value2 = Convert.ToInt32(line.Substring(48, 7).Trim());
                    w.Difference = Math.Abs(w.value2 - w.value1);
                    ListofEntity.Add(w);
                }

            }


            return ListofEntity;
        }
    }
}
