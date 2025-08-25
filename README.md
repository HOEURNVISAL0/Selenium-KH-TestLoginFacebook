# Selenium-KH-TestLoginFacebook ![Login Icon](https://img.icons8.com/fluency/48/000000/facebook.png)

This repository demonstrates automated login testing for Facebook using Selenium in C#.  
It is designed for educational and QA purposes, showing how to set up Selenium WebDriver, perform test automation, and validate login scenarios.

## 🚀 Features

- Automated Facebook login test case
- Selenium WebDriver integration
- Clean C# codebase
- Easy to extend for other scenarios

## 🛠️ Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) (or any compatible C# IDE)
- [Selenium WebDriver](https://www.selenium.dev/)
- Chrome/Firefox browser & matching WebDriver

### Setup

1. Clone this repository:
   ```bash
   git clone https://github.com/HOEURNVISAL0/Selenium-KH-TestLoginFacebook.git
   ```
2. Open the project in Visual Studio.
3. Restore NuGet packages.

### Running the Test

- Update your Facebook test credentials in the code (never use real ones!).
- Run the test file in your IDE or via CLI:
  ```bash
  dotnet test
  ```

## 📄 Example Usage

```csharp
// Example: LoginTest.cs
[Test]
public void FacebookLoginTest()
{
    // Setup WebDriver
    // Navigate to Facebook
    // Enter username & password
    // Assert login result
}
```

## 📦 Folder Structure

```
Selenium-KH-TestLoginFacebook/
├── TestCases/
│   └── LoginTest.cs
├── Drivers/
├── README.md
└── ...
```

## 🤝 Contributing

Pull requests are welcome!  
Feel free to submit issues or suggestions.

## 📃 License

This project is licensed under the MIT License.

---

> Made with ❤️ by [HOEURNVISAL0](https://github.com/HOEURNVISAL0)
