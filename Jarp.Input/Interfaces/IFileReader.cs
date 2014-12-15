using Jarp.Input.EventArg;
using Jarp.Interfaces;

namespace Jarp.Input.Interfaces
{
    public interface IFileReader : IProgressable<ReadStartArgs,ReadInProgressArgs,ReadCompleteArgs>
    {
        string[] Read(string[] filePaths);
    }
}
