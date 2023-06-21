let message: string = 'Hello Maan';
console.log(message);

let x: [string, number];
x = ["Bye", 5];

enum color
{ 
    Red = 1,
    Green = 2
}

let colorname: string = color[1];

console.log(colorname);

let somthing: Object = "safi";
let some: any = 5;

function warnUser(): void {
    console.log("Warned");
}

function error(message: string): never {
    throw new Error(message);
}


declare function create(o: object | null): void;


class Greeter {
    greeting: string;
    constructor(message: string) {
        this.greeting = message;
    }
    greet() {
        return "Hello, " + this.greeting;
    }
}

function printLabel(LabeledOBJ: { label: string }) {
    console.log(LabeledOBJ.label);
}

let myobj = { size: 10 ,label:"size 10 object"};
printLabel(myobj);