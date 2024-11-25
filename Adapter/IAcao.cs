namespace Adapter
{

    //O IAcao define a interface específica do domínio usada pelo código do cliente.
    internal interface IAcao
    {
        void Andar(string jogador);
        void Atirar();
    }
}