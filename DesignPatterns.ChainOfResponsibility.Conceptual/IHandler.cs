namespace DesignPatterns.ChainOfResponsibility.Conceptual
{
    /// <summary>
    /// A interface Handler declara um método para construir a cadeia de manipuladores.
    /// Ele também declara um método para executar uma solicitação.
    /// </summary>
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object  Handle(object request);
    }
}
