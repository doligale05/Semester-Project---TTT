using CommunityToolkit.Maui.Storage;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace SemesterProject;

public partial class Login : ContentPage
{

    String usernameLine;
	String passwordLine;
    String workplaceLine;
    public Login()
	{
		InitializeComponent();
	}

	private void loginButtonClicked(object sender, EventArgs e)
	{
        Button loginButtonClicked = (Button)sender;
        string loginButtonClickedText = loginButtonClicked.Text;
		
		StreamReader usernameFile = new StreamReader("C:\\Users\\JohnT\\source\\repos\\SemesterProject\\SemesterProject\\username_list.txt");
		usernameLine = usernameFile.ReadLine();

        StreamReader passwordFile = new StreamReader("C:\\Users\\JohnT\\source\\repos\\SemesterProject\\SemesterProject\\password_list.txt");
        passwordLine = passwordFile.ReadLine();

        StreamReader workplaceFile = new StreamReader("C:\\Users\\JohnT\\source\\repos\\SemesterProject\\SemesterProject\\workplace_list.txt");
        workplaceLine = workplaceFile.ReadLine();


        if(loginButtonClicked.IsPressed && usernameLogin.Text == ""
            || loginButtonClicked.IsPressed && passwordLogin.Text == "")
        {
            loginError.Text = "Please Fill Out All Entries!"; 
            loginError.Opacity = 1; 
        }
        else
        { loginError.Opacity = 0; }

        if (loginButtonClicked.IsPressed && usernameLogin.Text != usernameLine
            || loginButtonClicked.IsPressed && passwordLogin.Text != passwordLine)
        {
            loginError.Text = "This User Does Not Exist!";
            loginError.Opacity = 1;
        }
        else { loginError.Opacity = 0; }


        if ((usernameLine == usernameLogin.Text) && (passwordLine == passwordLogin.Text) && (loginButton.IsPressed)) 
		{
            Navigation.PushAsync(new HomeScreen(usernameLogin.Text, passwordLogin.Text, workplaceLine));
        }
        
    }

}