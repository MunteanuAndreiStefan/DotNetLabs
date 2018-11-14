using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataLayer;
using Laborator7.Models;

namespace Laborator7.Controllers
{
    [Route("api/[controller]/{cityId}/Pois")]
    [ApiController]
    public class PoisController : ControllerBase
    {
        private readonly IPoiRepository _repository; 

        public PoisController(IPoiRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IReadOnlyList<Poi>> Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}", Name = "GetByPoiId")]
        public ActionResult<Poi> Get(Guid poiId)
        {
            return Ok(_repository.GetById(poiId));
        }

        [HttpPost]
        public ActionResult<Poi> Post([FromBody] CreatePoiModel createTodoModel)
        {

            if (createTodoModel == null)
            {
                return BadRequest();
            }

            var poi = new Poi(createTodoModel.Description);

            _repository.Create(poi);


            return CreatedAtRoute("GetByPoiId", new { id = poi.Id }, poi);
        }
    }
}