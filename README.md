# C# Console Text Editor

## Description

This is a C# console text editor application, designed to reinforce skills in file manipulation, string processing, input/output handling, and interactive menu systems in a terminal-based environment. The application allows users to open existing text files, create new ones, and save changes directly through a simple console interface. It's part of a learning portfolio and serves as a foundational exercise in building practical, real-world applications using C#.

## Features

- Interactive menu with numeric selection
- Open and read existing .txt files
- Create and edit new text files
- Save files to a specified location
- Input validation for menu options
- ESC key detection to exit editing mode

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) (version 6.0 or higher recommended)
- A terminal or command prompt
- (Optional) Visual Studio Code or another C# compatible IDE

## How to Run

1. **Clone the repository:**

   ```bash
   git clone https://github.com/alfredo-petri/csharp-console-text-editor.git
cd csharp-console-text-editor
    ```

2. **Build the project:**

    ```bash
    dotnet build
    ````

3. **Run the application:**

    ```bash
    cd TextEditor
    dotnet run
    ```

## Future Improvements

- Enhance file open/save functions to support:
    - File selection from a directory listing (no manual path input required)
    - Suggested paths or recent file history
- Add "Edit existing file" option to update content in-place
- Display file size and last modified date before opening
- Improved error handling for file paths and read/write permissions
- Support for different file formats (e.g., .md, .csv, .json)
- Undo/redo functionality during editing
- Text search and replace features

## License
This project is licensed under the MIT License. See the [LICENSE](https://github.com/alfredo-petri/csharp-console-text-editor/blob/main/LICENSE) file for details.


