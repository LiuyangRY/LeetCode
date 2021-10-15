using LeetCodeSolutions.DataStructure.Interface;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 基于链表结构的集合
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class LinkedListSet<T> : ISet<T>
	{
		private LinkedList<T> linkedList = new();

		public void Add(T element)
		{
			if(!linkedList.Contains(element))
			{
				linkedList.AddFirst(element);
			}
		}

		public bool Contains(T element)
		{
			return linkedList.Contains(element);
		}

		public int GetSize()
		{
			return linkedList.GetSize();
		}

		public bool IsEmpty()
		{
			return linkedList.IsEmpty();
		}

		public void Remove(T element)
		{
			linkedList.RemoveElement(element);
		}
	}
}