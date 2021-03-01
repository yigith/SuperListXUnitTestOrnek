using Moq;
using SuperListXUnitTestOrnek;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTests
{
    public class CokluEkleme
    {
        [Fact]
        public void CokluEklendigindeOgeSayisiKadarEkleMetoduCagir()
        {
            var mockSuperList = new Mock<SuperList<int>>();
            mockSuperList.CallBase = true; // virtual metotlari override ettiğinde miras alınan (base) metodu da çağır
            var sayilar = new int[] { 3, 5, 11 };
            mockSuperList.Object.CokluEkle(sayilar);
            mockSuperList.Verify(x => x.Ekle(It.IsAny<int>()), Times.Exactly(3));
        }
    }
}
