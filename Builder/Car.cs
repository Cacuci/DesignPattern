namespace Builder
{
    internal class Car
    {
        // Um carro pode ter um GPS, computador de bordo, e alguns
        // assentos. Diferentes modelos de carros (esportivo, SUV,
        // conversível) podem ter diferentes funcionalidades
        // instaladas ou equipadas.

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