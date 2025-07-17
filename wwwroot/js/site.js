document.addEventListener('DOMContentLoaded', function () {
    const form = document.getElementById('contactForm');
    if (form) {
        form.addEventListener('submit', function (e) {
            e.preventDefault();
            document.getElementById('contactSuccess').classList.remove('d-none');
            form.reset();
        });
    }
});