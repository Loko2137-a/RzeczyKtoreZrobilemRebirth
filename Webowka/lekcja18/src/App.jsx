import 'bootstrap/dist/css/bootstrap.min.css'
import { useState } from 'react'

function App() {

  const [formData, setFormData] = useState({
    text: "",
    email: "",
    haslo: "",
    liczba: "",
    textarea: "",
    select: "",
    radio: "",
    check: false,
    data: "",
    godzina: "",
    color: "#000000",
    range: 50,
    plik: null
  })

  const handleChange = (e) => {
    const { id, value, type, checked, files } = e.target
    setFormData({
      ...formData,
      [id]: type === "checkbox" ? checked : type === "file" ? files[0] : value
    })
  }

  const handleRadio = (e) => {
    setFormData({
      ...formData,
      radio: e.target.value
    })
  }

  const handleSubmit = (e) => {
    e.preventDefault()
    console.log(formData)
  }

  return (
    <div className='container mt-5'>
      <h1>Formularz Bootstrap w React</h1>

      <form className='mb-3' onSubmit={handleSubmit}>

        <label htmlFor="text">Pole Tekstowe</label> <input className='form-control' type="text" id="text" value={formData.text} onChange={handleChange} />

        <label htmlFor="email">Email</label> <input className='form-control' type="email" id="email" value={formData.email} onChange={handleChange} />

        <label htmlFor="haslo">Hasło</label> <input className='form-control' type="password" id="haslo" value={formData.haslo} onChange={handleChange} />

        <label htmlFor="liczba">Liczba</label> <input className='form-control' type="number" id="liczba" value={formData.liczba} onChange={handleChange} />

        <label htmlFor="textarea">Duży tekst</label> <textarea className='form-control' id="textarea" value={formData.textarea} onChange={handleChange}></textarea>

        <label htmlFor="select">Wybierz opcję</label>
        <select className="form-control" id="select" value={formData.select} onChange={handleChange}>
          <option value="">-- Wybierz --</option>
          <option value="1">1</option>
          <option value="2">2</option>
        </select>

        <br/>

        <div className="form-check">
          <input className="form-check-input" type="radio" name="radio" value="radio1" checked={formData.radio === "radio1"} onChange={handleRadio}/>
          <label className="form-check-label">Radio 1</label>
        </div>

        <div className="form-check">
          <input className="form-check-input" type="radio" name="radio" value="radio2" checked={formData.radio === "radio2"} onChange={handleRadio}/>
          <label className="form-check-label">Radio 2</label>
        </div>

        <div className="form-check">
          <input className="form-check-input" type="checkbox" id="check" checked={formData.check} onChange={handleChange}/>
          <label className="form-check-label">Zgadzam się z warunkami</label>
        </div>

        <label htmlFor="data">Wybierz datę</label> <input type="date" id="data" className='form-control' value={formData.data} onChange={handleChange}/>

        <label htmlFor="godzina">Wybierz godzinę</label> <input type="time" id="godzina" className='form-control' value={formData.godzina} onChange={handleChange}/>

        <label htmlFor="color">Wybierz kolor</label> <input type="color" id="color" className='form-control form-control-color' value={formData.color} onChange={handleChange}/>

        <label htmlFor="range">Zakres</label> <input type="range" id="range" min="0" max="100" className='form-control' value={formData.range} onChange={handleChange}/>

        <label htmlFor="plik">Wgraj plik</label> <input type="file" id="plik" className='form-control' onChange={handleChange}/>

        <input type="submit" className="btn btn-primary mt-3" value="Wyślij"/>

      </form>

    </div>
  )
}

export default App
