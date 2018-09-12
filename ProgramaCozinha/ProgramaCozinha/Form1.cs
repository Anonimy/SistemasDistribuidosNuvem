using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaCozinha
{
    public partial class FormCozinha : Form
    {
        private LibUDP.UDPSocket socket;
        private string ip = "127.0.0.1";

        public FormCozinha()
        {
            InitializeComponent();
        }

        private void FormCozinha_Load(object sender, EventArgs e)
        {
            this.socket = new LibUDP.UDPSocket(ReceberPedido, 6001);
        }
        private void FormCozinha_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (socket != null)
            {
                socket.Close();
                socket.Dispose();
            }
        }

        private void ListaChegada_DoubleClick(object sender, EventArgs e)
        {
            Produto p = (Produto) ListaChegada.SelectedItem;
            if (p != null)
            {
                if (p.Id > 0 && ListaSaida.Items.Count < 255)
                {
                    ListaSaida.Items.Add(p);
                }
                ListaChegada.Items.Remove(p);
            }
        }

        private void ListaSaida_DoubleClick(object sender, EventArgs e)
        {
            if (ListaChegada.Items.Count < 255)
            {
                Produto p = (Produto) ListaSaida.SelectedItem;
                if (p != null)
                {
                    ListaChegada.Items.Add(p);
                    ListaSaida.Items.Remove(p);
                }
            }
        }

        private void BtnPronto_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                byte counter = (byte) ListaSaida.Items.Count;
                byte[] buffer = new byte[3];
                while (counter > 0)
                {
                    Produto p = (Produto) ListaSaida.Items[0];
                    buffer[0] = p.NumeroMesa;
                    buffer[1] = 1;
                    buffer[2] = p.Id;
                    socket.Send(buffer, ip, 6002);
                    ListaSaida.Items.Remove(p);
                    counter = (byte) ListaSaida.Items.Count;
                }
            }
        }

        private void ReceberPedido(byte[] buffer, int size, string ip, int port)
        {
            if (size > 2)
            {
                byte numeroMesa = buffer[0];
                byte qtdProdutos = buffer[1];
                for (byte i = 0; i < qtdProdutos; i++)
                {
                    Produto produto = Cardapio.GetProduto(buffer[i + 2]);
                    produto.NumeroMesa = numeroMesa;
                    ListaChegada.Items.Add(produto);
                }
            }
        }
    }
}
