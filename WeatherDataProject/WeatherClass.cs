using CommonCodeProject;
using System.Xml.Linq;

namespace WeatherDataProject
{
    public class WeatherClass : MyAbractClass
    {
        public WeatherClass(string weather_filepath)
        {
            if (!System.IO.File.Exists(weather_filepath))
            {
                throw new Exception(weather_filepath + " file not found. please correct the path");
            }
            else
            {
                DataFilePath = weather_filepath;
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
                    w.Name = line.Substring(2, 2).Trim();
                    w.value1 = Convert.ToInt32(line.Substring(6, 2).Trim());
                    w.value2 = Convert.ToInt32(line.Substring(12, 2).Trim());
                    w.Difference = Math.Abs(w.value2 - w.value1);
                    ListofEntity.Add(w);
                }

            }


            return ListofEntity;


        }

    }


}