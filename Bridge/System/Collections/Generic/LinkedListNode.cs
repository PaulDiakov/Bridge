using Bridge;

namespace System.Collections.Generic
{
    public sealed class LinkedListNode<T>
    {
        public LinkedListNode(T value)
        {
        }

        internal LinkedListNode(LinkedList<T> list, T value)
        {
        }

        internal LinkedListNode(LinkedList<T> list, T value, LinkedListNode<T> previousNode, LinkedListNode<T> nextNode)
        {
        }

        internal void Detach()
        {
            throw new NotImplementedException();
        }

        internal void SelfReference(LinkedList<T> list)
        {
            throw new NotImplementedException();
        }

        internal void InsertBetween(LinkedListNode<T> previousNode, LinkedListNode<T> nextNode, LinkedList<T> list)
        {
            throw new NotImplementedException();
        }

        public LinkedList<T> List
        {
            get { throw new NotImplementedException(); }
        }

        public LinkedListNode<T> Next
        {
            get { throw new NotImplementedException(); }
        }

        public LinkedListNode<T> Previous
        {
            get { throw new NotImplementedException(); }
        }

        public T Value
        {
            get { throw new NotImplementedException(); }
            set {
                throw new NotImplementedException();
            }
        }
    }
}