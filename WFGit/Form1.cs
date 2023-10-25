namespace WFGit
{
    public partial class Form1 : Form
    {
        List<string> quotes;
        Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            label1.Text = quotes[random.Next(quotes.Count)];
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                quotes = (await File.ReadAllLinesAsync("quotes.txt")).ToList();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
            
        }
    }
}