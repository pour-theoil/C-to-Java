// Put your code here

console.log("Let's roll some dice, baby!");
console.log("---------------------------");

let rolling =() => {
    for( let i = 0; i < 10; i++) {
    let diceone = Math.floor(Math.random() * 6) + 1
    let dicetwo = Math.floor(Math.random() * 6) + 1
    if (diceone === dicetwo) {
        console.log(`${diceone} + ${dicetwo} == ${diceone + dicetwo} DOUBLES!`)
    }
    else {
        console.log(`${diceone} + ${dicetwo} == ${diceone + dicetwo}`)
    }
}}

rolling()