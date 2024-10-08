document.addEventListener("DOMContentLoaded", function() {
    document.getElementById('discount-row').addEventListener('click', function(e){
        if (e.target.classList.contains('discount')) {
            e.preventDefault();
            document.getElementById('code').innerHTML = e.target.dataset['code'];
            document.getElementById('product').innerHTML = e.target.dataset['product'];
            document.getElementById('title').innerHTML = e.target.dataset['title'];
            bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast')).show();
        }
    });
});