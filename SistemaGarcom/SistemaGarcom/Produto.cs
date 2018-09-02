using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGarcom
{
    class Produto
    {
        private byte id;
        private string descricao;

        public byte Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }

        public Produto(byte id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", id, descricao);
        }
    }
}
