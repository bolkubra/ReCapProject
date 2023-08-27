using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key); // böyle de yazılabilir ama tip dönüşümü gerektirir
        void Add(string key, object value, int duration); // duration: cache'de ne kadar duracak
        bool IsAdd(string key); // veri cache'de varmı? yoksa cache ekle 
        void Remove(string key); // cache'den uçurma
        void RemoveByPattern(string pattern); // içinde get vs. olaları getir
    }
}
