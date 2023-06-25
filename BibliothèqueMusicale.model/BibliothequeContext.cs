using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BibliothèqueMusicale
{
    public class BibliothequeContext
    {
    }

    public class Album
    {
        public int Id { get; set; }

        public string Nom { get; set; } = "Nouvel Album";
        public string Compositeur { get; set; } = "Nouveau Compositeur";
        public ObservableCollection<Piste> Pistes { get; set; } = new ObservableCollection<Piste>();
    }

    public class Piste
    {
        public int Id { get; set; }

        public string Nom { get; set; } = "Nouvelle Piste";

        public int NoPiste { get; set; } = 0;

        public Piste(int id)
        {
            Id = id;
            NoPiste = id+1;
        }
    }
}
