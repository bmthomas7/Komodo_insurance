using System;
using Dev_Team_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Komodo_Test
{
    [TestClass]
    public class DevTeamRepoTest
    {
        private DevTeamRepository _repo;
        private DevTeam _content;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new DevTeamRepository();
            _content = new DevTeam("ben", 1, true);


            _repo.AddContentToList(_content);


        }


        //add method

        [TestMethod]
        public void AddToList_ShouldGetNotNull()
        {
            //arrange --> setting up the playing field

            DevTeam content = new DevTeam();
            content.TeamMember = "";
            DevTeamRepository repository = new DevTeamRepository();


            // act --> get/run the code we want to test
            repository.AddContentToList(content);
            DevTeam contentFromDirectory = repository.GetContentByName("");

            // assert --> use the assert class to verify the expected outcome
            Assert.IsNotNull(contentFromDirectory);

        }

        // update
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange
            //testinitialize
            DevTeam newContent = new DevTeam("ben", 1, true);

            //act
            bool updateResult = _repo.UpdateExistingContent("ben", newContent);

            // assert
            Assert.IsTrue(updateResult);
        }

        [DataTestMethod]
        [DataRow("ben", true)]
        [DataRow("ryan", false)]
        public void UpdateExistingContent_ShouldMatchGivenBool(string originalName, bool shouldUpdate)
        {
            //arrange
            //testinitialize
            DevTeam newContent = new DevTeam("ben", 1, true);

            //act
            bool updateResult = _repo.UpdateExistingContent(originalName, newContent);

            // assert
            Assert.AreEqual(shouldUpdate, updateResult);
        }

        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            // arrange

            //act
            bool deleteResult = _repo.RemoveContentFromList(_content.TeamMember);

            Assert.IsTrue(deleteResult);
        }

    }
}
