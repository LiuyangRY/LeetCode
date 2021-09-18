using LeetCodeSolutions.DataStructure.Interface;
using System.Text;

namespace LeetCodeSolutions.DataStructure
{
	public class ArrayStack<T> : IStack<T>
	{
		private Array<T> array;

		public ArrayStack() : this(10)
		{
		}

		/// <summary>
		/// 数组栈构造函数
		/// </summary>
		/// <param name="capacity">栈容量</param>
		public ArrayStack(int capacity)
		{
			array = new Array<T>(capacity);
		}

		public int GetCapacity()
		{
			return array.GetCapacity();
		}

		public int GetSize()
		{
			return array.GetSize();
		}

		public bool IsEmpty()
		{
			return array.IsEmpty();
		}

		public T Peek()
		{
			return array.Get(array.GetSize() - 1);
		}

		public T Pop()
		{
			return array.RemoveLast();
		}

		public void Push(T e)
		{
			array.AddLast(e);
		}

		public override string ToString()
		{
			StringBuilder sb = new();
			sb.Append("Stack: [");
			int size = array.GetSize();
			for(int i = 0; i < size; i++)
			{
				sb.Append($"{array.Get(i)},");
			}
			if(size > 0)
			{
				sb.Remove(sb.Length - 1, 1);
			}
			sb.Append("] top");
			return sb.ToString();
		}
	}
}