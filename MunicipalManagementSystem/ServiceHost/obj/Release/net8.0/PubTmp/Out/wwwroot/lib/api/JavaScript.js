//function GetEngineers(RoofCount, ProjectArea) {
var RoofCount = 5;
var ProjectArea = 2000;
    const settings = {
        "url": "http://217.219.161.44:8098/api/AgencyApi/GetEngineers",
        "method": "POST",
        "timeout": 0,
        "headers": {
            "Content-Type": "application/json"
        },
        "data": JSON.stringify({
            "user": {
                "UserName": "sahhrdarisari-wb",
                "Password": "H2PA%B2B(9$JAvf#",
                "ServiceName": "string",
                "PassPhrase": "string"
            },
            "RoofCount": RoofCount,
            "AscRoofCount": 0,
            "ProjectArea": ProjectArea,
            "AscProjectArea": 0,
            "TrackCode": "string",
            "UnitCount": 0,
            "FirstName": "string",
            "LastName": "string"
        }),
    };

    $.ajax(settings).done(function (response) {
        //console.log(response);
    });
//}