using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliothèqueMusicale
{
    public class AlbumViewModel : ViewModelBase
    {
        private readonly Album _model;

        public AlbumViewModel()
        {
            _model = new Album();
        }

        public AlbumViewModel(Album model)
        {
            _model = model;
        }

        public Album Model
        {
            get { return _model; }
        }

        public string Nom
        {
            get { return _model.Nom; }
            set
            {
                _model.Nom = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public ICollection<Piste> Pistes
        {
            get { return _model.Pistes; }
            set
            {
                _model.Pistes = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public string Compositeur
        {
            get { return _model.Compositeur; }
            set
            {
                _model.Compositeur = value;
                OnPropertyChanged(nameof(Nom));
            }
        }

        public int Id
        {
            get { return _model.Id; }
            set
            {
                _model.Id = value;
                OnPropertyChanged(nameof(Nom));
            }
        }
    }
}
