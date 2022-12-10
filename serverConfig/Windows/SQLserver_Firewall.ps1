# Scrpit
Write-Output "Add Firewall Rules: SQLServer default instance(TCP/1433)"
netsh advfirewall firewall add rule name="SQLServer default instance" protocol=TCP dir=in localport=1433 action=allow 
Write-Output "Add Firewall Rules: SQLServer Admin Connection(TCP/1434)"
netsh advfirewall firewall add rule name="SQLServer Admin Connection" protocol=TCP dir=in localport=1434 action=allow
Write-Output "Add Firewall Rules: SQLServer Service Broker(TCP/4022)"
netsh advfirewall firewall add rule name="SQLServer Service Broker" protocol=TCP dir=in localport=4022 action=allow
Write-Output "Add Firewall Rules: SQLServer Debugger/RPC(TCP/135) "
netsh advfirewall firewall add rule name="SQLServer Debugger/RPC" protocol=TCP dir=in localport=135 action=allow
Write-Output "Add Firewall Rules: Analysis Service(TCP/2383) "
netsh advfirewall firewall add rule name="Analysis Service" protocol=TCP dir=in localport=2383 action=allow
Write-Output "Add Firewall Rules: SQL Browser(TCP/2382)"
netsh advfirewall firewall add rule name="SQL Browser(TCP)" protocol=TCP dir=in localport=2382 action=allow
Write-Output "Add Firewall Rules: SQL Browser(UDP/1434)"
netsh advfirewall firewall add rule name="SQL Browser(UDP)" protocol=UDP dir=in localport=1434 action=allow

Write-Output "Show ALL firewall rule"
netsh advfirewall firewall show rule name="all"