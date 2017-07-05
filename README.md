# "Pico y Placa" Challenge

[![Build status](https://ci.appveyor.com/api/projects/status/v8vj61357fcw0s6l?svg=true)](https://ci.appveyor.com/project/geobasis/traffic)

This Project implements the basic rules for the control of the vehicle circulation (Pico y Placa) in Quito City

The Solution contains the TrafficControl.Core Project and TrafficControl.Core.Test Project.
The TrafficControl.Core Project contains the classes with the structs and logic for the rules to control the vehicle circulation.

- The struct RestrictedTimeRange contains the Start and End Time for a RestrictedTimeRange to ciruclation of Vehicles
- The Schedule class contains the properties with the configuration of the Last Digit Restricteds for each Day of Week and RangeTime Restricteds
- The LastDigit property of LicencePlate class return the last digit of the License Plate for check if IsRestricted your circulation in the date received.
- The class MilitaryTime contains the Value property that return the string time as a integer in militar format for example 14:28 return 1428, this value is verified if is contained by any RestrictedTimeRange.
- The Policy Object check if circulation of Vehicles IsRestricted by the License Plate Number in the date and time received

The TrafficControl.Core.Test Project contains the unit Test classes for each public property in the TrafficControl.Core Project.
