node
{
    stage 'pull code'    
    	    checkout scm
    
    stage 'run nginx from docker'
	    pipeline {
    agent { docker { image '37d4cec4a5fbb64b8faab0385026d40ee7a46eef506e2c6a34d46d53e8bce745' } }
    stages {
        stage('build') {
            steps {
                sh 'nginx --version'
            }
        }
    }
}
    
    stage 'run bash in nginx'
	    bat 'start cmd.exe /docker exec -it 37d4cec4a5fbb64b8faab0385026d40ee7a46eef506e2c6a34d46d53e8bce745 bash'
        
}
