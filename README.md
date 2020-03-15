# BattleShipStateTracker
BattleShip game in .Net core using c#

This is WebAPI project for creating BattleShip Game board with the followings
### Models: 
- 2 Players
- 2 Boards for each player
  - OceanBoard (This is the 10*10 Game board where the ships would be placed)
  - TargetBoard (This is the 10*10 Target board where the Red/White Pegs get placed notifying Hit/Miss)
- 5 Ships for each player
  - Battleship
  - Carrier
  - Cruiser
  - Destroyer
  - Submarine 


### Game Rules
  This is a classic “Battleship” Game with
  • Two players
  • Each have a 10x10 board
  • During setup, players can place an arbitrary number of “battleships” on their board. 
  • The ships are 1-by-n sized, must fit entirely on the board, and must be aligned either vertically or horizontally.
  • During play, players take turn “attacking” a single position on the opponent’s board, and the opponent must respond by either reporting a “hit” on one of their battleships (if one occupies that position) or a “miss”
  • A battleship is sunk if it has been hit on all the squares it occupies
  • A player wins if all of their opponent’s battleships have been sunk.
  
## Structure
- Solution contains two projects 
  - BattleShipStateTracker - the BattleShip Project
  - BattleShipStateTrackerTest - the Unit test Project using xunit
- /Controllers: WebAPI controller with basic method (GET)
- /Extenstions: Contains C# extension methods
- /Models: contains different data models
- /Properties: launch settings

## Requirements
- Visual Studio
- .Net Core 3.1
- C#

### Clone this project

```
git clone https://github.com/jiteshkaranjkar/BattleShipStateTracker.git
```
### Setup
If git is not installed automatically on your mac, follow these instructions:

1. Download Mac installer: https://git-scm.com/download/mac
2. Double click the installer to start the installation.
3. Use Visual Studio possibly latest version
4. Open the cloned project

### Building
- Open Visual Studio -> Build -> Build All

### Execution
- Open Visual Studio -> Run -> Start Without Debugging

### Testing
- Open BattleShipStateTrackerTest project -> open Test Explorer -> Run all tests

## Current Implementation
The current implementation of the game is to just implement a Battleship state tracking API for a single player that must support the following logic:
• Create a board
• Add a battleship to the board
• Take an “attack” at a given position, and report back whether the attack
resulted in a hit or a miss.
The API does not support the entire game, just the state tracker. No graphical interface or persistence layer is been implemented.

##Tried to upload this application in Cloud using AWS BeanStalk and Lambda,SAM CLI, but was unsuccessful.
###Beanstalk - Tried a couple of times but was getting Errors in deployment
  ERROR - Create environment operation is complete, but with errors. For more information, see troubleshooting documentation.
  2020-03-14 13:33:29 UTC+1100	
  WARN - Environment health has transitioned from Ok to Degraded. Command failed on all instances. Initialization completed 22 seconds ago and took 4 minutes.
  2020-03-14 13:33:06 UTC+1100	
  INFO - Command execution completed on all instances. Summary: [Successful: 0, Failed: 1].
  2020-03-14 13:33:06 UTC+1100	
  ERROR - [Instance: i-0398cfcd8ec5b9773 ConfigSet: Infra-EmbeddedPreBuild, Hook-PostInit, Hook-PreAppDeploy, Infra-EmbeddedPostBuild, Hook-EnactAppDeploy, Hook-PostAppDeploy, Infra-WriteVersionOnStartup] Command failed on instance. Return code: 1 Output: null.
  2020-03-14 13:33:02 UTC+1100	
  ERROR - Error occurred during build: Command hooks failed



###Lambda - Following are the error getting when deploying the codebase using SAM-CLI
  Starting SAM Application deployment...
  Building SAM Application...
  Packaging SAM Application to S3 Bucket: amplifyawsapp-20181213170826-deployment
  Deploying SAM Application to CloudFormation Stack: battleshipgame
  Error: Error with child process: Usage: sam deploy [OPTIONS]
  Try "sam deploy --help" for help.

  Error: Invalid value for "--parameter-overrides":  AppId= is not in valid format. It must look something like 'ParameterKey=KeyPairName,ParameterValue=MyKey ParameterKey=InstanceType,ParameterValue=t1.micro' or 'KeyPairName=MyKey InstanceType=t1.micro'
  Deploy failed
  An error occurred while deploying a SAM Application. Check the logs for more information by running the "View AWS Toolkit Logs" command from the Command Palette.
  Starting SAM Application deployment...
  Building SAM Application...
  Packaging SAM Application to S3 Bucket: amplifyawsapp-20181213170826-deployment
  Deploying SAM Application to CloudFormation Stack: BattleShipGame
  Error: Error with child process: Usage: sam deploy [OPTIONS]
  Try "sam deploy --help" for help.

  Error: Invalid value for "--parameter-overrides":  AppId= is not in valid format. It must look something like 'ParameterKey=KeyPairName,ParameterValue=MyKey ParameterKey=InstanceType,ParameterValue=t1.micro' or 'KeyPairName=MyKey InstanceType=t1.micro'
  Deploy failed
  An error occurred while deploying a SAM Application. Check the logs for more information by running the "View AWS Toolkit Logs" command from the Command Palette.

