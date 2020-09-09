﻿namespace peopleapi.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using peopleapi.Models;

    [Route("/")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        /// <summary>
        ///     GET The list of people
        /// </summary>
        /// <returns>
        ///     HTTP Status showing it was found or that there is an error. And the list of people records.
        /// </returns>
        /// <response code="200">Returns the list of People records</response>
        [HttpGet]
        public ActionResult<IEnumerable<People>> Get()
        {
            var peopleList = new List<People>();
            peopleList.Add(new People { firstname = "Dale", lastname = "Bingham", title = "Mr.", middlename = "E." });
            peopleList.Add(
                new People { firstname = "Richard", lastname = "Cranium", title = "Mr.", middlename = "B." });
            peopleList.Add(
                new People { firstname = "Christine", lastname = "Smith", title = "Ms.", middlename = "L." });
            peopleList.Add(
                new People { firstname = "Jessica", lastname = "Lampard", title = "Mrs.", middlename = "Q." });
            return this.Ok(peopleList);
        }

        /// <summary>
        ///     GET a people record
        /// </summary>
        /// <returns>
        ///     HTTP Status showing it was found or that there is an error.
        ///     And the the person matching this ID, which we are faking for now. :)
        /// </returns>
        /// <response code="200">Returns the People record</response>
        [HttpGet("{id}")]
        public ActionResult<People> Get(string id)
        {
            var p = new People();
            p.firstname = "Richard";
            p.middlename = "B";
            p.lastname = "Cranium";
            p.title = "Mr.";
            return this.Ok(p);
        }
    }
}