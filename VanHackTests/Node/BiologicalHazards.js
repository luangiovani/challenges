'use strict';

const fs = require('fs');

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}



/*
 * Complete the 'bioHazard' function below.
 *
 * The function is expected to return a LONG_INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER_ARRAY affected
 *  3. INTEGER_ARRAY poisonous
 */

function bioHazard(n, affected, poisonous) {

    /// Count all possible
    var canCoexists = 0;

    /// Saves the evil Bacteries (pairs of Affected x Poisonous)
    var evilBacteries = new Map();

    /// Run affected bacteria
    for (var i = 0; i < affected.length; i++)
    {
        /// The poisonous bacteria can't affect yourself
        if (affected[i] == poisonous[i])
            continue;
        
        ///Get the min evil bacteria
        var min = Math.min(affected[i], poisonous[i]);
    
        ///Get the max evil bacteria
        var max = Math.max(affected[i], poisonous[i]);

        /// Current evil bacteria that have been verified
        var current = 0;

        /// Add as evil bacteria pair
        if (!evilBacteries.has(min)) {
            evilBacteries.set(min, max);
        } else {
            current = evilBacteries.get(min);
        }
            
        /// Add as evil bacteria pair case current  evil bacteria is greater than max
        if (current > max) {
            evilBacteries.set(min, max);
        }    
    }

    /// The last evil bacteria
    var lEvilBacteria = n + 1;

    /// Run to count possible groups
    for (var i = n; i >= 1; i--)
    {
        /// Check evilBacteries
        var added = lEvilBacteria;

        /// Evil Bacteria
        var bacteria = 0;

        /// Check if Evil Bacteria has an Affected enemy
        if(evilBacteries.has(i)) {
            bacteria = evilBacteries.get(i);
        }

        /// Has evil bacteria and last evil bacteria is greater than evil bacteria verified
        if (evilBacteries.has(i) && (lEvilBacteria > bacteria))
        {
            lEvilBacteria = bacteria;
            added = bacteria;
        }

        /// If don't have figth among evil bacteria and affected, can coexists
        canCoexists = canCoexists + (added - i);
    }

    return canCoexists;
}

function main() {
    const ws = fs.createWriteStream(process.env.OUTPUT_PATH);

    const n = parseInt(readLine().trim(), 10);

    const affectedCount = parseInt(readLine().trim(), 10);

    let affected = [];

    for (let i = 0; i < affectedCount; i++) {
        const affectedItem = parseInt(readLine().trim(), 10);
        affected.push(affectedItem);
    }

    const poisonousCount = parseInt(readLine().trim(), 10);

    let poisonous = [];

    for (let i = 0; i < poisonousCount; i++) {
        const poisonousItem = parseInt(readLine().trim(), 10);
        poisonous.push(poisonousItem);
    }

    const result = bioHazard(n, affected, poisonous);

    ws.write(result + '\n');

    ws.end();
}
