# TerminalCalculator

![Build Status](https://github.com/Ooperalta/terminal-calculator/actions/workflows/build.yml/badge.svg)

A simple and straightforward terminal calculator built in C# (.NET 9).

## ✨ Features

- **Four basic operations:** addition (`+`), subtraction (`-`), multiplication (`*`), and division (`/`).
- **Two input modes:** choose an operation from an interactive menu or type the full expression at once (e.g., `12,5 + 4`).
- **Decimal support:** accepts numbers with commas.
- **History:** view the calculations performed during your session.

## 🚀 How to Download and Use

You do not need .NET installed to run the calculator.

1. Go to the [Releases page](https://github.com/Ooperalta/terminal-calculator/releases).
2. Download the file for your operating system:
   - **Windows:** `TerminalCalculator-Windows.exe`
   - **Linux:** `TerminalCalculator-Linux`
   - **macOS:** `TerminalCalculator-macOS`
3. Run the program:
   - **Windows:** double-click the downloaded file.
   - **Linux / macOS:** open your terminal in the download folder and grant execution permission (replace the filename for your OS):
     ```bash
     chmod +x TerminalCalculator-Linux
     ./TerminalCalculator-Linux
     ```

## 🛠️ Running from Source

If you have the **.NET 9 SDK** installed and want to run the project directly from the source code:

```bash
git clone (git@github.com:Ooperalta/terminal-calculator.git)
cd Terminal-calculator/TerminalCalculator
dotnet run
```
