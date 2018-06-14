using System.Collections.Generic;
using Arch.Common.Entities;

namespace Arch.Factories
{
    public class MiladClinicFactory : IMiladClinicFactory
    {
        private IMiladLaboratoryFactory laboratoryFactory;

        public MiladClinicFactory(IMiladLaboratoryFactory laboratoryFactory)
        {
            this.laboratoryFactory = laboratoryFactory;
        }

        public IEnumerable<TaminPrescriptionDto> Create(MiladClinicDs miladClinicDs)
        {
            var taminPrescriptions = new List<TaminPrescriptionDto>();
            var taminLaboratoryPresc = this.laboratoryFactory.Create(miladClinicDs);

            taminPrescriptions.Add(taminLaboratoryPresc);
            return taminPrescriptions;
        }
    }
}