# AStar Navigator [![Build status](https://ci.appveyor.com/api/projects/status/fu2jsiaylryisy5t?svg=true)](https://ci.appveyor.com/project/WichardRiezebos/astar)
Portable NuGet library/package for navigating on a tile-based 2-dimensional raster/matrix.

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

