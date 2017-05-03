using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoU2016.Models
{
    public class Instructor: Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        //=========================== NAVIGATION PROPERTIES ======================== //
        //An instructor can teach any number of courses, so Courses is defined as a collection
        //of the CourseAssignment Entity
        public virtual ICollection<CourseAssignment> Courses { get; set; }

        //An instructor can only have at most one office, so the OfficeAssignment property holds a single
        //OfficeAssignment Entity (which may be null if not office assigned)
        public virtual OfficeAssignment OfficeAssignment { get; set; }


    }
}
