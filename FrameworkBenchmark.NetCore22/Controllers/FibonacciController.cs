using System;
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
		public ActionResult<int> Get(int index)
		{
			try
			{
				return Helpers.Fibonacci.GetFibonacciNumberByIndex(index);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				return this.BadRequest(ex.Message);
			}
		}

		// POST api/fibonacci
		[HttpPost]
		public ActionResult<int> Post([FromBody] FibonacciRequestModel request)
		{
			if (request != null)
			{
				try
				{
					return Helpers.Fibonacci.GetFibonacciNumberByIndex(request.Index);
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