import { useState } from "react";
function ToDoList()
{
  const [zadanie, setZadanie] = useState("");
  const [lista, setLista] = useState([]);
  return (
    <>
      <input type="text" value={zadanie} onChange={(e) => setZadanie(e.target.value)} />
      <button onClick={() => setLista([...lista, zadanie])}>Dodaj</button>
      {lista.map((item) => (
        <>
        <li key={item}>{item}</li> <button onClick={() => setLista(lista.filter((i) => i !== item))}>Usun</button>
        </>
      ))}
    </>
  );
}
export default ToDoList;
