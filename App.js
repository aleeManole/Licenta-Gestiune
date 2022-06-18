
import './App.css';

import {Home} from './pages/Home';
import {Gestionar} from './pages/Gestionar';
import {Subinventar} from './pages/Subinventar';
import {Navigatie} from './components/Navigatie';

import {BrowserRouter, Route, Routes} from 'react-router-dom';

function App() {
  return (
    <BrowserRouter>
    <div className="container">
      <h3 className="m-3 d-flex justify-content-center">
        Gestiune
      </h3>
      <Navigatie/>

      <Routes>
        <Route path='/Home' element={<Home/>} exact/>
        <Route path='/Subinventar' element={<Subinventar/>}/>
        <Route path='/Gestionar' element={<Gestionar/>}/>
        <Route path="/" element={<Home/>}/>
        <Route path="*" 
              element={
                <div>
                  <h2>Pagina nu a fost gasită.</h2>
                </div>}/>
      </Routes>
    </div>
    </BrowserRouter>
  );
}

export default App;
