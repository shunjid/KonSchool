﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonSchool.Models;
using KonSchool.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KonSchool.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly ISchoolService _schoolService;
        private List<School> _schools;

        public SchoolsController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
            _schools = _schoolService.GetSchools().ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<School>> Get()
        {
            return Ok(_schools);
        }

        [HttpGet("{id}")]
        public ActionResult<School> GetOneSchool(string id)
        {
            var school = _schools.Where(s => s.EIIN == int.Parse(id)).FirstOrDefault();

            if (school == null)
            {
                return NotFound();
            }

            return Ok(school);
        }

        [HttpGet("div/{div}")]
        public ActionResult<IEnumerable<School>> GetSchoolsByDivision(string div)
        {
            var schools = _schools.Where(s => s.Division == div);

            if (schools.Count() == 0)
            {
                return NotFound();
            }

            return Ok(schools);
        }

        [HttpGet("dis/{dis}")]
        public ActionResult<IEnumerable<School>> GetSchoolsByDistrict(string dis)
        {
            var schools = _schools.Where(s => s.District == dis);

            if (schools.Count() == 0)
            {
                return NotFound();
            }

            return Ok(schools);
        }

    }
}