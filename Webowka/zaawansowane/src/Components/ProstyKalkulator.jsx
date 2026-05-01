import { useState } from 'react';
function ProstyKalkulator()
{
    const [wynik, setWynik] = useState(0);
    const [liczba1, setLiczba1] = useState(0);
    const [liczba2, setLiczba2] = useState(0);
    const dodaj = () => setWynik(liczba1 + liczba2);
    const odejmij = () => setWynik(liczba1 - liczba2);
    const pomnoz = () => setWynik(liczba1 * liczba2);
    const podziel = () => setWynik(liczba1 / liczba2);
    return (
        <>
            <input type="number" onChange={(e) => setLiczba1(parseInt(e.target.value))} />
            <input type="number" onChange={(e) => setLiczba2(parseInt(e.target.value))} />
            <button onClick={dodaj}>+</button>
            <button onClick={odejmij}>-</button>
            <button onClick={pomnoz}>*</button>
            <button onClick={podziel}>/</button>
            <p>Wynik: {wynik}</p>
        </>
    );
}
export default ProstyKalkulator;
