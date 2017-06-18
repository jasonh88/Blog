using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.ViewModels
{
    public class Progress
    {
        public int Id { get; set; }
        public int? Pushups { get; set; }    
        public int? Situps { get; set; }
        public int? Steps { get; set; }  
        public int? Pullups { get; set; }
        public int? Bench { get; set; }
        public int? Squat { get; set; } 
        public string Notes { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateModified { get; set; }
    }
}