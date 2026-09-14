document.addEventListener('DOMContentLoaded', () => {

    // --- ELEMENTOS DE LOGIN ---
    const formLogin = document.getElementById('formLogin');
    const usuarioInput = document.getElementById('usuario');
    const passwordInput = document.getElementById('password');
    const seccionLogin = document.getElementById('seccionLogin');
    const seccionCalculadora = document.getElementById('seccionCalculadora');
    const mensajeErrorLogin = document.getElementById('mensajeErrorLogin');
    const btnCerrarSesion = document.getElementById('btnCerrarSesion');

    // --- ELEMENTOS DE CALCULADORA ---
    const btnCalcular = document.getElementById('btnCalcular');
    const precioInput = document.getElementById('precio');
    const cantidadInput = document.getElementById('cantidad');
    const totalTexto = document.getElementById('totalTexto');
    const mensajeEstado = document.getElementById('mensajeEstado');
    const badgeDescuento = document.getElementById('badgeDescuento');

    // CREDENCIALES (Usuario y Contraseña por defecto)
    const USER_CORRECTO = "admin";
    const PASS_CORRECTO = "1234";

    // 1. EVENTO INICIAR SESIÓN
    formLogin.addEventListener('submit', (e) => {
        e.preventDefault();

        const userVal = usuarioInput.value.trim();
        const passVal = passwordInput.value.trim();

        if (userVal === USER_CORRECTO && passVal === PASS_CORRECTO) {
            // Credenciales correctas
            mensajeErrorLogin.classList.add('hidden');
            seccionLogin.classList.add('hidden');
            seccionCalculadora.classList.remove('hidden');
        } else {
            // Credenciales incorrectas
            mensajeErrorLogin.classList.remove('hidden');
        }
    });

    // 2. EVENTO CERRAR SESIÓN
    btnCerrarSesion.addEventListener('click', () => {
        usuarioInput.value = '';
        passwordInput.value = '';
        seccionCalculadora.classList.add('hidden');
        seccionLogin.classList.remove('hidden');
    });

    // 3. EVENTO CALCULAR DESCUENTO Y TOTAL
    btnCalcular.addEventListener('click', () => {
        const precio = parseFloat(precioInput.value);
        const cantidad = parseInt(cantidadInput.value);

        if (isNaN(precio) || isNaN(cantidad) || precio <= 0 || cantidad <= 0) {
            mensajeEstado.textContent = "Por favor ingrese valores válidos.";
            totalTexto.textContent = "Total: $0.00";
            return;
        }

        let subtotal = precio * cantidad;
        let descuento = 0;

        // Regla de Descuentos
        if (cantidad >= 3 && cantidad < 6) {
            descuento = 0.10; // 10% OFF
        } else if (cantidad >= 6) {
            descuento = 0.20; // 20% OFF
        }

        let totalFinal = subtotal - (subtotal * descuento);
        let porcentajeTexto = (descuento * 100) + "% OFF";

        // Actualizar Interfaz
        badgeDescuento.textContent = porcentajeTexto;
        totalTexto.textContent = `Total: $${totalFinal.toFixed(2)}`;
        
        if(descuento > 0) {
            mensajeEstado.textContent = `¡Felicidades! Aplicaste un ${porcentajeTexto} por tu compra.`;
        } else {
            mensajeEstado.textContent = "Compra 3 prendas o más para obtener descuentos.";
        }
    });

});