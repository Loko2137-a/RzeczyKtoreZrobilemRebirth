import { useState, useEffect } from 'react'
function Timer() {
  const [time, setTime] = useState(10);
  useEffect(() => {
    const interval = setInterval(() => {
      setTime(time - 1);
    }, 1000);
    return () => clearInterval(interval);
  }, [time]);
  return (
    <div>
      <p>Odliczam od 10 do 0: {time}</p>
    </div>
  );
}
export default Timer
