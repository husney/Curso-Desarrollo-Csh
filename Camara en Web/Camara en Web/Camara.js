let dispositivos = [];
let lista = document.querySelector("#ContentPlaceHolder1_PruebaControl_listaDispositivos");
let close = document.getElementById("ContentPlaceHolder1_PruebaControl_cerrarCamara");
let start = document.getElementById("ContentPlaceHolder1_PruebaControl_iniciarCamara");
let lista2 = document.getElementById("ContentPlaceHolder1_PruebaControl_listaDispositivos");
let canva = document.querySelector("#ContentPlaceHolder1_PruebaControl_canvas");

document.getElementById("ContentPlaceHolder1_PruebaControl_captura").style.cssText = "display : none;";

const buscarDispositivos = () =>{
    navigator.mediaDevices.enumerateDevices().then(devices =>{
        devices.forEach(elemento =>{
            if(elemento.kind === "videoinput"){
                dispositivos.push(elemento);
            }
        });

        if(dispositivos.length > 0 ){
            dispositivos.forEach(dispositivoC =>{
                let option = document.createElement('option');
                option.value = dispositivoC.deviceId;
                option.text = dispositivoC.label;
                lista.appendChild(option)
            });
        }
    });

    

}


let imagen;
let mostrarVideo = document.getElementById("ContentPlaceHolder1_PruebaControl_video");
mostrarVideo.setAttribute("style", "display:none");
//let capturarImagen = document.getElementById("ContentPlaceHolder1_capturarFoto");

//capturarImagen.addEventListener("click", tomarFoto());
//start.addEventListener("click", iniciarVideo());
buscarDispositivos();


function iniciarVideo(){
    navigator.mediaDevices.getUserMedia({video : true }).then((stream) =>{
        
        //console.log(dispositivos);
    
        mostrarVideo.setAttribute("style", "display: inline-block");
        imagen = stream;
        mostrarVideo.srcObject = stream;
        
        lista2.addEventListener("change", ()=>{
            if(stream){
                stream.getTracks().forEach(track =>{
                    track.stop();
                })
                
            }
        }); 

        

    
    }).catch((error) => console.log(error));
}



  function cerrarVideo(){
    
    mostrarVideo.srcObject.getTracks()[0].stop();
    mostrarVideo.srcObject = null;
    mostrarVideo.setAttribute("style", "display:none");
  }

  //let fotoFRMT64;

 function tomarFoto(){
     mostrarVideo.pause();

     var contexto = canva.getContext("2d");
     canva.width = mostrarVideo.videoWidth;
     canva.height = mostrarVideo.videoHeight;
     contexto.drawImage(mostrarVideo, 0, 0, canva.width, canva.height);
 

     let foto = canva.toDataURL(); 

     // ----Descargar Imagen PC
     //let enlace = document.createElement('a');
     //enlace.download = "CapturaImagen.png";
     //enlace.href = foto;
     //enlace.click();

     //---Mostrar Fromato Base 64 (PROBADO)
     //document.getElementById("ContentPlaceHolder1_pruebaLink").setAttribute("href", foto);
     //document.getElementById("ContentPlaceHolder1_pruebaLink").innerText = foto;
     //fotoFRMT64 = foto;


     /**************
     document.getElementById("ctl00_ctl00_ContentPlaceHolder1_mainContent_FotoWebGroupBox_imagenBase64").setAttribute("value", foto);

     *****************/
     
     mostrarVideo.play();

     let img = document.getElementById("ContentPlaceHolder1_PruebaControl_captura");
     img.style.cssText = "display : inline-block;";
     img.setAttribute("src", foto);
     



    //console.log(foto);
     
    //contexto = document.querySelector("#canvas");
    //contexto = contexto.getContext("2d");
    //contexto.drawImage(mostrarVideo, 0, 0, 500, 400);
    //imgCanva = document.querySelector("#canvas");
    //img = imgCanva.toDataURL("image/png");
    //console.log(img);
    //document.getElementById("canvas1").setAttribute("src", img);
  }

  



