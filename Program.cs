namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager manager = new GameManager(); //instance of GameManager created
            String response = " ";
            do
            {
                Console.WriteLine("    _                                                      _       \r\n   / \\   _ __ ___   _   _  ___  _   _   _ __ ___  __ _  __| |_   _ \r\n  / _ \\ | '__/ _ \\ | | | |/ _ \\| | | | | '__/ _ \\/ _` |/ _` | | | |\r\n / ___ \\| | |  __/ | |_| | (_) | |_| | | | |  __/ (_| | (_| | |_| |\r\n/_/   \\_\\_|  \\___|_ \\__, |\\___/_\\__,_| |_|  \\___|\\__,_|\\__,_|\\__, |\r\n| |_ ___    _ __ | ||___/ _   |__ \\                          |___/ \r\n| __/ _ \\  | '_ \\| |/ _` | | | |/ /                                \r\n| || (_) | | |_) | | (_| | |_| |_|                                 \r\n \\__\\___/  | .__/|_|\\__,_|\\__, (_)                                 \r\n           |_|            |___/                                    ?");
                //asks the user if they would like to play
                response = Console.ReadLine();
                if (response.ToUpper() != "YES" && response.ToUpper() != "NO")
                {
                    Console.WriteLine("Please enter a valid response."); //keep telling the user to type a valid response until they type yes or no
                } //if code ends
                if (response.ToUpper() == "YES")
                {
                    manager.PlayGame(); //play the game
                } //if code ends
            }  while (response.ToUpper() != "NO");
        }
    }
}
