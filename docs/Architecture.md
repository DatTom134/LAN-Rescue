# LAN Rescue architecture (initial)

## Planned components

- **Console:** WPF desktop UI used by IT staff.
- **Agent:** Windows Service installed in advance on managed endpoints.
- **Contracts:** versioned request/response messages shared by Console and Agent.
- **Application:** use cases and orchestration.
- **Domain:** device identity and recovery rules.
- **Infrastructure:** Windows networking APIs, transport, persistence, and logging.

## Non-negotiable safety rules

1. IP address alone is not a device identity.
2. A MAC address observed in ARP is evidence, not proof that a target is reachable.
3. Do not change IP unless the target Agent identity has been authenticated.
4. Do not start a rogue DHCP server on the company LAN.
5. Prefer the organization's DHCP/IPAM process or an approved static-IP allocation.
6. Preserve a management channel and provide rollback for IP changes.
