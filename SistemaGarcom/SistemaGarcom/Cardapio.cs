using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGarcom
{
    static class Cardapio
    {
        private static readonly List<Produto> produtos = new List<Produto>()
        {
            new Produto(20, "Coca-Cola"),
            new Produto(10, "Jiló"),
            new Produto(5, "Cuzuz"),
            new Produto(35, "Yakisoba"),
            new Produto(120, "Sal"),
            new Produto(26, "Tofu"),
            new Produto(6, "Pão com ovo"),
            new Produto(33, "Guaraná Jesus"),
            new Produto(51, "Corote"),
            new Produto(8, "Alcachofra"),
            new Produto(27, "Hot dog"),
            new Produto(45, "Feijoada"),
            new Produto(98, "Bolo de Cenoura"),
            new Produto(1, "Maionese"),
            new Produto(13, "Pizza Doce"),
            new Produto(22, "Baião de Dois"),
            new Produto(44, "Banana"),
            new Produto(255, "Caijuina"),
            new Produto(59, "Caipirinha"),
            new Produto(19, "Caqui"),
            new Produto(68, "Bem Casado"),
            new Produto(92, "Tapioca"),
            new Produto(50, "Panqueca"),
            new Produto(60, "Paçoca"),
            new Produto(75, "Sushi"),
            new Produto(23, "Guacamole"),
            new Produto(7, "Esfiha"),
            new Produto(96, "Frango Assado"),
            new Produto(39, "Pastel"),
            new Produto(2, "Açaí"),
            new Produto(69, "Anã"),
            new Produto(24, "Fafinha")
        };

        internal static List<Produto> Produtos { get => produtos; }

        public static Produto GetProduto(byte id)
        {
            foreach (Produto p in produtos)
            {
                if (p.Id == id)
                {
                    return p;
                }
            }
            return new Produto(0, "Produto não existente!");
        }
    }
}
