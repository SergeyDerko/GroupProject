using System.Deployment.Internal;

namespace UserProject
{
    internal interface IRecruit
    {
        int Str { get; set; }
        int Agi { get; set; }
        int Int { get; set; }
        int Health { get; set; }
        int Exp { get; set; }
        int Lvl { get; set; }

        int LevelUp();
    }
}