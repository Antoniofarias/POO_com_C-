using System;
using System.Windows.Forms;

namespace POO
{
    public delegate void BeforeLigarHandler(string Descricao);

    public abstract class Meio_de_Transporte
    {
        public event BeforeLigarHandler BeforeLigar;

        public string Descricao { get; set; }

        private int FCapacidade;

        public int Capacidade
        {
            get { return FCapacidade; }
            set { FCapacidade = value; }
        }

        public Meio_de_Transporte()
        {
            Descricao = "Indefinido";
        }

        protected abstract void Ligar();

        public virtual void Mover() // Virtual (Polimorfismo)
        {
            onBeforeLigar();
            Ligar();
        }

        protected virtual void onBeforeLigar()
        {
            if (BeforeLigar != null)
                BeforeLigar(Descricao);
        }
    }
}