namespace LectureEx_GenericClassesAndMethods_Hafsa
{
    internal class Program
    {
        // Method for swapping elements in a generic list
        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }

        static void Main(string[] args)
        {
            // Example usage of the TeamRoster class with FootballPlayer
            TeamRoster<FootBallPlayer> footballTeamRoster = new TeamRoster<FootBallPlayer>();
            FootBallPlayer player1 = new FootBallPlayer("Hafsa Mohamed", "11", 500);
            footballTeamRoster.AddPlayer(player1);

            // Example usage of the TeamRoster class with BaseballPlayer
            TeamRoster<BaseBallPlayer> baseballTeamRoster = new TeamRoster<BaseBallPlayer>();
            BaseBallPlayer player2 = new BaseBallPlayer("Hafsa Mohamed", "22", "Pitcher");
            baseballTeamRoster.AddPlayer(player2);

            // Accessing properties using the TeamRoster
            Console.WriteLine("Football Player Name: " + footballTeamRoster.Roster[0].Name);
            Console.WriteLine("Football Player Number: " + footballTeamRoster.Roster[0].Number);
            Console.WriteLine("Football Player Yards Run: " + footballTeamRoster.Roster[0].YardsRun);

            Console.WriteLine("Baseball Player Name: " + baseballTeamRoster.Roster[0].Name);
            Console.WriteLine("Baseball Player Number: " + baseballTeamRoster.Roster[0].Number);
            Console.WriteLine("Baseball Player Position: " + baseballTeamRoster.Roster[0].Position);

            // Example of using the generic Swap method
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Original List: " + string.Join(", ", numbers));

            Swap(numbers, 1, 3);

            Console.WriteLine("List after swapping: " + string.Join(", ", numbers));

        }
    }
}