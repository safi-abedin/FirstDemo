var message = 'Hello Maan';
console.log(message);
var x;
x = ["Bye", 5];
var color;
(function (color) {
    color[color["Red"] = 1] = "Red";
    color[color["Green"] = 2] = "Green";
})(color || (color = {}));
var colorname = color[1];
console.log(colorname);
var somthing = "safi";
var some = 5;
function warnUser() {
    console.log("Warned");
}
function error(message) {
    throw new Error(message);
}
var Greeter = /** @class */ (function () {
    function Greeter(message) {
        this.greeting = message;
    }
    Greeter.prototype.greet = function () {
        return "Hello, " + this.greeting;
    };
    return Greeter;
}());
function printLabel(LabeledOBJ) {
    console.log(LabeledOBJ.label);
}
var myobj = { size: 10, label: "size 10 object" };
printLabel(myobj);
//# sourceMappingURL=demo.js.map