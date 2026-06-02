pipeline {
    agent any
    environment {
        DOTNET_CLI_HOME="C:\\Program Files\\dotnet"
    }
    stages {
        stage("Checkout") {
         steps {
               checkout scm
         }
        }
        stage("Restore") {
            steps {
                bat "dotnet restore"
            }
        }
        stage("Build") {
            steps {
                bat "dotnet build --configuration Release"
            }
        }
        stage("Test") {
            steps {
                bat "dotnet test --no-restore --configuration Release"
            }

        }
        stage("Publish") {
            steps {
                script {
                    bat "dotnet publish --no-restore --configuration Release --output .\\publish"
                }
            }
        }
        // stage("Deployment") {
        //     steps {
        //         bat "del /q /s C:\\inetpub\\wwwroot\\isspipeline\\*"
        //         bat "xcopy /E /Y /I publish\\* C:\\inetpub\\wwwroot\\isspipeline\\*"
        //     }
        // }
        stage("Deployment") {
    steps {
        bat '%windir%\\System32\\inetsrv\\appcmd stop apppool /apppool.name:"iispipeline"'

        bat "del /q /s C:\\inetpub\\wwwroot\\isspipeline\\*"
        bat "xcopy /E /Y /I publish\\* C:\\inetpub\\wwwroot\\isspipeline\\"

        bat '%windir%\\System32\\inetsrv\\appcmd start apppool /apppool.name:"iispipeline"'
    }
}
    }
    post {
        success {
            echo "Build, Test and Publish stages completed successfully."
        }
    }
}