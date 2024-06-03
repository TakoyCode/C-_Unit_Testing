# EnhetsTesting

**Enhetstesting (Unit testing)** er at man isolerer sm� enheter av koden og tester dem for � sikre at de oppf�rer seg som forventet.
Det sikrer at hver del av koden fungerer individuelt, uavhengig av andre komponenter i koden.

En **enhet (unit)** refererer til den minste testbare delen av programvare,
for eksempel en metode, funksjon eller klasse.

En **testcase (enkel enhetstest)** der inngangsdata og resultat skal bli forh�ndsdefinert, 
hvor de da blir sammen liknet i forhold the det egentlige utfallet n�r programmet har kj�rt.

Et **enhetstest-rammeverk** gir strukturer og retningslinjer for � skrive og kj�re enhetstester.
For C# er det flere popul�re rammeverk som MSTest, NUnit og xUnit.

Eksempel med NUnit:

Klassen vi har:

```
 public class MinKlasse
    {
        public int Leggsammen(int a, int b)
        {
            return a + b;
        }
    }
```

Her vil vi teste LeggeSammen-metoden med NUnit:
```
using NUnit.Framework;

[TestFixture]
public void LeggSammen_GittToVerdier_ReturnererSummen()
{
    MinKlasse test = new MinKlasse();
    int result = test.LeggSammen(3,4);
    Assert.AreEqual(7, result)
}
```
Her lager vi en ny instans av klassen for � hente metoden vi �nsker � teste.
Vi lagrer svaret som metoden gir oss i variabelen result,
og kj�rer en Assert.AreEqual for � sjekke om resultatet det burde f� (7) er det samme som det faktiske resultatet (result).
