using System.ComponentModel;

namespace Hangman
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public List<String> words = new List<String>()
            {"gato", "tito", "pato", "mayo", "coca",
             "lola", "mami", "peru", "lima", "agua",
             "lalo", "aaac", "abce", "aaaa", "aaaab"};

        public List<char> userletters = new List<char>();
        public List<char> answer = new List<char>();

        private List<char> letters = new List<char>();

        public List<char> Letters
        {
            get => letters;
            set
            {
                letters = value;
                OnPropertyChanged();
            }
        }

        String word;
        private String spotlight = "";
        public String Spotlight
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
            int num = random.Next(0, 14);

            answer.Add(Convert.ToChar(num));

            return word = words[num];
        }

        public void BtnClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.IsEnabled = false;
            char buttonletter = Convert.ToChar(button.Text);
            CheckLetter(buttonletter);
            button.Text = "";
        }

        public void CheckLetter (char letter)
        {
            if(userletters.IndexOf(letter) == -1)
            {
                userletters.Add(letter);
            }
            if(answer.IndexOf(letter) >= 0)
            {
                MaskWord(word, userletters);
            }
        }

        private void MaskWord (String word, List<char> letters)
        {
            var mask = word.Select(index => letters.IndexOf(index) == 0 ? index : '_').ToArray();
            Spotlight = string.Join(" ", mask);
        }
        public MainPage()
        {
            InitializeComponent();
            RandomWord();
            Letters.AddRange("qwertyuiopasdfghjklzxcvbnm".ToCharArray());
            BindingContext = this;
            MaskWord(word, Letters);
        }


    }

}
