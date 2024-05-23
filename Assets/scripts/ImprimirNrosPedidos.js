let input = document.getElementById('numerosCrus')
let paragrafo = document.querySelector('p');
/**
 * @param {string} entradaCrua
 * @returns string[]
 */
function sanitizaEFiltraEntrada(entradaCrua) {
    return entradaCrua
        .split(" ")
        .map(str => str.trim())
        .filter(str => str.length !== 0)
        .filter(str => str.match(/^\d+$/));
}

/**
 * @param {string[]} entradaSanitizada
 * @return boolean
 */
function validaEntrada(entradaSanitizada) {
    return (
        entradaSanitizada.length !== 20 ||
        entradaSanitizada.length > 20
    );
}

function separarParaEnviarNumeros(e) {
    const nums = sanitizaEFiltraEntrada(e.target.value);
    return validaEntrada(nums)
        ? false
        : "/exibirNros?nums=" + nums
            .join("%20")
}
async function recebeSaida(url) {
    let server = await fetch(url)
    return await server.text();
}
input.oninput = async (ev) => {
    let nums = separarParaEnviarNumeros(ev);
    if (nums)
        paragrafo.innerText =  await recebeSaida(nums);
}