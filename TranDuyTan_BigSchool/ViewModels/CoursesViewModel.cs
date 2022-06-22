using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TranDuyTan_BigSchool.Models;

namespace TranDuyTan_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }

}