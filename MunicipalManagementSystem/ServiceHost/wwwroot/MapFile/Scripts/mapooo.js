 <reference path="OpenLayers.js" />
var wms_iran_cities, osm_map, google_street, map, navigation_history;
var MapServerUrl;
var iran_States;
function init_map() {

    //wms_iran_cities = new OpenLayers.Layer.WMS("iran_cities",
    //"htqtp://localhost:8080/geoserver/webgis/wms", 
    // { layers: "webgis:iran_cities", format: 'image/png', transparent: 'true', visibility: true });

    osm_map = new OpenLayers.Layer.OSM("osm_map");

   // MapServerUrl = "http://127.0.0.1/cgi-bin/mapserv.exe";

    iran_States = new OpenLayers.Layer.MapServer("MapServer Layer",
        "http://127.0.0.1/cgi-bin/mapserv.exe?map=/ms4w/apps/local-demo/localh.map&",
        { layers: 'states' },
        { singleTile: "true", ratio: 1 });


    
    google_street = new OpenLayers.Layer.Google("google_street",
        { numZoomLevels: 20, visibility: true });



    //map = new OpenLayers.Map('map',
    //    { projection: 'EPSG:900913', allOverlays: true });



  





    var map = new OpenLayers.Map('map',
        {
            maxExtent: new OpenLayers.Bounds(43.942387, 24.660000, 64.457613, 40.040000),
            maxResolution: 0.025676
        });
    var mslayer = new OpenLayers.Layer.MapServer("MapServer Layer",
        "http://127.0.0.1/cgi-bin/mapserv.exe?map=/ms4w/apps/local-demo/local.map&",
        { layers: 'states' },
        { singleTile: "true", ratio: 1 });
   // map.addLayer(google_street);
    //map.zoomToMaxExtent();

    map.addLayers( [mslayer]);

    map.setCenter(new OpenLayers.LonLat(54.96484, 33.55225).
        transform(new OpenLayers.Projection('EPSG:4326'),
            map.getProjection()), 5);

    map.addControl(new OpenLayers.Control.LayerSwitcher());

    map.addControl(new OpenLayers.Control.ScaleLine({
        'div':OpenLayers.Util.getElement('scale_line')
    }));

    map.addControl(new OpenLayers.Control.MousePosition({
        'div': OpenLayers.Util.getElement('mouse_position')
    }));

    navigation_history = new OpenLayers.Control.NavigationHistory();

    map.addControl(navigation_history);


 

}

function navigation_next() {
    navigation_history.next.trigger();
}
function navigation_prev() {
    navigation_history.previous.trigger();
}
function zoon_to_default() {
    map.setCenter(new OpenLayers.LonLat(54.96484, 33.55225).transform(new OpenLayers.Projection('EPSG:4326'), map.getProjection()), 5);
}