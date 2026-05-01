import { useState } from 'react';
function WalidacjaEmail()
{
  const wzorHaslo = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{6,}$/;
  const wzorEmail = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
  const [email, setEmail] = useState('');
  const [haslo, setHaslo] = useState('');

  return (
    <div>
      <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
      <p>{email.match(wzorEmail) ? 'Poprawny email' : 'Niepoprawny email'}</p>
      <input type="password" value={haslo} onChange={(e) => setHaslo(e.target.value)} />
      <p>{haslo.match(wzorHaslo) ? 'Poprawne hasło' : 'Niepoprawne hasło'}</p>
    </div>
  );
}
export default WalidacjaEmail;
