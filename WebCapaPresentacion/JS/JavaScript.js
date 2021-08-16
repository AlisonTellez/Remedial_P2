function Alerta(ti, msj, iconotipo) {
    Swal.fire({
        title: ti,
        text: msj,
        icon: iconotipo,
        confirmButtonText: 'Aceptar'
    })
}
