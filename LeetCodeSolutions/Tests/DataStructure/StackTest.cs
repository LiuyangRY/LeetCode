using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
	public class StackTest
	{
		[Fact]
		public void Stack_InitTest()
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
		public void Stack_PushTest()
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
		}

		[Fact]
		public void Stack_PopTest()
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
		public void Stack_PeekTest()
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
		}
	}
}