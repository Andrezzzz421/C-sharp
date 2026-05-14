// wwwroot/js/categorias.js

document.addEventListener("DOMContentLoaded", function () {
    const logoInput = document.getElementById('logoInput');
    const previewContainer = document.getElementById('previewContainer');
    const previewImage = document.getElementById('previewImage');

    if (logoInput) {
        logoInput.addEventListener('change', function () {
            const file = this.files[0];

            if (file) {
                const reader = new FileReader();

                reader.onload = function (e) {
                    // Mostrar la imagen seleccionada en el contenedor de previsualización
                    if (previewImage) {
                        previewImage.src = e.target.result;
                        previewContainer.classList.remove('d-none');
                    }
                }

                reader.readAsDataURL(file);
            }
        });
    }
});

document.getElementById('logoInput').addEventListener('change', function () {
    const status = document.getElementById('textStatus');
    const placeholder = document.getElementById('noLogoPlaceholder');
    const preview = document.getElementById('previewImage');

    if (status) status.innerText = "Nueva imagen seleccionada";
    if (placeholder) placeholder.classList.add('d-none');
    if (preview) preview.classList.remove('d-none');
});