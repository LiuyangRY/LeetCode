using System;
using System.Collections.Generic;

namespace LeetCodeSolutions.DataStructure.Interface
{
	public interface ITree<T> where T : IComparable<T>
	{
		void Add(T element);

		bool Contains(T element);

		void Remove(T element);

		int GetSize();

		bool IsEmpty();

		IEnumerable<T> PreOrderTraversal();

		IEnumerable<T> InOrderTraversal();

		IEnumerable<T> PostOrderTraversal();

		IEnumerable<T> LevelOrderTraversal();
	}
}