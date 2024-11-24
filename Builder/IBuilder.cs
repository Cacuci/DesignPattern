namespace Builder
{
    // Usar o padrão Builder só faz sentido quando seus produtos são
    // bem complexos e requerem configuração extensiva.
    internal interface IBuilder
    {
        void SetConstruct();
        void SetSeats(byte number);
        void SetTripComputer();
        void SetGPS();
    }
}