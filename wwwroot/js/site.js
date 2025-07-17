document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');
    const successMsg = document.getElementById('contactSuccess');
    if (form && successMsg) {
        form.addEventListener('submit', function (e) {
            e.preventDefault();
            successMsg.classList.remove('d-none');
            form.reset();
        });
    }
});