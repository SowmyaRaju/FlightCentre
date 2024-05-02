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

    fetch('http://localhost:5086/api/flights/count', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ Input: inputString })
    })
        .then(response => response.json())
        .then(data => {
            document.getElementById('flightCount').innerText = `Number of instances of 'flight' : ${data.count}`;
        })
        .catch(error => console.error('Error:', error));
}