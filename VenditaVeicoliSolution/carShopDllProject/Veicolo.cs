using System;
using System.Xml.Serialization;

namespace carShopDllProject
{
    [Serializable()]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Auto))]
    public abstract class Veicolo
    {

        #region fields
        private string marca;
        private string modello;
        private string colore;
        private int cilindrata;
        private int potenzaKw;
        private DateTime immatricolazione;
        private string isUsato;
        private string isKmZero;
        private int kmPercorsi;
        private int prezzo;
        #endregion

        public Veicolo() { }

        public Veicolo(string marca, string modello, string colore, int cilindrata, int potenzaKw, DateTime immatricolazione, string isUsato, string isKmZero, int kmPercorsi, int prezzo)
        {
            this.Marca = marca;
            this.Modello = modello;
            this.Colore = colore;
            this.Cilindrata = cilindrata;
            this.PotenzaKw = potenzaKw;
            this.Immatricolazione = immatricolazione;
            this.IsUsato = isUsato;
            this.IsKmZero = isKmZero;
            this.KmPercorsi = kmPercorsi;
            this.Prezzo = prezzo;
        }

        public string Marca { get => marca.ToUpper(); set => marca = value; }
        public string Modello { get => modello; set => modello = value; }
        public string Colore { get => colore; set => colore = value; }
        public int Cilindrata { get => cilindrata; set => cilindrata = value; }
        public int PotenzaKw { get => potenzaKw; set => potenzaKw = value; }
        public DateTime Immatricolazione { get => immatricolazione; set => immatricolazione = value; }
        public string IsUsato { get => isUsato; set => isUsato = value; }
        public string IsKmZero { get => isKmZero; set => isKmZero = value; }
        public int KmPercorsi { get => kmPercorsi; set => kmPercorsi = value; }
        public int Prezzo { get => prezzo; set => prezzo = value; }

        public override string ToString()
        {
            string retVal = $"{this.Marca} {this.Modello} ({this.Immatricolazione.Year})";
            return retVal;
        }

    }
}
