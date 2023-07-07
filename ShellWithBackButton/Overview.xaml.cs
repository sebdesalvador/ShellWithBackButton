namespace ShellWithBackButton;

public partial class Overview
{
    public Overview()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var button = (Button)sender;
        Shell.Current.GoToAsync(button.Text);
    }
}
