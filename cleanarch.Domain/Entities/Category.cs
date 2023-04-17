using cleanarch.Domain.Validation;

namespace cleanarch.Domain.Entities
{
    /// <summary>
    /// CLASSE RESPONSÁVEL POR CRIAR OBJETOS DO TIPO CATEGORIA.
    /// </summary>
    public sealed class Category : Entity
    {
        #region Propriedades
        public ICollection<Product>? Products { get; set; }
        #endregion

        #region Construtores
        public Category(string name)
        {
            ValidateCategory(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido, precisa ser maior que 0.");
            Id = id;
            ValidateCategory(name);
        }
        #endregion

        #region Métodos
        private void ValidateCategory(string name)
        {
            #region Validações para o nome
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome inválido, nome é obrigatório.");

            DomainExceptionValidation.When(name.Length < 3, "Nome inválido, precisa conter mais de 3 caracteres");
            #endregion

            Name = name;
        }

        private void Update(string name)
        {
            ValidateCategory(name);
        }
        #endregion
    }
}
