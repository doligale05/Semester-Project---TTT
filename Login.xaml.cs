//using Windows.Web.AtomPub;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
namespace SemesterProject;

public partial class Login : ContentPage
{
	private string userEntry;
	private string passwordEntry;
	private string workplaceEntry;
	private Entry username;
	private Entry password;
	private Entry workplace;
	private Button register;

	

	public Login(Entry username, Entry password, Entry workplace, Button register)
	{
		InitializeComponent();

		this.username = username;
		this.password = password;
		this.workplace = workplace; 
		this.register = register;

		if (register.IsPressed)
		{
			userEntry = username.ToString();
            passwordEntry = password.ToString();
            workplaceEntry = workplace.ToString();
		}

		username.ToString(); //send to debug output
		password.ToString();
	}

	private void loginButtonClicked(object sender, EventArgs e)
	{
        Button loginButton = (Button)sender;
        string loginButtonText = loginButton.Text;
		//on mine it doesn't show initialize component. I'll send a ss in the discord
		if (userLogin == username && passLogin == password) 
		{
            Navigation.PushAsync(new HomeScreen(userEntry, passwordEntry, workplaceEntry));
        }
        /*second comparison test
		 if (userEntry.Equals(username) && passwordEntry.Equals(password)){
        Navigation.PushAsync(new HomeScreen(userEntry.ToString(), passwordEntry.ToString(), workplace.ToString()));}
		*/
    }

}