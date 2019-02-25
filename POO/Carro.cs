using System;
using System.Windows.Forms;

namespace POO
{
    public class Carro : Meio_de_Transporte // Herança
    {
        public int Quilometragem { get; set; }

        public Carro()
        {
            Quilometragem = 0;
        }

        protected override void onBeforeLigar()
        {
            MessageBox.Show("Manipulando método de despacho");
            base.onBeforeLigar();
        }

        protected override void Ligar()
        {
            MessageBox.Show("Ligando " + Descricao);
        }

        public override void Mover() // Override sobrescreve o metódo da classe base
        {
            base.Mover();
            MessageBox.Show(Descricao + " entrou em movimento");
        }

    }
}
