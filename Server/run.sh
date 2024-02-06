echo "Which option do you choose?"
PS3="Select the operation: "
sudo  systemctl start docker
select yn in "create compose file and run container" "run container" "list container" "logs container" "stop and remove container created by up" "create volume" "remove volume" "cancel"; do
    case $yn in
        create\ compose\ file\ and\ run\ container ) 
            read -p "Enter the volumes name: " n1
            read -p "Enter the password mssql: " n2
            # echo "$n1 - $n2"
            sudo docker volume create $n1
            mkdir output/$n1
            cp .env mssql.yaml output/$n1
            sed -i 's/test-vol/'$n1'/g' output/$n1/mssql.yaml
            sed -i 's/YourStrong@Passw0rd/'$n2'/g' output/$n1/.env
            # cat output/$n1/mssql.yaml
            sudo docker-compose -f mssql.yaml up -d
            break
            ;;
        run\ container )
            read -p "Enter the path to compose file: " composeup
            sudo docker-compose -f $composeup up -d
            ;;
        list\ container )
            sudo docker ps
            ;;
        logs\ container )
            read -p "Enter the name container: " container
            sudo docker logs $container
            ;;
        stop\ and\ remove\ container\ created\ by\ up )
            read -p "Enter the path to compose file: " composedown
            sudo docker-compose -f $composedown down
            ;;
        create\ volume )
            read -p "Enter the volume name: " volumecre
            sudo docker volume create $volumecre
            ;;
        remove\ volume )
            read -p "Enter the volume name: " volume
            sudo docker volume rm $volume
            ;;
        cancel ) 
            exit
            ;;
    esac
done