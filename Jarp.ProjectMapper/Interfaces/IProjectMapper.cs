using System.Collections.Generic;

namespace Jarp.ProjectMapper.Interfaces
{
    public interface IProjectMapper
    {
        IEnumerable<string> GetFiles(string path);
    }
}
