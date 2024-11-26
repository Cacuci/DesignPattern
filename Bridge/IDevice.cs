namespace Bridge
{
    // A interface "implementação" declara métodos comuns a todas as
    // classes concretas de implementação. Ela não precisa coincidir
    // com a interface de abstração. Na verdade, as duas interfaces
    // podem ser inteiramente diferentes. Tipicamente a interface de
    // implementação fornece apenas operações primitivas, enquanto
    // que a abstração define operações de alto nível baseada
    // naquelas primitivas.
    internal interface IDevice
    {
        bool IsEnable();
        void Enable();
        void Disable();
        int GetVolume();
        int SetVolume(int volume);
        double GetChannel();
        double SetChannel(double channel);
    }
}