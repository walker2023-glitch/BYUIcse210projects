Written by AI for speed. 

# HR Diagram Classification Engine - README

## Project Overview

The **HR Diagram Classification Engine** is a C# application designed to identify and categorize stars based on their physical properties: Temperature, Luminosity, Radius, and Absolute Magnitude.

The program uses a **hybrid classification approach**:

1. **Manual Physics Strategies:** The engine first attempts to classify stars using hard-coded astronomical rules (e.g., checking if a star's magnitude and temperature match known bounds for Red Dwarfs or Hypergiants).
2. **Machine Learning Fallback:** If a star does not fit any manual rule, the program utilizes an **ML.NET Multiclass Classification model** (trained on verified data) to predict the star's type.

---

## How to Use the Project

### 1. Data Setup

The program relies on two main data files in the root directory:

* **`StarData.txt` (The Litmus Test):** This is the master training file. The AI uses this file to "learn" the relationship between stellar features and their classifications.
* **Target File (e.g., `testData.txt`):** This is the file the user wants to "descramble" or analyze.

**File Format (CSV):**
Both files must include a header and follow this column order:
`Temperature, Luminosity, Radius, AbsoluteMagnitude, StarType, Color, SpectralClass`.

### 2. Running the Program

To run the application, use the .NET CLI in your terminal:

```bash
dotnet run

```

### 3. Application Flow

1. **System Initialization:** The engine loads manual strategies (HyperGiant, SuperGiant, BrownDwarf, etc.) in a specific "priority order" to ensure accurate labeling.
2. **Training:** The `InitializeMLModel()` method trains the AI brain using `StarData.txt` and saves the model as `star_classifier_model.zip`.
3. **User Input:** The program will prompt you to enter the name of the file you wish to analyze (e.g., `testData.txt`).
4. **Analysis:** The engine processes each star, determining its type and calculating its **Spectral Class** (O, B, A, F, G, K, or M) based on its temperature.
5. **Output:** A numbered report is generated and saved to **`OutputMethod.txt`**, detailing every star's type, temperature, luminosity, and spectral classification.

---

## Technical Features

* **Polymorphism:** Different star types (e.g., `SuperGiant`, `WhiteDwarf`) inherit from a base `Star` class and override report generation to provide specific prefixes or data.
* **Encapsulation:** Raw data is parsed into `StarDataRaw` objects for the ML model, while the logic is hidden within the `HertzsprungRussell` engine.
* **Strategy Pattern:** Classification logic is decoupled into separate strategy classes (e.g., `MainSequenceStrategy`), making it easy to add new astronomical rules without changing the main engine.
* **Coordinate Formatting:** The project includes an `AstroCoordinate` helper to format Right Ascension and Declination into standard astronomical notation.

---

## Dependencies

* **.NET 8.0 SDK**
* **Microsoft.ML NuGet Package** (for the machine learning predictor)