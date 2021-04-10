
function Exito(titulo, texto, icono) {
    return new Promise(promese => {

        Swal.fire(
            titulo,
            texto,
            icono
        ).then((result) => {
            if (result.value) {
                promese(null);
            } else {
                promese(null);
            }
        })
    })
}
function PreguntarBorrar(titulo, texto, icon) {
    return new Promise(promese => {

        Swal.fire({
            title: titulo,
            text: texto,
            icon: icon,
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Si, Borrar!',
            cancelButtonText: 'Cancelar'
        }).then((result) => {
            if (result.value) {
                promese(true);
            } else {
                promese(false);
            }
        });
    });
};