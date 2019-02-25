using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Variavel do tipo carro
        private Meio_de_Transporte CarroObj;

        // Variavel do tipo aviao
        private Meio_de_Transporte AviaoObj;

        private void Carro_BeforeLigar(string Descricao)
        {
            MessageBox.Show("BeforeLigar chamado para " + Descricao);
        }

        private void btnCriarCarro_Click(object sender, EventArgs e)
        {
            CarroObj = new Carro()
            {
                Descricao = txbDescricaoCarro.Text,
                Capacidade = int.Parse(txbCapacidadeCarro.Text),
                Quilometragem = int.Parse(txbQuilometragem.Text)
            };
            CarroObj.BeforeLigar += new BeforeLigarHandler(Carro_BeforeLigar);
        }

        private void btnCriarAvião_Click(object sender, EventArgs e)
        {
            try
            {
                AviaoObj = new Aviao()
                {
                    Descricao = txbDescricaoAviao.Text,
                    Capacidade = int.Parse(txbCapacidadeAviao.Text),
                    Horas = int.Parse(txbHoras.Text)
                };
            }
            catch (Exception E)
            {
                MessageBox.Show("Erro ao criar avião: " + E.Message);
            }
        }

        private void btnMoverCarro_Click(object sender, EventArgs e)
        {
            CarroObj.Mover();
        }

        private void btnMoverAviao_Click(object sender, EventArgs e)
        {
            AviaoObj.Mover();
        }

        private void btnCriarPessoa_Click(object sender, EventArgs e)
        {
            // Pessoa
            var GP = new Pessoa() { nome = "Guinther" };

            // Carro
            if (rbCarro.Checked)
            {
                CarroObj = new Carro()
                {
                    Descricao = txbDescricaoCarro.Text,
                    Capacidade = int.Parse(txbCapacidadeCarro.Text),
                    Quilometragem = int.Parse(txbQuilometragem.Text)
                };
                GP.Transporte = CarroObj;
            }

            // Cria Avião
            else if (rbAviao.Checked)
            {
                AviaoObj = new Aviao()
                {
                    Descricao = txbDescricaoAviao.Text,
                    Capacidade = int.Parse(txbCapacidadeAviao.Text),
                    Horas = int.Parse(txbHoras.Text)
                };
                GP.Transporte = AviaoObj;
            }

            // Bike
            else if (rbBike.Checked)
            {
                var BikeObj = new Bike()
                {
                    Capacidade = int.Parse(txbCapacidadeBike.Text),
                    Descricao = txbDescricaoBike.Text,
                    Suspensao = ckSuspensao.Checked
                };
                GP.Transporte = BikeObj;
            }

            GP.Transporte.Mover();

        }
    }
}