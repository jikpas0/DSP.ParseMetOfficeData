# DSP.ParseMetOfficeData
Parse Met office historical weather data and store data on the database from the server given a console RESTFul port request

Example input file to be parsed found
http://www.metoffice.gov.uk/pub/data/weather/uk/climate/stationdata/heathrowdata.txt

Client console application post requests to server

MVC WebAPI2 implementation of server with Entity Framework model first SQL server CE database to store data

Example of data shown below:

Heathrow (London Airport)
Location 507800E 176700N, Lat 51.479 Lon -0.449, 25m amsl
Estimated data is marked with a * after the value.
Missing data (more than 2 days missing in month) is marked by  ---.
Sunshine data taken from an automatic Kipp & Zonen sensor marked with a #, otherwise sunshine data taken from a Campbell Stokes recorder.
   yyyy  mm   tmax    tmin      af    rain     sun
              degC    degC    days      mm   hours
   1948   1    8.9     3.3    ---     85.0    ---
   1948   2    7.9     2.2    ---     26.0    ---
   1948   3   14.2     3.8    ---     14.0    ---
   1948   4   15.4     5.1    ---     35.0    ---
   1948   5   18.1     6.9    ---     57.0    ---
