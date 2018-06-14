namespace Arch.Common.Entities
{
    public class TaminDetailPrescriptionDto
    {
        public decimal SRV_ID { get; set; }
        public string SRV_Code { get; set; }

        public int SRV_QTY { get; set; }

        public System.Nullable<int> TIMESADAY { get; set; }
        public string DOSE { get; set; }
        public System.Nullable<int> DRUG_INST_ID { get; set; }

    }
}