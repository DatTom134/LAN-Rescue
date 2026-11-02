using System.Collections.ObjectModel;
using System.Windows.Controls;
using LANRescue.ConsoleApp.Models;

namespace LANRescue.ConsoleApp.Views;

public partial class DevicesView : UserControl
{
    public ObservableCollection<DeviceRecord> Devices { get; } = new()
    {
        new() { DeviceName="IT-PC-A", RescueId="DEMO-A-001", IPv4="192.168.110.151", MacAddress="AA-AA-AA-AA-AA-AA", AgentStatus="Demo", IpStatus="Normal" },
        new() { DeviceName="QA-PC-02 (B)", RescueId="DEMO-B-001", IPv4="192.168.110.93", MacAddress="BB-BB-BB-BB-BB-BB", AgentStatus="Demo", IpStatus="Conflict" },
        new() { DeviceName="QA-PC-03 (C)", RescueId="DEMO-C-001", IPv4="192.168.110.93", MacAddress="CC-CC-CC-CC-CC-CC", AgentStatus="Demo", IpStatus="Conflict" },
        new() { DeviceName="PMC-PC-01", RescueId="DEMO-D-001", IPv4="192.168.110.75", MacAddress="DD-DD-DD-DD-DD-DD", AgentStatus="Demo", IpStatus="Unknown" }
    };

    public DevicesView()
    {
        InitializeComponent();
        DataContext = this;
    }

    private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (DevicesGrid is null) return;
        var query = SearchBox.Text.Trim();
        DevicesGrid.ItemsSource = string.IsNullOrWhiteSpace(query)
            ? Devices
            : Devices.Where(d =>
                d.DeviceName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                d.IPv4.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                d.RescueId.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
