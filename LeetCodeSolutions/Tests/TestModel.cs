namespace LeetCodeSolutions.Tests
{
	public class TestModel
	{
		public int Id { get; set; }

		public string TestName { get; set; }

		public override string ToString()
		{
			return $"Id: {Id}, TestName: {TestName}";
		}
	}
}