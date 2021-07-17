# StoryDev Editor
StoryDev is an interactive story designer and development environment primarily for use in video games.

Current features include:

 * Ability to manage data for interactive stories, saved as JSON files which can be used in other projects.
 * Create and manage conversations using an interactive semi-linear approach to story design.
 * Write your stories using simple syntax. The project [sd2](https://github.com/storydev/sd2) can be used to parse your stories with the Haxe programming language.
 * Create and design maps for a visual aid to managing your story, as well as being a method for designing and creating Places and Sections.
 * Simulation options to allow debugging of your conversations -- know at any point in your story what your Best and Worst outcomes will be.

## Installation
To install the Software, you must have .NET Framework 4.7.2 or later installed. You must also have a Windows operating system that supports this version of the .NET Framework.

You can download and install the runtime [here](https://dotnet.microsoft.com/download/dotnet-framework/net472). Windows 10 comes with .NET Framework 4.7 already installed.

## Beta
As this is a Beta, please note that not all features have been implemented or certain features may appear missing or incomplete.

However, we will accept Issues for problems that occur with any existing feature, so please feel free to post an Issue if need be.

## Roadmap
Our current roadmap is as follows:

 * Record Simulations - that is to save a currently active simulation state (either Best or Worst Outcomes) and use it to compare with other Simulations.
 * Script Manager - the ability to create and manage scripts as if coding in the Haxe environment for StoryDev using the JavaScript Interpreter as the code testing library.
 * Scene Designer - the ability to create and manage 2D scenes for use in a video game, generating Kha-appropriate code for Haxe and using the Twinspire Core framework.
 * Project Validating - validate all the code in the project, including conversations, and ensure that any missing items are filled in.
 * Building - build the project, i.e., generate code, pack resources and compile into an executable.

## Documentation
On the [Twinspire website](https://twinspirefw.com/), you will find relevant articles relating to the development of StoryDev which can serve as documentation.

Official documentation on this project will come after the editor has gone through it's Beta phase.

## License
The StoryDev Editor has been released under our own open source license.

Please see the license in this project for more details.