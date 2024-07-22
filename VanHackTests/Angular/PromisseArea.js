'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(str => str.trim());
    
    main();
});

let readLine = () => inputString[currentLine++];


// Complete the calculateArea function below.
// It returns a Promise which on success, returns area of the shape, and on failure returns [-1].
let calculateArea = (shape, values) => {
     return new Promise(async (resolve, reject) => {

        switch(shape) {
            case 'square':
                resolve(values[0]*values[0]);
                break;

            case 'rectangle':
                resolve(values[0]*values[1]);
                break;
            case 'circle':
                resolve(values[0]*values[0] * 3.14);
                break;
                case 'triangle':
                resolve(0.5 * values[0]*values[1]);
                break;
            default:
                reject([-1]);
                break;
        }
    })
}

// Complete the generateArea function below.
// It returns a Promise which on success, returns an array of areas of all the shapes and on failure, returns [-1].
let getAreas = (shapes, values_arr) => {
    return new Promise(async(resolve, reject) => {
        
        let valid_shapes = ['square','rectangle','circle','triangle'];

        for(let i=0; i < shapes.length; i++) {
            if(!valid_shapes.includes(shapes[i]))
            {
                return reject([-1]);
            }
        }

        let areas_array = [];
        for(let i=0; i < shapes.length; i++) {
            await calculateArea(shapes[i],values_arr[i]).then(area => {
                areas_array.push(area);
            }).catch(error => {
                return reject(error);
            })
        }
        resolve(areas_array);
    })
}

let callCalculateArea = async (shapes, values) => await calculateArea(shapes[0], values[0]).catch(error => error) instanceof Promise;

let callGetAreas = (shapes, values) => getAreas(shapes, values).catch(error => error);

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine(), 10);

    let shapes = [];

    for (let shapesItr = 0; shapesItr < n; shapesItr++) {
        const shapesItem =  readLine();
        shapes.push(shapesItem);
    }

    let values = [];

    for (let valuesItr = 0; valuesItr < n; valuesItr++) {
        const valuesItem =  readLine();
        values.push(JSON.parse('[' + valuesItem + ']'));
    }
    
    if (callCalculateArea(shapes, values)) {
        callGetAreas(shapes, values).then((res) => {
            ws.write(res.join('\n') + '\n');
            ws.end();
        });
    } else {
        console.error('calculateArea does not return a Promise.');
    }
}