function WordSquare(letters) {
    var len = letters.length, 
        n = parseInt(Math.sqrt(len)),
        i,
        oc=0, //count of characters that occur odd # of times
        uc=0, //count of unique characters in the given string
        // ml - unique # of characters allowed for the square size	
        ml = n + (len - n)/2;
    if (len != n*n) return false;

    // get the cc
    var cc = [];
    
    //initialize the array
    for (i=0; i<26; i++) cc[i] = 0;
    
    // count the characters
    for (i=0; i<len; i++) cc[letters.charCodeAt(i) - 65]++;

    // find the cc of each character
    for (i=0; i<26; i++) {
        if (cc[i] > 0) uc++; 
        if (cc[i] % 2 === 1) oc++; 
    }
    
    // unique character count is <= max allowed for the square size
    // and # of odd characters is less than square size
    return (uc <= ml && oc <= n); 
}