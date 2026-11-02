using System.Windows.Controls;

namespace LANRescue.ConsoleApp.Views;

public partial class IpConflictView : UserControl
{
    public IpConflictView() => InitializeComponent();
}

public sealed class ConflictRow
{
    public string DeviceName { get; set; } = "";
    public string MacAddress { get; set; } = "";
    public string Identity { get; set; } = "";
    public string Evidence { get; set; } = "";
}
