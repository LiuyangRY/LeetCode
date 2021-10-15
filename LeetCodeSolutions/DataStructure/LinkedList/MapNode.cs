namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 图节点
	/// </summary>
	/// <typeparam name="K">键类型</typeparam>
	/// <typeparam name="V">值类型</typeparam>
	public class MapNode<K, V>
	{
		public K Key { get; set; }

		public V Value { get; set; }

		public MapNode<K, V> Next { get; set; }

		public MapNode(K key, V value, MapNode<K, V> next)
		{
			Key = key;
			Value = value;
			Next = next;
		}

		public MapNode(K key, V value) : this(key, value, null)
		{
		}

		public MapNode() : this(default, default, null)
		{
		}

		public override string ToString()
		{
			return $"{Key.ToString()}:{Value.ToString()}";
		}
	}
}