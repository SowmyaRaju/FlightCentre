function countFlights() {
    const inputString = document.getElementById('inputString').value.toLowerCase();

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