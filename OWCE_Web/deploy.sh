#!/bin/bash

clear

# Gather input of what environment to deploy for.
while true; do
    echo "================ Deploy Environment ================"
    echo '1. Dev'
    echo '9. Prod'
    echo 'q. Quit'
    echo ""
    read -p "Select deploy environment: " input_result

    case $input_result in
        "1" ) FUNCTION_NAME="OWCE_WebDev"; break;;
        "9" ) FUNCTION_NAME="OWCE_Web"; break;;
        [Qq] ) exit;;
    esac
    echo ""
done
echo ""


echo ""
echo "Deploying function: $FUNCTION_NAME"


dotnet lambda deploy-function --function-name $FUNCTION_NAME --profile owce --region us-east-1
