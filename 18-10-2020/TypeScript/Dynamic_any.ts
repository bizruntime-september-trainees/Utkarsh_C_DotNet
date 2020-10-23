  let anyType: any =25; //    Reverts Typescript back to Javascript

anyType = true;
console.log(anyType);

anyType = 'utkarsh';
console.log(anyType);


anyType =  {
    name: 'Utkarsh', age: 24,  isTopper: false
}

let mixedType: any[] = []; // Note: When declaring (not assigning) types use colons(:) instead of (=)

mixedType.push('Utkarsh');
mixedType.push(23);
mixedType.push(true);

console.log(mixedType);

let student: {
  name: any, rollno: any, college: any
}

student = {
  name: 'Utkarsh', rollno: 24, college: 'REC Rewa'
}
