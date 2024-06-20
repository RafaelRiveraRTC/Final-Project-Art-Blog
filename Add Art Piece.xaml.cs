using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Final_Project_Art_Blog
{
    /// <summary>
    /// Interaction logic for Add_Art_Piece.xaml
    /// </summary>
    public partial class Add_Art_Piece : Window
    {
        public Add_Art_Piece()
        {
            InitializeComponent();
            PopulateComboBox();
            yearSelection.SelectedIndex = yearSelection.Items.Count - 1;
        }


        private void PopulateComboBox()
        {
            for(int i = 1780; i < 2026; i++)
            {
                yearSelection.Items.Add(i);
            }
        }
        private void PictureChooser_Click(object sender, RoutedEventArgs e)
        {

            //FilePicker
            //Open Fiole dialog
            //We need to create a forst instancw of it
            OpenFileDialog filePicker = new OpenFileDialog();
            //Displays in drop down | Filters by file format
            //use an if to check if the user slected a file and said okay
            filePicker.Filter = "  Image (*.png, *.jepg, *.jpg) | *.png;*.jepg;*.jpg";

            if (filePicker.ShowDialog() == true)
            {
                string filePath = filePicker.FileName;
                txtImgPath.Text = filePath;

                BitmapImage newImage = ArtPiece.GenerateBitMap(filePath);

                imgTemp.Source = newImage;
            }


          //PictureChooser_Click
        }//This button will pull a picture from the image file and display it onto the text box

        private void SubmitPhoto_Click(object sender, RoutedEventArgs e)
        {
            //Getting all of our values from our form
            string name = txtArtName.Text;
            int date = int.Parse(yearSelection.Text);
            string artist = txtArtistName.Text;
            string description = runDescription.Text;
            string filePath = txtImgPath.Text;
            ArtPiece.Format format = GetFormat();

            //Creating a new piece
            ArtPiece tempPiece = new ArtPiece (name,date,artist,description,filePath,format);
        }//Once all of the info 

        //Adding the artpiece to our observable collection inside the Class Data

      

        public ArtPiece.Format GetFormat()
        {
            if (Impressionism.IsChecked == true) { return ArtPiece.Format.Impressionalism; }

            else if (Surrealism.IsChecked == true) { return ArtPiece.Format.Surrealism; }

            else if (Abstract.IsChecked == true) { return ArtPiece.Format.Abstract; }

            return ArtPiece.Format.Realism; 
        
        
        }
    }


    //Controls 
    //Rich Text Box (Basic)
    
    //Radio Buttons
    //Combo Box Fill Up With Dates
    //File Picker
    //Text

}
