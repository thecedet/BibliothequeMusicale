using System;
using System.Collections.Generic;


namespace BibliothèqueMusicale
{
    public class BibliothequeContext
    {
    }

    public class Album
    {
        public int Id { get; set; }

        public string Nom { get; set; } = "dfdfdf";
        public string Compositeur { get; set; } = "dsfgfdh";
        public ICollection<Piste> Pistes { get; set; } = new HashSet<Piste>();
    }

    public class Piste
    {
        public int Id { get; set; }

        public string Nom { get; set; } = "";

        public int NoPiste { get; set; } = 0;

        public Piste(int id, string nom)
        {
            Id = id;
            Nom = nom;
            NoPiste = id;
            NoPiste++;
        }
    }
}
