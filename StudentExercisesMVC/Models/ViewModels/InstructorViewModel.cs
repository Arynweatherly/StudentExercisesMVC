﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using StudentExercisesMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentExercisesMVC.Models.ViewModels
{
    public class InstructorViewModel
    {
        public Instructor Instructor { get; set; }
        public List<SelectListItem> Cohorts { get; set; }
    }
}
