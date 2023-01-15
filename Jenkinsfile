node {
    /* Requires the Docker Pipeline plugin to be installed */
    docker.image('nginx').inside {
        stage('Test') {
            sh 'nginx --version'
        }
    }
}
