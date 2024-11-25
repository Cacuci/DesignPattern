namespace Adapter
{
    internal class Personagem : IAcao
    {
        public void Andar(string jogador)
        {
            Console.WriteLine(jogador + " andou para frente!");
        }

        public void Atirar()
        {
            Console.WriteLine("Atirou no jogo!");
        }
    }
}