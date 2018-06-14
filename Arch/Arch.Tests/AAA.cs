using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Tests
{
    public class AAA : IDisposable
    {
        public AAA()
        {
            Arrage();
            Act();
        }
        public virtual void Arrage()
        {
        }

        public virtual void Act()
        {
        }

        public virtual void Clean()
        {
        }

        public void Dispose()
        {
            Clean();
        }
    }
}
