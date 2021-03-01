using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SuperListXUnitTestOrnek
{
    public class SuperList<T> : IEnumerable<T>
    {
        List<T> veriler = new List<T>();

        public virtual void Ekle(T obj)
        {
            veriler.Add(obj);
            // veriler.Add(obj); // sırf testten fail olması için yapıyorum
        }

        public virtual void Sil(T obj)
        {
            veriler.Remove(obj);
        }

        public virtual void CokluEkle(IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                Ekle(item);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return veriler.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
