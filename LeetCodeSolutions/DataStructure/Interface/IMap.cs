namespace LeetCodeSolutions.DataStructure.Interface
{
	/// <summary>
	/// 图接口
	/// </summary>
	/// <typeparam name="K">键类型</typeparam>
	/// <typeparam name="V">值类型</typeparam>
	public interface IMap<K, V>
	{
		void Add(K key, V value);

		V Remove(K key);

		bool Contains(K key);

		V Get(K key);

		void Set(K key, V newValue);

		int GetSize();

		bool IsEmpty();
	}
}