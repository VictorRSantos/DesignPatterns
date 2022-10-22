namespace DesignPatterns.ChainOfResponsibility.Conceptual
{
    /// <summary>
    /// O comportamento de encadeamento padrão pode ser implementado dentro de um manipulador base class.
    /// </summary>
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;

            // Retorna um manipulador daqui nos permitirá vincular manipuladores em uma maneira conveniente como está:
            // monkey.SetNext(squirrel).SetNext(dog)
            return handler;
        }
        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

    }
}
