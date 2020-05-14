using System;

namespace carShopDllProject
{
    [Serializable()]
    public class Moto:Veicolo
    {

        private string marcaSella;

        public Moto() : base(
            "Ducati",
            "Squalo",
            "Nero",
            1000,
            75,
            DateTime.Now,
           "si",
            "no",
            0,
            0)
        {
            this.MarcaSella = "Cavallino";
        }

        public Moto(string marca, string modello, string colore,
            int cilindrata, int potenzaKw, DateTime immatricolazione,
            string isUsato, string isKmZero, int kmPercorsi, string marcaSella, int prezzo) 
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
            this.MarcaSella = marcaSella;
        }

        public string MarcaSella { get => marcaSella; set => marcaSella = value; }

        public override string ToString()
        {
            return $"Moto: {base.ToString()} - Sella {this.MarcaSella}";
        }
    }
}
