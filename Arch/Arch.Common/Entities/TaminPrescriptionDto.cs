using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Common.Entities
{
    public class TaminPrescriptionDto
    {
        public string ReceptionNo { get; set; }
        public string WhichFrom { get; set; }
        public IEnumerable<TaminDetailPrescriptionDto> DetailEpresclist { get; set; }
        public TaminHeadPrescriptionDto HeadPrescriptionDto { get; set; }
        public TaminPrescriptionPatient PrescriptionPatient { get; set; }
    }
}
