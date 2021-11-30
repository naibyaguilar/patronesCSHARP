using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    //  El comportamiento de encadenamiento por defecto puede ser implementado dentro de un handler base
    abstract class AbstractHandler :IHandler
    {
    private IHandler _nextHandler;

    public IHandler SetNext(IHandler handler)
    {
        this._nextHandler = handler;

        // Returning a handler from here will let us link handlers in a
        // convenient way like this:
        // monkey.SetNext(squirrel).SetNext(dog);
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
