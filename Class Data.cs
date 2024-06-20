using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Final_Project_Art_Blog.ArtPiece;
using System.Windows.Media.Imaging;

namespace Final_Project_Art_Blog
{
    public static  class ClassData
    {
        //Observable collection of products
        static ObservableCollection<ArtPiece> _artPieces;

        //static constructor

        static ClassData()
        {
            _artPieces = new ObservableCollection<ArtPiece>();
            string location = @"C:\\Users\\tropi\\Desktop\\Final Project Art Blog Computer Programming\\Final Project Art Blog\\Images for the project\\BeachPicture.jpeg.jpg";
            ArtPiece newArtPiece = new ArtPiece("La Playa", 2020, "Roberto Clemente", "Beautiful Carribean View", location,Format.Realism);


            AddArtPiece(newArtPiece);       




        }

        public static ObservableCollection<ArtPiece> ArtPieces { get => _artPieces; }//we removed the set so that no one else would be able to change anything

        //create a method

        //this is a method that will allow the art to be added inside
       public static void AddArtPiece(ArtPiece artPiece)
        {
            _artPieces.Add(artPiece);
        }

       

    }
}
