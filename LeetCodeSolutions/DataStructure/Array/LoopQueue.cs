using LeetCodeSolutions.DataStructure.Interface;
using System.Text;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 循环队列
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class LoopQueue<T> : IQueue<T>
	{
		private T[] data;
		
		private int front, tail;

		public LoopQueue() : this(10)
		{
		}

		public LoopQueue(int capacity)
		{
			data = new T[capacity];
			front = 0;
			tail = 0;
		}

		public T DeQueue()
		{
			if(IsEmpty())
			{
				throw new System.Exception("Cannot dequeue from an empty queue.");
			}
			T result = data[front];
			data[front] = default;
			front = (front + 1) % data.Length;
			if(GetSize() == data.Length / 4 && data.Length / 2 != 0)
			{
				Resize(data.Length / 2);
			}
			return result;
		}

		public void EnQueue(T e)
		{
			if((tail + 1) % data.Length == front)
			{
				Resize(GetCapacity() * 2);
			}
			data[tail] = e;
			tail = (tail + 1) %  data.Length;
		}

		public int GetCapacity()
		{
			return data.Length;
		}

		public T GetFront()
		{
			return default;
		}

		public int GetSize()
		{
			return tail >= front ? tail - front : data.Length + tail - front;
		}

		public bool IsEmpty()
		{
			return tail == front;
		}

		public override string ToString()
		{
			StringBuilder sb = new();
			int size = GetSize();
			sb.Append($"Queue: size = {size}, capacity = {GetCapacity()} front [");
			for(int i = 0; i < size; i++)
			{
				sb.Append($"{data[(front + i) % data.Length]},");
			}
			if(size > 0)
			{
				sb.Remove(sb.Length - 1, 1);
			}
			sb.Append("] tail");
			return  sb.ToString();
		}

		private void Resize(int newCapacity)
		{
			int size = GetSize();
			T[] newData = new T[newCapacity + 1];
			for(int i = 0; i < size; i++)
			{
				newData[i] = data[(i + front) % data.Length];
			}
			data = newData;
			front = 0;
			tail = size;
		}
	}
}