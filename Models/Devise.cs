namespace WPSConvertisseur.Models
{
    public class Devise
    {
        public Devise(int id, string nomDevise, double taux)
        {
            this.Id = id;
            this.NomDevise = nomDevise;
            this.Taux = taux;
        }
        public Devise()
        {
            
        }

        public int Id { get; set; }
        public string NomDevise { get; set; }
        public double Taux { get; set; }
    }
}
