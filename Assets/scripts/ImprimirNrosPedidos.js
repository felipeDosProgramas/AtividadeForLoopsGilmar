/**
 * @param {string} entradaCrua
 * @returns string[]
 */
export function sanitizaEFiltraEntrada(entradaCrua) {
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
export function validaEntrada(entradaSanitizada) {
    return (
        entradaSanitizada.length !== 20 ||
        entradaSanitizada.length > 20
    );
}

export function separarParaEnviarNumeros(e) {
    const nums = sanitizaEFiltraEntrada(e.target.value);
    return validaEntrada(nums)
        ? false
        : "/exibirNros?nums=" + nums
            .join("%20")
}
export async function recebeSaida(url) {
    let server = await fetch(url)
    return await server.text();
}