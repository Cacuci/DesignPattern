namespace Bridge
{
    // A "abstração" define a interface para a parte "controle" das
    // duas hierarquias de classe. Ela mantém uma referência a um
    // objeto da hierarquia de "implementação" e delega todo o
    // trabalho real para esse objeto.
    internal class RemoteControl
    {
        protected readonly IDevice _device;

        public RemoteControl(IDevice device) => _device = device;

        internal void TogglePower()
        {
            if (_device.IsEnable())
            {
                _device.Disable();
            }
            else
            {
                _device.Enable();
            }
        }

        internal void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume() - 10);
        }

        internal void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume() + 10);
        }

        internal void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel() - 1);
        }

        internal void ChannelUp()
        {
            _device.SetChannel(_device.GetChannel() + 1);
        }
    }
}