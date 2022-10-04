using CommonCodeProject;
using WeatherDataProject;
  

string _weather_filepath = @"C:\Users\cis\Desktop\test\weather.dat";
 
WeatherClass w = new WeatherClass(_weather_filepath);
List<Entity> data = w.GetData();
Entity SmallestSpreadWeather = w.GetAbsoluteDifferenceEntity(data);

Console.WriteLine("Question : Write the day number with the smallest temperature spread");
Console.WriteLine("Ans : " + SmallestSpreadWeather.Name.ToString());
Console.WriteLine("--------------------------------------------------");
