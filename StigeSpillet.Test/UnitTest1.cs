using StigeSpilletTDD.Main;

namespace StigeSpilletTDD.Test
{
    public class Tests
    {
        [Test]
        public void TestStartAt0()
        {
            // lager ett nytt spill
            var game = new Game(4);
            // får alle plassene til spillerene
            var position = game.GetPlayerPosition(0);
            // sjekker at vi starter på 0
            Assert.AreEqual(0, position);
        }

        [Test]
        public void TestInitialMove()
        {
            // lager ett nytt spill
            var game = new Game(4);
            // flytter spiller 1, 4 plasser
            game.Move(0, 4);

            // får alle plassene til spillerene
            var position = game.GetPlayerPosition(0);
            // sjekker at vi starter på 0
            Assert.AreEqual(4, position);
        }

        [Test]
        public void TestMultiplePLayerPosition()
        {
            // lager ett nytt spill med 2 spillere
            var game = new Game(2);

            // flytter spiller 1, 3 plasser og spiller 2, 4 plasser
            game.Move(0,3);
            game.Move(1,4);

            // sjekker plassen til spillerene
            Assert.AreEqual(3, game.GetPlayerPosition(0));
            Assert.AreEqual(4, game.GetPlayerPosition(1));
        }
        // Eksempel på en TestCase:
        [TestCase (1,40)]
        [TestCase (36,52)]
        [TestCase (24,5)]
        public void TestLadder(int posFrom, int posTo)
        {
            // lager ett nytt spill med 1 spiller
            var game = new Game(1);

            // flytter spiller 1, 1 plass
            game.Move(0, posFrom);

            // sjekker plassen til spilleren
            Assert.AreEqual(posTo, game.GetPlayerPosition(0));
        }
        //[Test]
        //public void TestLadderFrom1To40()
        //{
        //    // lager ett nytt spill med 1 spiller
        //    var game = new Game(1);

        //    // flytter spiller 1, 1 plass
        //    game.Move(0,1);

        //    // sjekker plassen til spilleren
        //    Assert.AreEqual(40, game.GetPlayerPosition(0));
        //}
        [Test]
        public void TestDiceMax6()
        {
            // lager ett nytt spill med 1 spiller
            var game = new Game(1);

            // flytter spiller 1, 1 plass
            game.Move(0, 7);

            // sjekker plassen til spilleren
            Assert.AreEqual(0, game.GetPlayerPosition(0));
        }
        [Test]
        public void TestWinning()
        {
            // lager ett nytt spill med 1 spiller
            var game = new Game(1);

            // flytter spiller 1, 1 plass
            game.Move(0, 1);
            game.Move(0, 3);
            game.Move(0, 3);
            game.Move(0, 6);
            game.Move(0, 2);

            var winner = game.GetWinner();

            // sjekker plassen til spilleren
            Assert.AreEqual(0, winner);
        }
        [Test]
        public void TestNotWinning()
        {
            // lager ett nytt spill med 1 spiller
            var game = new Game(1);

            // flytter spiller 1, 1 plass
            game.Move(0, 2);

            var winner = game.GetWinner();

            // sjekker plassen til spilleren
            Assert.IsNull(winner);
        }
    }
}