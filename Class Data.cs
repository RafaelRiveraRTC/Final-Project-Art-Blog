using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Art_Blog
{
    public class Class_Data
    {
        private ObservableCollection<ArtPiece> _artPieces = new ObservableCollection<ArtPiece>();

        public Class_Data(ObservableCollection<ArtPiece> artPieces)
        {
            _artPieces = artPieces;
        }

        public void AddArtPiece(ArtPiece artPiece)
        {
            _artPieces.Add(artPiece);
        }
    }
}
