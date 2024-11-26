namespace Bridge
{
    // Todos os dispositivos seguem a mesma interface.
    internal class TV : IDevice
    {
        private double channel;
        private int volume;
        private bool isEnable;

        public void Disable() => Console.WriteLine("TV desligada");

        public void Enable() => Console.WriteLine("TV ligada");

        public double GetChannel() => channel;

        public int GetVolume() => volume;

        public bool IsEnable() => isEnable;

        public double SetChannel(double channel) => this.channel = channel;

        public int SetVolume(int volume) => this.volume = volume;
    }
}