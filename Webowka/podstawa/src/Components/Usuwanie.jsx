import { useState } from "react"
function Usuwanie()
{
    const[podaneImie, setPodaneImie] = useState("")
    const[imiona, setImiona] = useState(["Maciej", "Miłosz", "Marcel","Piotrek", "Kamil"])
    return(
        <>
        <ul>
        {imiona.map((imie)=>
            (
                <>
                    <li key={imie}>{imie}</li> <button onClick={() => setImiona(imiona.filter((i) => i !== imie))}>Usun</button>
                </>
            ))}
        </ul>
        <input type="text" name="imie" id="imie" onChange={(e) => setPodaneImie(e.target.value)}/>
        <button onClick={() => setImiona([...imiona, podaneImie])}>Dodaj</button>
        </>
    )
}
export default Usuwanie
