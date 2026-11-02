# LAN Rescue v0.1.0

LAN Rescue is a Windows desktop project for diagnosing LAN connectivity and preparing a safe remote IP recovery workflow.

## Current scope

This first source package contains:
- WPF Console shell and navigation.
- Dashboard, Devices, IP Conflicts, IP Recovery, Diagnostics, and Settings screens.
- Sample-only device data to demonstrate the intended workflow.
- A preliminary folder layout for later Console/Agent separation.

**Important:** All device states and IP conflict records in this version are sample data. This version does not discover real devices, connect to an Agent, change IP settings, or run remote commands.

## Requirements

- Windows 10/11
- .NET 10 SDK
- Visual Studio Code
- C# Dev Kit extension (recommended)

## Run

From the repository root:

```powershell
dotnet --info
dotnet restore .\LANRescue.sln
dotnet build .\LANRescue.sln
dotnet run --project .\src\LANRescue.Console\LANRescue.Console.csproj
```

## Project structure

- `src/LANRescue.Console`: WPF UI.
- `src/LANRescue.Application`: placeholder for use cases and interfaces.
- `src/LANRescue.Domain`: placeholder for domain entities.
- `src/LANRescue.Contracts`: placeholder for Console-Agent messages.
- `src/LANRescue.Infrastructure`: placeholder for Windows/network integrations.
- `src/LANRescue.Agent`: placeholder for a future Windows Service.
- `docs`: architecture and testing notes.

Placeholder folders contain `.gitkeep` files until their first implementation.

## Safe development plan

1. Finish the UI shell and sample screens.
2. Define device identity and Agent communication contracts.
3. Prototype IPv6 link-local connectivity in an isolated test environment.
4. Add read-only diagnostics.
5. Implement remote IP changes only after identity verification, authorization, configuration backup, and rollback are in place.
6. Test against lab devices before using on a production network.

## Sample network scenario

- PC-A: `192.168.110.151/24`, gateway `192.168.110.9`
- PC-B: `192.168.110.93/24`, gateway `192.168.110.9`
- PC-C: `192.168.110.93/24`, gateway `192.168.110.9`

The UI intentionally displays B and C as a sample IP conflict. It does not infer which MAC owns the IP from ARP and does not perform any network action.
