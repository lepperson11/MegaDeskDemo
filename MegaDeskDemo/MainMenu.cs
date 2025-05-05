namespace MegaDeskDemo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenAddQuote(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            Hide();
        }

        private void ViewQuotes_Btn(object sender, EventArgs e)
        {
            ViewQuotes viewQuotes = new ViewQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void SearchQuotes_Btn(object sender, EventArgs e)
        {
            SearchQuote searchQuote = new SearchQuote();
            searchQuote.Tag = this;
            searchQuote.Show(this);
            Hide();
        }
    }
}
