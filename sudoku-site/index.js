const prefixo = 'bloco';
const numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9];
const classCellValue = '.cell-value';
const classGameCell = '.game-cell';
const classGameValue = 'game-value'
const classCellSelected = 'cell-selected';
const classHiglightTable = 'highlight-table';
const classMistake = 'mistake';
const classConflict = 'conflict';
//const url = 'https://api.rocktools.com.br/sudoku/'; /*http://localhost:3000/sudoku/*/
const url = 'https://converter.blog.br/sudoku/'
const startSVG = ["SVG0", "SVG1", "SVG2", "SVG3", "SVG4", "SVG5", "SVG6", "SVG7", "SVG8", "SVG9"];
const maxBlocos = 81;
let mapa = {
    /*quadrante 1*/
    bloco1: { quadrante: "quadrante1", linha: "linha1", coluna: "coluna1", initial: 0, valor: 0, gabarito: 1 },
    bloco2: { quadrante: "quadrante1", linha: "linha1", coluna: "coluna2", initial: 3, valor: 3, gabarito: 3 },
    bloco3: { quadrante: "quadrante1", linha: "linha1", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco4: { quadrante: "quadrante2", linha: "linha1", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco5: { quadrante: "quadrante2", linha: "linha1", coluna: "coluna5", initial: 2, valor: 2, gabarito: 0 },
    bloco6: { quadrante: "quadrante2", linha: "linha1", coluna: "coluna6", initial: 7, valor: 7, gabarito: 0 },
    bloco7: { quadrante: "quadrante3", linha: "linha1", coluna: "coluna7", initial: 8, valor: 8, gabarito: 0 },
    bloco8: { quadrante: "quadrante3", linha: "linha1", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco9: { quadrante: "quadrante3", linha: "linha1", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 2*/
    bloco10: { quadrante: "quadrante1", linha: "linha2", coluna: "coluna1", initial: 6, valor: 6, gabarito: 0 },
    bloco11: { quadrante: "quadrante1", linha: "linha2", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco12: { quadrante: "quadrante1", linha: "linha2", coluna: "coluna3", initial: 9, valor: 9, gabarito: 0 },
    bloco13: { quadrante: "quadrante2", linha: "linha2", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco14: { quadrante: "quadrante2", linha: "linha2", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco15: { quadrante: "quadrante2", linha: "linha2", coluna: "coluna6", initial: 3, valor: 3, gabarito: 0 },
    bloco16: { quadrante: "quadrante3", linha: "linha2", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco17: { quadrante: "quadrante3", linha: "linha2", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco18: { quadrante: "quadrante3", linha: "linha2", coluna: "coluna9", initial: 7, valor: 7, gabarito: 0 },
    /*quadrante 3*/
    bloco19: { quadrante: "quadrante1", linha: "linha3", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco20: { quadrante: "quadrante1", linha: "linha3", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco21: { quadrante: "quadrante1", linha: "linha3", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco22: { quadrante: "quadrante2", linha: "linha3", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco23: { quadrante: "quadrante2", linha: "linha3", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco24: { quadrante: "quadrante2", linha: "linha3", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco25: { quadrante: "quadrante3", linha: "linha3", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco26: { quadrante: "quadrante3", linha: "linha3", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco27: { quadrante: "quadrante3", linha: "linha3", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 4*/
    bloco28: { quadrante: "quadrante4", linha: "linha4", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco29: { quadrante: "quadrante4", linha: "linha4", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco30: { quadrante: "quadrante4", linha: "linha4", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco31: { quadrante: "quadrante5", linha: "linha4", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco32: { quadrante: "quadrante5", linha: "linha4", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco33: { quadrante: "quadrante5", linha: "linha4", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco34: { quadrante: "quadrante6", linha: "linha4", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco35: { quadrante: "quadrante6", linha: "linha4", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco36: { quadrante: "quadrante6", linha: "linha4", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 5*/
    bloco37: { quadrante: "quadrante4", linha: "linha5", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco38: { quadrante: "quadrante4", linha: "linha5", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco39: { quadrante: "quadrante4", linha: "linha5", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco40: { quadrante: "quadrante5", linha: "linha5", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco41: { quadrante: "quadrante5", linha: "linha5", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco42: { quadrante: "quadrante5", linha: "linha5", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco43: { quadrante: "quadrante6", linha: "linha5", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco44: { quadrante: "quadrante6", linha: "linha5", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco45: { quadrante: "quadrante6", linha: "linha5", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 6*/
    bloco46: { quadrante: "quadrante4", linha: "linha6", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco47: { quadrante: "quadrante4", linha: "linha6", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco48: { quadrante: "quadrante4", linha: "linha6", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco49: { quadrante: "quadrante5", linha: "linha6", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco50: { quadrante: "quadrante5", linha: "linha6", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco51: { quadrante: "quadrante5", linha: "linha6", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco52: { quadrante: "quadrante6", linha: "linha6", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco53: { quadrante: "quadrante6", linha: "linha6", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco54: { quadrante: "quadrante6", linha: "linha6", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 7*/
    bloco55: { quadrante: "quadrante7", linha: "linha7", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco56: { quadrante: "quadrante7", linha: "linha7", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco57: { quadrante: "quadrante7", linha: "linha7", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco58: { quadrante: "quadrante8", linha: "linha7", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco59: { quadrante: "quadrante8", linha: "linha7", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco60: { quadrante: "quadrante8", linha: "linha7", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco61: { quadrante: "quadrante9", linha: "linha7", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco62: { quadrante: "quadrante9", linha: "linha7", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco63: { quadrante: "quadrante9", linha: "linha7", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 8*/
    bloco64: { quadrante: "quadrante7", linha: "linha8", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco65: { quadrante: "quadrante7", linha: "linha8", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco66: { quadrante: "quadrante7", linha: "linha8", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco67: { quadrante: "quadrante8", linha: "linha8", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco68: { quadrante: "quadrante8", linha: "linha8", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco69: { quadrante: "quadrante8", linha: "linha8", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco70: { quadrante: "quadrante9", linha: "linha8", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco71: { quadrante: "quadrante9", linha: "linha8", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco72: { quadrante: "quadrante9", linha: "linha8", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    /*quadrante 9*/
    bloco73: { quadrante: "quadrante7", linha: "linha9", coluna: "coluna1", initial: 0, valor: 0, gabarito: 0 },
    bloco74: { quadrante: "quadrante7", linha: "linha9", coluna: "coluna2", initial: 0, valor: 0, gabarito: 0 },
    bloco75: { quadrante: "quadrante7", linha: "linha9", coluna: "coluna3", initial: 0, valor: 0, gabarito: 0 },
    bloco76: { quadrante: "quadrante8", linha: "linha9", coluna: "coluna4", initial: 0, valor: 0, gabarito: 0 },
    bloco77: { quadrante: "quadrante8", linha: "linha9", coluna: "coluna5", initial: 0, valor: 0, gabarito: 0 },
    bloco78: { quadrante: "quadrante8", linha: "linha9", coluna: "coluna6", initial: 0, valor: 0, gabarito: 0 },
    bloco79: { quadrante: "quadrante9", linha: "linha9", coluna: "coluna7", initial: 0, valor: 0, gabarito: 0 },
    bloco80: { quadrante: "quadrante9", linha: "linha9", coluna: "coluna8", initial: 0, valor: 0, gabarito: 0 },
    bloco81: { quadrante: "quadrante9", linha: "linha9", coluna: "coluna9", initial: 0, valor: 0, gabarito: 0 },
    linha1: ["bloco1", "bloco2", "bloco3", "bloco4", "bloco5", "bloco6", "bloco7", "bloco8", "bloco9"],
    linha2: ["bloco10", "bloco11", "bloco12", "bloco13", "bloco14", "bloco15", "bloco16", "bloco17", "bloco18"],
    linha3: ["bloco19", "bloco20", "bloco21", "bloco22", "bloco23", "bloco24", "bloco25", "bloco26", "bloco27"],
    linha4: ["bloco28", "bloco29", "bloco30", "bloco31", "bloco32", "bloco33", "bloco34", "bloco35", "bloco36"],
    linha5: ["bloco37", "bloco38", "bloco39", "bloco40", "bloco41", "bloco42", "bloco43", "bloco44", "bloco45"],
    linha6: ["bloco46", "bloco47", "bloco48", "bloco49", "bloco50", "bloco51", "bloco52", "bloco53", "bloco54"],
    linha7: ["bloco55", "bloco56", "bloco57", "bloco58", "bloco59", "bloco60", "bloco61", "bloco62", "bloco63"],
    linha8: ["bloco64", "bloco65", "bloco66", "bloco67", "bloco68", "bloco69", "bloco70", "bloco71", "bloco72"],
    linha9: ["bloco73", "bloco74", "bloco75", "bloco76", "bloco77", "bloco78", "bloco79", "bloco80", "bloco81"],
    coluna1: ["bloco1", "bloco10", "bloco19", "bloco28", "bloco37", "bloco46", "bloco55", "bloco64", "bloco73"],
    coluna2: ["bloco2", "bloco11", "bloco20", "bloco29", "bloco38", "bloco47", "bloco56", "bloco65", "bloco74"],
    coluna3: ["bloco3", "bloco12", "bloco21", "bloco30", "bloco39", "bloco48", "bloco57", "bloco66", "bloco75"],
    coluna4: ["bloco4", "bloco13", "bloco22", "bloco31", "bloco40", "bloco49", "bloco58", "bloco67", "bloco76"],
    coluna5: ["bloco5", "bloco14", "bloco23", "bloco32", "bloco41", "bloco50", "bloco59", "bloco68", "bloco77"],
    coluna6: ["bloco6", "bloco15", "bloco24", "bloco33", "bloco42", "bloco51", "bloco60", "bloco69", "bloco78"],
    coluna7: ["bloco7", "bloco16", "bloco25", "bloco34", "bloco43", "bloco52", "bloco61", "bloco70", "bloco79"],
    coluna8: ["bloco8", "bloco17", "bloco26", "bloco35", "bloco44", "bloco53", "bloco62", "bloco71", "bloco80"],
    coluna9: ["bloco9", "bloco18", "bloco27", "bloco36", "bloco45", "bloco54", "bloco63", "bloco72", "bloco81"],
    quadrante1: ["bloco1", "bloco2", "bloco3", "bloco10", "bloco11", "bloco12", "bloco19", "bloco20", "bloco21"],
    quadrante2: ["bloco4", "bloco5", "bloco6", "bloco13", "bloco14", "bloco15", "bloco22", "bloco23", "bloco24"],
    quadrante3: ["bloco7", "bloco8", "bloco9", "bloco16", "bloco17", "bloco18", "bloco25", "bloco26", "bloco27"],
    quadrante4: ["bloco28", "bloco29", "bloco30", "bloco37", "bloco38", "bloco39", "bloco46", "bloco47", "bloco48"],
    quadrante5: ["bloco31", "bloco32", "bloco33", "bloco40", "bloco41", "bloco42", "bloco49", "bloco50", "bloco51"],
    quadrante6: ["bloco34", "bloco35", "bloco36", "bloco43", "bloco44", "bloco45", "bloco52", "bloco53", "bloco54"],
    quadrante7: ["bloco55", "bloco56", "bloco57", "bloco64", "bloco65", "bloco66", "bloco73", "bloco74", "bloco75"],
    quadrante8: ["bloco58", "bloco59", "bloco60", "bloco67", "bloco68", "bloco69", "bloco76", "bloco77", "bloco78"],
    quadrante9: ["bloco61", "bloco62", "bloco63", "bloco70", "bloco71", "bloco72", "bloco79", "bloco80", "bloco81"]
}
let highlight = [];
let blocoAtual;
let dificuldade = 1;
const blocos = document.querySelectorAll(classGameCell);
const timer = new Timer('timer');
const lastEvent = {
    blocoNome: '',
    value: 0,
    SVG: '',
    notes: false
};
let notes = false;
Init();



/*Função de start do sistema!*/
function Init() {
    //start no sudoku
    fetchSudoku();

    //Eventos da tabua sudoku//#344861
    InitTabuaEvents();

    //eventos de interação com o sudoku:
    InitSudokuInterationsEvents();

    //Eventos de criação, restart e cancelar o jogo atual
    InitMenuEvents();

    //Eventos de seleção da dificuldade:
    InitDificuldadeEvents();

    //Inicializando o contador:
    InitTimerEvents();

    //inicializando os eventos de anotações, dicas, desfazer e apagar:
    InitControlEvents();
}

function fetchSudoku() {
    const fetchURL = url + dificuldade.toString();
    fetch(fetchURL)
        .then((response) => {
            return response.json();
        })
        .then((data) => {
            mapa = data;
            console.log(data);
            CreateSudoku();
        })
        .catch((error) => {
            console.log(error);
        })
}

function CreateSudoku() {
    for (let index = 1; index <= 81; index++) {
        const _nomeBloco = _retornaNomeDoBlocoByIndex(index);
        if (mapa[_nomeBloco].initial > 0) {
            AddBlocoValue(_nomeBloco, mapa[_nomeBloco].initial, classGameValue);
            resetLastEvent();
        }

    }
}

function CleanSudoku() {
    for (let index = 1; index <= 81; index++) {
        const _nomeBloco = _retornaNomeDoBlocoByIndex(index);
        const _bloco = _querySelectorByBloco(_nomeBloco);
        _bloco.classList.remove(classGameValue);
        const _cellValue = _bloco.querySelector(classCellValue);
        let _atualSVG = _cellValue.querySelector('svg');
        if (_atualSVG)
            _atualSVG.remove();
    }
}


function InitDificuldadeEvents() {
    document.querySelector('.difficulty-label').addEventListener('click', (e) => {
        if (e.target.tagName != 'A' && e.target.tagName != 'LI' && e.target.tagName != 'UL') {
            const parent = e.currentTarget.parentElement;
            parent.querySelector('.difficulty-menu').style.display = 'block';
        }
    });

    const difficultyMenu = document.querySelectorAll('.difficulty-menu > ul > li');
    difficultyMenu.forEach((element, index) => {
        element.addEventListener('click', (e) => {
            const clicked = e.currentTarget;
            const aClicked = clicked.querySelector('a');
            dificuldade = aClicked.getAttribute('data-difficulty');
            document.querySelector('.difficulty-label-text').innerText = aClicked.innerText;
            CloseMenus();
        });
    });
}

function InitTabuaEvents() {
    blocos.forEach((element, index) => {
        index++;
        element.addEventListener('click', (e) => {
            blocoAtual = e.currentTarget;
            /*captura os blocos que precisam ser validados*/

            highlight = SelectAllBlocos(_retornaNomeDoBlocoByElement(blocoAtual));

            /*Controle das classes no click do bloco*/
            _class_clickCELL(classCellSelected, classHiglightTable, blocoAtual);
        });
    });
}

function InitSudokuInterationsEvents() {
    const numpad = document.querySelectorAll('.numpad-item');
    numpad.forEach((element, index) => {
        const value = element.getAttribute("data-value");
        element.addEventListener('click', (e) => {
            if (blocoAtual == null || blocoAtual == 'undefined')
                return;
            const nomeBloco = _retornaNomeDoBlocoByElement(blocoAtual);
            const bloco = mapa[nomeBloco];

            if (bloco.initial != 0)
                return;

            const classes = ['mistake', 'conflict']
            AddBlocoValue(nomeBloco, value, null, classes);
            if (value != bloco.gabarito) {
                blocoAtual.classList.remove(classHiglightTable);
                //precisa marcar porque está incorreto.

                MarkWhyIsItWrong(classes, nomeBloco, value);
            }
            else {
                CleanWhyIsItWrong(classes, nomeBloco, value);
            }
        });

    });
}

function InitTimerEvents() {
    timer.Play();

    document.querySelector('.icon-pause').addEventListener('click', (e) => {
        timer.Pause();
        //document.querySelector('.pause-overlay').style.display = 'block';
        document.getElementById('sudoku-wrapper').classList.add('paused');
        e.currentTarget.parentElement.classList.add('paused');
    });

    document.querySelector('.icon-play').addEventListener('click', (e) => {
        timer.Play();
        //document.querySelector('.pause-overlay').style.display = 'none';
        document.getElementById('sudoku-wrapper').classList.remove('paused');
        e.currentTarget.parentElement.classList.remove('paused');
    });

    document.querySelector('.icon-play-big').addEventListener('click', (e) => {
        timer.Play();
        //document.querySelector('.pause-overlay').style.display = 'none';
        document.getElementById('sudoku-wrapper').classList.remove('paused');
        document.querySelector('.timer-wrapper').classList.remove('paused');
    });

}

function MarkWhyIsItWrong(arrClassWrong, nomeBloco, value) {
    blocoAtual.classList.add(...arrClassWrong);

    highlight.forEach((element) => {
        if (mapa[element].valor == value) {
            const _auxBlocoWrong = _querySelectorByBloco(element)
            _auxBlocoWrong.classList.add('conflict');

            if (_auxBlocoWrong.hasAttribute('data-conflitwhy')) {
                let _atributoantigo = _auxBlocoWrong.getAttribute('data-conflitwhy');

                if (!_atributoantigo.includes(nomeBloco)) {
                    _atributoantigo = _atributoantigo.concat(nomeBloco);
                    console.log(_atributoantigo);
                    _auxBlocoWrong.setAttribute('data-conflitwhy', _atributoantigo);
                }
            } else {
                _auxBlocoWrong.setAttribute('data-conflitwhy', nomeBloco);
            }

        }
    });
}

function CleanWhyIsItWrong(arrClassWrong, nomeBloco, value) {
    blocoAtual.classList.remove(...arrClassWrong);
    const _blocosErrados = document.querySelectorAll(`[data-conflitwhy*='${nomeBloco}']`);
    if (_blocosErrados != null) {
        _blocosErrados.forEach((element) => {
            let _atributoantigo = element.getAttribute('data-conflitwhy');
            _atributoantigo = _atributoantigo.replace(nomeBloco, '');
            if (_atributoantigo.length > 0) {
                element.setAttribute('data-conflitwhy', _atributoantigo);
            }
            else {
                element.removeAttribute('data-conflitwhy');
                element.classList.remove('conflict');
            }

        });
    }
}


function SelectAllBlocos(bloco) {
    if (typeof (bloco) == 'string') {
        bloco = mapa[bloco];
    }

    let _importantBlocos = [];
    _importantBlocos = _quadrante(bloco);
    _importantBlocos = _importantBlocos.concat(_linha(bloco));
    _importantBlocos = _importantBlocos.concat(_coluna(bloco));
    return _importantBlocos;
}



function InitMenuEvents() {
    //eventos de novo jogo:
    const newGameButton = document.querySelectorAll('.new-game-button');
    newGameButton.forEach((element, index) => {
        element.addEventListener('click', (e) => {
            const parent = e.currentTarget.parentElement;
            parent.querySelector('.new-game-menu').style.display = 'block';
        });

    });

    const cancelNewGame = document.querySelectorAll('.new-game-menu-cancel');
    cancelNewGame.forEach((element, index) => {
        element.addEventListener('click', (e) => {
            CloseMenus();
        });

    });

    const restartNewGame = document.querySelectorAll('.new-game-menu-restart');
    restartNewGame.forEach((element, index) => {
        element.addEventListener('click', (e) => {
            RestartNewGame();
            CloseMenus();
        });
    });

    const startNewGame = document.querySelectorAll('.new-game-menu-new');
    startNewGame.forEach((element, index) => {
        element.addEventListener('click', (e) => {
            StartNewGame();
            CloseMenus();
        });

    });
}

function CloseMenus(obj) {
    if (obj) {
        obj.style.display = 'none';
        return;
    }


    let _menu = document.querySelectorAll('.new-game-menu');
    _menu.forEach((el) => {
        el.style.display = 'none';
    });

    let _menud = document.querySelectorAll('.difficulty-menu');

    _menud.forEach((element) => {
        element.style.display = 'none';
    });


}

function StartNewGame() {
    console.log('-- start --');
    CleanSudoku();
    fetchSudoku();
    timer.Restart();
}

function RestartNewGame() {
    CleanSudoku();
    CreateSudoku();
    timer.Restart();
}

function PausePlayGame(event) {
    console.log('-- play/pause --');
    if (event == 'play')
        timer.Play();
    else if (event == 'pause')
        timer.Pause();
}


/*Funções para interação do sudoku*/
function _class_clickCELL(classSelected, classMarkUp, elementAdd) {
    [].forEach.call(blocos, function (el) {
        el.classList.remove(classSelected, classMarkUp);
    });
    elementAdd.classList.add(classSelected);

    highlight.forEach((element, index) => {
        _querySelectorByBloco(element).classList.add(classMarkUp);
    });
}

function _retornaNomeDoBlocoByIndex(posicao) {
    return prefixo.concat(posicao);
}

function _retornaNomeDoBlocoByElement(bloco) {
    return bloco.getAttribute("data-bloco");
}

function _querySelectorByBloco(bloco) {
    return document.querySelector(`[data-bloco='${bloco}']`)
}

function QuerySelectorSVG(numberSVG) {
    const modelo = document.getElementById("modelo");
    return modelo.querySelector(`#${numberSVG}`);
}

function _quadrante(bloco) {
    const quadrante = bloco.quadrante;
    return mapa[quadrante];
}

function _linha(bloco) {
    const linha = bloco.linha;
    return mapa[linha];
}

function _coluna(bloco) {
    const coluna = bloco.coluna;
    return mapa[coluna];
}


function InitControlEvents() {
    const controles = { 'pencil': Pencil, 'hint': Hint, 'undo': Undo, 'erase': Erase };
    const controladores = document.querySelectorAll('div[data-action]')

    for (let c = 0; c < controladores.length; c++) {
        controladores[c].addEventListener('click', () => controles[controladores[c].getAttribute('data-action')]());
    }
}

function Pencil() {
    console.log('Pencil');
}

function Hint() {
    console.log('Hint');
    if (blocoAtual == null || blocoAtual == 'undefined')
        return;
    const nomeBloco = _retornaNomeDoBlocoByElement(blocoAtual);
    const bloco = mapa[nomeBloco];

    if (bloco.initial != 0)
        return;

    AddBlocoValue(nomeBloco, bloco.gabarito);
}

function Undo() {
    console.log('Undo');
    if (lastEvent.blocoNome != '')
        RemoveBlocoValue(lastEvent.blocoNome, lastEvent.value);
}

function Erase() {
    console.log('Erase');
}

function AddBlocoValue(nomeBloco, value, addClass, removeClass) {
    const _bloco = _querySelectorByBloco(nomeBloco);
    if (addClass)
        _bloco.classList.add(addClass);

    if (removeClass)
        _bloco.classList.remove(removeClass);
    const _svg = startSVG[value];
    const _cellValue = _bloco.querySelector(classCellValue);

    let _atualSVG = _cellValue.querySelector('svg');
    if (_atualSVG)
        _atualSVG.remove();
    const _svgAppend = QuerySelectorSVG(_svg).cloneNode(true);
    _cellValue.append(_svgAppend);
    lastEvent.svg = _svgAppend;
    lastEvent.notes = notes;
    lastEvent.value = value;
    lastEvent.blocoNome = nomeBloco;
}

function RemoveBlocoValue(nomeBloco, value, addClass, removeClass) {
    const _bloco = _querySelectorByBloco(nomeBloco);
    if (addClass)
        _bloco.classList.add(addClass);

    if (removeClass)
        _bloco.classList.remove(removeClass);

    const _cellValue = _bloco.querySelector(classCellValue);

    let _atualSVG = _cellValue.querySelector('svg');
    if (_atualSVG)
        _atualSVG.remove();
}

function resetLastEvent() {
    lastEvent.blocoNome = '',
        lastEvent.value = 0,
        lastEvent.SVG = '',
        lastEvent.notes = false
}

