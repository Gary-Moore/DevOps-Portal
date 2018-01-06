using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevOps.Portal.Infrastructure.Git;
using NUnit.Framework;

namespace DevOps.Portal.Tests.Integration.SolutionCreation.Git
{
    [TestFixture]
    public class GitLabServiceTests : BaseTest
    {
        private IGitLabService Sut;

        [SetUp]
        public void Setup()
        {
            Sut = Get<IGitLabService>();
        }
        
    }
}
