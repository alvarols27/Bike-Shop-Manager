# MyBikes - Bike Management System

A Windows Forms application built with C# and .NET 8.0 for managing different types of bicycles with full CRUD operations and XML persistence.

![MyBikes Logo](bikelog.gif)

## 📋 Overview

MyBikes is a desktop application that allows users to manage a collection of bicycles. The system supports four different bike types (Road, Mountain, Electric, and Hybrid) with specific attributes for each type. The application demonstrates object-oriented programming principles including inheritance, polymorphism, interfaces, and serialization.

## Features

- **User Authentication**: Secure login system (default credentials: `user1` / `123`)
- **Multi-Type Bike Support**: 
  - Road bikes with seat height specifications
  - Mountain bikes with suspension types and ground clearance
  - Electric bikes with battery indicators
  - Hybrid bikes with urban/leisure classifications
- **CRUD Operations**: Create, Read, Update, and Delete bike records
- **Data Persistence**: Save and load bike collections to/from XML files
- **Advanced Filtering**: View bikes by specific type or view all bikes
- **Speed Management**: Each bike type has different maximum speeds
- **Data Validation**: Built-in date validation and input checking
- **Visual Interface**: User-friendly Windows Forms GUI

## 🏗️ Architecture

### Object-Oriented Design

The application follows solid OOP principles:

- **Abstract Base Class**: `Bike` - defines common properties and abstract methods
- **Inheritance**: Specialized bike types (`Road`, `Mountain`, `Electric`, `Hybrid`) inherit from `Bike`
- **Interfaces**: 
  - `IMovable` - defines movement behavior (speed control)
  - `IPrintable` - defines display behavior (state representation)
- **Polymorphism**: 
  - Static polymorphism through constructor overloading
  - Dynamic polymorphism through method overriding (`GetState()`, `SpeedUp()`, `GetMaxSpeed()`)

### Project Structure

```
MyBikes2/
├── bus/                          # Business logic layer
│   ├── Bike.cs                   # Abstract base class
│   ├── Road.cs                   # Road bike implementation
│   ├── Mountain.cs               # Mountain bike implementation
│   ├── Electric.cs               # Electric bike implementation
│   ├── Hybrid.cs                 # Hybrid bike implementation
│   ├── IMovable.cs               # Movement interface
│   ├── IPrintable.cs             # Display interface
│   ├── DataCollection.cs         # Collection management
│   ├── FileManager.cs            # XML serialization
│   ├── Date.cs                   # Custom date struct
│   ├── EnumBikeType.cs           # Bike type enumeration
│   ├── EnumColor.cs              # Color enumeration
│   ├── EnumFrameType.cs          # Frame type enumeration
│   ├── EnumHybridType.cs         # Hybrid type enumeration
│   └── EnumSuspension.cs         # Suspension enumeration
├── user/                         # Presentation layer
│   ├── LoginForm.cs              # Login form
│   ├── LoginForm.Designer.cs     # Login form designer
│   ├── Form1.cs                  # Main application form
│   └── Form1.Designer.cs         # Main form designer
├── Properties/
│   ├── Resources.resx            # Resource file
│   └── Resources.Designer.cs     # Resource designer
├── data/
│   └── bikes.xml                 # XML data file
└── Program.cs                    # Application entry point
```

## 🚀 Getting Started

### Prerequisites

- .NET 8.0 SDK or later
- Windows OS (Windows Forms application)
- Visual Studio 2022 or later (recommended)

### Installation

1. Clone the repository:
```bash
git clone https://github.com/yourusername/mybikes.git
cd mybikes
```

2. Open the solution in Visual Studio:
```bash
start MyBikes2.csproj
```

3. Restore NuGet packages:
```bash
dotnet restore
```

4. Build the project:
```bash
dotnet build
```

5. Run the application:
```bash
dotnet run
```

### Default Login Credentials

- **Username**: `user1`
- **Password**: `123`

## 💻 Usage

### Adding a Bike

1. Select the bike type from the dropdown
2. Fill in the required fields:
   - Serial Number
   - Manufacturer
   - Model
   - Speed
   - Wheel Size
   - Frame Type
   - Color
   - Manufacturing Date (day/month/year)
   - Type-specific fields (e.g., seat height for road bikes)
3. Click "Add" to save the bike to the collection

### Managing Bikes

- **View All Bikes**: Display all bikes in the collection
- **Filter by Type**: View bikes of a specific type
- **Edit**: Modify existing bike information
- **Delete**: Remove a bike from the collection
- **Save**: Persist changes to XML file
- **Load**: Import bikes from XML file

### Speed Controls

Each bike type has a maximum speed:
- Road bikes: 40 km/h
- Electric bikes: 28 km/h
- Hybrid bikes: 25 km/h
- Mountain bikes: 20 km/h (default)

## 📊 Data Model

### Bike Base Class Properties

- Serial Number
- Manufacturer
- Model
- Current Speed
- Wheel Size
- Frame Type (Aluminum, Steel, Carbon Fiber, Titanium)
- Manufacturing Date
- Color (Red, Green, Blue, Yellow, Orange, Pink)
- Bike Type

### Specialized Properties

**Road Bike**:
- Seat Height

**Mountain Bike**:
- Suspension Type (Front, Rear, Front and Rear)
- Height from Ground

**Electric Bike**:
- Battery Indicator (%)

**Hybrid Bike**:
- Hybrid Type (Urban, Leisure)

## 🔧 Technical Details

### Serialization

The application uses XML serialization for data persistence:
- Bikes are serialized to `data/bikes.xml`
- Supports all bike types through XML type inclusion
- Automatic serialization/deserialization on save/load

### Design Patterns

- **Factory Pattern**: Object creation in `DataCollection.Search()`
- **Repository Pattern**: `DataCollection` acts as a data repository
- **Singleton-like behavior**: Static list in `DataCollection`

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 🙏 Acknowledgments

- Built as a demonstration of OOP principles in C#
- Windows Forms for GUI implementation
- XML Serialization for data persistence
