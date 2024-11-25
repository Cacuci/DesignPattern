using Adapter;

IAcao personagem = new Personagem();

Application(personagem);

Aviao aviao = new();

IAcao adapter = new Adapter.Adapter(aviao);

Application(adapter);

Console.ReadKey();

static void Application(IAcao acao)
{
    acao.Andar("Rafael");
    acao.Atirar();
}