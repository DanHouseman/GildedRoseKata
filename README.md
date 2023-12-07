# Gilded Rose C# Solution

The provided code implements the Gilded Rose inventory management system, which handles the quality and sell-in days of various items. The design patterns, principles, and methodologies employed in this code:

### Design Patterns:
1.	Strategy Pattern:
-	The code utilizes a strategy pattern through the IItemUpdater interface and its implementations (RegularItemUpdater, AgedBrieUpdater, BackstagePassUpdater, ConjuredItemUpdater, SulfurasItemUpdater). Each item type has its updater strategy, allowing flexibility in extending and modifying the behavior of different item categories.
2.	Factory Pattern:
-	The ItemUpdaterFactory serves as a simple factory pattern, encapsulating the logic for creating the appropriate IItemUpdater based on the item’s name. This centralizes the decision-making process for choosing the correct updater strategy.

### Principles:
1.	SOLID Principles:
-	Single Responsibility Principle (SRP):
-	Each class has a single responsibility, such as updating the quality of a specific item type.
-	Open/Closed Principle (OCP):
-	The code is open for extension, allowing for the addition of new item types without modifying existing code (evident in the use of strategy pattern and factory pattern).
-	Liskov Substitution Principle (LSP):
-	The IItemUpdater interface ensures that each concrete updater can be substituted for one another.
-	Interface Segregation Principle (ISP):
-	Interfaces (IItemUpdater) are tailored to the needs of specific item types, avoiding unnecessary methods in implementing classes.

### Methodologies:
1.	DRY (Don’t Repeat Yourself):
-	The code attempts to follow the DRY principle by encapsulating common item updating logic in the BaseItemUpdater, shared by various item type updaters.
2.	Composition over Inheritance:
-	Instead of using inheritance to share behavior, the code employs composition by having a separate class (ConjuredItemUpdater) handle specific logic without relying on the abstract base class’s method.

### Reasoning:
1.	Maintainability and Extensibility:
-	The strategy pattern and factory pattern enhance maintainability and extensibility. Adding new item types or modifying existing ones can be done without altering the existing code extensively.
2.	Readability and Clarity:
-	The code aims for readability and clarity through the use of descriptive class and method names. The separation of concerns ensures that each class is focused on a specific aspect of the system.
3.	Flexibility:
-	The design allows for easy modification of individual item behavior, making it flexible to adapt to potential future changes in requirements.
4.	Testability:
-	The code’s structure makes it amenable to unit testing. Each updater strategy can be tested independently, and the factory pattern simplifies the creation of test scenarios.

The code follows object-oriented design principles, embraces flexibility through design patterns, and emphasizes readability and maintainability for long-term viability. The use of composition over inheritance and adherence to SOLID principles contribute to a modular and extensible architecture.

## ALL TESTS PASS



## Build the project

Use your normal build tools. 

## Run the TextTest fixture from the Command-Line

For e.g. 10 days:

```
GildedRoseTests/bin/Debug/net7.0/GildedRoseTests 10
```

You should make sure the command shown above works when you execute it in a terminal before trying to use TextTest (see below). If your tooling has placed the executable somewhere else, you will need to adjust the path above.


## Run the TextTest approval test that comes with this project

There are instructions in the [TextTest Readme](../texttests/README.md) for setting up TextTest. You will need to specify the GildedRoseTests executable and interpreter in [config.gr](../texttests/config.gr). Uncomment this line:

    executable:${TEXTTEST_HOME}/csharpcore/GildedRoseTests/bin/Debug/net7.0/GildedRoseTests

