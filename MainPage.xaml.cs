using System.ComponentModel;

namespace Hangman
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        List<String>  words = new List<String> ()
            {"gato", "tito", "pato", "mayo", "coca",
             "lola", "mamá", "peru", "lima", "agua",
             "lalo", "tito", "tito", "tito", "tito"};

        List<char> UserLetters = new List<char> ();

        public void RandomWord()
        {
           Random random = new Random();
           int num = random.Next() % words.Count;
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }


    }

}
