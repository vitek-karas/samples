.NET Core PInvoke Marshalling Sample
================

This project demonstrates different ways to marshall arguments to native function when using PInvokes. Documentation can be found here for [PInvokes](https://docs.microsoft.com/en-us/dotnet/standard/native-interop/pinvoke) and here for the [Type marshalling](https://docs.microsoft.com/en-us/dotnet/standard/native-interop/type-marshaling).

Prerequisites
------------

* .NET Core 3.0 (at least Preview 6) - [https://dot.net](https://github.com/dotnet/core-sdk#installers-and-binaries)

* C++ compiler
  * Windows: `cl.exe`
  * Linux/OSX: `g++`

Build and Run
-------------

1) In order to build and run, all prerequisites must be installed. The following are also required:

    * The C++ compiler (`cl.exe` or `g++`) must be on the path.
      * On Windows, a [Developer Command Prompt for Visual Studio](https://docs.microsoft.com/cpp/build/building-on-the-command-line#developer_command_prompt_shortcuts) should be used.
    * The C++ compiler (`cl.exe` or `g++`) and `dotnet` must be the same bitness.
      * On Windows the default developer command prompt for VS is using the 32bit compilers but `dotnet` is typically 64bit by default, make sure to pick the "x64 Native Tools Command Prompt for Visual Studio".

1) Navigate to the root directory and run `dotnet build`

1) Run the samples

    * Either use `dotnet run` (which will build and run at the same time)
    * Or the executable will be in `bin` under a subdirectory for the configuration (`Debug` is the default).
        * Windows: `bin\Debug\MarshallingSample.exe`
        * Non-Windows: `bin/Debug/MarshallingSample`
