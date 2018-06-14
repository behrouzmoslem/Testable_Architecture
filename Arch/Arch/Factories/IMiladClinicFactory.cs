using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Common.Entities;

namespace Arch.Factories
{
    public interface IMiladClinicFactory
    {
        IEnumerable<TaminPrescriptionDto> Create(MiladClinicDs miladClinicDs);
    }
}
