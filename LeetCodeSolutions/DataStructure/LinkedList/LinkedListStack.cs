using LeetCodeSolutions.DataStructure.Interface;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 基于链表结构的栈
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class LinkedListStack<T> : IStack<T>
	{
		private LinkedList<T> list = new();

		public int GetSize()
		{
			return list.GetSize();
		}

		public bool IsEmpty()
		{
			return list.IsEmpty();
		}

		public T Peek()
		{
			return list.GetLast();
		}

		public T Pop()
		{
			return list.RemoveLast();
		}

		public void Push(T e)
		{
			list.AddLast(e);
		}
	}
}