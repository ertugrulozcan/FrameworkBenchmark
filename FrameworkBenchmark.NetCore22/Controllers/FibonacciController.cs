using System;
using System.Threading.Tasks;
using FrameworkBenchmark.NetCore22.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrameworkBenchmark.NetCore22.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class FibonacciController : ControllerBase
	{
		// GET api/fibonacci/5
		[HttpGet("{index}")]
		public async Task<ActionResult<int>> Get(int index)
		{
			try
			{
				return await Helpers.Fibonacci.GetFibonacciNumberByIndexAsync(index);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return this.BadRequest(ex.Message);
			}
		}

		// POST api/fibonacci
		[HttpPost]
		public async Task<ActionResult<int>> Post([FromBody] FibonacciRequestModel request)
		{
			if (request != null)
			{
				try
				{
					return await Helpers.Fibonacci.GetFibonacciNumberByIndexAsync(request.Index);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex);
					return this.BadRequest(ex.Message);
				}
			}
			else
			{
				return this.BadRequest("Body is null!");
			}
		}
	}
}