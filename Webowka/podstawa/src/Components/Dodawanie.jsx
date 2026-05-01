import { useState } from "react"
function Dodawanie()
{
    const[podaneImie, setPodaneImie] = useState("")
    const[imiona, setImiona] = useState(["Maciej", "Miłosz", "Marcel","Piotrek", "Kamil"])
    return(
        <>
        <ul>
        {imiona.map((imie)=>
            (
                <>
                    <li key={imie}>{imie}</li>
                </>
            ))}
        </ul>
        <input type="text" name="imie" id="imie" onChange={(e) => setPodaneImie(e.target.value)}/>
        <button onClick={() => setImiona([...imiona, podaneImie])}>Dodaj</button>
        </>
    )
}
export default Dodawanie
