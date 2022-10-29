using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libArrayList
{
    public interface IArrayList<T>
    {
        void Add(T item);
        bool RemoveAt(int index);
        bool Remove(T item);
        void Clear();
        T this[int index] { get; set; }
        int count { get; }
        void InsertAt(int index, T value);
    }
}
