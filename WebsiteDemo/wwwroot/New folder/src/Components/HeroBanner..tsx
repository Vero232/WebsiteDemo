import React, { useState } from "react";

export function HeroBanner({...props}){

const [heroData, setData] = useState([props.data[0]]);


    

    return(
      <>       
       {heroData.map((value, index) => {
                
            return      <div className="w-full bg-cover bg-center h-[32rem]" style={{backgroundImage: `url(${'https://images.unsplash.com/photo-1504384308090-c894fdcc538d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80'})` }}>
            <div className="flex items-center justify-center h-full w-full bg-gray-900 bg-opacity-50">
                <div className="text-center">
                    <h1 className="text-white text-2xl font-semibold uppercase md:text-3xl pb-4">{value.Heading}</h1>
                    <p className="pb-8 text-white">{value.Description}</p>
                    <a className="mt-4 px-4 py-2 bg-blue-600 text-white text-sm uppercase font-medium rounded hover:bg-blue-500 focus:outline-none focus:bg-blue-500" href={value.ButtonURL} target={value.ButtonTarget}>{value.ButtonName}</a>
                </div>
            </div>
        </div>
          }
        )}
        </>

    )

}