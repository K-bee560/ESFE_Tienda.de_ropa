document.addEventListener('DOMContentLoaded', () => {

    const inputPrecio = document.querySelector('#precio');
    const inputCantidad = document.querySelector('#cantidad');
    const btnCalcular = document.querySelector('#btnCalcular');

    const contenedorResultado = document.querySelector('#contenedorResultado');
    const totalTexto = document.querySelector('#totalTexto');
    const mensajeEstado = document.querySelector('#mensajeEstado');
    const badgeDescuento = document.querySelector('#badgeDescuento');

    btnCalcular.addEventListener('click', () => {

        const precio = Number(inputPrecio.value);
        const cantidad = Number(inputCantidad.value);

        if (inputPrecio.value === '' || inputCantidad.value === '' || cantidad <= 0) {
            alert('Por favor, ingresa un precio y una cantidad válidos.');
            return;
        }

        const subtotal = precio * cantidad;
        let descuento = 0;

        contenedorResultado.className = 'resultado-box';

        if (subtotal >= 100) {
            descuento = 0.20;
            contenedorResultado.classList.add('excelente');
            mensajeEstado.textContent = '🌟 ¡Super Descuento Claret! Tienes un 20% OFF por compra mayor a $100.';
            badgeDescuento.textContent = '20% OFF';
        } else if (subtotal >= 50) {
            descuento = 0.10;
            contenedorResultado.classList.add('aprobado');
            mensajeEstado.textContent = '👍 ¡Promoción Claret! Tienes un 10% OFF por compra mayor a $50.';
            badgeDescuento.textContent = '10% OFF';
        } else {
            descuento = 0;
            contenedorResultado.classList.add('reforzar');
            mensajeEstado.textContent = '🏷️ Compra estándar. ¡Agrega más prendas para conseguir descuento!';
            badgeDescuento.textContent = '0% OFF';
        }

        const totalFinal = subtotal - (subtotal * descuento);
        totalTexto.textContent = `Total a pagar: $${totalFinal.toFixed(2)}`;
    });

});