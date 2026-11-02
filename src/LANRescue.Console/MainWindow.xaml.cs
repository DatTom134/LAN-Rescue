using System.Windows;
using LANRescue.ConsoleApp.Views;

namespace LANRescue.ConsoleApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Navigate("Dashboard", new DashboardView());
    }

    private void Navigate(string title, object view)
    {
        PageTitleText.Text = title;
        PageHost.Content = view;
    }

    private void Dashboard_Click(object sender, RoutedEventArgs e) =>
        Navigate("Dashboard", new DashboardView());

    private void Devices_Click(object sender, RoutedEventArgs e) =>
        Navigate("Devices", new DevicesView());

    private void IpConflicts_Click(object sender, RoutedEventArgs e) =>
        Navigate("IP Conflicts", new IpConflictView());

    private void IpRecovery_Click(object sender, RoutedEventArgs e) =>
        Navigate("IP Recovery", new IpRecoveryView());

    private void Diagnostics_Click(object sender, RoutedEventArgs e) =>
        Navigate("Diagnostics", new DiagnosticsView());

    private void Settings_Click(object sender, RoutedEventArgs e) =>
        Navigate("Settings", new SettingsView());
}
