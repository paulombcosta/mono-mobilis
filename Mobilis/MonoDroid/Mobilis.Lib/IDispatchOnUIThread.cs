using System;

namespace Mobilis.Lib
{
    // Interface que exibe opera��o de acesso a thread principal
    public interface IDispatchOnUIThread
    {
        void invoke(Action action);
    }
}