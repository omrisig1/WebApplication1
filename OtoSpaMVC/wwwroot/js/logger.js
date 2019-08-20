
var Logger = function () {

    this.target;
    this.log = function (msg, src) {
        this.addToHistory(msg, src);
    }

    this.init = function (target) {
        if (!target) {
            target = console;
        }
        this.target = target;
        this.log = function (msg, src) {
            this.target.log(msg);
            this.addToHistory(msg, src);
            return this;
        }
    }

    this.history = [];
    this.addToHistory = function (msg, src) {
        this.history.push({
            logged: msg,
            source: src,
            time: Date()
        });
    }
    this.clearHistory = function () {
        this.history = [];
    }
};

defaultLogger = new Logger();
