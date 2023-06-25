using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using Calculatrice;

namespace BibliothèqueMusicale
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<AlbumViewModel>? _albums = new ObservableCollection<AlbumViewModel>();

        private AlbumViewModel _selectedAlbum;

        public MainViewModel()
        {
            for(int i=0; i < 10; i++)
            {
                AlbumViewModel album = new AlbumViewModel();
                for(int j = 0; j < 10; j++)
                {
                    album.Pistes.Add(new Piste(j, $"Salut{i}"));
                }
                _albums.Add(album);
            }

            _selectedAlbum = _albums[0];

        }


        public void DoubleClick(AlbumViewModel album)
        {

            _selectedAlbum = album;
            OnPropertyChanged(nameof(SelectedAlbum));

        }
        public ICommand AjouterAlbumCommand
        {
            get { return new RelayCommand<AlbumViewModel>(AjouterAlbum); }
        }

        private void AjouterAlbum(AlbumViewModel album)
        {
            _albums.Add(album);
        }

        public ICommand AjouterPisteCommand
        {
            get { return new RelayCommand<Piste>(AjouterPiste); }
        }

        private void AjouterPiste(Piste piste)
        {
            _selectedAlbum.Pistes.Add(piste);
        }

        public ICommand SupprimerPisteCommand
        {
            get { return new RelayCommand<Piste>(SupprimerPiste); }
        }

        private void SupprimerPiste(Piste piste)
        {
            _selectedAlbum.Pistes.Remove(piste);
        }

        public ObservableCollection<AlbumViewModel> Albums
        {
            get { return _albums; }
        }
        public AlbumViewModel SelectedAlbum
        {
            get { return _selectedAlbum; }
        }

    }
}
