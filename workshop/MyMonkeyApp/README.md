# MyMonkeyApp

A C# console application that provides information about various monkey species around the world.

## Features

- **List all monkeys**: View details about all 17 monkey species in the database
- **Search by name**: Find specific monkey species by their name (case-insensitive)
- **Random monkey**: Get a randomly selected monkey with fun ASCII art
- **Interactive menu**: Easy-to-use command-line interface
- **ASCII art**: Visual appeal with monkey-themed ASCII art throughout the app

## Requirements

- .NET 9.0 SDK
- C# 13

## How to Run

1. Navigate to the application directory:
   ```bash
   cd workshop/MyMonkeyApp
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. Follow the on-screen menu to interact with the application:
   - Press `1` to list all monkeys
   - Press `2` to search for a monkey by name
   - Press `3` to get a random monkey
   - Press `4` to exit the application

## Project Structure

- **Monkey.cs**: Model class representing a monkey species with properties like Name, Location, Population, etc.
- **MonkeyHelper.cs**: Static helper class that manages the monkey data collection and provides methods to retrieve monkeys
- **Program.cs**: Main application with interactive menu and ASCII art

## Monkey Species Included

The application includes information about 17 monkey species from around the world:

1. Baboon (Africa & Asia)
2. Capuchin Monkey (Central & South America)
3. Blue Monkey (Central and East Africa)
4. Squirrel Monkey (Central & South America)
5. Golden Lion Tamarin (Brazil)
6. Howler Monkey (South America)
7. Japanese Macaque (Japan)
8. Mandrill (Southern Cameroon, Gabon, Equatorial Guinea, and Congo)
9. Proboscis Monkey (Borneo)
10. Red-shanked douc (Vietnam, Laos)
11. Gray-shanked douc (Vietnam)
12. Golden Snub-nosed Monkey (China)
13. Black Snub-nosed Monkey (China)
14. Tonkin Snub-nosed Monkey (Vietnam)
15. Thomas's langur (Indonesia)
16. Purple-faced Langur (Sri Lanka)
17. Gelada (Ethiopia)

## Code Standards

This project follows C# 13 and .NET 9 coding standards:

- PascalCase for class names, method names, and properties
- camelCase for local variables and parameters
- XML documentation comments for public classes and methods
- File-scoped namespaces
- Nullable reference types enabled
- Separation of concerns between UI and business logic

## License

This is a sample application created for educational purposes.
