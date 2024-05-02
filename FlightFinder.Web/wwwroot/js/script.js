function countFlights() {
    const inputString = document.getElementById('inputString').value.toLowerCase();

    if (inputString.length === 0) {
        document.getElementById('errorMessage').textContent = 'Please enter a valid string.';
        document.getElementById('flightCount').textContent = '';
        return;
    }

    if (inputString.length > 100) {
        document.getElementById('errorMessage').textContent = 'Input is too long. Maximum 100 characters allowed.';
        document.getElementById('flightCount').textContent = '';
        return;
    }

    const apiHostname = 'localhost';
    const apiPort = '5086'; //Default port name

    const apiUrl = `http://${apiHostname}:${apiPort}/api/flights/count`;

    fetch(apiUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ Input: inputString })
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById('flightCount').innerText = `Number of instances of 'flight' : ${data.count}`;
            document.getElementById('errorMessage').textContent = '';
        })
        .catch(error => console.error('Error:', error));
}