namespace Builder
{
    // Ao contrário dos outros padrões criacionais, o Builder
    // permite que você construa produtos que não seguem uma
    // interface comum.
    internal class CarBuilder : IBuilder
    {
        private readonly Car car = new();

        public void SetConstruct()
        {
            Console.WriteLine("Construção um carro");
        }

        public void SetGPS()
        {
            Console.WriteLine("GPS");
            car.SetGPS();
        }

        public void SetSeats(byte number)
        {
            Console.WriteLine("Assentos " + number);
            car.SetSeats(number);
        }

        public void SetTripComputer()
        {
            Console.WriteLine("Computador de bordo");
            car.SetTripComputer();
        }

        // Builders concretos devem fornecer seus próprios
        // métodos para recuperar os resultados. Isso é porque
        // vários tipos de builders podem criar produtos
        // inteiramente diferentes que nem sempre seguem a mesma
        // interface. Portanto, tais métodos não podem ser
        // declarados na interface do builder (ao menos não em
        // uma linguagem de programação de tipo estático).
        //
        // Geralmente, após retornar o resultado final para o
        // cliente, espera-se que uma instância de builder comece
        // a produzir outro produto. É por isso que é uma prática
        // comum chamar o método reset no final do corpo do método
        // `getProduct`. Contudo este comportamento não é
        // obrigatório, e você pode fazer seu builder esperar por
        // uma chamada explícita do reset a partir do código cliente
        // antes de se livrar de seu resultado anterior.
        public Car GetProduct()
        {
            return car;
        }
    }
}