using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaBalcao
{
    public partial class FormBalcao : Form
    {
        private LibUDP.UDPSocket socket;

        public FormBalcao()
        {
            InitializeComponent();
        }

        private void FormBalcao_Load(object sender, EventArgs e)
        {
            this.socket = new LibUDP.UDPSocket(PedidoRecebido, 6002);
        }

        private void FormBalcao_FormClosed(object sender, FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (socket != null)
            {
                socket.Close();
                socket.Dispose();
            }
        }

        private void PedidoRecebido(byte[] buffer, int size, string ip, int port)
        {
            if (size > 2)
            {
                byte numeroMesa = buffer[0];
                byte qtdProdutos = buffer[1];
                for (byte i = 0; i < qtdProdutos; i++)
                {
                    Produto p = Cardapio.GetProduto(buffer[i + 2]);
                    p.NumeroMesa = numeroMesa;
                    ListaBalcao.Items.Add(p);
                }
            }
        }

        private void BtnTerminar_Click(object sender, EventArgs e)
        {
            ListaBalcao.Items.Clear();
        }
    }
}
