function init_map() {

    //wms_iran_cities = new OpenLayers.Layer.WMS("iran_cities",
    //"htqtp://localhost:8080/geoserver/webgis/wms", 
    // { layers: "webgis:iran_cities", format: 'image/png', transparent: 'true', visibility: true });
    osm_map = new OpenLayers.Layer.OSM("osm_map");

    MapServerUrl = "http://127.0.0.1/cgi-bin/mapserv.exe";

    //iran_States = new OpenLayers.Layer.MapServer("iran_states",
    //    MapServerUrl, { map: 'C:/ms4w/apps/local-demo/local.map' });
    google_street = new OpenLayers.Layer.Google("google_street",
        { numZoomLevels: 20, visibility: true });



    map = new OpenLayers.Map('map',
        { projection: 'EPSG:900913', allOverlays: true });



    map.addLayers([google_street]);



    map.setCenter(new OpenLayers.LonLat(54.96484, 33.55225).
        transform(new OpenLayers.Projection('EPSG:4326'),
            map.getProjection()), 5);

    map.addControl(new OpenLayers.Control.LayerSwitcher());

    map.addControl(new OpenLayers.Control.ScaleLine({
        'div': OpenLayers.Util.getElement('scale_line')
    }));

    map.addControl(new OpenLayers.Control.MousePosition({
        'div': OpenLayers.Util.getElement('mouse_position')
    }));

    navigation_history = new OpenLayers.Control.NavigationHistory();

    map.addControl(navigation_history);


}
