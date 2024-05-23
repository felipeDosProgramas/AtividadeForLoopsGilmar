let dom = {
    nro: document.getElementById('numero'),
    btnImprimir: document.getElementById('imprimir'),
    tabuada: document.getElementById('tabuada'),
};

/**
 * @async
 * @param {int} nro
 * @returns Promise<string>
 */
async function getTabuada(nro) {
    let server = await fetch(`/tabuada/${nro}`);
    return await server.text();
}
dom.btnImprimir.onclick = async () => {
    const nro = dom.nro.value.trim();
    console.log(nro)
    if (nro === "") return;
    const tabuada = await getTabuada(parseInt(nro));
    dom.tabuada.innerHTML = tabuada.replaceAll('>>><<<', '<br>')
}