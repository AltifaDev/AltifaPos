self.addEventListener('install', (event) => {
    console.log('Service Worker installing.');
    // Perform install steps
});

self.addEventListener('activate', () => {
    console.log('sw activate');
    clients.claim();
});
 