using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
	public class ArrayStackTest
	{
		[Fact]
		public void ArrayStack_InitTest()
		{
			ArrayStack<TestModel> test = new();
			bool exceptedBool = true;
			int exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			test.Push(new() { Id = 1, TestName = "t1"} );
			exceptedBool = false;
			exceptedValue = 1;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}
		
		[Fact]
		public void ArrayStack_PushTest()
		{
			ArrayStack<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			string exceptedString = "t1";
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.Push(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.Peek().Id);
			Assert.Equal(exceptedString, test.Peek().TestName);
			TestModel t2 = new() { Id = 2, TestName = "t2" };
			test.Push(t2);
			exceptedValue = 2;
			exceptedString = "t2";
			Assert.Equal(exceptedValue, test.Peek().Id);
			Assert.Equal(exceptedString, test.Peek().TestName);
		}

		[Fact]
		public void ArrayStack_PopTest()
		{
			ArrayStack<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.Push(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			test.Pop();
			exceptedBool = true;
			exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}

		[Fact]
		public void ArrayStack_PeekTest()
		{
			ArrayStack<TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.Push(t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			TestModel peek = test.Peek();
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(t1.Id, peek.Id);
			Assert.Equal(t1.TestName, peek.TestName);
			TestModel t2 = new() { Id = 2, TestName = "t2" };
			test.Push(t2);
			TestModel peek2 = test.Peek();
			Assert.Equal(t2.Id, peek2.Id);
			Assert.Equal(t2.TestName, peek2.TestName);
		}
	}
}