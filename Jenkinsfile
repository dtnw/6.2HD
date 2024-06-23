pipeline{
    agent any
    stages{
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/dtnw/task6.2hd.git'
            }
        }
        stage('Build'){
            steps{
                echo "Build the code using Vue to compile and package the code."
                dir("my-project"){
                    bat "npm install"
                    bat "npm run build"
                }
            }
        }
        stage('Start Application') {
            steps {
                script {
                    // Start the Vue.js application in the background
                    bat 'start /B npm run serve'
                    
                    // Wait for the application to start
                    retry(5) {
                        sleep time: 10, unit: 'SECONDS'
                        bat "curl --fail ${env.APP_URL} || exit 1"
                    }
                }
            }
        }
        stage('Unit and Integration Tests'){
            steps {
                dir("test/seleniumtest/seleniumtest"){
                    bat "dotnet run"
                }
            }
        }
        
        stage('Deploy'){
            steps{
                    echo "Deploy the application to a production server on AWS EC2 instance."
                    ftpPublisher alwaysPublishFromMaster: false, continueOnError: false, failOnError: false,masterNodeName: "main", paramPublish: null, publishers: [[configName: "website", transfers: [[asciiMode: false, cleanRemote: false, excludes: "", flatten: false, makeEmptyDirs: false, noDefaultExcludes: false, patternSeparator: "[, ]+", remoteDirectory: "sit753-task6.2hd.000webhost.com", remoteDirectorySDF: false, removePrefix: "", sourceFiles: "my-project/dist/*/*"]], usePromotionTimestamp: false, useWorkspaceInPromotion: false, verbose: false]]
                    }
        }
    }
}