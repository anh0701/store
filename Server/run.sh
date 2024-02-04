echo "Which option do you choose?"
PS3="Select the operation: "
select yn in "create compose file and run container" "run container" "stop and remove container created by up" "remove volume" "cancel"; do
    case $yn in
        create\ compose\ file\ and\ run\ container ) 
            read -p "Enter the volumes name: " n1
            read -p "Enter the password mssql: " n2
            # echo "$n1 - $n2"
            sudo  systemctl start docker
            sudo docker volume create $n1
            mkdir output/$n1
            cp .env mssql.yaml output/$n1
            sed -i 's/test-vol/'$n1'/g' output/$n1/mssql.yaml
            sed -i 's/123456/'$n2'/g' output/$n1/.env
            # cat output/$n1/mssql.yaml
            sudo docker-compose -f mssql.yaml up -d
            break
            ;;
        run\ container )
            read -p "Enter the path to compose file: " composeup
            sudo  systemctl start docker
            sudo docker-compose -f $composeup up -d
            ;;
        stop\ and\ remove\ container\ created\ by\ up )
            read -p "Enter the path to compose file: " composedown
            sudo docker-compose -f $composedown down
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