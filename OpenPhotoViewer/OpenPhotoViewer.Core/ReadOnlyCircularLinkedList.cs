using System;
using System.Collections;
using System.Collections.Generic;

namespace OpenPhotoViewer.Core
{
    public class ReadOnlyCircularLinkedList<T> : IReadOnlyCollection<T>
    {
        private readonly LinkedList<T> _linkedList;
        private LinkedListNode<T> _currentNode;

        public ReadOnlyCircularLinkedList(IEnumerable<T> values)
        {
            _linkedList = new LinkedList<T>(values);
            _currentNode = _linkedList.First;
        }

        public void FindAndSetCurrentNode(T value)
        {
            var currentNode = _linkedList.Find(value);
            _currentNode = currentNode ?? throw new ArgumentException($"Unable to find a node with value {value.ToString()}");
        }

        public T GetNext()
        {
            _currentNode = _currentNode.Next ?? _linkedList.First;
            return _currentNode.Value;
        }
        
        public T GetPrevious()
        {
            _currentNode = _currentNode.Previous ?? _linkedList.Last;
            return _currentNode.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count => _linkedList.Count;
    }
}