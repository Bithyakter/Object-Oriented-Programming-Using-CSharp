namespace Interfaces
{
    interface IPrinter
    {
        void SetIpAddress(string ip);
        void Print();

        string GetBasicInformation();       //Explicit Interface Implementation
    }
}

