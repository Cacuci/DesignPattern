using Facade;

// O código do cliente pode já ter alguns dos objetos do subsistema
// criado. Neste caso, pode valer a pena inicializar o
// Fachada com esses objetos em vez de deixar a Fachada criar
//novas instâncias.

SubSystem1 subsystem1 = new();
SubSystem2 subsystem2 = new();

Facade.Facade facade = new(subsystem1, subsystem2);

Client.ClientCode(facade);