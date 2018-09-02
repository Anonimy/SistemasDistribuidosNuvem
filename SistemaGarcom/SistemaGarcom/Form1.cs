using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGarcom
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string ip = "127.0.0.1";

        public Form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            foreach (Produto produto in Cardapio.Produtos)
            {
                listaCardapio.Items.Add(produto);
            }
        }

        private void listaCardapio_DoubleClick(object sender, EventArgs e)
        {
            if (listaPedidos.Items.Count < 255)
            {
                listaPedidos.Items.Add(listaCardapio.SelectedItem);
            }
        }

        private void listaPedidos_DoubleClick(object sender, EventArgs e)
        {
            listaPedidos.Items.Remove(listaPedidos.SelectedItem);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            using (LibUDP.UDPSocket socket = new LibUDP.UDPSocket())
            {
                byte counter = (byte) listaPedidos.Items.Count;
                byte[] buffer = new byte[counter + 2];
                buffer[0] = byte.Parse(inputMesa.Text);
                buffer[1] = counter;
                for (int i = 0; i < counter; i++)
                {
                    buffer[i + 2] = ((Produto) listaPedidos.Items[i]).Id;
                }
                socket.Send(buffer, this.ip, 6001);
                listaPedidos.Items.Clear();
            }
        }
    }
}
