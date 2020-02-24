using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sparkfish_WebApi
{
    class Listify : IList
    {
        private IEnumerable<int> _contents;
        public Listify(int min, int max)
        {
            _contents = Enumerable.Range(min, max);
        }
        
        /*8set purposely throws exception because it has to be implemented for IList interface,
         but we don't want this value to be changed outside of the class*/
        public object this[int index] { get => _contents.ElementAt(index); set => throw new NotImplementedException(); }
        
        //Required to implement IList interface, but not used
        public int Count => throw new NotImplementedException();
        public bool IsSynchronized => throw new NotImplementedException();
        public object SyncRoot => throw new NotImplementedException();
        public bool IsFixedSize => throw new NotImplementedException();
        public bool IsReadOnly => throw new NotImplementedException();
        public int Add(object value){ throw new NotImplementedException(); }
        public void Clear(){ throw new NotImplementedException(); }
        public bool Contains(object value){ throw new NotImplementedException(); }
        public void CopyTo(Array array, int index){ throw new NotImplementedException(); }
        public IEnumerator GetEnumerator(){ throw new NotImplementedException(); }
        public int IndexOf(object value){ throw new NotImplementedException(); }
        public void Insert(int index, object value){ throw new NotImplementedException(); }
        public void Remove(object value){ throw new NotImplementedException(); }
        public void RemoveAt(int index){ throw new NotImplementedException(); }
    }
}
