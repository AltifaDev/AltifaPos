window.toggleSidebar = (open) => {
    const sidebar = document.getElementById('sidebar');
    if (sidebar) {
        if (open) {
            sidebar.classList.remove('hidden');
            setTimeout(() => {
                sidebar.classList.add('sidebar-open');
            }, 10); // small delay to ensure class removal is processed
        } else {
            sidebar.classList.remove('sidebar-open');
            setTimeout(() => {
                sidebar.classList.add('hidden');
            }, 300); // match this to the CSS transition duration
        }
    }
};
window.showFileDialog = function () {
    document.getElementById('image').click();
};