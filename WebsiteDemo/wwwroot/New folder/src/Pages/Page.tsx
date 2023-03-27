import React, { Component, Fragment } from "react";
import {  useEffect, useState } from "react";
import { render } from "react-dom";
import { ComponentRender } from "../Components/ComponentRender";
import { environment } from "../Environment";



export function Page({...props}){

  const [comp, setComp] = useState([]);

  useEffect(() => {
 
    async function getMenu() {

      const response = await fetch(`${environment.baseUrl}Content/GetContent?url=${props.url}`);

      const data = await response.json();
console.log(data)
      setComp(data)
  }

  getMenu();
  }, []);

    return (
      <div>     
   

                  {(Object.entries(comp) || []).map(([key, value]) => {
                return (
                    <ComponentRender
                        data={value}  values={comp}
                    />
                );
            })}
          
      </div>

    )
}