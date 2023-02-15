import { useParams } from "react-router-dom";
function DetailedProduct() {
    let { productId } = useParams();
    return (
      <div>
        <h1>This is where detailed product will show {productId}</h1>
      </div>
    );
  }
  
  export default DetailedProduct;