using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Controls;

namespace Final_Project_Art_Blog
{
    public class ArtPiece
    {
        public enum Format { Impressionalism,Surrealism,Abstract,Realism}
        string _name;
        int _date;
        string _artist;
        string _body;
        string _filePath;
        Format _format;
        BitmapImage _art;

        public string Name { get => _name; set => _name = value; }
        public int Date { get => _date; set => _date = value; }
        public string Artist { get => _artist; set => _artist = value; }
        public string Body { get => _body; set => _body = value; }
        public string FilePath { get => _filePath; set => _filePath = value; }
        public Format Format1 { get => _format; set => _format = value; }
        public BitmapImage Art { get => _art; set => _art = value; }

        public ArtPiece(string name, int date, string artist, string body, string filePath, Format format)
        {
            _name = name;
            _date = date;
            _artist = artist;
            _body = body;
            _filePath = filePath;
            _format = format;
            //Calling our method to convert  our file path into a bitmap image and assigning it to our field
            _art = GenerateBitMap(_filePath);
        }

        //These are the fields,fir these you highlight everything except the public enum

        //This is the constuctor that holds the info parameters for the photos being displayed,when
        //You create this you highlight all but the public enum and the nitmap image

        public static BitmapImage GenerateBitMap(string filepath)
        {
            //uniform resource identifier
            Uri convertFilePath = new Uri(filepath);

            BitmapImage bitmapImage = new BitmapImage(convertFilePath);

            return bitmapImage;
            //this will convert the image once whenever the object is being contructed
        }// Generates the bitmap image



        //public FlowDocument FormattedPost()
        //{

        //} // Displays your fully formatted Art Post to a Rich Text Box

        public FlowDocument FormattedPost()
        {
            FlowDocument fullDoc = new FlowDocument();

            fullDoc.Blocks.Add(Name_Formatted());

            return fullDoc;
        }

        //private Paragraph Date_Formatted()
        //{

        //} // Format Date YEAR ONLY (size font family) Option: Color Weight

        

        private Paragraph Name_Formatted()
        {
            Paragraph para = new Paragraph();
            Run run = new Run(_name);
            run.FontSize = 24;
            run.FontWeight = FontWeights.Bold;
            para.Inlines.Add(run);//we add the inlines as a part of the para graph and returning the parargaph

            return para;
        } // Format header (size font family) Option: Color Weight

        //private Paragraph Artist_Formatted()
        //{

        //} // Format artist (size font family) Option: Color Weight

        //private Paragraph Body_Formatted()
        //{

        //} // Format body (size font family) Option: Color Weight


    }
}
