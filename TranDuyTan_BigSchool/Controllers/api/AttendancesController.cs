﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TranDuyTan_BigSchool.DTOs;
using TranDuyTan_BigSchool.Models;

namespace TranDuyTan_BigSchool.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userID = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userID && a.CourseId == attendanceDto.CourseId))
                return BadRequest(" The Attendance already exists!");
            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userID
            };

            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }
        //[HttpDelete]
        //public IHttpActionResult DeleteAttendance(int id)
        //{
        //    var userId = User.Identity.GetUserId();
        //    var attendance = _dbContext.Attendances
        //        .SingleOrDefault(a => a.AttendeeId == userId && a.CourseId == id);

        //    if (attendance == null)
        //        return NotFound();

        //    _dbContext.Attendances.Remove(attendance);
        //    _dbContext.SaveChanges();

        //    return Ok(id);
        //}
    }
}
