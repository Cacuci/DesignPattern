namespace Bridge
{
    // Todos os dispositivos seguem a mesma interface.
    internal class Radio : IDevice
    {
        private double channel;
        private int volume;
        private bool isEnable;

        public void Disable() => Console.WriteLine("Rádio desligado");

        public void Enable() => Console.WriteLine("Rádio deligado");

        public double GetChannel() => channel;

        public int GetVolume() => volume;

        public bool IsEnable() => isEnable;

        public double SetChannel(double channel) => this.channel = channel;

        public int SetVolume(int volume) => this.volume = volume;
    }
}