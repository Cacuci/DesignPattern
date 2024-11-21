namespace FactoryMethod
{
    // A classe Factory declara o método de fábrica que deve retornar
    // um objeto de uma classe Transport. As subclasses do Factory geralmente fornecem
    // a implementação deste método.
    internal abstract class Factory
    {
        // Observe que o Criador também pode fornecer alguma implementação padrão de
        // o método de fábrica.
        protected abstract ITransport FactoryMethod();

        // Observe também que, apesar do nome, o principal
        // responsabilidade não é criar produtos. Geralmente contém alguns
        // lógica de negócios principal que depende de objetos Transport, retornados pelo
        // método de fábrica. As subclasses podem alterar indiretamente essa lógica de negócios
        // substituindo o método de fábrica e retornando um tipo diferente de
        // produto dele.
        public virtual string Operation()
        {
            // Chame o método fábrica para criar um objeto Transport.
            var transport = FactoryMethod();

            // Agora, use o Transport.
            var result = "O mesmo código do criado acabou de trabalhar com " + transport.Deliver();

            return result;
        }
    }
}