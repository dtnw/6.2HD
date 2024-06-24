pipeline{
    agent any
        environment {
        // Define a variable for the application URL, adjust the port if necessary
        APP_URL = "http://localhost:5173"
    }
    stages{
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/dtnw/6.2HD.git'
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
                    // Navigate to the project directory
                    dir('my-project') {
                        // Install dependencies
                        bat 'npm install'
                        
                        // Start the Vue.js application in the background
                        bat 'start /B npm run dev'
                        
                        // Wait for the application to start
                        retry(5) {
                            sleep time: 10, unit: 'SECONDS'
                            bat "curl --fail ${env.APP_URL} || exit 1"
                        }
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
                    echo "Deploy the application to 000webhost"
                    ftpPublisher alwaysPublishFromMaster: false,
                    continueOnError: false,
                    failOnError: false,
                    masterNodeName: "main",
                    paramPublish: null,
                    publishers: [[
                        configName: "website",
                        transfers: [[
                            asciiMode: false,
                            cleanRemote: false,
                            excludes: "",
                            flatten: false,
                            makeEmptyDirs: false,
                            noDefaultExcludes: false,
                            patternSeparator: "[, ]+",
                            remoteDirectory: "/public_html",
                            remoteDirectorySDF: false,
                            removePrefix: "my-project/dist",
                            sourceFiles: "my-project/dist/**"
                        ]],
                        usePromotionTimestamp: false,
                        useWorkspaceInPromotion: false,
                        verbose: false
                    ]]
                }
        }
    }
}