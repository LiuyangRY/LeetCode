using System;
using LeetCodeSolutions.DataStructure.Interface;

namespace LeetCodeSolutions.DataStructure
{
	public class BSTMap<K, V> : IMap<K, V> where K : IComparable<K>
	{
		private BSTMapNode<K, V> root;

		private int size;

		public void Add(K key, V value)
		{
			root = Add(root, key, value);
		}

		public bool Contains(K key)
		{
			return GetNode(root, key) is not null;
		}

		public V Get(K key)
		{
			BSTMapNode<K, V> node = GetNode(root, key);
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
			BSTMapNode<K, V> node = GetNode(root, key);
			if(node is not null)
			{
				root = Remove(root, key);
				return node.Value;
			}
			return default;
		}

		public void Set(K key, V newValue)
		{
			BSTMapNode<K, V> node = GetNode(root, key);
			if(node is null)
			{
				throw new ArgumentException($"{key} does't exist.");
			}
			node.Value = newValue;
		}

		private BSTMapNode<K, V> Add(BSTMapNode<K, V> node, K key, V value)
		{
			if(node is null)
			{
				size++;
				return new BSTMapNode<K, V>(key, value);
			}
			switch(key.CompareTo(node.Key))
			{
				case < 0:
					node.Left = Add(node.Left, key, value);
					break;
				case > 0:
					node.Right = Add(node.Right, key, value);
					break;
				default:
					node.Value = value;
					break;
			}
			return node;
		}

		private BSTMapNode<K, V> GetNode(BSTMapNode<K, V> node, K key)
		{
			if(node is null)
			{
				return null;
			}
			if(key.Equals(node.Key))
			{
				return node;
			}
			else if(key.CompareTo(node.Key) < 0)
			{
				return GetNode(node.Left, key);
			}
			else
			{
				return GetNode(node.Right, key);
			}
		}

		private BSTMapNode<K, V> Minimum(BSTMapNode<K, V> node)
		{
			if(node.Left is null)
			{
				return node;
			}
			return Minimum(node.Left);
		}

		private BSTMapNode<K, V> Maximum(BSTMapNode<K, V> node)
		{
			if(node.Right is null)
			{
				return node;
			}
			return Maximum(node.Right);
		}

		private BSTMapNode<K, V> RemoveMin(BSTMapNode<K, V> node)
		{
			if(node.Left is null)
			{
				BSTMapNode<K, V> rightNode = node.Right;
				node.Right = null;
				size--;
				return rightNode;
			}
			node.Left = RemoveMin(node.Left);
			return node;
		}

		private BSTMapNode<K, V> RemoveMax(BSTMapNode<K, V> node)
		{
			if(node.Right is null)
			{
				BSTMapNode<K, V> leftNode = node.Left;
				node.Left = null;
				size--;
				return leftNode;
			}
			node.Right = RemoveMax(node.Right);
			return node;
		}

		private BSTMapNode<K, V> Remove(BSTMapNode<K, V> node, K key)
		{
			if(node is null)
			{
				return null;
			}
			switch(key.CompareTo(node.Key))
			{
				case < 0:
					node.Left = Remove(node.Left, key);
					return node;
				case > 0:
					node.Right = Remove(node.Right, key);
					return node;
				default:
					if(node.Left is null)
					{
						// 待删除节点左子树为空
						BSTMapNode<K, V> rightNode = node.Right;
						node.Right = null;
						size--;
						return rightNode;
					}
					if(node.Right is null)
					{
						// 待删除节点右子树为空
						BSTMapNode<K, V> leftNode = node.Left;
						node.Left = null;
						size--;
						return leftNode;
					}
					/*
					待删除节点左右子树均不为空的情况
					找到比待删除节点大的最小节点，即待删除节点右子树的最小节点
					用这个节点顶替待删除节点的位置
					*/
					BSTMapNode<K, V> successor = Minimum(node.Right);
					successor.Right = RemoveMin(node.Right);
					successor.Left = node.Left;
					node.Left = node.Right = null;
					return successor;
			}
		}
	}
}