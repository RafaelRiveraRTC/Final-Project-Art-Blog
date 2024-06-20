//Rafael Rivera Harrison
//Final project art blog
//6/16/2024

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Project_Art_Blog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvPieces.ItemsSource = ClassData.ArtPieces;
        }//Main Window

        private void btnAddNewPiece_Click(object sender, RoutedEventArgs e)
        {
            //open up a new window from the button click
            //You have to create  a new instance of the window
            //Then do .show() on it 
            new Add_Art_Piece().Show();
        }

        private void lvPieces_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ArtPiece selectedPiece = lvPieces.SelectedItem as ArtPiece;

            if(selectedPiece != null)
            {
                //we attact
                rtbPieceInfo.Document = selectedPiece.FormattedPost();//This allows the selected document to be attached

                imgPieces.Source = selectedPiece.Art;
            }

       
        }
    }

   //Rich Text Box (Advanced)
   //List View (Plus Click Event)
   //Image




}