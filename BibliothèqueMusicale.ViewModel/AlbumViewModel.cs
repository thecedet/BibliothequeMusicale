using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothèqueMusicale
{
    public class AlbumViewModel : ViewModelBase
    {
        private Album _model;
        private Piste? _selectedPiste;

        public AlbumViewModel(int id)
        {
            _model = new Album();
            Id = id;
            SelectedPiste = null;
        }

        public AlbumViewModel(Album model)
        {
            _model = model;
            SelectedPiste = model.Pistes.First();
        }

        public Album Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        public string Nom
        {
            get { return _model.Nom; }
            set
            {
                _model.Nom = value;
                OnPropertyChanged(nameof(Model));
                OnPropertyChanged(nameof(Nom));
            }
        }

        public Piste SelectedPiste
        {
            get { return _selectedPiste; }
            set
            {
                _selectedPiste = value;
                OnPropertyChanged(nameof(SelectedPiste));
                OnPropertyChanged(nameof(Model));
            }
        }

        public ICollection<Piste> Pistes
        {
            get { return _model.Pistes; }
            set
            {
                _model.Pistes = value;
                OnPropertyChanged(nameof(Model));
                OnPropertyChanged(nameof(Pistes));
            }
        }

        public string Compositeur
        {
            get { return _model.Compositeur; }
            set
            {
                _model.Compositeur = value;
                OnPropertyChanged(nameof(Model));
                OnPropertyChanged(nameof(Compositeur));
            }
        }

        public int Id
        {
            get { return _model.Id; }
            set
            {
                _model.Id = value;
                OnPropertyChanged(nameof(Model));
                OnPropertyChanged(nameof(Id));
            }
        }
    }
}
