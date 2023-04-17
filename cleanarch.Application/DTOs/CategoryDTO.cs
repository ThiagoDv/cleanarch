using System.ComponentModel.DataAnnotations;

namespace cleanarch.Application.DTOs
{
    public class CategoryDTO
    {
        #region Propriedades
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        #endregion
    }
}
