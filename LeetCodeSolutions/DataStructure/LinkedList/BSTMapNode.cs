using System;

namespace LeetCodeSolutions.DataStructure
{
	public class BSTMapNode<K, V> where K : IComparable<K>
	{
		public K Key;

		public V Value;

		public BSTMapNode<K, V> Left, Right;

		public BSTMapNode(K key, V value)
		{
			Key = key;
			Value = value;
		}
	}
}