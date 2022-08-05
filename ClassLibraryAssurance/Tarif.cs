namespace ClassLibraryAssurance
{


    public enum CouleurTarif
    {
        Bleu = 0,
        Vert = 1,
        Orange = 2,
        Rouge = 3
    }
    public class Tarif
    {
        public int Age { get; set; }
        public int Duree { get; set; }
        public int NombreAccident { get; set; }
        public CouleurTarif NomduTarif { get => DeterminerTarif(); }

        public int Fidelite { get; set; }

        public CouleurTarif DeterminerTarif()
        {
            //int nombrePoints = 0;
            //if (this.Fidelite < 5) nombrePoints++;
            //if (this.Age < 25) nombrePoints++;
            //if (this.Duree < 2) nombrePoints++;
            //nombrePoints += this.NombreAccident;
            //if (nombrePoints > Enum.GetValues(typeof(CouleurTarif)).Length - 1)
            //{
            //    throw new Exception("Erreur");
            //}
            //return (CouleurTarif)nombrePoints;


            if (this.Age < 25)
            {
                if (this.Duree < 2)
                {
                    if (this.NombreAccident == 0) return CouleurTarif.Rouge;
                }
                else
                {
                    if (this.NombreAccident == 0) return CouleurTarif.Orange;
                    if (this.NombreAccident == 1) return CouleurTarif.Rouge;
                }
            }
            if (this.Age >= 25)
            {
                if (this.Duree < 2)
                {
                    if (this.NombreAccident == 0)
                    {

                        return CouleurTarif.Orange;
                    }

                    if (this.NombreAccident == 1)
                    {

                        return CouleurTarif.Rouge;
                    }

                }
                else
                {
                    if (this.NombreAccident == 0) return CouleurTarif.Vert;
                    if (this.NombreAccident == 1)
                    {

                        return CouleurTarif.Orange;
                    }

                    if (this.NombreAccident == 2)
                    {

                        return CouleurTarif.Rouge;
                    }

                }
            }
            throw new Exception("Conducteur Refusé");
        }

    }

}
