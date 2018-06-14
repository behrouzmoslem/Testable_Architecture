using System;
using System.Collections.Generic;

namespace Arch.Common.Entities
{
    public class MiladClinicListDs
    {
        public MiladReceptionDs Reception { set; get; }
     
        public IEnumerable<MiladLaboratoryListDs> Laboratories { set; get; }
 

    }

    public class MiladReceptionDs
    {

        public int Id { get; set; }
        public string ReceptionNo { get; set; }
        public string ReceptionDate { get; set; }
        public string ReceptionTime { get; set; }
        public ShiftDs Shift { get; set; }
        public InsuranceDs Insurance { get; set; }
        public PatientDs Patient { set; get; }
        public DoctorBase Doctor { set; get; }
        public UnitDs Clinic { set; get; }
        public int SequenceNo { get; set; }
        public ReceptionStatusDs ReceptionStatus { set; get; }


    }
    public class DoctorBase : PersonDs
    {
        public string MedicalNo { get; set; }
    }
    public class PatientDs
    {
        public PersonDs Person { get; set; }
    }
    public class ShiftDs
    {
        public byte Id { get; set; }
        public string Title { get; set; }
    }
    public class AuthorizedToAcceptClinicsDs
    {
        public string Id { get; set; }
        public string Title { get; set; }
    }
    public class UnitDs
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class InsuranceDs
    {
        public int Id { get; set; }
        public string Title { get; set; }

    }
    public class GenderDs
    {
        public byte Id { get; set; }
        public string Title { get; set; }
    }
    public class PersonDs
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string FullName => string.Format($"{FName} {LName}");
        public string NationalCode { get; set; }
        public string FatherName { get; set; }
        public string BirthDate { get; set; }
        public GenderDs Gender { get; set; }
    }
    public class OperatorDs : PersonDs
    {
        public string Id { get; set; }
        public string UserName { get; set; }
    }
    public class StatusTypeDs
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Date { get; set; }
        public OperatorDs Operator { get; set; }
    }
    public class ReceptionStatusDs
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int ReceptionId { get; set; }
        public DateTime Date { get; set; }
        public StatusTypeDs Status { get; set; }
        public OperatorDs Operator { get; set; }
    }

    public class MiladClinicDs
    {
        public MiladReceptionDs Reception { set; get; }
        public MiladLaboratoryListDs Laboratory { set; get; }




    }
    public class MiladLaboratoryDs
    {
        public int Id { get; set; }
        public int SequenceNo { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsEmergency { get; set; }
        public DateTime? Date { get; set; }
        public int ReceptionId { get; set; }
        public OperatorDs Operator { get; set; }
        public decimal LaboratoryMasterId { get; set; }


    }
    public class MiladLaboratoryListDs : MiladLaboratoryDs
    {
        public IEnumerable<LaboratoryItemDs> LaboratoryItems { get; set; }
    }
    public class LaboratoryItemDs
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public int LaboratoryRequestMasterId { get; set; }
        public DateTime Date { get; set; }
        public LaboratoryCodeDs Code { get; set; }
        public OperatorDs Operator { get; set; }
    }
    public class LaboratoryGroupCodes
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<LaboratoryCodeDs> LaboratorySubGroupCodes { get; set; }
    }
    public class LaboratoryCodeDs
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}