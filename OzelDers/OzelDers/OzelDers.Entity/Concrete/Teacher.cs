﻿using OzelDers.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Entity.Concrete
{
    public class Teacher : IEntityBase
    {
        public int Id { get ; set ; }
        public string UniverstyGraduatedFrom { get; set; }
        public int HourlyPrice { get; set; }
        public bool IsFacetoFace { get; set; }
        public bool CertifiedTrainer { get; set; }
        public string Email { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }


    }
}
