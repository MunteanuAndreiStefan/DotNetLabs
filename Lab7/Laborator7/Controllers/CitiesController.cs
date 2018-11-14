using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataLayer;
using Laborator7.Models;

namespace Laborator7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository _repository;

        public CitiesController(ICityRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public ActionResult<IReadOnlyList<City>> Get()
        {
            return Ok(_repository.GetAll());
        }


        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<City> Get(Guid id)
        {
            return Ok(this._repository.GetById(id));
        }

        [HttpPost]
        public ActionResult<City> Post([FromBody] CreateCityModel createTodoModel)
        {
            if (createTodoModel == null)
            {
                return BadRequest();
            }

            var city = new City
                            {
                                Id = createTodoModel.Id,
                                Description = createTodoModel.Description
                            };

            _repository.Create(city);

            return CreatedAtRoute("GetById", new { id = city.Id }, city);
        }
    }
}