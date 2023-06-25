using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BibliothèqueMusicale
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<AlbumViewModel> _albums = new ObservableCollection<AlbumViewModel>();

        private AlbumViewModel _selectedAlbum;

        public MainViewModel()
        {

            for (int i=0; i < 3; i++)
            {
                AlbumViewModel album = new AlbumViewModel(i);
                for(int j = 0; j < 4; j++)
                {
                    album.Pistes.Add(new Piste(j));
                }
                _albums.Add(album);
            }

            _selectedAlbum = _albums[0];

        }


        public void DoubleClick(AlbumViewModel album)
        {

            SelectedAlbum = album;

        }

        public void DoubleClickPiste(Piste piste)
        {

            SelectedAlbum.SelectedPiste = piste;

        }

        public ICommand AjouterAlbumCommand
        {
            get { return new RelayCommand(AjouterAlbum); }
        }

        private void AjouterAlbum()
        {
            AlbumViewModel album = new AlbumViewModel(Albums.Count);
            Albums.Add(album);
            SelectedAlbum = album;
        }

        public ICommand SupprimerAlbumCommand
        {
            get { return new RelayCommand(SupprimerAlbum); }
        }

        private void SupprimerAlbum()
        {
            
            if(Albums.Count > 1)
            {
                Albums.Remove(SelectedAlbum);
                SelectedAlbum = Albums.First();
            }

        }

        public ICommand AjouterPisteCommand
        {
            get { return new RelayCommand(AjouterPiste); }
        }

        private void AjouterPiste()
        {
            SelectedAlbum.AjouterPiste();
        }


        public ICommand SupprimerPisteCommand
        {
            get { return new RelayCommand(SupprimerPiste); }
        }

        private void SupprimerPiste()
        {
            SelectedAlbum.SupprimerPiste();
        }



        public ObservableCollection<AlbumViewModel> Albums
        {
            get{ return _albums; }
            set
            {
                _albums = value;
                OnPropertyChanged(nameof(Albums));
            }
        }
        public AlbumViewModel SelectedAlbum
        {
            get { return _selectedAlbum; }
            set
            {
                _selectedAlbum = value;
                OnPropertyChanged(nameof(SelectedAlbum));
            }
        }

    }
}
