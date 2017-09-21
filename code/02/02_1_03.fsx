let topla x y = 
#if INTERACTIVE
    // FSI ile çalıştırılırsa
    printfn "Etkileşimli"
    x + y
#endif
#if COMPILED
    // Derleyici tarafından derlenirse
    printfn "Derlenmiş"
    x + y
#endif

// TEST
topla 1 1