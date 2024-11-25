namespace Adapter
{

    // O Aviao (Adaptee) contém alguns comportamentos úteis, mas sua interface é
    // incompatível com o código do cliente existente. O "Adaptee" precisa de alguma
    // adaptação antes que o código do cliente possa usá-lo.
    internal class Aviao
    {
        public void Voar(string jogador)
        {
            Console.WriteLine(jogador + " voou para frente!");
        }

        public void SoltarMissil()
        {
            Console.WriteLine("Soltou um míssil no jogo!");
        }
    }
}