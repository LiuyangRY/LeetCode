using LeetCodeSolutions.DataStructure.Interface;
using System.Text;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 基于数组结构的队列
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class ArrayQueue<T> : IQueue<T>
	{
		private Array<T> array;

		public ArrayQueue() : this(10)
		{
		}

		public ArrayQueue(int capacity)
		{
			array = new Array<T>(capacity);
		}

		public T DeQueue()
		{
			return array.RemoveFirst();
		}

		public void EnQueue(T e)
		{
			array.AddLast(e);
		}

		public int GetCapacity()
		{
			return array.GetCapacity();
		}

		public T GetFront()
		{
			return array.GetFirst();
		}

		public int GetSize()
		{
			return array.GetSize();
		}

		public bool IsEmpty()
		{
			return array.IsEmpty();
		}

		public override string ToString()
		{
			StringBuilder sb = new();
			sb.Append("Queue: front [");
			int size = array.GetSize();
			for(int i = 0; i < size; i++)
			{
				sb.Append($"{array.Get(i)},");
			}
			if(size > 0)
			{
				sb.Remove(sb.Length - 1, 1);
			}
			sb.Append("] tail");
			return sb.ToString();
		}
	}
}