// Arrays

let names = ['Rohit', 'Virat', 'Dhawan']; //    This is a string array

names.push('Utkarsh');
names[2] = 'Ramesh';


let mixed = ['Utkarsh', 25, true, 100];

mixed.push('Rahul');
mixed.push(23);

mixed[2] = 'Krishna';
mixed.push({name:'Utkarsh' };)

//      Objects 

let ninja = {
    name: 'mario',
    belt: 'black',
    age: 20

};

ninja.age = 40;
//ninja.age = '20';  Not valid

// Once object is declared ,we cannot assign a new property to the object

//  We can override declared object but the struture should remain same