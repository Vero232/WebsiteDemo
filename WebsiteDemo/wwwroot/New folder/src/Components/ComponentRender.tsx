import React from "react";
import { HeroBanner } from "./HeroBanner.";
import { InfoCards } from "./InfoCards";
import Introduction from "./Introduction"; 



export function ComponentRender({...props}){
console.log(props.data.Key)

type test = {
  introduction: JSX.Element | JSX.Element[] | null
}

const componentsType : test = {
     introduction: Introduction 
  }

  const comonent1 = componentsType["Introduction"];
let component;

  switch( props.data.Key) {
    case "Introduction":
        component = <Introduction data={props.data.Value}/>
      break;
    case "Herobanner":
        component = <HeroBanner data={props.data.Value}/>
        break;
     case "Infocards":
      component = <InfoCards data={props.data.Value}/>
      
      break;
 
    default:
      // code block
  }

    return(
       <>{component}</> 
    )

}