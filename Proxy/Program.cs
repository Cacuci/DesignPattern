using Proxy;

Client client = new();

Console.WriteLine("Client: Executando o codigo cliente com o Subject real");

RealSubject subject = new();

client.ClientCode(subject);

Console.WriteLine();

Console.WriteLine("client: Executando o mesmo cliente com o Proxy");

Proxy.Proxy proxy = new(subject);

client.ClientCode(proxy);