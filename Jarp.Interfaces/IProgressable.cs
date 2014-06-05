using System;

namespace Jarp.Interfaces
{
    public interface IProgressable
    {
        event EventHandler Start;

        event EventHandler InProgress;

        event EventHandler Complete;
    }

    public interface IProgressable<TStartArg, TInProgressArgs, TCompleteArgs>
        where TStartArg : EventArgs
        where TInProgressArgs : EventArgs
        where TCompleteArgs : EventArgs
    {
        event EventHandler<TStartArg> Start;

        event EventHandler<TInProgressArgs> InProgress;

        event EventHandler<TCompleteArgs> Complete;
    }
}
