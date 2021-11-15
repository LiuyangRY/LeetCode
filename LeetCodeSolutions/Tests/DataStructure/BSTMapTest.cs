using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
	public class BSTMapTest
	{
		[Fact]
		public void BSTMap_InitTest()
		{
			BSTMap<string, TestModel> test = new();
			bool exceptedBool = true;
			int exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			test.Add("t1", new() { Id = 1, TestName = "t1"} );
			exceptedBool = false;
			exceptedValue = 1;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}
	
		[Fact]
		public void BSTMap_AddTest()
		{
			BSTMap<string, TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 1;
			string exceptedString = "t1";
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			test.Add("t1", t1);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.Get("t1").Id);
			Assert.Equal(exceptedString, test.Get("t1").TestName);
		}

		[Fact]
		public void BSTMap_RemoveTest()
		{
			BSTMap<int, TestModel> test = new();
			bool exceptedBool = false;
			int exceptedValue = 2;
			TestModel t1 = new() { Id = 1, TestName = "t1"};
			TestModel t2 = new() { Id = 2, TestName = "t2" };
			test.Add(1, t1);
			test.Add(2, t2);
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
			Assert.Equal(t1.Id, test.Get(1).Id);
			Assert.Equal(t1.TestName, test.Get(1).TestName);
			Assert.Equal(t2.Id, test.Get(2).Id);
			Assert.Equal(t2.TestName, test.Get(2).TestName);
			test.Remove(1);
			Assert.False(test.Contains(1));
			Assert.True(test.Contains(2));
			test.Remove(2);
			exceptedBool = true;
			exceptedValue = 0;
			Assert.Equal(exceptedBool, test.IsEmpty());
			Assert.Equal(exceptedValue, test.GetSize());
		}
	}
}