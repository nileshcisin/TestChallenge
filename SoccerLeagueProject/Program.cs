using CommonCodeProject;
using SoccerLeagueProject;
 

string _football_filepath = @"C:\Users\cis\Desktop\test\football.dat";

SoccerLeagueClass  sl = new SoccerLeagueClass(_football_filepath);
List<Entity> data = sl.GetData();
Entity SmallestDiffTeam = sl.GetAbsoluteDifferenceEntity(data);

Console.WriteLine("Question : Write the name of the team with the smallest difference in ‘for’ and ‘against’ goals.");
Console.WriteLine("Ans : " + SmallestDiffTeam.Name.ToString());
Console.WriteLine("--------------------------------------------------");



