using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Sources;

namespace Lab2WenJames
{
    internal class Program
    {
        static void Main(string[] args)
        {
        GameManager manager = new GameManager(); //instance of GameManager created
        manager.PlayGame(); //call GameManager.Play(Game)
        }
    }
}
