# _Vendors and Orders_

#### _A C# MVC Application, friday code review. March 13, 2020_

#### By _**Jeremy Padot**_


## Description

_An MVC application that will keep track of vendors and their orders for our friend Pierre. This application will supply Pierre with Vendor categories, their description, and a list of what they typically order. _



## Behavior Driven Project Specifications

| Behavior | Input | Output |
|:---|:---:|:---:|
| Application creates instance of Vendor | Vendor name/description  | Application creates new Vendor |
| Application creates instance of Order | Order title/description/price/date  | Application creates new Order |
| Application sorts orders inside vendors as categories and items | newVendor newOrder | Application creates object within object |
| Application returns Vendor and Order | Vendor: Harus Bakery / Order: Tenderpaw Biscuits & Catnip sweetroll, $10, March 12, 2020  | Vendor: Harus Bakery Order: Harus Order, Tenderpaw Biscuits & Catnip sweetroll, $10, March 12, 2020 |


## Setup/Installation Requirements

In your computer's terminal:

1. Navigate to where you want this application to be saved, i.e.:
```sh
cd desktop
```
2. Clone the file from GitHub with HTTPS
```sh
git clone https://github.com/kalepadot/VendorAndOrder.Solutions.git
```
3.  Enter into the new file directory
```sh
cd VendorAndOrder.Solutions
```
4. Enter the program file
```sh
cd VendorAndOrder/
```
5. Restore
```sh
dotnet restore
```
6. Build
```sh
dotnet build
```
7.  Start the program
```sh
dotnet run
```
8. Open in your browser by clicking
```sh
http://localhost:5000
```


## Known Bugs

_No known bugs at this time._

## Support and contact details

_Have a bug or an issue with this application? [Open a new issue](https://github.com/kalepadot/VendorAndOrder.Solutions/issues) here on GitHub._

## Technologies Used

* C#
* .NET 2.2
* Terminal
* Git
* VS Code
* Macbook Pro
* MVC
* Mr. Squiggles
### License

[MIT](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 **_Jeremy Padot_**