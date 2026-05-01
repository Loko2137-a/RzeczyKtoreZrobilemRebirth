import { useState } from "react";
function Formularz() {
  const [dane, setDane] = useState({
    imie: "",
    email: "",
    accept: false,
    rola: ""
  });
  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(dane);
  };
  return (
    <form onSubmit={handleSubmit}>
      <input type="text" name="imie" value={dane.imie} onChange={(e) => setDane({ ...dane, imie: e.target.value })} />
      <input type="email" name="email" value={dane.email} onChange={(e) => setDane({ ...dane, email: e.target.value })} />
      <input type="checkbox" name="accept" checked={dane.accept} onChange={(e) => setDane({ ...dane, accept: e.target.checked })} />
      <select name="rola" value={dane.rola} onChange={(e) => setDane({ ...dane, rola: e.target.value })}>
        <option value="">Wybierz rolę</option>
        <option value="admin">Admin</option>
        <option value="user">User</option>
      </select>
      <button type="submit">Wyślij</button>
    </form>
  );
}

export default Formularz;
