import React, { useState } from "react";

export default function Introduction({...props}){
console.log(props.data)
const [introData, setintroData] = useState([props.data[0]])

    return(
      <>       
       {introData.map((value, index) => 
                
              <div  className="max-w-[1200px] text-center mx-auto my-0 pt-12">
            
                        <h2 className="text-4xl font-extrabold dark:text-white">{value.Title}</h2>
                            <p className="my-4 text-lg text-gray-500">
                        {value.Description}
                        </p>
                </div>
          
        )}
        </>

    )

}