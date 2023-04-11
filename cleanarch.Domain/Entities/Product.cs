﻿using cleanarch.Domain.Validation;

namespace cleanarch.Domain.Entities
{
    /// <summary>
    /// CLASSE RESPONSÁVEL POR CRIAR OBJETOS DO TIPO PRODUTO.
    /// </summary>
    public sealed class Product
    {
        #region Propriedades
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public long Stock { get; private set; }

        public string Image { get; private set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        #endregion

        #region Construtores
        public Product(int id, string name, string description, decimal price, long stock, string imagem)
        {
            DomainExceptionValidation.When(id < 0, "Id inválido");
            ValidateProduct(name, description, price, stock, imagem);
        }
        public Product(string name, string description, decimal price, long stock, string imagem)
        {
            ValidateProduct(name, description, price, stock, imagem);
        }
        #endregion

        #region Métodos

        private void ValidateProduct(string name, string description, decimal price, long stock, string imagem)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Nome é obrigatório");

            DomainExceptionValidation.When(description.Length < 5, "Descrição é obrigatória.");

            DomainExceptionValidation.When(price < 0, "Preço inválido.");

            DomainExceptionValidation.When(stock < 0, "Estoque inválido");

            DomainExceptionValidation.When(string.IsNullOrEmpty(imagem), "Image é obrigatório");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = imagem;
        }                

        #endregion
    }
}