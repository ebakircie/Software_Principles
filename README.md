# Software Principles

Software Pirinciples are recommendations or best practices for developers that they should benefit while coding in order to avoid repeating the same thing over and over or write cleaner, understandable and maintainable code. 
For example those recommendations are; 

# DRY: Don't Repeat Yourself!
It aims to reduce repetition of patterns and practices which means  whenever implementing new technology or modificate any single part of system should not require a change in any other part which related to modificated one.
>_Every piece of knowledge must have a single, unambiguous, authoritative representation within a system ‐ The Pragmatic Programmer by Andrew Hunt, David Thomas_

# KISS: Keep It Simple Stupid!
This principle basicly saying that whole system would work better if system kept simple rather than complicated. While designing anything ***unnecessary complexity*** should be avoided in order to prevent sustainability of system. This term is used first by Kelly Johnson, who was the lead engineer. He told the designers that they should design very simple so with basic tools they can be repaired in a combat situations.

# YAGNI: You Aren't Gonna Need It!
Why would you add a feature or functionality that you don't need right now but you ***might*** need next month or year later. If it is not a feature yet you are wasting your time. This principle says that ***you should implement things when you need them.***

![1_7T_MQ8cFP1TgKBkf8dDWeg](https://user-images.githubusercontent.com/77506856/165793671-fc5dec4a-7757-4e5d-8258-6f5ca41d7aa6.jpeg)

# SOLID

SOLID is acronym for 5 deisgn pattern that helps the software to be more flexible and maintainable as how Software Principles should be.
Those Principles are;
- Single Responsibility Principle
- Open Closed Principle
- Liskov Substitution Principle
- Interface Segregation Principle
- Dependency Inversion Principle 

# [Single Responsibility Principle](https://github.com/ebakircie/Software_Principles/tree/main/SOLID/SOLID/1.SRP)

Tells us that every class or function should only have one job to do. If we give more responsibilities than it should be, it will be effected more changes and bugs. System will be more understandable, less complex so new developers can adapt the project faster. Also it means less responsibilities easier integrations.

# [Open/Closed Principle](https://github.com/ebakircie/Software_Principles/tree/main/SOLID/SOLID/2.OCP)

***Entities should be open for extension, but closed for modifications.*** This is the exact definition of OCP, it basicly says that Entities such as Business classes or Entity classes must be designed as you can extend them into sub pieces with the help of polymorphism but can't modify main/base classes. Which means it can gain new abilities without changing the behavior. It works really well with Single Responsibility Principle.

# [Liskov Substitution Principle](https://github.com/ebakircie/Software_Principles/tree/main/SOLID/SOLID/3.LSP)

This Principle defines we should be able to use the sub classes without any modification on behalf of main classes.
Derived classes should behave same as the main classes but also they can contain its own unique abilities.

# [Interface Segregation Principle](https://github.com/ebakircie/Software_Principles/tree/main/SOLID/SOLID/4.ISP)

Tells that instead of having a bigger responsibilities in single interface we should divide them into smaller pieces. By doing that we will work with what we need otherwise it means we are adding unnecessary feature or method to the target class. 

***“Clients should not be forced to depend upon interfaces that they do not use.”***

# [Dependency Inversion Principle](https://github.com/ebakircie/Software_Principles/tree/main/SOLID/SOLID/5.DIP)

_It states that higher level modules should not depend on lower level modules, both should depend on abstraction.
Abstractions should not depend on details, Details should depend upon abstractions._
 
 
