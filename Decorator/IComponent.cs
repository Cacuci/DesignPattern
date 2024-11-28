namespace Decorator
{
    // A interface do componente base define operações que podem ser alteradas por Decorators.
    internal interface IComponent
    {
        string Operation();
    }
}