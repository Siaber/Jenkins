node {
    /* Requires the Docker Pipeline plugin to be installed */
    docker.image('node:16.13.1-alpine3.13').inside {
        stage('Test') {
            sh 'node --version'
        }
    }
}
