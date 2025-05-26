
var map = L.map('map').setView([28.6139, 77.2090], 13); // Default Delhi
L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
    attribution: '© OpenStreetMap contributors'
}).addTo(map);

var driverMarker = null;

function updateDriverLocation(lat, lng) {
    if (driverMarker) {
        driverMarker.setLatLng([lat, lng]);
    } else {
        driverMarker = L.marker([lat, lng]).addTo(map).bindPopup('Driver');
    }
}
