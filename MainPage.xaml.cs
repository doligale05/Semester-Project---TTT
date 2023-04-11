
//using System.ComponentModel.Design;

namespace SemesterProject;

public partial class MainPage : ContentPage
{
    private string userLogin;
    private string passLogin;
    //private string workplace;

    public MainPage()
    {
        InitializeComponent();
    }

    private void toLoginButton(object sender, EventArgs e)
    {
        Button toLoginButton = (Button)sender;
        string toLoginButtonText = toLoginButton.Text;


        if (toLoginButton.IsPressed)
        {
            //userLogin = username.Text;
            //passLogin = password.Text;
            //workplaceEntry = workplace.Text;
            Navigation.PushAsync(new Login(username, password, workplace, register));
        }
    }

    private void registarButton(object sender, EventArgs e)
    {
        Button registerButton = (Button)sender;
        string registerButtonText = registerButton.Text;

        if (registerButton.IsPressed && username.Text == null)
        {
            registerComplete.Text = "Please fill out all Entries!";
            registerComplete.Opacity = 100;
        }
        else if (registerButton.IsPressed && password.Text == null)
        {
            registerComplete.Text = "Please fill out all Entries!";
            registerComplete.Opacity = 100;
        }
        else if (registerButton.IsPressed && workplace.Text == null)
        {
            registerComplete.Text = "Please fill out all Entries!";
            registerComplete.Opacity = 100;
        }
        else
            registerComplete.Text = "Register Complete!";
        registerComplete.Opacity = 100;

        /*
        if (registerButton.IsPressed)
        {
            username.ToString();
            password.ToString();
            workplace.ToString();
        }
        */
    }



    

}

