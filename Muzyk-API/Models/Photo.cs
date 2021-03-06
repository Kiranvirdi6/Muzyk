using System;

namespace Muzyk_API.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string PhotoUrl { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool isProfilePhoto { get; set; }
        public bool isCoverPhoto { get; set; }
        public string PublicId { get; set; }
        public User user { get; set; }
        public int UserId { get; set; }
    }
}