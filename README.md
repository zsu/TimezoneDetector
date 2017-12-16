# What is TimezoneDetector

TimezoneDetector is an asp.net MVC/Web Form library for browser timezone detection. It provides simple way to detect browser timezone and display browser time.

# Demo
  * Demo can be found at: http://devs.azurewebsites.net/TimezoneDetector

# Nuget
~~~xml
  Install-Package TimezoneDetector
~~~

# Getting started with TimezoneDetector
  * Reference TimezoneDetector.dll
  * Call DateTime.UtcNow.ToClientTime() when you want to display message;
  * Use it on your page;
```xml
Razor:
@using TimezoneDetector

WebForms:
<%@ Import Namespace="TimezoneDetector" %>
```
```xml
Razor:
@Html.TimezoneDetector()

WebForms:
<%@Html.TimezoneDetector %> 
```
  * Link to Jquery/JQuery-cookie/jsTimezoneDetect on your page: 
```xml
    <link href="http://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" rel="stylesheet"/>
    <link href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" rel="stylesheet"/>
    <script src='https://code.jquery.com/jquery-1.12.4.min.js' type='text/javascript'></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery-cookie/1.4.1/jquery.cookie.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jstimezonedetect/1.0.6/jstz.min.js"></script>
```
# License
All source code is licensed under MIT license - http://www.opensource.org/licenses/mit-license.php
