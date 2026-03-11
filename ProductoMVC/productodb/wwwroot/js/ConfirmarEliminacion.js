document.addEventListener("DOMContentLoaded", function () {
    const deleteLinks = document.querySelectorAll('.delete-confirm');

    deleteLinks.forEach(function (link) {
        link.addEventListener('click', function (e) {
            e.preventDefault();
            const url = this.href;

            Swal.fire({
                title: '¿Estas seguro?',
                text: '!El Registro sera eliminado',
                icon: 'warming',
                showCancelButton: true,
                ConfirmButtonColor: '#3085d6'
                cancelButtonColor: '#d33',
                confirmButtonText: 'Si, eliminarlo',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                if (result.isConfirmed) {
                    window.location.href = url;
                }
            });
        });
    });
});