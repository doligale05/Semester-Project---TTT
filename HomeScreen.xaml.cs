using CommunityToolkit.Maui.Storage;
using System.Text;
using System.IO;
using CommunityToolkit.Maui.Converters;

namespace SemesterProject;

public partial class HomeScreen : ContentPage
{
    private string username;
    private string password;
    private string workplace;

    public HomeScreen(string usernameLine, string passwordLine, string workplaceLine)
    {
        InitializeComponent();

        username = usernameLine;
        password = passwordLine;
        workplace = workplaceLine;
        

        currentTime.Text = "Current Date/Time: " + DateTime.Now.ToString("F");

        currentUser.Text = "Welcome to, " + workplaceLine + " " + usernameLine; 
    }

    private void backToLoginButton(object sender, EventArgs e)
    {
        Button backToLoginButton = (Button)sender;
        string backToLoginButtonText = backToLoginButton.Text;

        if (backToLoginButton.IsPressed)
        {
            Navigation.PushAsync(new Login());
        }

    }

    private void exitButton(object sender, EventArgs e)
    {
        int exitCode = 0; 
        Button exitButton = (Button)sender;
        string exitButtonText = exitButton.Text;

        if (exitButton.IsPressed)
        {
            Environment.Exit(exitCode);
        }

    }


    private void clockInButton(object sender, EventArgs e)
    {
        Button clockInButton = (Button)sender;
        string clockInButtonText = clockInButton.Text;
        string clockInWorkTime = "";
        

        if (clockInButton.IsPressed && shiftPosition.Text == null)
        {
            ifEmpty.Opacity = 1; 
        }
        if (clockInButton.IsPressed && shiftPosition.Text != null)
        {
            ifEmpty.Opacity = 0;
            workTime.Text = shiftPosition.Text + ": " + DateTime.Now.ToString("G");
        }

    }

    private void clockOutButton(object sender, EventArgs e)
    {
        Button clockOutButton = (Button)sender;
        string clockOutButtonText = clockOutButton.Text;

        if (clockOutButton.IsPressed && shiftPosition.Text != null) 
        {
            ifEmpty.Opacity = 1;
        }
        if(clockOutButton.IsPressed && shiftPosition.Text != null && workTime != null)
        {
            ifEmpty.Opacity = 0;
            workTime2.Text = workTime.Text + " - " + DateTime.Now.ToString("G");
            
            
            /*
            using var streamClockOutWorkTime = new MemoryStream(Encoding.Default.GetBytes(workTime.Text));
            var pathClockOutWorkTime = await filesaver.SaveAsync("clock_out_work_times.txt", streamClockOutWorkTime, default);
            */
        }


    }

}