# Auto Crypto Miner

A app that automatically starts your desired Mining application after desired time of inactivity has passed.
When you resume using your computer the app will automatically close the Miner. You can also run custom scripts when miner starts/stops.

## Getting Started

Download the precompilede AutoCryptoMine .exe to your windows pc from the releases section [HERE](https://github.com/GitMag/AutoCryptoMine/releases).

If you want the newest version  read the installation section.

## Installation

You only need this guide if you want to compile the program yourself and want the newest version(may be unstable)!
```
Copy this repository to your computer(Clone or download --> Download as ZIP)
Extract the zip and navigate to Automine\Automine.csproj with Visual Studio 2015 or newer
Compile
Done!
```
## Features:
Basic features:
```
Set the time before starting mining app
set Mining app
Set Config file for mining app
Set custom script to execute when starting
Set custom script to execute when stopping
```
Advanced features:
```
Profiler:
Allows you to create custom profiles by day and time. 
```
Read more about profiler in the Profiler section of Usage.

##Usage/configuration

Basic usage:
```
Start AutoMine.exe
```
Basic settings:
```
Look for Auto Crpto Mine Notifyicon and right click --> settings
Configure the inactivity time before opening miner
Select where your miner is located
Select where your config file is located
Save and you are done!
```
Advanced settings:
```
Click advanced settings in the settings menu
Custom Run script and Close script:
Allows you to run custom scripts/programs when starting/stopping miner.
Save and you are done!
```
Profiler:
```
Allows you to create custom profiles by day and time. 
To open profiler Click the Profiler tab in the settings menu
Example profiles:
Work profile, Run X miner with X config and execute X custom start and stop script on Monday, Tuesday, Wednesday, Thursday, Friday from 08:00 to 17:00
Evening profile: Run Run X miner with X config and execute X custom start and stop script on Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday from 17:01 to 23:59
The possibiliteis are endless.
Enable profiler by clicking advanced settings from settigns menu --> Enable profiler checkbox
```
### Prerequisites

```
.NET Framework 4.5.2 or newer.
Windows or WINE(may not be stable)
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details
