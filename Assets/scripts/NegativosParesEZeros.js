import {sanitizaEFiltraEntrada} from "/assets/scripts/ImprimirNrosPedidos.js";

/**
 * @type {{
 *  input: HTMLInputElement,
 *  p: HTMLParagraphElement
 * }}
 */
let dom = {
    input: document.getElementsByName('numeros')[0],
    p: document.querySelector('p')
};
let timer = null;
dom.input.oninput = (ev) => {
    clearTimeout(timer)
    timer = setTimeout(async () => {
        let server = await fetch(`/NegativosParesEZeros/${
            sanitizaEFiltraEntrada(ev.target.value.trim()) 
                .join("%20")
        }`);
        dom.p.innerHTML = (await server.text())
            .split('>>><<<')
            .join('<br>');
    }, 750)
}