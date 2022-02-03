using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TutorialCoreApp.Models
{
    public class Tutorial
    {
        [Key]
        public int TutorialId { get; set; }
        public string TutorialName { get; set; }
        public string TutorialDesc { get; set; }
        public bool Published { get; set; }
        public decimal TutorialFees { get; set; }
    }
}

//strongly typed set