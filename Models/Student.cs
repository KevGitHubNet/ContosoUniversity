using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models 
{     
    /*
    public class Student     
    {         
        public int ID { get; set; }
        [Required]
        [StringLength(50, MinimumLength=1)]//set id limit to 50 characters
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]//character limit error message
        //[RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]  requires the first character to be upper case and the remaining characters to be alphabetical
        [Column("FirstName")]//rename column to 'FirstName' 'NOTE:THE MODEL CHANGES THEREFORE AN ADD-MIGRATION IS NEEDED'
        [Display(Name = "First Name")]
        public string FirstMidName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]//format without the time
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }          
        public virtual ICollection<Enrollment> Enrollments { get; set; }     
    }
     * */

        public class Student : Person
        {
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [Display(Name = "Enrollment Date")]
            public DateTime EnrollmentDate { get; set; }

            public virtual ICollection<Enrollment> Enrollments { get; set; }
        }
} 
/** If you changed data that was created by the Seed method, that will be changed back to its original state because of the AddOrUpdate method that you're using in the Seed method. **/