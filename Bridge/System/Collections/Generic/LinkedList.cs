using Bridge;
using System.Runtime.Serialization;

namespace System.Collections.Generic
{
    public class LinkedList<T> : ICollection<T>, ICollection, ISerializable, IDeserializationCallback
    {
        public LinkedList()
        {
        }

        public LinkedList(IEnumerable<T> collection)
        {
        }

        protected LinkedList(SerializationInfo info, StreamingContext context)
        {
        }

        void VerifyReferencedNode(LinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        static void VerifyBlankNode(LinkedListNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> AddAfter(LinkedListNode<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void AddAfter(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> AddBefore(LinkedListNode<T> node, T value)
        {
            throw new NotImplementedException();
        }

        public void AddBefore(LinkedListNode<T> node, LinkedListNode<T> newNode)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(LinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> AddFirst(T value)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> AddLast(T value)
        {
            throw new NotImplementedException();
        }

        public void AddLast(LinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int index)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> Find(T value)
        {
            throw new NotImplementedException();
        }

        public LinkedListNode<T> FindLast(T value)
        {
            throw new NotImplementedException();
        }

        public Enumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }

        public virtual void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(LinkedListNode<T> node)
        {
            throw new NotImplementedException();
        }

        public void RemoveFirst()
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {
            throw new NotImplementedException();
        }

        void ICollection<T>.Add(T value)
        {
            throw new NotImplementedException();
        }

        void ICollection.CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { throw new NotImplementedException(); }
        }

        public LinkedListNode<T> First
        {
            get { throw new NotImplementedException(); }
        }

        public LinkedListNode<T> Last
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
            set {
                throw new NotImplementedException();
            }
        }

        public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
        {
            const String VersionKey = "version";
            const String IndexKey = "index";
            const String ListKey = "list";

            public T Current
            {
                get
                {
                    throw new NotImplementedException();
                }
            }

            object IEnumerator.Current
            {
                get { throw new NotImplementedException(); }
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            void IEnumerator.Reset()
            {
                throw new NotImplementedException();
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }
            
            void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            void IDeserializationCallback.OnDeserialization(object sender)
            {
                throw new NotImplementedException();
            }
        }
    }
}