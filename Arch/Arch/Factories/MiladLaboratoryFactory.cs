using Arch.Common.Entities;

namespace Arch.Factories
{
    public class MiladLaboratoryFactory : IMiladLaboratoryFactory
    {
        public TaminPrescriptionDto Create(MiladClinicDs miladClinicDs)
        {
          
            var taminLaboratoryPresc = new TaminPrescriptionDto();
            taminLaboratoryPresc.ReceptionNo = miladClinicDs.Reception.ReceptionNo;
            taminLaboratoryPresc.WhichFrom = "آزمایشگاه";
            taminLaboratoryPresc.HeadPrescriptionDto = new TaminHeadPrescriptionDto();
            taminLaboratoryPresc.DetailEpresclist =new TaminDetailPrescriptionDto[0];
            var  detailPrescriptionDto = new TaminDetailPrescriptionDto()
            {

            };
        
            taminLaboratoryPresc.PrescriptionPatient = new TaminPrescriptionPatient();

          
            return taminLaboratoryPresc;
        }
    }
}