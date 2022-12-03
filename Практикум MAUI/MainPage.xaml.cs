namespace Tester;

public partial class MainPage : ContentPage
{
	static string s = "";
	string password = "1873";
	bool flag = true;
	public MainPage()
	{
		InitializeComponent();
	}
	public void DigitClicked(object sender, EventArgs e)
	{
		if(flag)
		{
            s += (sender as Button).Text;
            DisplayLabel.Text = s;
        }
    }
	public void AccessClicked(object sender, EventArgs e)
	{
		if (s == password)
		{
			flag = false;
            DisplayLabel.Text = "Success";
			return;
        }
        else
		{
           DisplayLabel.Text = "";
			s = "";
        }
    }
	public void DeleteClicked(object sender, EventArgs e)
	{
		if(flag)
		{
            s = s.Substring(0, s.Length - 1);
            DisplayLabel.Text = s;
        }
    }
}

