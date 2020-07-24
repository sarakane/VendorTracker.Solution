# _Vendor and Order Tracker_

#### _C#/.NET Project for [Epicodus](https://www.epicodus.com/), 2020.07.24_

#### By **Sara Kane**

## Description
MVC application to track vendors that order baked goods from a bakery.

## Specifications
|                                                          Behavior                                                         | Input                             | Output                                                                                                       | Met? (Y/N) |
|--------------------------------------------------------------------------------------------------------------------------|-----------------------------------|--------------------------------------------------------------------------------------------------------------|------------|
| Program should create an Order object with properties for title, description, price, and date                             | croissants, weekly, 35, 7/24/2020 | Order newOrder = new Order() {OrderTitle = "croissants", Description = "weekly", Price=35, Date="7/24/2020"} | N          |
| Program should create a Vendor object with properties for name, description, and a list of order belonging to the vendor  | Suzie's Cafe, small cafe          | Vendor newVendor = new Vendor() {VendorName = "Suzie's Cafe", Description = "small cafe"}                    | N          |
| Program should add an order object to a Vendor object                                                                     | add newOrder to newVendor         | Suzie's Cafe {OrderTitle = "croissants"}                                                                     | N          |

## Known Bugs
* No known bugs.   

## Setup/Installation Requirements

#### View locally

*[.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2) is needed to run this application*

To clone this repository from your command line you will need [Git](https://git-scm.com/) installed. 

First navigate in the command line to where you want to clone this repository. 

Then from your command line run:

`$ git clone https://github.com/sarakane/VendorTracker.Solution`

Once the repository has been cloned, navigate to the to the application directory and run `$ dotnet build`.

#### Run locally
* To run the program run `$ dotnet run` 

### Edit
* To view and edit the code, open the application in your preferred code editor, such as Visual Studio Code.

## Technologies Used
* Visual Studio Code (code editor)
* C#/.NET

## License
This software is licensed under the MIT license. Copyright (c) 2020 Sara Kane.