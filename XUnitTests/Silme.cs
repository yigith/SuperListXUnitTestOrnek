using SuperListXUnitTestOrnek;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace XUnitTests
{
    public class Silme
    {
        [Fact]
        public void SilinmeyiDogrula()
        {
            var liste = new SuperList<char>();
            liste.Ekle('a');
            liste.Ekle('b');
            liste.Ekle('c');
            // silme öncesi a,b,c listede bulunmalı
            Assert.Contains('a', liste);
            Assert.Contains('b', liste);
            Assert.Contains('c', liste);
            liste.Sil('b');
            // silme sonrası a ve c durmalı b silinmiş olmalı
            Assert.Contains('a', liste);
            Assert.DoesNotContain('b', liste);
            Assert.Contains('c', liste);
        }

        [Fact]
        public void SilmeSonrasiAdetAzalmali()
        {
            var liste = new SuperList<char>();
            liste.Ekle('a');
            liste.Ekle('b');
            liste.Ekle('c');
            // silme öncesi adet 3 olmalı
            Assert.Equal(3, liste.Count());
            liste.Sil('a');
            // silme sonrası adet 2 olmalı
            Assert.Equal(2, liste.Count());
        }
    }
}
