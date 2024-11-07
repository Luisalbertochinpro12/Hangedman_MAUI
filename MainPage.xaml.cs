using System.ComponentModel;

namespace Hangman
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        List<String>  words = new List<String> ()
            {"gato", "tito", "pato", "mayo", "coca",
             "lola", "mamá", "peru", "lima", "agua",
             "lalo", "aaac", "abce", "aaaa", "aaaab"};

        List<char> UserLetters = new List<char> ();

        private List<char> letras = new List<char> ();

        public List<char> Letras
        {
            get => letras;
            set
            {
                letras = value;
                OnPropertyChanged();
            }
        }

        String word;
        private String spotlight = "";

        private String SpotLight
        {
            get => spotlight;
            set 
            {
                spotlight = value;
                OnPropertyChanged();
             }
        }

        public String RandomWord()
        {
           Random random = new Random();
            int num = random.Next(0,14);

            return word = words [num];
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            RandomWord();
            Letras.AddRange("qwertyuiopasdfghjklzxcvbnm".ToCharArray());
        }


    }

}
