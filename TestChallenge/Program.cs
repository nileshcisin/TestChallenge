using CommonCodeProject;
using WeatherDataProject;
using SoccerLeagueProject;



string _weather_filepath = @"d:\Users\cis\Desktop\test\weather.dat";
string _football_filepath = @"d:\Users\cis\Desktop\test\football.dat";
try
{

    WeatherClass w = new WeatherClass(_weather_filepath);
    List<Entity> wdata = w.GetData();
    Entity SmallestSpreadWeather = w.GetAbsoluteDifferenceEntity(wdata);

    Console.WriteLine("Question : Write the day number with the smallest temperature spread");
    Console.WriteLine("Ans : " + SmallestSpreadWeather.Name.ToString());
    Console.WriteLine("--------------------------------------------------");



    SoccerLeagueClass sl = new SoccerLeagueClass(_football_filepath);
    List<Entity> sdata = sl.GetData();
    Entity SmallestDiffTeam = sl.GetAbsoluteDifferenceEntity(sdata);

    Console.WriteLine("Question : Write the name of the team with the smallest difference in ‘for’ and ‘against’ goals.");
    Console.WriteLine("Ans : " + SmallestDiffTeam.Name.ToString());

}
catch (Exception ex)
{
    Console.WriteLine("-------------ERROR-------------");
    Console.WriteLine(ex.Message);
    Console.WriteLine("-------------------------------");
}
