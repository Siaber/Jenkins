node {
    /* Requires the Docker Pipeline plugin to be installed */
    docker.image('ngnixfortest').inside {
        stage('Test') {
            sh 'nginx --version'
        }
    }
}
