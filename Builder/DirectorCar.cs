namespace Builder
{
    // O diretor é apenas responsável por executar as etapas de
    // construção em uma sequência em particular. Isso ajuda quando
    // produzindo produtos de acordo com uma ordem específica ou
    // configuração. A rigor, a classe diretor é opcional, já que o
    // cliente pode controlar os builders diretamente.
    internal class DirectorCar
    {
        private readonly IBuilder _buider;

        // O diretor trabalha com qualquer instância builder que
        // o código cliente passar a ele. Dessa forma, o código
        // cliente pode alterar o tipo final do produto recém
        // montado. O diretor pode construir diversas variações
        // do produto usando as mesmas etapas de construção.
        public DirectorCar(IBuilder builder) => _buider = builder;

        public void ConstructSportCar()
        {
            _buider.SetConstruct();
            _buider.SetSeats(2);
            _buider.SetTripComputer();
            _buider.SetGPS();
        }

        public void ConstructSUVCar()
        {
            _buider.SetConstruct();
            _buider.SetSeats(5);
            _buider.SetTripComputer();
            _buider.SetGPS();
        }
    }
}