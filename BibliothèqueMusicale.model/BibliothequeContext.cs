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

        public string Nom { get; set; } = "Le Nom";
        public string Compositeur { get; set; } = "Le Compositeur";
        public ICollection<Piste> Pistes { get; set; } = new HashSet<Piste>();
    }

    public class Piste
    {
        public int Id { get; set; }

        public string Nom { get; set; } = "La piste";

        public int NoPiste { get; set; } = 0;

        public Piste(int id)
        {
            Id = id;
            NoPiste = id+1;
        }
    }
}
