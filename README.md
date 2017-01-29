# AStar Navigator 
 
Portable NuGet library/package for navigating on a tile-based 2-dimensional raster/matrix.

| | |
| --- | --- |
| **Build** | [![Build](https://ci.appveyor.com/api/projects/status/fu2jsiaylryisy5t?svg=true)](https://ci.appveyor.com/project/WichardRiezebos/astar) |
| **NuGet** | [![NuGet](https://buildstats.info/nuget/AStarNavigator)](https://www.nuget.org/packages/AStarNavigator/) |
| **Gitter** | [![Join the chat at https://gitter.im/astar-navigator/Lobby](https://badges.gitter.im/astar-navigator/Lobby.svg)](https://gitter.im/astar-navigator/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) |

## Installation

Install the NuGet package using the command below,

```
Install-Package AStarNavigator
```

. . . or search for `AStarNavigator` in the NuGet index.

## Getting started
The code below is an example how to use the library.

```
using AStarNavigator;
using AStarNavigator.Algorithms;
using AStarNavigator.Providers;

var navigator = new TileNavigator(
    new EmptyBlockedProvider(),         // Instance of: IBockedProvider
    new DiagonalNeighborProvider(),     // Instance of: INeighborProvider
    new PythagorasAlgorithm(),          // Instance of: IDistanceAlgorithm
    new ManhattanHeuristicAlgorithm()   // Instance of: IDistanceAlgorithm
);

var from = new Tile(1, 2);
var to = new Tile(20, 22);

var result = navigator.Navigate(from, to); 
```
