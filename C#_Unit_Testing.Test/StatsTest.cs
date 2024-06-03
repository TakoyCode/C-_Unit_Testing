namespace C__Unit_Testing.Test
{
    public class StatsTests
    {
        [Test]
        public void TestWithTwoNumbers()
        {
            // arrange - sette opp ting som vi �nsker det
            var stats = new Stats();

            // act - kaller vi koden vi vil sjekke skal funke
            stats.Add(3);
            stats.Add(4);

            // assert - sjekker om de har blitt riktig
            Assert.AreEqual(2, stats.Count);
            Assert.AreEqual(7, stats.Sum);
            Assert.AreEqual(4, stats.Max);
            Assert.AreEqual(3, stats.Min);
            Assert.AreEqual(3.5, stats.Mean);

        }

        // N�r man tester ting vil du teste hva som kan g� feil, s� en generelt r�d er � alltid teste grense tilfellene.
        // Eksempel p� et grensetilfelle:
        [Test]
        public void TestEmptyStats()
        {
            // arrange - sette opp ting som vi �nsker det
            var stats = new Stats();

            // act - kaller vi koden vi vil sjekke skal funke


            // assert - sjekker om de har blitt riktig
            Assert.AreEqual(0, stats.Count);
            Assert.AreEqual(0, stats.Sum);
            Assert.IsNull(stats.Max);
            Assert.IsNull(stats.Min);
            Assert.AreEqual(float.NaN, stats.Mean);

            // Dette funka ikke som forventet s� m�tte endre p� denne testen
            // Her forventer vi at koden kommer til � kalle en DivideByZeroException, fordi vi deler med 0.
            // Assert.Throws<DivideByZeroException>(() => { var m = stats.Mean; });

        }

        [Test]
        public void TestWithThreeNumbers()
        {
            // arrange - sette opp ting som vi �nsker det
            var stats = new Stats();

            // act - kaller vi koden vi vil sjekke skal funke
            stats.Add(2);
            stats.Add(4);
            stats.Add(9);

            // assert - sjekker om de har blitt riktig
            Assert.AreEqual(3, stats.Count);
            Assert.AreEqual(15, stats.Sum);
            Assert.AreEqual(9, stats.Max);
            Assert.AreEqual(2, stats.Min);
            Assert.AreEqual(5, stats.Mean);

        }
    }
}