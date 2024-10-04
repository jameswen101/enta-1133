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
                response = Console.ReadLine();
                if (response == "yes" || response == "Yes")
                {
                    manager.PlayGame(); //call GameManager.Play(Game)
                } //if code ends
            }  while (response == "yes" || response == "Yes");

        }
    }
}
