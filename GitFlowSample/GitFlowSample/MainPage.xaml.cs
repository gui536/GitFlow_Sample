namespace GitFlowSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = $"Obrigado por clicar!";
            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
