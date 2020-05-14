using System;

namespace carShopDllProject
{

    [Serializable()]
    public class Auto : Veicolo
    {

        private int numAirbag;

        public Auto() : base(
            "Mercedes",
            "GLX",
            "Nero",
            2100,
            175,
            DateTime.Now,
            "si",
            "no",
            0,
            0)
        {
            NumAirbag = 6;
        }

        public Auto(string marca, string modello, string colore,
            int cilindrata, int potenzaKw, DateTime immatricolazione,
            string isUsato, string isKmZero, int kmPercorsi, int numAirbag, int prezzo) 
            : base(
                marca, 
                modello, 
                colore,
                cilindrata, 
                potenzaKw, 
                immatricolazione,
                isUsato, 
                isKmZero, 
                kmPercorsi,
                prezzo)
        {
            this.NumAirbag = numAirbag;
        }

        public int NumAirbag { get => numAirbag; set => numAirbag = value; }

        public override string ToString()
        {
            return $"Auto: {base.ToString()} - {this.NumAirbag} Airbag" ;
        }

    }
}
