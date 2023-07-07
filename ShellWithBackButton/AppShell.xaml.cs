
namespace ShellWithBackButton;

public partial class AppShell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute("TestPageOutsideVisualHierarchy", typeof(TestPage));
    }
}
