
class Timer {
    constructor(elementID) {
        this.contador = 0;
        this.elementID = elementID;
        this.timeInterval;
    }


    Play() {
        console.log('Play timer');
        this.timeInterval = setInterval(() => {
            this.contador++;
            this.Show();
        }, 1000);


    }

    Pause() {
        clearInterval(this.timeInterval);
    }

    Damage(valorDano) {
        if (Number.isInteger(valorDano))
            this.contador = this.contador + valorDano;
    }

    Restart() {
        this.contador = 0;
        clearInterval(this.timeInterval);
        this.Play();
    }

    Format() {
        const seconds = Math.floor((this.contador) % 60);
        const minutes = Math.floor((this.contador / 60) % 60);
        return ('0' + minutes).slice(-2) + ':' + ('0' + seconds).slice(-2);
    }

    Show() {
        document.getElementById(this.elementID).innerHTML = this.Format();
    }
}