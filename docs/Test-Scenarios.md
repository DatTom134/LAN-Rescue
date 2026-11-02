# Initial test scenarios

## Sample conflict scenario

- PC-A: 192.168.110.151/24
- PC-B: 192.168.110.93/24
- PC-C: 192.168.110.93/24
- Gateway: 192.168.110.9
- A's ARP cache currently maps 192.168.110.93 to C's MAC.

Expected UI behavior:
- Display a possible/known conflict as sample data.
- Keep B and C as separate managed identities.
- Never infer target identity from IP alone.
- Never enable a real IP change in this version.

## Future acceptance test

Only after Agent and management transport are implemented:
- Authenticate B by its registered identity/certificate.
- Reach B through an independent working management channel.
- Apply an IP allocated/approved by IT.
- Confirm C retains its original IP.
- Verify B's new address, gateway, DNS and network reachability.
- Roll back or report a safe failure if verification fails.
