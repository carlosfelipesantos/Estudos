let validarNomeUsuario = /^(?=.{3,16}$)[a-z\-9_]/;

console.log(validarNomeUsuario.test("matheus_123"));