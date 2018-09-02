using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaCozinha
{
    class Produto
    {
        private byte id;
        private byte numeroMesa;
        private string descricao;

        public byte Id { get => id; }
        public byte NumeroMesa { set => numeroMesa = value; }
        public string Descricao { get => descricao; }

        public Produto(byte id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} #{2}", id, descricao, numeroMesa);
        }
    }
}
