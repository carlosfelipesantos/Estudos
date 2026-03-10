function tipoDado(dado){

    if(typeof dado === 'string'){
        console.log("O dado é string");
    } else if (typeof dado === 'number'){
        console.log("O dado é number");
    } else if (typeof dado === 'boolean'){
        console.log("O dado é boolean");
    }
}

tipoDado(3);
tipoDado(true);
tipoDado("ola");
