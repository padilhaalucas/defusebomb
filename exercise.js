defuse(['branco', 'vermelho', 'verde', 'branco']); // Não deve explodir
defuse(['branco', 'laranja', 'verde', 'branco']); // Deve explodir

function defuse(wires) {

    const rules = {
        branco: { forbidden: ["branco", "preto"] },
        vermelho: { allowed: ["verde"] },
        preto: { forbidden: ["branco", "verde", "laranja"] },
        laranja: { allowed: ["vermelho", "branco"] },
        verde: { allowed: ["laranja", "branco"] },
        roxo: { forbidden: ["roxo", "verde", "laranja", "branco"] }
    };

    let last;
    let boom;

    wires.forEach(function(current, index) {
        if (boom) return;
        if (last) {
            // Verifica se é necessário cortar algum fio específico
            if (rules[last]["allowed"]) {
                if (rules[last]["allowed"].indexOf(current) < 0) {
                    // O fio atual é diferente do fio que é necessário cortar (seguindo as regras)
                    boom = true;
                }
            }
            // Verifica se NÃO temos permissão para cortar fios específicos
            if (rules[last]["forbidden"]) {
                if (rules[last]["forbidden"].indexOf(current) > 0) {
                    // O fio atual é um fio ainda ativo
                    boom = true;
                }
            }
        }
        // Para a próxima iteração
        last = current;
    });

    console.log(boom ? "A Bomba explodiu" : "A Bomba foi desarmada");

}
