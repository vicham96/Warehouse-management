import { useState } from "react";
import { baseAPIURL } from "../Constants";
import { Box } from "@mui/system";
function ProductList() {
    const [products, setProducts] = useState(null);

    React.useEffect(() => {
      axios.get(baseAPIURL + "products").then((response) => {
        setProducts(response.data);
      });
    }, []);

    const listOfProducts = products.map(product => 
        <Box
        sx={{
          width: 300,
          height: 300,
          backgroundColor: 'primary.dark',
          '&:hover': {
            backgroundColor: 'primary.main',
            opacity: [0.9, 0.8, 0.7],
          },
        }}
      />)
    return (
      <div>
        <h1>List of products in stock</h1>
        {listOfProducts}
      </div>
    );
  }
  
  export default ProductList;