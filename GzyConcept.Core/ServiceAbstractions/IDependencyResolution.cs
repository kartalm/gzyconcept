using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GzyConcept.Core.ServiceAbstractions
{
    public interface IDependencyResolution
    {
        T GetInstance<T>() where T : class;

    }
}
