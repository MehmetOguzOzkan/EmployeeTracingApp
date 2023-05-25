using EmployeeTracingApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeTracingApp.Controllers
{
	[Route("employees")]
	public class EmployeeController : Controller
	{

		// POST: employees/
		[HttpPost]
		public IActionResult Create(CreateEmployeeModel createEmployeeModel)
		{
			return View();
		}

		// GET: employees/
		[HttpGet]
		public IActionResult GetAll()
		{
			return View();
		}

		// GET: employees/id
		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			return View();
		}

		// PUT: employees/id
		[HttpPut("{id}")]
		public IActionResult Edit(int id, UpdateEmployeeModel updateEmployeeModel)
		{
			return View();
		}

		// DELETE: employees/id
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			return View();
		}


		
	}
}
