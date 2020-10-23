var anyType = 25; //    Reverts Typescript back to Javascript
anyType = true;
console.log(anyType);
anyType = 'utkarsh';
console.log(anyType);
anyType = {
    name: 'Utkarsh', age: 24, isTopper: false
};
var mixedType = [];
mixedType.push('Utkarsh');
mixedType.push(23);
mixedType.push(true);
console.log(mixedType);
