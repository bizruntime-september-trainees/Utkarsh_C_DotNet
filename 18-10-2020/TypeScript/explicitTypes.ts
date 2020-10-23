
let player: string;
let sport: string;
let age: number;
let isMarried: boolean;


age = 30;

isMarried = false;

//Arrays

let players: string[] = []; // Creating and initializing string array  to push string objects

players.push('Sachin');

//  Union Types

let mixedArray : (string | number)[] = [];

mixedArray.push('Rohit');
mixedArray.push(34);
//mixedArray.push(true);    Error


//      Objects 
let ninjaOne : object;

ninjaOne = {

    uid: 123,
    name: "Utkarsh"
}

let ninjaTwo: {
    name: string,
    age: number
};

ninjaTwo = {name: 'Utkarsh', age: 23};




console.log(mixedArray);
 