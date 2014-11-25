using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Main
{
    [MetadataType(typeof(PostOverride))]
    public partial class Post
    {
    
    }

    public class PostOverride
    {
        public int PostID { get; set; }
        public string UserID { get; set; }
        public System.DateTime PostDate { get; set; }
            
        [Required]
        public string Title { get; set; }
            
        [AllowHtml]
        [Required]
        public string Description { get; set; }
        public int ViewCount { get; set; }
            
        [Display(Name = "Category")]
        [Required]
        public int CategoryID { get; set; }
        public bool Removed { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public Nullable<decimal> Latitude { get; set; }
    }
}
