import 'bootstrap/dist/css/bootstrap.min.css';
import { useState } from "react";
function Ksiazki() {
  const [kategoria1, setKategoria1] = useState(true);
  const [kategoria2, setKategoria2] = useState(true);
  const [kategoria3, setKategoria3] = useState(true);
  const [ksiazki, setKsiazki] = useState([
    { id: 1, title: "Wiedźmin", author: "Andrzej Sapkowski", category: 1, likes: 5, image: "https://picsum.photos/200/300?random=1" },
    { id: 2, title: "Ksiazka2", author: "autor2", category: 2, likes: 2, image: "https://picsum.photos/200/300?random=2" },
    { id: 3, title: "Ksiazka3", author: "autor3", category: 2, likes: 0, image: "https://picsum.photos/200/300?random=3" },
    { id: 4, title: "Ksiazka4", author: "autor4", category: 1, likes: 0, image: "https://picsum.photos/200/300?random=4" },
    { id: 5, title: "Ksiazka5", author: "autor5", category: 3, likes: 0, image: "https://picsum.photos/200/300?random=5" },
    { id: 6, title: "Ksiazka6", author: "autor6", category: 1, likes: 0, image: "https://picsum.photos/200/300?random=6" },
  ]);
  const filtrowaneKsiazki = ksiazki.filter(k =>
    (kategoria1 && k.category === 1) ||
    (kategoria2 && k.category === 2) ||
    (kategoria3 && k.category === 3)
  );
  const dodajLike = (id) => {
    setKsiazki(prev => prev.map(k => k.id === id ? { ...k, likes: k.likes + 1 } : k));
  };
  return (
    <div className="container mt-4">
      <h1 className="mb-4">Katalog moich książek</h1>
      <div className="d-flex gap-4 mb-4">

        <div className="form-check form-switch">
          <input type="checkbox" id="cat1" checked={kategoria1} className="form-check-input" onChange={() => setKategoria1(prev => !prev)} />
          <label htmlFor="cat1">Beletrystyka</label>
        </div>

        <div className="form-check form-switch">
          <input type="checkbox" id="cat2" checked={kategoria2} className="form-check-input" onChange={() => setKategoria2(prev => !prev)} />
          <label htmlFor="cat2">Nauka</label>
        </div>

        <div className="form-check form-switch">
          <input type="checkbox" id="cat3" checked={kategoria3} className="form-check-input" onChange={() => setKategoria3(prev => !prev)} />
          <label htmlFor="cat3">Komiksy</label>
        </div>

      </div>
      <div className="row">
        {filtrowaneKsiazki.map(ksiazka => (
          <div key={ksiazka.id} className="col-md-4 mb-4">
            <div className="card h-100">
              <img src={ksiazka.image} className="card-img-top" alt={ksiazka.title} style={{ height: "300px", objectFit: "cover" }} />
              <div className="card-body">
                <h5 className="card-title">{ksiazka.title}</h5>
                <p>{ksiazka.author}</p>
                <p>Kategoria: {ksiazka.category}</p>
                <p>Lajki: {ksiazka.likes}</p>
                <button className="btn btn-primary" onClick={() => dodajLike(ksiazka.id)}>
                   Polub
                </button>

              </div>

            </div>
          </div>
        ))}
      </div>

    </div>
  );
}
export default Ksiazki;
