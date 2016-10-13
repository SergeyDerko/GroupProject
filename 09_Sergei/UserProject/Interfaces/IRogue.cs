namespace UserProject.Interfaces
{
    internal interface IRogue : IUser
    {
        int Mutilate();
        int DeadlyPoison();
        int Stealth();
    }
}