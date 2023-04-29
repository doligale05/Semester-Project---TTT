using CommunityToolkit.Maui.Storage;
using System.Text;
using System.IO;
namespace SemesterProject;

public partial class MainPage : ContentPage
{
    IFileSaver filesaver;
    
    public MainPage(IFileSaver fileSaver)
    {
        InitializeComponent();
        this.filesaver = fileSaver;
    }


    private async void registarButton(object sender, EventArgs e)
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
        {
            registerComplete.Text = "Register Complete!";
            registerComplete.Opacity = 100;
        }

        if ((registerButton.IsPressed && username.Text != null) && (registerButton.IsPressed && password.Text != null)
                                && (registerButton.IsPressed && workplace.Text != null)) 
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                string[] userInfo = new string[i]; 
                userInfo[i] = username.Text + " " + password.Text + " " + workplace.Text;
                using var streamUserInfo = new MemoryStream(Encoding.Default.GetBytes(userInfo[i]));
                var pathUserInfo = await filesaver.SaveAsync("UserInfo_list.txt", streamUserInfo, default);
            }
            */ // This was my initial idea so that we wouldnt need multiple different txt files, but i couldnt get the array in bounds for some reason? 

            //Therefore, I just came up with a dumb solution like this. It will probably be easier to use the data on the other pages this way anyway. 
            //fileSaver is being used from the (using CommunityToolkit.Maui.Storage;) library and being declared in the public MainPage() function. 
            using var streamUsername = new MemoryStream(Encoding.Default.GetBytes(username.Text));
            var pathUsername = await filesaver.SaveAsync("username_list.txt", streamUsername, default);

            using var streamPassword = new MemoryStream(Encoding.Default.GetBytes(password.Text));
            var pathPassword = await filesaver.SaveAsync("password_list.txt", streamPassword, default);

            using var streamWorkplace = new MemoryStream(Encoding.Default.GetBytes(workplace.Text));
            var pathWorkplace = await filesaver.SaveAsync("workplace_list.txt", streamWorkplace, default);
        }

    }

    private void toLoginButton(object sender, EventArgs e)
    {
        Button toLoginButton = (Button)sender;
        string toLoginButtonText = toLoginButton.Text;


        if (toLoginButton.IsPressed)
        {
            Navigation.PushAsync(new Login());
        }
    }


}

