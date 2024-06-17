using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Documents;

namespace Final_Project_Art_Blog
{
    public class ArtPiece
    {
        int _date;
        string _name;
        string _artist;
        string _body;
        string _filePath;
        BitmapImage _art;
        Style _artStyle;

        public ArtPiece(int date, string name, string artist, string body, string filePath, BitmapImage art, Style artStyle)
        {
            _date = date;
            _name = name;
            _artist = artist;
            _body = body;
            _filePath = filePath;
            _art = art;
            _artStyle = artStyle;
        }

        public int Date { get => _date; set => _date = value; }
        public string Name { get => _name; set => _name = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public string Body { get => _body; set => _body = value; }
        public string FilePath { get => _filePath; set => _filePath = value; }
        public BitmapImage Art { get => _art; set => _art = value; }
        public Style ArtStyle { get => _artStyle; set => _artStyle = value; }

        public enum Style
        {
            Impressionism,
            Surrealism,
            Abstract,
            Realism
        }
        private BitmapImage GenerateBitMap(string filepath)
        {
            return new BitmapImage(new Uri(filepath));
        }// Generates the bitmap image

        public FlowDocument FormattedPost()
        {

        } // Displays your fully formatted Art Post to a Rich Text Box

        private Paragraph Date_Formatted()
        {

        } // Format Date YEAR ONLY (size font family) Option: Color Weight

        private Paragraph Header_Formatted()
        {

        } // Format header (size font family) Option: Color Weight

        private Paragraph Artist_Formatted()
        {

        } // Format artist (size font family) Option: Color Weight

        private Paragraph Body_Formatted()
        {

        } // Format body (size font family) Option: Color Weight


    }
}
