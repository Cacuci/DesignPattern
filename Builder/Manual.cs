namespace Builder
{
    internal class Manual
    {
        // Cada carro deve ter um manual do usuário que corresponda
        // a configuração do carro e descreva todas suas
        // funcionalidades.
        public bool GPS { get; private set; }
        public byte Seat { get; private set; }
        public bool TripComputer { get; private set; }

        public void SetGPS()
        {
            GPS = true;
        }

        public void SetSeats(byte number)
        {
            Seat = number;
        }

        public void SetTripComputer()
        {
            TripComputer = true;
        }
    }
}