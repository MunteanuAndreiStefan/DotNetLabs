using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using DataLayer;
using Laborator7.Models;

namespace Laborator7.Controllers
{
    [Route("api/Pois/{id}")]
    [ApiController]
    public class PoisController : ControllerBase
    {
        private readonly IPoiRepository _repository; 

        public PoisController(IPoiRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        [Route("/Pois")]
        public ActionResult<IReadOnlyList<Poi>> Get()
        {

            return Ok(_repository.GetAll());

        }

    

        [HttpGet("{poiId}", Name = "GetByPoiId")]
        [Route("/Pois/{poiId}")]
        public ActionResult<Poi> Get(Guid poiId)
        {

            return Ok(this._repository.GetById(poiId));

        }

        [HttpPost]
        [Route("/Pois")]
        public ActionResult<Poi> Post([FromBody] CreatePoiModel createTodoModel)

        {

            if (createTodoModel == null)

            {

                return BadRequest();

            }



            var poi = new Poi(createTodoModel.Description);

            this._repository.Create(poi);



            return CreatedAtRoute("GetByPoiId", new { id = poi.Id }, poi);

        }
    }
}