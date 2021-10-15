using System;
using System.Collections.Generic;
using LeetCodeSolutions.DataStructure.Interface;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 基于二分搜索树的集合
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class BSTSet<T> : ITree<T> where T : IComparable<T>
	{
		private BinarySearchTree<T> binarySearchTree = new();
		
		public void Add(T element)
		{
			binarySearchTree.Add(element);
		}

		public bool Contains(T element)
		{
			return binarySearchTree.Contains(element);
		}

		public int GetSize()
		{
			return binarySearchTree.GetSize();
		}

		public IEnumerable<T> InOrderTraversal()
		{
			return binarySearchTree.InOrderTraversal();
		}

		public bool IsEmpty()
		{
			return binarySearchTree.IsEmpty();
		}

		public IEnumerable<T> LevelOrderTraversal()
		{
			return binarySearchTree.LevelOrderTraversal();
		}

		public IEnumerable<T> PostOrderTraversal()
		{
			return binarySearchTree.PostOrderTraversal();
		}

		public IEnumerable<T> PreOrderTraversal()
		{
			return binarySearchTree.PreOrderTraversal();
		}

		public void Remove(T element)
		{
			binarySearchTree.Remove(element);
		}
	}
}