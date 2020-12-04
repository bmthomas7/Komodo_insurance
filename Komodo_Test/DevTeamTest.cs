using System;
using Dev_Team_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Test
{
    [TestClass]
    public class DevTeamTest
    {
        [TestMethod]
        public void SetTeamMember_ShouldSetCorrectString()
        {
            DevTeam content = new DevTeam();

            content.TeamMember = "team";

            string expected = "team";
            string actual = content.TeamMember;

            Assert.AreEqual(expected, actual);
        }
    }
}
