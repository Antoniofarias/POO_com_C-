using System;
using System.Windows.Forms;

namespace POO
{
    public class Aviao : Meio_de_Transporte // Herança
    {
        private int FHoras;

        public int Horas
        {
            get { return FHoras; }
            set { if (value > 20)
                    throw new Exception("Avião muito antigo!");
                FHoras = value; }
        }

        public Aviao()
        {
            Horas = 0;
        }

        protected override void Ligar()
        {
            MessageBox.Show("Ligando " + Descricao);
        }

        public override void Mover() // Override sobrescreve o metódo da classe base
        {
            base.Mover();
            MessageBox.Show(Descricao + " está voando");
        }

    }
}
