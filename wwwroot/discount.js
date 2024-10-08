document.addEventListener("DOMContentLoaded", function() {
    document.getElementById('discount-row').addEventListener('click', function(e){
        e.preventDefault();
        bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast')).show();
    });
});