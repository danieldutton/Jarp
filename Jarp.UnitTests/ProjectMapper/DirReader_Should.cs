using Jarp.ProjectMapper;
using NUnit.Framework;

namespace Jarp.Tests.ProjectMapper
{
    [TestFixture]
    public class DirReader_Should
    {
        [Test]
        public void Foo()
        {
            var sut = new DirReader();
            var result = sut.GetFiles(@"C:\Users\Dan\Documents\GitHub\TempPlus_Java");
            
            int i = 10;
        }
    }
}
