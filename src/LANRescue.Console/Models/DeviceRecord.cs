namespace LANRescue.ConsoleApp.Models;

public sealed class DeviceRecord
{
    public string DeviceName { get; init; } = "";
    public string RescueId { get; init; } = "";
    public string IPv4 { get; init; } = "";
    public string SubnetMask { get; init; } = "";
    public string Gateway { get; init; } = "";
    public string MacAddress { get; init; } = "";
    public string AgentStatus { get; init; } = "";
    public string IpStatus { get; init; } = "";
    public string Connection { get; init; } = "";
}
