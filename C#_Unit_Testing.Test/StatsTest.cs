namespace C__Unit_Testing.Test
{
    public class StatsTests
    {
        [Test]
        public void TestWithTwoNumbers()
        {
            // arrange - sette opp ting som vi ønsker det
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

        // Når man tester ting vil du teste hva som kan gå feil, så en generelt råd er å alltid teste grense tilfellene.
        // Eksempel på et grensetilfelle:
        [Test]
        public void TestEmptyStats()
        {
            // arrange - sette opp ting som vi ønsker det
            var stats = new Stats();

            // act - kaller vi koden vi vil sjekke skal funke


            // assert - sjekker om de har blitt riktig
            Assert.AreEqual(0, stats.Count);
            Assert.AreEqual(0, stats.Sum);
            Assert.IsNull(stats.Max);
            Assert.IsNull(stats.Min);
            Assert.AreEqual(float.NaN, stats.Mean);

            // Dette funka ikke som forventet så måtte endre på denne testen
            // Her forventer vi at koden kommer til å kalle en DivideByZeroException, fordi vi deler med 0.
            // Assert.Throws<DivideByZeroException>(() => { var m = stats.Mean; });

        }

        [Test]
        public void TestWithThreeNumbers()
        {
            // arrange - sette opp ting som vi ønsker det
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