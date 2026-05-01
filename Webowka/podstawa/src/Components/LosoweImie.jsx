import { useState } from "react"
function LosoweImie()
{
  const [imiona, setImiona] = useState(["Maciej", "Miłosz", "Marcel", "Piotrek", "Kamil"])
  const [wylosowane, setWylosowane] = useState("")
    return(
      <>
        <button onClick={()=> setWylosowane(Math.round(Math.random() * imiona.length) -1)}>losuj imie</button>
        <p>Wylosowano: {imiona[wylosowane]}</p>
      </>
    )
}
export default LosoweImie
