
# CoreWCF Migration Helper
This repository contains 3 projects that illustrate the use of CoreWCF with .net Framework and .net Core. It illustrates the changes required to migrate a WCF service from .net Framework to .net Core.


## Introduction
WCF is a .net API to send messages between client and server applications. Providing reliable mechanisms to serialize data, many softwares use it. Unfortunately, WCF is part of .net Framework and it is not provided by .net Core causing numerous challenging issues when migrating to .net Core.

CoreWCF is a community implementation of WCF that complies with .net Standard 2.0 and is a great API to complete it. This repository is useful to help you to identify required changes for both client and server as standalone applications.


## Content
Projects below depict a WCF IService usage:
* CoreWCFClient: A .net Core client
* CoreWCFService/CoreWCFServiceNetFramework: A .net Framework server
* CoreWCFService/CoreWCFService: A .net Core server

IService provides 2 methods:
* string GetData(int value)
* CompositeType GetDataUsingDataContract(CompositeType composite)
The client connects to the server and call both methods. The server returns values according IService's implementation in Service.cs

## Usage
Build projects as usual with Visual. Please note that Nuget dependencies should be automatically downloaded during this operation. Then, launch either the .net Framework or .net Core server. Eventually launch the client. Please note that as client does not display anything, you should launch it through Visual with a breakpoint to check that it successfully connected to the service.


## License
[GPLv3](https://choosealicense.com/licenses/gpl-3.0/)
