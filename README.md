# Notes Manager

### Description

A Windows desktop note-taking app built to solve a simple frustration: traditional text editors require navigating through Windows File Explorer every time you want to switch files.

This app embeds the entire file navigation system directly into the interface—browse folders, create nested directories, and switch between notes instantly without leaving the app. Added basic text scrambling for privacy on shared computers.

### How to Run

**Prerequisites:** Windows, Visual Studio with .NET Framework

**Build & Run:**

1. Open `Notes.sln` in Visual Studio
2. Press F5 (or Build → Start Debugging)

**Usage:**

- Type folder/file names in the text boxes
- Use the "Directories" dropdown to navigate your entire note structure
- Save, load, delete notes without touching File Explorer
- Optional: Use encryption password to scramble text

### What I Learned

- Windows Forms GUI development and event-driven programming
- File I/O operations with `System.IO` (reading, writing, directory traversal)
- Building custom dropdown menus that recursively display nested folder structures
- Honest reflection: The "encryption" is really just scrambling with a character offset algorithm — functional for hiding casual text, but NOT cryptographically secure. Real encryption requires established libraries.
