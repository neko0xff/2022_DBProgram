FROM mcr.microsoft.com/mssql/server:2019-latest
FROM mcr.microsoft.com/mssql-tools
MAINTAINER neko_0xff <zangmenhsu@yahoo.co.jp> 


ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=oitmis
ENV TZ=Asia/Taipei
RUN useradd -M -s /bin/bash -u 10001 -g 0 mssql
RUN mkdir -p -m 770 /var/opt/mssql && chgrp -R 0 /var/opt/mssql
ADD cpData.bak /var/opt/mssql/backup 
ENV sql1 /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P oitmis -Q "RESTORE FILELISTONLY FROM DISK = '/var/opt/mssql/backup/cpData.bak'"
ENV sql1 /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P oitmis -Q "SELECT Name FROM sys.Databases"
EXPOSE 1433

