namespace MS.Games;

public partial class MainPage : ContentPage
{
	int count = 0;
    private bool isRaised = false;

    public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

    private void OnFrameTapped(object sender, EventArgs e)
    {
        if (isRaised)
        {
            raisedFrame.TranslateTo(0, 0, 250, Easing.SpringOut);
        }
        else
        {
            raisedFrame.TranslateTo(0, -10, 250, Easing.SpringOut);
        }

        isRaised = !isRaised;
    }
}

