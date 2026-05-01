import { useState } from 'react';
function LosowanieLiczby()
{
  const [liczby, setLiczby] = useState([2,1,3,5,7]);
  return (
    <div>
      <button onClick={() => setLiczby([...liczby, Math.floor(Math.random() * 10) + 1])}>Losuj</button>
      {liczby.map((liczba) => (
        liczba + ","
      ))}
    </div>
  );
}
export default LosowanieLiczby;
