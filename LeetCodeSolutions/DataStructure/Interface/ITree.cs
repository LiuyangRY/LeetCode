using System;
using System.Collections.Generic;

namespace LeetCodeSolutions.DataStructure.Interface
{
	/// <summary>
	/// 树接口
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
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