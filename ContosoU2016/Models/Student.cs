﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2016.Models
{
    public class Student: Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        //================= NAVIGATION PROPERTY ======================= //
        /* The enrollments property is a navigation property. Navigation properties hold other
         * entitites that are related to this entity. In this case, the Enrollments property of 
         * a Student entity will hold all of the Enrollments that are related to that Student.
         * In other words, if a given student row in the database has two related enrollment rows
         * (rows that contain that student's primary key value in their studentid foreign key
         * column), that student entity's enrollment navigation property will contain those two
         * enrollment entities.
         * 
         * Navigation properties are typically defined as virtual so that they can take advantage
         * of certain Entity Framework functionality such as lazy loading.
         * Note: Lazy Loading is not yet available in EF Core.
        */
        public virtual ICollection<Enrollment> Enrollments { get; set; } //1 student: many enrollments
    }

}
