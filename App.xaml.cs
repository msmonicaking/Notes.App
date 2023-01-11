/*
 * <?Just to keep things simple, both of these files are referred to as a single file. >
    <?There are generally two files with any XAML file, the .xaml file itself, >
    <?and a corresponding code file that is a child item of it in the Solution Explorer. >
    <?The .xaml file contains XAML markup and the code file contains code created by the user to interact with the XAML markup.

	The App.xaml.cs file generally contains code that instantiates the Shell application. 
	In this project, it points to the AppShell class.
*/

namespace Notes;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
