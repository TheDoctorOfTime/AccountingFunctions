const ipc = require('electron').ipcRenderer;

document.getElementById("print-pdf").addEventListener('click', event => {
    console.log("click detected");
    ipc.send('print-to-pdf');
});