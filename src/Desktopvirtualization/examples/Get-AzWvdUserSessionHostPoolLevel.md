### Example 1: List Windows Virtual Desktop UserSessions
```powershell
PS C:\> Get-AzWvdUserSessionHostPoolLevel -ResourceGroupName ResourceGroupName -HostPoolName HostPoolName

Name                           Type
----                           ----
HostPoolName/SessionHostName/2 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
HostPoolName/SessionHostName/3 Microsoft.DesktopVirtualization/hostpools/sessionhosts/usersessions
```

This command lists Windows Virtual Desktop UserSessions in a Host Pool.
