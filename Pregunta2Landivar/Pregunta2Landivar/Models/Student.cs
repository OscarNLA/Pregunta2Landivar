﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pregunta2Landivar.Models
{
    public class Student
    {
        public int ID { get; set; }
        public String LastName { get; set; }
        public String FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}