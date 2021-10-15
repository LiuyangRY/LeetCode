using System;
using LeetCodeSolutions.DataStructure.Interface;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 基于链表结构的图
	/// </summary>
	/// <typeparam name="K">键类型</typeparam>
	/// <typeparam name="V">值类型</typeparam>
	public class LinkedListMap<K, V> : IMap<K, V>
	{
		private MapNode<K, V> DummyHead = new();

		private int size;

		public void Add(K key, V value)
		{
			MapNode<K, V> node = GetNode(key);
			if(node is null)
			{
				DummyHead.Next = new(key, value, DummyHead.Next);
				size++;
			}
			else
			{
				node.Value = value;
			}
		}

		public bool Contains(K key)
		{
			return GetNode(key) is not null;
		}

		public V Get(K key)
		{
			MapNode<K, V> node = GetNode(key);
			return node is null ? default : node.Value;
		}

		public int GetSize()
		{
			return size;
		}

		public bool IsEmpty()
		{
			return size == 0;
		}

		public V Remove(K key)
		{
			MapNode<K, V> prev = DummyHead;
			while(prev.Next is not null)
			{
				if(prev.Next.Key.Equals(key))
				{
					break;
				}
				prev = prev.Next;
			}
			if(prev.Next is not null)
			{
				MapNode<K, V> delNode = prev.Next;
				prev.Next = delNode.Next;
				delNode.Next = null;
				size--;
				return delNode.Value;
			}
			return default;
		}

		public void Set(K key, V newValue)
		{
			MapNode<K, V> node = GetNode(key);
			if(node is null)
			{
				throw new ArgumentException($"{key} doesn't exist.");
			}
			node.Value = newValue;
		}

		private MapNode<K, V> GetNode(K key)
		{
			MapNode<K, V> cur = DummyHead.Next;
			while(cur is not null)
			{
				if(cur.Key.Equals(key))
				{
					return cur;
				}
				cur = cur.Next;
			}
			return cur;
		}
	}
}