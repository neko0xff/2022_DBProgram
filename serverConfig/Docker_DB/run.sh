data="/opt/data:/var/opt/mssql/data"
log="/opt/log:/var/opt/mssql/log"
port="1433:1433"
image="neko_0xff/db_docker:laster"
docker run -d --restart=always -v $data -v $log -p $port $image