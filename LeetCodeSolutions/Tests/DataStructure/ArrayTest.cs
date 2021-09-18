using LeetCodeSolutions.DataStructure;
using Xunit;

namespace LeetCodeSolutions.Tests.DataStructure
{
    public class ArrayTest
    {
        [Fact]
        public void Array_CountTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }};
            Array<TestModel> test = new();
            bool exceptedBool = true;
            Assert.Equal(exceptedBool, test.IsEmpty());
            int exceptedValue = 0;
            Assert.Equal(exceptedValue, test.GetSize());
            exceptedValue = 10;
            Assert.Equal(exceptedValue, test.GetCapacity());
            for(int i = 0; i < array.Length; i++)
            {
                test.Add(array[i]);
            }
            exceptedBool = false;
            Assert.Equal(exceptedBool, test.IsEmpty());
            exceptedValue = 2;
            Assert.Equal(exceptedValue, test.GetSize());
            exceptedValue = 10;
            Assert.Equal(exceptedValue, test.GetCapacity());
            test.Clear();
            exceptedBool = true;
            Assert.Equal(exceptedBool, test.IsEmpty());
            exceptedValue = 0;
            Assert.Equal(exceptedValue, test.GetSize());
            exceptedValue = 10;
            Assert.Equal(exceptedValue, test.GetCapacity());
        }

        [Fact]
        public void Array_AddTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }, new() { Id = 3, TestName = "t3" }};
            Array<TestModel> test = new();
            test.Add(array[0]);
            TestModel t1 = test.Get(0);
            int exceptedValue = 1;
            string exceptedString = "t1";
            Assert.Equal(exceptedValue, t1.Id);
            Assert.Equal(exceptedString, t1.TestName);
            test.AddFirst(array[1]);
            TestModel t2 = test.GetFirst();
            exceptedValue = 2;
            exceptedString = "t2";
            Assert.Equal(exceptedValue, t2.Id);
            Assert.Equal(exceptedString, t2.TestName);
            test.AddLast(array[2]);
            TestModel t3 = test.GetLast();
            exceptedValue = 3;
            exceptedString = "t3";
            Assert.Equal(exceptedValue, t3.Id);
            Assert.Equal(exceptedString, t3.TestName);
        }

        [Fact]
        public void Array_UpdateTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }, new() { Id = 3, TestName = "t3" }};
            Array<TestModel> test = new();
            bool exceptedBool = false;
            int exceptedValue = 0;
            Assert.Equal(exceptedBool, test.Contain(array[0]));
            test.Add(array[0]);
            TestModel t1 = test.Get(0);
            exceptedBool = true;
            exceptedValue = 1;
            Assert.Equal(exceptedBool, test.Contain(t1));
            test.Set(0, array[1]);
            TestModel t2 = test.Get(0);
            exceptedValue = 2;
            Assert.Equal(exceptedBool, test.Contain(t2));
            Assert.Equal(exceptedValue, t2.Id);
        }

        [Fact]
        public void Array_RemoveTest()
        {
            TestModel[] array = new TestModel[]{ new(){ Id = 1, TestName = "t1" }, new(){ Id = 2, TestName = "t2" }, new() { Id = 3, TestName = "t3" }};
            Array<TestModel> test = new();
            bool exceptedBool = true;
            test.Add(array[0]);
            test.Add(array[1]);
            test.Add(array[2]);
            Assert.Equal(exceptedBool, test.Contain(array[0]));
            test.RemoveFirst();
            exceptedBool = false;
			Assert.Equal(exceptedBool, test.Contain(array[0]));
            exceptedBool = true;
			Assert.Equal(exceptedBool, test.Contain(array[1]));
            test.Remove(0);
            exceptedBool = false;
            Assert.Equal(exceptedBool, test.Contain(array[1]));
            exceptedBool = true;
            Assert.Equal(exceptedBool, test.Contain(array[2]));
            test.RemoveLast();
            exceptedBool = false;
            Assert.Equal(exceptedBool, test.Contain(array[2]));
        }
    }
}