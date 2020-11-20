using System;
using System.Collections.Generic;

namespace Estoq
{
    public class ProductDAO
    {
        /*
            estoque/produtos/{nome}
            GET

            estoque/produtos/
            PATCH

            estoque/produto/{id}
            GET

            estoque/produto
            POST

            estoque/produto/
            PATCH
        */

        public ProductDAO(String clientID, String nome) {
            this.clientID = clientID;
            this.nome = nome;
        }

        public List<Produto> getNameLike() {
            return null;
        }

        // ver repository
        public void increaseQuantity(double incrementValue) {
            // bla
        }

        public void decreaseQuantity(double) {
            // bla
        }
    }
}
