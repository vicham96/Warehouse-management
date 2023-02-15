import { useState, useEffect } from "react";
import { baseAPIURL } from "../Constants";
import axios from "axios";
import ProductCard from "../components/Card";
function ProductList() {
    const [products, setProducts] = useState([]);

    useEffect(() => {
      axios.get(baseAPIURL).then((response) => {
        setProducts(response.data);
      });
    }, []);
    console.log(products)

    const listOfProducts = products.map(p =>
    <ProductCard
     id = {p.id}
     title = {p.name} 
     price = {p.price}
     articles = {p.articles}
    />
    
    );
    return (
      <div>
        <h1>List of products in stock</h1>
        {listOfProducts}
      </div>
    );
  }
  
  export default ProductList;