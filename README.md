# Design Patterns

A comprehensive collection of classic design pattern implementations in C#/.NET, demonstrating best practices and practical examples from the Gang of Four (GoF) and other essential software design patterns.

## Overview

This repository contains 11 design pattern implementations, each in its own project with working examples and demonstrations. The patterns are implemented following object-oriented principles and demonstrate how to solve common software design problems.

## Technology Stack

- **Language:** C# (.NET Framework)
- **IDE:** Visual Studio
- **Structure:** Individual solution files (.sln) for each pattern

## Design Patterns Implemented

### 1. **Adapter Pattern** (`AdapterPattern/`)
**Purpose:** Converts the interface of a class into another interface that clients expect. Allows classes to work together that couldn't otherwise because of incompatible interfaces.

**Key Components:**
- `IDuck` and `ITurkey` interfaces
- `TurkeyAdapter` - Adapts turkey interface to duck interface
- `MallardDuck`, `WildTurkey` implementations

**Example:** Making a turkey look like a duck by adapting `gobble()` to `quack()` and adjusting `fly()` behavior.

---

### 2. **Command Pattern** (`CommandPattern/`)
**Purpose:** Encapsulates a request as an object, allowing you to parameterize clients with different requests, queue or log requests, and support undoable operations.

**Key Components:**
- `ICommand` interface with `Execute()`, `Undo()`, and `GetName()` methods
- Command implementations: `LightOnCommand`, `LightOffCommand`, `CeilingFanCommands`, `StereoOnWithCD`
- `MacroCommand` for executing multiple commands
- `RemoteControl` as command invoker
- Receivers: `Light`, `CeilingFan`, `Stereo`, `GarageDoor`

**Example:** Home automation remote control with programmable buttons and undo functionality.

---

### 3. **Decorator Pattern** (`DecoratorPattern/`)
**Purpose:** Attaches additional responsibilities to an object dynamically. Provides a flexible alternative to subclassing for extending functionality.

**Key Components:**
- `Beverage` abstract base class
- `CondimentDecorator` abstract decorator
- Beverages: `Espresso`, `DarkRoast`, `HouseBlend`, `Decaf`
- Condiments: `Mocha`, `Milk`, `Soy`, `Whip`
- `EnumSize` for beverage sizes

**Example:** Building custom coffee orders by decorating base beverages with condiments, calculating total cost.

---

### 4. **Facade Pattern** (`FacadePattern/`)
**Purpose:** Provides a unified interface to a set of interfaces in a subsystem. Makes the subsystem easier to use by providing a higher-level interface.

**Key Components:**
- `HomeTheaterFacade` - Simplifies home theater operations
- Subsystem components: `DvdPlayer`, `Amplifier`, `Projector`, `Screen`, `PopcornPopper`, `CdPlayer`, `Tuner`, `TheaterLights`

**Example:** Single method calls like `watchMovie()` and `endMovie()` that coordinate multiple subsystem components.

---

### 5. **Factory Pattern** (`FactoryPattern/`)
**Purpose:** Defines an interface for creating objects, but lets subclasses decide which class to instantiate. Lets a class defer instantiation to subclasses.

**Key Components:**
- `PizzaStore` abstract factory with factory method
- Concrete stores: `NYPizzaStore`, `ChicagoPizzaStore`
- Abstract Factory: `IPizzaIngredientFactory`
- Ingredient factories: `NYPizzaIngredientFactory`, `ChicagoPizzaIngredientFactory`
- Pizza varieties: NY Style and Chicago Style pizzas
- 20+ ingredient classes: Dough, Sauce, Cheese, Veggies, Pepperoni, Clams

**Example:** Creating region-specific pizzas with locally-sourced ingredients using both Factory Method and Abstract Factory patterns.

---

### 6. **Iterator & Composite Patterns** (`Iterator_CompositePatterns/`)
**Purpose:** 
- **Iterator:** Provides a way to access elements of an aggregate object sequentially without exposing its underlying representation.
- **Composite:** Composes objects into tree structures to represent part-whole hierarchies.

**Key Components:**
- `ITerator` interface
- Iterator implementations: `DinerMenuIterator`, `PancakeHouseIterator`
- `MenuComponent` composite base class
- `Menu` and `MenuItem` for hierarchical menu structures
- Menus: `DinerMenu`, `PancakeHouseMenu`, `CafeMenu`
- `Waitress` to traverse menu hierarchy

**Example:** Restaurant menu system with nested menus and iteration over all menu items.

---

### 7. **Observer Pattern** (`ObserverPattern/`)
**Purpose:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

**Key Components:**
- `ISubject`, `IObserver`, `IDisplay` interfaces
- `WeatherData` subject
- Observers: `ConditionsDisplay`, `HeatDisplay`, `ForecastDisplay`, `StatisticsDisplay`

**Example:** Weather station broadcasting updates to multiple display units when measurements change.

---

### 8. **Singleton Pattern** (`SingletonPattern/`)
**Purpose:** Ensures a class has only one instance and provides a global point of access to it.

**Key Components:**
- `Singleton` - Basic singleton implementation
- `SingletonLazy` - Lazy initialization variant

**Example:** Two different singleton implementations demonstrating eager and lazy loading strategies.

---

### 9. **State Pattern** (`StatePattern/`)
**Purpose:** Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.

**Key Components:**
- `IState` interface
- States: `NoCoinState`, `HasCoinState`, `SoldState`, `SoldOutState`, `WinnerState`
- `GumballMachine` context
- `StateKind` enumeration

**Example:** Gumball vending machine with different behaviors based on current state (has coin, sold out, etc.).

---

### 10. **Strategy Pattern** (`StrategyPattern/`)
**Purpose:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Lets the algorithm vary independently from clients that use it.

**Key Components:**
- `Duck` abstract class
- Duck types: `MallardDuck`, `RedHeadDuck`, `RubberDuck`, `ModelDuck`, `DecoyDuck`
- `IFlyBehavior` interface with: `FlyWithWings`, `FlyNoWay`, `FlyRocketPowered`
- `IQuackBehavior` interface with: `Quack`, `Squeak`, `MuteQuack`

**Example:** Different duck types with interchangeable flying and quacking behaviors that can be changed at runtime.

---

### 11. **Template Method Pattern** (`TemplateMethodPattern/`)
**Purpose:** Defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Lets subclasses redefine certain steps without changing the algorithm's structure.

**Key Components:**
- `WaterPreparedBeverage` abstract class with template method
- Implementations: `Coffee`, `Tea`

**Example:** Beverage preparation algorithm where the overall process is defined but specific steps (brewing, adding condiments) are customized by subclasses.

---

## Getting Started

### Prerequisites
- Visual Studio 2017 or later
- .NET Framework

### Running the Examples

1. Clone the repository:
   ```bash
   git clone https://github.com/Robfeb/designpatterns.git
   cd designpatterns
   ```

2. Open any pattern's solution file in Visual Studio:
   ```
   designpatterns/[PatternName]/[PatternName].sln
   ```

3. Build and run the project (F5 or Ctrl+F5)

Each pattern includes a `Program.cs` file with demonstration code showing the pattern in action.

## Repository Structure

```
designpatterns/
├── AdapterPattern/          # Adapter pattern implementation
├── CommandPattern/          # Command pattern implementation
├── DecoratorPattern/        # Decorator pattern implementation
├── FacadePattern/           # Facade pattern implementation
├── FactoryPattern/          # Factory and Abstract Factory patterns
├── Iterator_CompositePatterns/  # Iterator and Composite patterns
├── ObserverPattern/         # Observer pattern implementation
├── SingletonPattern/        # Singleton pattern implementation
├── StatePattern/            # State pattern implementation
├── StrategyPattern/         # Strategy pattern implementation
├── TemplateMethodPattern/   # Template Method pattern implementation
├── .gitignore
└── README.md
```

Each pattern directory contains:
- Solution file (.sln)
- Project file (.csproj)
- Source code organized into Models, Interfaces, and implementation folders
- Program.cs with demonstration code

## Design Pattern Categories

### Creational Patterns
- **Factory Pattern** - Object creation patterns
- **Singleton Pattern** - Controlled instantiation

### Structural Patterns
- **Adapter Pattern** - Interface compatibility
- **Decorator Pattern** - Dynamic functionality addition
- **Facade Pattern** - Simplified interface
- **Composite Pattern** - Tree structures

### Behavioral Patterns
- **Command Pattern** - Request encapsulation
- **Iterator Pattern** - Sequential access
- **Observer Pattern** - Event notification
- **State Pattern** - State-dependent behavior
- **Strategy Pattern** - Algorithm encapsulation
- **Template Method Pattern** - Algorithm skeleton

## Learning Resources

These implementations are inspired by classic design pattern literature:
- "Design Patterns: Elements of Reusable Object-Oriented Software" by Gang of Four
- "Head First Design Patterns" by Freeman & Freeman

## Contributing

Feel free to contribute by:
- Adding new design patterns
- Improving existing implementations
- Adding more examples or test cases
- Improving documentation

## License

This project is for educational purposes.
