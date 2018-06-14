using Arch.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arch.Tests.Fixtures;

namespace Arch.Tests.LaboratoryFactoryTests
{
    public class Given_ClinicFactory:AAA
    {
        protected MiladClinicFactory Sut;
        protected MiladClinicFactoryFixture Fixture;
        public override void Arrage()
        {
            base.Arrage();
            Fixture = new MiladClinicFactoryFixture();
            Sut = Fixture.Create();
        }
    }
}
