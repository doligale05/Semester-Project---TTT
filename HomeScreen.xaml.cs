namespace SemesterProject;

public partial class HomeScreen : ContentPage
{
    private string userEntry; 
    private string passwordEntry;
    private string workplace;


    public HomeScreen(string userEntry, string passwordEntry, string workplace)
    {
        InitializeComponent();

        this.userEntry = userEntry;
        this.passwordEntry = passwordEntry;
        this.workplace = workplace;

        currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        currentDate.Text = DateTime.Now.ToString("dddd , MMM dd yyyy");

        currentUser.Text = userEntry; 
    }



}