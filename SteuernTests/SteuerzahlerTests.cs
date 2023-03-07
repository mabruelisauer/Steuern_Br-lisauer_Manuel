namespace Steuern_Brülisauer_Manuel
{
    [TestClass]
    public class SteuerzahlerTests
    {
        [TestMethod]
        public void PersonTest()
        {
            //Arrange
            Person Joe_Miller = new Person(6400);

            //Act
            int Steuern = Joe_Miller.berechneSteuer();

            //Assert
            Assert.AreEqual(1600, Steuern);
        }

        [TestMethod]
        public void PersonTest2()
        {
            //Arrange
            Person Joe_Griller = new Person(1);

            //Act
            int Steuern = Joe_Griller.berechneSteuer();

            //Assert
            Assert.AreEqual(0, Steuern);
        }

        [TestMethod]
        public void ArbeiterTest()
        {
            //Arrange
            Arbeiter Jonny_Worker = new Arbeiter(36000);

            //Act
            int Steuern = Jonny_Worker.berechneSteuer();

            //Assert
            Assert.AreEqual(6600, Steuern);
        }

        [TestMethod]
        public void ArbeiterTest2()
        {
            //Arrange
            Arbeiter Jonny_Twerker = new Arbeiter(9600);

            //Act
            int Steuern = Jonny_Twerker.berechneSteuer();

            //Assert
            Assert.AreEqual(0, Steuern);
        }

        [TestMethod]
        public void BankerTest()
        {
            //Arrange
            Banker Fred_Moneymaker = new Banker(4000000);

            //Act
            int Steuern = Fred_Moneymaker.berechneSteuer();

            //Assert
            Assert.AreEqual(1001000, Steuern);
        }

        [TestMethod]
        public void BankerTest2()
        {
            //Arrange
            Banker Fred_Honeymaker = new Banker(0);

            //Act
            int Steuern = Fred_Honeymaker.berechneSteuer();

            //Assert
            Assert.AreEqual(1000, Steuern);
        }

        [TestMethod]
        public void KoeniginTest()
        {
            //Arrange
            Koenigin Silvia = new Koenigin(1000000);

            //Act
            int steuern = Silvia.berechneSteuer();

            //Assert
            Assert.AreEqual(0, steuern);
        }

        [TestMethod]
        public void KoeniginTest2()
        {
            //Arrange
            Koenigin Silvia = new Koenigin(0);

            //Act
            int steuern = Silvia.berechneSteuer();

            //Assert
            Assert.AreEqual(0, steuern);
        }

        [TestMethod]
        public void UnternehmenTest()
        {
            //Arrange
            Unternehmen MeierHansAG = new Unternehmen(500000);

            //Act
            int steuern = MeierHansAG.berechneSteuer();

            //Assert
            Assert.AreEqual(35000, steuern);
        }

        [TestMethod]
        public void UnternehmenTest2()
        {
            //Arrange
            Unternehmen MeierHansAG = new Unternehmen(1);

            //Act
            int steuern = MeierHansAG.berechneSteuer();

            //Assert
            Assert.AreEqual(0, steuern);
        }
    }
}