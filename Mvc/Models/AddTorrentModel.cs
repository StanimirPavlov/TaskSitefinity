using System;
using System.ComponentModel.DataAnnotations;

namespace SitefinityWebApp.Mvc.Models
{
    public class AddTorrentModel
	{
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Title { get; set; }

        [Display(Name = "Link")]
        public string DownloadLink { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Required]
        public string Description { get; set; }

        [Display(Name = "Additional Info")]
        public string AdditionalInfo { get; set; }

        [Required]
        public string Genre { get; set; }

        [Display(Name = "Date created")]
        public DateTime CreatedOn { get; set; }
    }
}