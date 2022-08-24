const canvas = documenntElementById('painel');

const ctx = canvas.getContext('2d');

ctx.canvas.width = COLUNA * TAM_BLOCO;
ctx.canvas.height = LINHA * TAM_BLOCO;

ctx.scale(TAM_BLOCO, TAM_BLOCO);