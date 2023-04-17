using cleanarch.Domain.Entities;

namespace cleanarch.Application.DTOs
{
    public class ProductDTO
    {
        #region Propriedades
        public int Id { get; private set; }

        public string? Name { get; private set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public long Stock { get; private set; }

        public string? Image { get; private set; }

        public int CategoryId { get; set; }

        public Category? Category { get; set; }
        #endregion
    }
}
