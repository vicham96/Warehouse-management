import { useNavigate } from 'react-router-dom';
import { baseAPIURL } from "../Constants";
import axios from "axios";

function ProductCard(props) {
    const navigate = useNavigate();
    return (
        <div class="card-body">
            {props.title}
            {props.price}

            {props.articles.map(article => 
            <ul>
                <li>{article.name} : {article.amountOf}</li>
            </ul>)}
            <button onClick = {()=> {
        axios
        .delete(`${baseAPIURL}/${props.id}`)
        .then(() => {
          alert("Product deleted!");
          navigate('/')
        })}}>Delete product</button>
        <button  onClick={()=> navigate('/detailed-view/' + props.id)}>Click here to see the detailed view</button>

      </div>
    );
  }
  
  export default ProductCard;