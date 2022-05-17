using System.ComponentModel.DataAnnotations;

namespace CrudOperation.Models
{
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        [Required,MaxLength(250)]
        public string Title { get; set; }
        public int year { get;  set; }
        public float Rate{ get; set; }
        [Required, MaxLength(2500)]
        public string StoryLine { get; set; }

        public byte[] Poster { get; set; }

        public byte Genreid { get; set; }

        public Genres Genres { get; set; }
    }
}
