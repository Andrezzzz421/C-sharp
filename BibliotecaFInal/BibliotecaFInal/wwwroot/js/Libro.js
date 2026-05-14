function verDetalles(titulo, isbn, anio, precio, autor, categoria, editorial, sinopsis, portadaBase64) {
    const modalTitulo = document.getElementById('modalTitulo');
    const modalIsbn = document.getElementById('modalIsbn');
    const modalAnio = document.getElementById('modalAnio');
    const modalPrecio = document.getElementById('modalPrecio');
    const modalAutor = document.getElementById('modalAutor');
    const modalCategoria = document.getElementById('modalCategoria');
    const modalEditorial = document.getElementById('modalEditorial');
    const modalSinopsis = document.getElementById('modalSinopsis');
    const modalPortada = document.getElementById('modalPortada');

    if (modalTitulo) modalTitulo.innerText = titulo;
    if (modalIsbn) modalIsbn.innerText = isbn || "N/A";
    if (modalAnio) modalAnio.innerText = anio;
    if (modalPrecio) modalPrecio.innerText = `$${precio}`;
    if (modalAutor) modalAutor.innerText = `por ${autor}`;
    if (modalCategoria) modalCategoria.innerText = categoria;
    if (modalEditorial) modalEditorial.innerText = editorial;
    if (modalSinopsis) modalSinopsis.innerText = sinopsis || "Sin sinopsis disponible.";

    if (modalPortada) {
        modalPortada.src = (portadaBase64 && portadaBase64.trim() !== "")
            ? 'data:image/*;base64,' + portadaBase64
            : '/img/no-book-cover.png';
    }

    const libroModalElem = document.getElementById('libroModal');
    if (libroModalElem) {
        const myModal = new bootstrap.Modal(libroModalElem);
        myModal.show();
    }
}



document.getElementById('portadaInput').addEventListener('change', function (e) {
    const preview = document.getElementById('previewImage');
    const placeholder = document.getElementById('placeholderPreview');

    const file = e.target.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = function (event) {
            preview.src = event.target.result;
            preview.classList.remove('d-none');
            if (placeholder) placeholder.classList.add('d-none');
        }
        reader.readAsDataURL(file);
    }
});

function abrirModalExportar() {
    const modalElem = document.getElementById('exportarPdfModal');
    if (modalElem) {
        const myModal = new bootstrap.Modal(modalElem);
        myModal.show();
    }
}

function validarSeleccionLibro(selectElement) {
    const btn = document.getElementById('btnDescargarPdf');
    const preview = document.getElementById('previsualizacionPdf');

    if (selectElement.value !== "") {
        btn.disabled = false;
        btn.classList.remove('btn-secondary');
        btn.classList.add('btn-danger');

        if (preview) preview.classList.remove('d-none');
        console.log("Seleccionado ID: " + selectElement.value);
    } else {
        btn.disabled = true;
        btn.classList.add('btn-secondary');
        btn.classList.remove('btn-danger');

        if (preview) preview.classList.add('d-none');
    }
}

function descargarPdf() {
    const select = document.getElementById('selectLibroPdf');
    if (!select || !select.value) {
        alert("Por favor, seleccione un libro de la lista.");
        return;
    }

    const id = select.value;
    const url = `/Libro/ExportarDetalle/${id}`;
    window.open(url, '_blank');
}

function gestionarBotones(modo) {
    const libroId = document.getElementById('selectLibroPdf').value;
    const btnInd = document.getElementById('btnPdfIndividual');
    btnInd.disabled = (libroId === "");
}

function descargarPdfIndividual() {
    const id = document.getElementById('selectLibroPdf').value;
    window.open(`/Libro/ExportarDetalle/${id}`, '_blank');
}

function descargarPdfFiltrado() {
    const cat = document.getElementById('filtroCategoria').value;
    const aut = document.getElementById('filtroAutor').value;
    const anio = document.getElementById('filtroAnio').value;

    let url = `/Libro/ExportarListado?idCategoria=${cat}&idAutor=${aut}&anio=${anio}`;
    window.open(url, '_blank');
}