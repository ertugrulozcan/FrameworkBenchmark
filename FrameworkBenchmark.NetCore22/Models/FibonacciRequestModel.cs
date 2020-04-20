using Newtonsoft.Json;

namespace FrameworkBenchmark.NetCore22.Models
{
	public class FibonacciRequestModel
	{
		#region Properties

		[JsonProperty("index")]
		public int Index { get; set; }

		#endregion
	}
}