using SuperListXUnitTestOrnek;
using System;
using System.Linq;
using Xunit;

namespace XUnitTests
{
    public class SuperListTestleri
    {
        [Fact]
        public void YeniOgeEkleninceSayiBirArtar()
        {
            SuperList<string> kelimeler = new SuperList<string>();
            var oncekiAdet = kelimeler.Count();

            kelimeler.Ekle("dünya");
            var sonrakiAdet = kelimeler.Count();

            bool birFazlasiMi = sonrakiAdet == oncekiAdet + 1;

            Assert.True(birFazlasiMi, "Ekleme sonrasý öðe sayýsý doðru deðil!");
        }

        [Fact]
        public void BosListeyeEklenenOgelerDogruSiradadir()
        {
            SuperList<int> sayilar = new SuperList<int>();
            sayilar.Ekle(3);
            sayilar.Ekle(5);
            var ilkOge = sayilar.First();
            var ikinciOge = sayilar.Skip(1).First();
            Assert.Equal(3, ilkOge);
            Assert.Equal(5, ikinciOge);
        }
    }
}
