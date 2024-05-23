using System.ComponentModel.DataAnnotations;

namespace films.Dtos
{
    public class GenreDto
    {
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
