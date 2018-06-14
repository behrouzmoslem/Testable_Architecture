using Arch.Common.Entities;
using Arch.Tests.LaboratoryFactoryTests;
using System.Collections.Generic;
using System.Linq;
using Arch.Tests.Builders;
using Xunit;

namespace Arch.Tests.LaboratoryFactoryTests
{

    public class When_CreateTaminPrescList : Given_ClinicFactory
    {
        private  IEnumerable<TaminPrescriptionDto> result;
        private MiladClinicDs miladClinicDs;
        public override void Arrage()
        {
            base.Arrage();
            miladClinicDs = new MiladClinicDsBuilder();
        }

        public override void Act()
        {
            base.Act();

            result = Sut.Create(miladClinicDs);
        }

        [Fact]
        public void Then_()
        {
       
        }
    }
   
}