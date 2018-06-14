using Arch.Common.Entities;

namespace Arch.Factories
{
    public interface IMiladLaboratoryFactory
    {
        TaminPrescriptionDto Create(MiladClinicDs miladClinicDs);
    }
}