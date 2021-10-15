using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.DataStructure
{
	/// <summary>
	/// 二分搜索树
	/// </summary>
	/// <typeparam name="T">泛型类型</typeparam>
	public class BinarySearchTree<T> where T : IComparable<T>
	{
		/// <summary>
		/// 二分搜索树根节点
		/// </summary>
		private BinaryTreeNode<T> root = null;

		/// <summary>
		/// 树节点数量
		/// </summary>
		private int size;

		/// <summary>
		/// 二分搜索树构造函数
		/// </summary>
		public BinarySearchTree()
		{
		}

		/// <summary>
		/// 二分搜索树构造函数
		/// </summary>
		/// <param name="list">数据集合</param>
		public BinarySearchTree(IEnumerable<T> list)
		{
			foreach(T item in list)
			{
				Add(item);
			}
		}

		/// <summary>
		/// 获取节点数量
		/// </summary>
		/// <returns></returns>
		public int GetSize()
		{
			return size;
		}

		/// <summary>
		/// 树是否为空
		/// </summary>
		/// <returns>树节点数量为0返回true，否则返回false</returns>
		public bool IsEmpty()
		{
			return size == 0;
		}

		/// <summary>
		/// 二分搜索树添加新元素
		/// </summary>
		/// <param name="element">节点数据</param>
		public void Add(T element)
		{
			root = Add(root, element);
		}

		/// <summary>
		/// 向以 node 为根的二分搜索树中插入元素 element，并返回插入新节点后二分搜索树的根（递归算法）
		/// </summary>
		/// <param name="node">新添加元素的根节点</param>
		/// <param name="element">节点数据</param>
		/// <returns>插入新节点的二分搜索树根节点</returns>
		private BinaryTreeNode<T> Add(BinaryTreeNode<T> node, T element)
		{
			if(node is null)
			{
				size++;
				return new(element);
			}
			if(element.CompareTo(node.element) < 0)
			{
				node.LeftNode = Add(node.LeftNode, element);
			}
			else if(element.CompareTo(node.element) > 0)
			{
				node.RightNode = Add(node.RightNode, element);
			}
			return node;
		}

		/// <summary>
		/// 二分搜索树是否包含指定元素
		/// </summary>
		/// <param name="element">指定元素</param>
		/// <returns>包含指定元素返回true，否则返回false</returns>
		public bool Contains(T element)
		{
			return Contains(root, element);
		}
		
		/// <summary>
		/// 前序遍历二分搜索树
		/// </summary>
		/// <returns>二分搜索树前序遍历结果</returns>
		public IEnumerable<T> PreOrderTraversal()
		{
			return PreOrderTraversal(root);
		}
 
		/// <summary>
		/// 二分搜索树的非递归前序遍历
		/// </summary>
		/// <returns>二分搜索树的前序遍历结果</returns>
		public IEnumerable<T> PreOrderTraversalNoRecursion()
		{
			List<T> result = new();
			if(root is null)
			{
				return result;
			}
			Stack<BinaryTreeNode<T>> stack = new();
			stack.Push(root);
			while(stack.Count != 0)
			{
				BinaryTreeNode<T> cur = stack.Pop();
				result.Add(cur.element);
				if(cur.RightNode is not null)
				{
					stack.Push(cur.RightNode);
				}
				if(cur.LeftNode is not null)
				{
					stack.Push(cur.LeftNode);
				}
			}
			return result;
		}

		/// <summary>
		/// 中序遍历二分搜索树
		/// </summary>
		/// <returns>二分搜索树中序遍历结果<returns>
		public IEnumerable<T> InOrderTraversal()
		{
			return InOrderTraversal(root);
		}

		/// <summary>
		/// 二分搜索树的非递归中序遍历
		/// </summary>
		/// <returns>二分搜索树的中序遍历结果</returns>
		public IEnumerable<T> InOrderTraversalNoRecursion()
		{
			List<T> result = new();
			if(root is null)
			{
				return result;
			}
			Stack<BinaryTreeNode<T>> stack = new();
			BinaryTreeNode<T> cur = root;
			while(stack.Count != 0 || cur is not null)
			{
				while(cur is not null)
				{
					stack.Push(cur);
					cur = cur.LeftNode;
				}
				cur = stack.Pop();
				result.Add(cur.element);
				cur = cur.RightNode;
			}
			return result;
		}

		/// <summary>
		/// 后序遍历二分搜索树
		/// </summary>
		/// <returns>二分搜索树后序遍历结果<returns>
		public IEnumerable<T> PostOrderTraversal()
		{
			return PostOrderTraversal(root);
		}

		/// <summary>
		/// 二分搜索树的非递归后序遍历
		/// </summary>
		/// <returns>二分搜索树的后序遍历结果</returns>
		public IEnumerable<T> PostOrderTraversalNoRecursion()
		{
			List<T> result = new();
			if(root is null)
			{
				return result;
			}
			Stack<TreeTagNode<T>> stack = new();
			BinaryTreeNode<T> cur = root;
			while(stack.Count != 0 || cur is not null)
			{
				while(cur is not null)
				{
					stack.Push(new(cur));
					cur = cur.LeftNode;
				}
				TreeTagNode<T> tagNode = stack.Pop();
				cur = tagNode.Node;
				if(!tagNode.IsTraversed)
				{
					// 节点尚未被遍历
					tagNode.IsTraversed = true;
					stack.Push(tagNode);
					cur = cur.RightNode;
				}
				else
				{
					// 节点已被遍历
					result.Add(cur.element);
					cur = null;
				}
			}
			return result;
		}

		/// <summary>
		/// 二分搜索树层序遍历
		/// </summary>
		/// <returns>二分搜索树层序遍历结果</returns>
		public IEnumerable<T> LevelOrderTraversal()
		{
			List<T> result = new();
			if(root is null)
			{
				return result;
			}
			Queue<BinaryTreeNode<T>> queue = new();
			queue.Enqueue(root);
			while(queue.Count != 0)
			{
				BinaryTreeNode<T> cur = queue.Dequeue();
				result.Add(cur.element);
				if(cur.LeftNode is not null)
				{
					queue.Enqueue(cur.LeftNode);
				}
				if(cur.RightNode is not null)
				{
					queue.Enqueue(cur.RightNode);
				}
			}
			return result;
		}

		/// <summary>
		/// 获取二分搜索树的最小元素
		/// </summary>
		/// <returns>二分搜索树中的最小元素</returns>
		public T GetMinimum()
		{
			if(size == 0)
			{
				throw new Exception("Binary search tree is empty.");
			}
			BinaryTreeNode<T> minNode = GetMinimumNode(root);
			return minNode.element;
		}

		/// <summary>
		/// 获取二分搜索树的最大元素
		/// </summary>
		/// <returns>二分搜索树中的最大元素</returns>
		public T GetMaximum()
		{
			if(size == 0)
			{
				throw new Exception("Binary Search tree is empty.");
			}
			BinaryTreeNode<T> maxNode = GetMaximumNode(root);
			return maxNode.element;
		}

		/// <summary>
		/// 从二分搜索树中删除最小值所在节点，返回最小值
		/// </summary>
		/// <returns>二分搜索树中的最小值</returns>
		public T RemoveMin()
		{
			T result = GetMinimum();
			root = RemoveMin(root);
			return result;
		}

		/// <summary>
		/// 从二分搜索树中删除最大值所在节点，返回最大值
		/// </summary>
		/// <returns>二分搜索树中的最大值</returns>
		public T RemoveMax()
		{
			T result = GetMaximum();
			root = RemoveMax(root);
			return result;
		}

		/// <summary>
		/// 从二分搜索树中删除指定值所在的节点
		/// </summary>
		/// <param name="element">指定值</param>
		public void Remove(T element)
		{
			root = Remove(root, element);
		}

		/// <summary>
		/// 二分搜索树指定根节点是否包含指定元素
		/// </summary>
		/// <param name="node">指定根节点</param>
		/// <param name="element">指定元素</param>
		/// <returns>包含指定元素返回true，否则返回false</returns>
		private bool Contains(BinaryTreeNode<T> node, T element)
		{
			if(node is null)
			{
				return false;
			}
			if(element.CompareTo(node.element) == 0)
			{
				return true;
			}
			else if(element.CompareTo(node.element) < 0)
			{
				return Contains(node.LeftNode, element);
			}
			else
			{
				return Contains(node.RightNode, element);
			}
		}
		/// <summary>
		/// 前序遍历以 node 为根的二分搜索树（递归算法）
		/// </summary>
		/// <param name="node">node 根节点</param>
		/// <returns>二分搜索树前序遍历的结果</returns>
		private IEnumerable<T> PreOrderTraversal(BinaryTreeNode<T> node)
		{
			List<T> result = new();
			if(node is null)
			{
				return result;
			}
			result.Add(node.element);
			PreOrderTraversal(node.LeftNode);
			PreOrderTraversal(node.RightNode);
			return result;
		}

		/// <summary>
		/// 中序遍历以 node 为根节点的二分搜索树（递归算法）
		/// </summary>
		/// <param name="node"></param>
		/// <returns>二分搜索树中序遍历的结果</returns>
		private IEnumerable<T> InOrderTraversal(BinaryTreeNode<T> node)
		{
			List<T> result = new();
			if(node is null)
			{
				return result;
			}
			InOrderTraversal(node.LeftNode);
			result.Add(node.element);
			InOrderTraversal(node.RightNode);
			return result;
		}

		/// <summary>
		/// 后序遍历以 node 为根节点的二分搜索树（递归算法）
		/// </summary>
		/// <param name="node"></param>
		/// <returns>二分搜索树后序遍历的结果<retuens>
		private IEnumerable<T> PostOrderTraversal(BinaryTreeNode<T> node)
		{
			List<T> result = new();
			if(node is null)
			{
				return result;
			}
			PostOrderTraversal(node.LeftNode);
			PostOrderTraversal(node.RightNode);
			result.Add(node.element);
			return result;
		}

		/// <summary>
		/// 返回以 node 为根节点的二分搜索树的最小值所在的节点
		/// </summary>
		/// <param name="node">node 根节点</param>
		/// <returns>以 node 为根节点的二分搜索树的最小值所在的节点</returns>
		private BinaryTreeNode<T> GetMinimumNode(BinaryTreeNode<T> node)
		{
			if(node.LeftNode is null)
			{
				return node;
			}
			return GetMinimumNode(node.LeftNode);
		}

		private BinaryTreeNode<T> GetMaximumNode(BinaryTreeNode<T> node)
		{
			if(node.RightNode is null)
			{
				return node;
			}
			return GetMaximumNode(node.RightNode);
		}

		/// <summary>
		/// 删除以 node 为根节点的二分搜索树的最小节点，返回删除节点后新的二分搜索树的根节点
		/// </summary>
		/// <param name="node">node 根节点</param>
		/// <returns>删除节点后的二分搜索树的根节点</returns>
		private BinaryTreeNode<T> RemoveMin(BinaryTreeNode<T> node)
		{
			if(node.LeftNode is null)
			{
				BinaryTreeNode<T> rightNode = node.RightNode;
				node.RightNode = null;
				size--;
				return rightNode;
			}
			node.LeftNode = RemoveMin(node.LeftNode);
			return node;
		}

		/// <summary>
		/// 删除以 node 为根节点的二分搜索树的最大节点，返回删除节点后新的二分搜索树的根节点
		/// </summary>
		/// <param name="node">node 根节点</param>
		/// <returns>删除节点后的二分搜索树的根节点</returns>
		private BinaryTreeNode<T> RemoveMax(BinaryTreeNode<T> node)
		{
			if(node.RightNode is null)
			{
				BinaryTreeNode<T> leftNode = node.LeftNode;
				node.LeftNode = null;
				size--;
				return leftNode;
			}
			node.RightNode = RemoveMax(node.RightNode);
			return node;
		}

		/// <summary>
		/// 删除以 node 为根节点的二分搜索树中值为 element 的节点（递归算法），发挥删除节点后新的二分搜索树的根
		/// </summary>
		/// <param name="node">node 根节点</param>
		/// <param name="element">值</param>
		/// <returns>新的二分搜索树的根</returns>
		private BinaryTreeNode<T> Remove(BinaryTreeNode<T> node, T element)
		{
			if(node is null)
			{
				return null;
			}
			if(element.CompareTo(node.element) < 0)
			{
				node.LeftNode = Remove(node.LeftNode, element);
				return node;
			}
			else if(element.CompareTo(node.element) > 0)
			{
				node.RightNode = Remove(node.RightNode, element);
				return node;
			}
			else
			{
				if(node.LeftNode is null)
				{
					// 待删除节点左子树为空
					BinaryTreeNode<T> rightNode = node.RightNode;
					node.RightNode = null;
					size--;
					return rightNode;
				}
				if(node.RightNode is null)
				{
					// 待删除节点右子树为空
					BinaryTreeNode<T> leftNode = node.LeftNode;
					node.LeftNode = null;
					size--;
					return leftNode;
				}
				// 待删除节点左右子树均不为空
				// 找到比待删除节点大的最小节点，即待删除节点右子树的最小节点
				// 用这个节点替代删除节点的位置
				BinaryTreeNode<T> successor = GetMinimumNode(node.RightNode);
				successor.RightNode = RemoveMin(node.RightNode);
				successor.LeftNode = node.LeftNode;
				node.LeftNode = node.RightNode = null;
				return successor;
			}
		}

		/// <summary>
		/// 生成以 node 为根节点，深度为 depth 的描述二叉树的字符串
		/// </summary>
		/// <param name="node">node 根节点</param>
		/// <param name="depth">深度</param>
		/// <param name="sb">字符串构建对象</param>
		private void GenerateBTSString(BinaryTreeNode<T> node, int depth, StringBuilder sb)
		{
			if(node is null)
			{
				sb.AppendLine($"{GenerateDepthString(depth)}null");
				return;
			}
			sb.AppendLine($"{GenerateDepthString(depth)}{node.element}");
			GenerateBTSString(node.LeftNode, depth + 1, sb);
			GenerateBTSString(node.RightNode, depth + 1, sb);
		}

		/// <summary>
		/// 生成深度字符串
		/// </summary>
		/// <param name="depth">深度</param>
		/// <returns>深度描述字符串</returns>
		private string GenerateDepthString(int depth)
		{
			StringBuilder sb = new();
			for(int i = 0; i < depth; i++)
			{
				sb.Append("--");
			}
			return sb.ToString();
		}

		public override string ToString()
		{
			StringBuilder sb = new();
			GenerateBTSString(root, 0, sb);
			return sb.ToString();
		}
	}
}