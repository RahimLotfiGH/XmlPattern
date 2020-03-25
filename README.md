XML Pattern  


Abstract

Designing object-oriented applications by itself is difficult and designing reusable object-oriented applications is even harder. A design pattern is a mechanism for expressing experience in an object-oriented design, and is an appropriate solution provided for one type of problem, which can be repeatedly used during design. Using design patterns enhances the durability and quality of the code.
This article introduces a new pattern for mapping a structured file (JSON, XML, etc.) to objects. Using the XML Pattern enhances the quality and durability of the code, and is easily extensible. 
Keywords: OFM, XML Pattern
1.	Introduction
The concept of design pattern is applied not only in the software world but also in other scientific fields. The concept of "pattern" was first introduced by a building architect named Alexander, who realized that good buildings have common features, which he called "pattern". "Pattern" is a shared view toward a problem and its concept is not changed by implementation. Each pattern describes a solution to a problem type [My]. After Alexander, software engineers realized that there were design patterns in software design. In 1995, GOF published a book on the use of pattern design in software design. They expressed a standard template for documenting a design pattern and categorized and published 23 design patterns. After the publication of the book Design Patterns, the use of the design pattern was greatly extended and a number of new patterns were discovered and used. As object-oriented programming proceeds, developers can design and offer better patterns that better support extensibility and maintenance. Design patterns are not the result of a programmer's experiences; they have resulted from the experiences of hundreds of programmers and design professionals over years. Design patterns are not innovations or inventions, but are feedbacks on redesign and recoding that programmers have been involved with in order to achieve the highest levels of flexibility, extensibility and reusability. Design patterns can be considered a summary of programmers' successful experiences. Their use makes the resulting design more simple, flexible and reusable. Design patterns can save time and cost and make it easier to document and maintain the system. The design pattern is a mechanism for expressing experience in object-oriented design and is an appropriate solution provided by the news person for one type of problem, which can be repeatedly used throughout the design [7]. Design patterns are not inventions or inventions, but feedback on redesigns and coding that developers have been involved with for the most flexibility, extensibility and reusability. Design patterns can be summarized as successful programmers' experiences. The use of design patterns makes the resulting design more simple, flexible and reusable. Design patterns can save time and cost and make it easier to document and maintain the system. The remainder of this article is organized as follows.
2.	Challenges and Objectives
•	Hiding the Details
Hiding the complexity enhances readability and code quality. Complying with Single Responsibility in Solid Principle allows each segment to perform its task. It divides tasks between layers, thus causing the complexities to be hidden. The proposed model has attempted to fully adhere to the Single Responsibility principle.
•	Prevention of Copy and Paste
Copying the same code (in the proposed algorithm, for example, reading data from files, etc.) can be confusing at various stages in the program and is a very wrong task, which decreases code maintenance and quality.
•	 Lazy Loading
Lazy loading is a design pattern commonly used in computer programming to defer initialization of an object until the point at which it is needed. It can contribute to efficiency in the program's operation if properly and appropriately used
There are two noteworthy points here: first, data must not be loaded until necessary, second the whole data must not be loaded; only the required data must be loaded (since the data are read from the file and the file has a unified single structure in the proposed pattern). 
Extensibility
The most important feature of the proposed pattern is its simplicity of structure and extensibility. In the proposed pattern, adding new and nested sections is very easy and fast.
3. Proposed XML Pattern
In this section, we introduce the XML Pattern. To better understand it, we will try to give an example. Imagine that in a program you have to store certain data in a file that you should not store in the database because of their limitations, like string connection, server port number, IP server, program name, etc. These data should not be stored in the database because they do not have a specific size and structure and are used in different parts of the program which do not need any connection to the database server to be read, so we decide to store them in the file. XML or JSON format is a good structure to do this. For example, consider a file (Setting.xml) with the following XML structure.
<?xml version="1.0" encoding="UTF-8"?>
<root>
<SystemSetting>
<AppName>Xml Pattern</AppName>
<AppVersion>V1.0</AppVersion>
<EfConnectionString>Entity FramWork Connection String</EfConnectionString>
<DapperConnectionString>Dapper Connection String</DapperConnectionString>
</SystemSetting>
<ServerSetting>
<ServerName> Server1 </ServerName>
<ServerIp>127.0.0.1</ServerIp>
<ServerLocation>Iran</ServerLocation>
<IsServerAvailable>True</IsServerAvailable>
<Ports>2200,27017,8045</Ports>
</ServerSetting>
</root>
As you can see, we have any type of data (string, number, Boolean, list, …).
