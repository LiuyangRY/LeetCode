namespace LeetCodeSolutions.DataStructure.Interface
{
	/// <summary>
	/// 队列接口
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public interface IQueue<T>
	{
		/// <summary>
		/// 获取队列中的元素个数
		/// </summary>
		/// <returns>元素个数</returns>
		int GetSize();

		/// <summary>
		/// 获取队列容量
		/// </summary>
		/// <returns>队列容量</returns>
		int GetCapacity();

		/// <summary>
		/// 队列是否为空
		/// </summary>
		/// <returns>队列为空返回true，否则返回false</returns>
		bool IsEmpty();

		/// <summary>
		/// 将新元素入队
		/// </summary>
		/// <param name="e">新元素</param>
		void EnQueue(T e);

		/// <summary>
		/// 将队头元素出队
		/// </summary>
		/// <returns>队头元素</returns>
		T DeQueue();

		/// <summary>
		/// 获取队头元素 
		/// </summary>
		/// <returns>队头元素</returns>
		T GetFront();
	}
}