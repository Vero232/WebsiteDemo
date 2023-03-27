
import { useEffect, useState } from "react";
import { environment } from "../Environment";
import { BrowserRouter as Router, Route, Routes } from "react-router-dom";

import { Page } from "../Pages/Page";
import React from "react";

export  function Menu() 
{

const [menu, setMenu] =  useState<any[]>([])
  useEffect(() => {
 
    async function getMenu() {

      const response = await fetch(`${environment.baseUrl}menu/GetHeaderMenu`);

      const data = await response.json();
console.log(data)
      setMenu(data)
  }

  getMenu();
  }, []);

  return (

      <>

            <Router>
                <div className="App">
                <Routes>
                  {menu.map((value, index) => {
                
                    return  <Route path={value.url} element={<Page url={value.url}/>} />
                  }
                )}
                </Routes>
                </div>
            </Router>
              {/* <BrowserRouter>
             
                <Routes>
              
                </Routes>
              </BrowserRouter> */}
   {/* <div className="loader_bg">
         <div className="loader"><img src="images/loading.gif" alt="#" /></div>
      </div> */}

       

   </>
  )
}
 
export default Menu;