var platform = new H.service.Platform({
    apikey: 'GCka5q0L48J72eJ3-qpUUD1B_k29BPGt_bb_It-zlwo'
});

var defaultLayers = platform.createDefaultLayers();

var map = new H.Map(document.getElementById('mapContainer'),
    defaultLayers.vector.normal.map, {
    center: { lat: -31.417, lng: -64.183, },
    zoom: 6,
    pixelRatio: window.devicePixelRatio || 1
});
window.addEventListener('resize', () => map.getViewPort().resize());

var behavior = new H.mapevents.Behavior(new H.mapevents.MapEvents(map));

var ui = H.ui.UI.createDefault(map, defaultLayers);

async function fetchDataUtn() {
    try {
        const response = await fetch('https://localhost:7275/api/apiMap',{
            method:"GET"
        });

        const data = await response.json();
        
        return data;
    } catch (error) {
        swal("¡No se pudo conectar con la API!", "¡Inténtalo de nuevo más tarde!", "error");
        // var a = new H.map.Marker({ lat: -31.41950006910025, lng: -64.17903671085821 });
        // coords = { lat: -31.41950006910025, lng: -64.17903671085821 };
        // map.addObject(a);
        // map.setCenter(coords);
        // map.setZoom(5);
    }
}

async function utn() {
    let data= await fetchDataUtn();
    mapdata = data.litadoMarcadores[0];
   var a = new H.map.Marker({  lat: mapdata.latitud, lng: mapdata.longitud });
   if (mapdata.info == "UTN FRC") {
               coords = { latitud: mapdata.latitud, longitud: mapdata.longitud };
               map.addObject(a);
               map.setCenter(coords);
               map.setZoom(15);
   }else{
        swal("¡No se pudo conectar con la API!", "¡Inténtalo de nuevo más tarde!", "error");
         var a = new H.map.Marker({ lat: -31.41950006910025, lng: -64.17903671085821 });
         coords = { lat: -31.41950006910025, lng: -64.17903671085821 };
         map.addObject(a);
         map.setCenter(coords);
         map.setZoom(5);
   }
}

async function pabellon(){
    let data = await fetchDataUtn();
    mapdata = data.litadoMarcadores[1];
    var a = new H.map.Marker({lat : mapdata.latitud, lng : mapdata.longitud});
    if (mapdata.info == "Pabellón Argentina") {
        coords = { lat: mapdata.latitud, lng: mapdata.longitud };
        map.addObject(a);
        map.setCenter(coords);
        map.setZoom(10);
    }else{
    swal("¡No se pudo conectar con la API!", "¡Inténtalo de nuevo más tarde!", "error");
    var a = new H.map.Marker({ lat: -31.41950006910025, lng: -64.17903671085821 });
    coords = { lat: -31.41950006910025, lng: -64.17903671085821 };
    map.addObject(a);
    map.setCenter(coords);
    map.setZoom(5);
    }

}