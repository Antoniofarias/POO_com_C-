using System;
using System.Windows.Forms;

namespace POO
{
    public class Bike : Meio_de_Transporte
    {
        public bool Suspensao { get; set; }

        protected override void Ligar()
        {
            MessageBox.Show("Pedalando " + Descricao);
        }

        public override void Mover()
        {
            base.Mover();
            MessageBox.Show(Descricao + " entrou em movimento");
        }
    }
}
