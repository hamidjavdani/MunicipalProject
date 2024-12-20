 <reference path="OpenLayers.js" />
var wms_iran_cities, osm_map, google_street, map, navigation_history;
var MapServerUrl;
var iran_States;
function init_map1() {

    var map = new OpenLayers.Map('map',
        {
            maxExtent: new OpenLayers.Bounds(681484.000000, 4044055.915519, 686537.000000, 4047844.084481),
            maxResolution: 6.324155
        });
    var mslayer = new OpenLayers.Layer.MapServer("MapServer Layer",
        "http://127.0.0.1/cgi-bin/mapserv.exe?map=/ms4w/apps/local-demo/local.map&",
        { layers: 'sari1 sari2 sari3' },
        { singleTile: "true", ratio: 1 });
    map.addLayer(mslayer);
    map.zoomToMaxExtent();

    identify();
}

function identify() {
    var x;
    x = 0;

    map.events.register("click", map, function (e) {
        //if (selected_layers_name.length > 0) {
            $.ajax({
                data: { width: map.getSize().w, height: map.getSize().h, x: e.xy.x, y: e.xy.y, layers: selected_layers_name.join(',') },
                type: 'GET',
                contentType: "application/json",
                url: identify_url,
                success: function (data) {
                    if (data.response == "") {
                        $("#msg_notfound").modal();
                    }
                    else {
                        $('#msg_city_detail').html(data.response);
                        $('#msg_city_detail').modal();
                    }
                },
                fail: function (data) {

                }
            });
       // }
    });
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