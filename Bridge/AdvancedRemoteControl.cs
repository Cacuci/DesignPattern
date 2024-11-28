namespace Bridge
{
    // Você pode estender classes a partir dessa hierarquia de
    // abstração independentemente das classes de dispositivo.
    internal class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device) { }

        private void Mute() => _device.SetVolume(0);
    }
}