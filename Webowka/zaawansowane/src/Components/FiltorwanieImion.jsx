import { useState } from "react";
function FiltorwanieImion()
{
  const [imiona, setImiona] = useState(["Maciej", "Piotrek", "Marcel", "Kamil", "Miłosz"]);
  const [szukaneImie, setSzukaneImie] = useState("");
  return (
    <>
      <input type="text" placeholder="Szukaj imion" onChange={(e) => setSzukaneImie(e.target.value)} />
      <ul>
        {imiona.filter((imie) => imie.includes(szukaneImie)).map((imie) => (
          <li key={imie}>{imie}</li>
        ))}
      </ul>
    </>
  )
}
export default FiltorwanieImion;
