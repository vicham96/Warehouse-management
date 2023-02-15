import './App.css';
import ProductList from './pages/ProductList';
import DetailedProduct from './pages/DetailedProduct';
import ProductForm from './pages/ProductForm';
import { Route, Routes } from 'react-router-dom';

function App() {
  return (
    <div>
      <Routes>
        <Route path="/" element={ <ProductList/> } />
        <Route path="detailed-view/:productId" element={ <DetailedProduct/> } />
        <Route path="create-product" element={ <ProductForm/> } />
      </Routes>
    </div>
  );
}

export default App;
