# BFS and DFS Visualizer in Graph

Finding the paths — and especially the shortest path — between two nodes is a well-studied problem in graph theory. This is because paths in a graph are frequently an interesting property. In the three jugs problem, a path from the start node to any node with 6 liters of water in one jug represented a solution to the riddle. In a social network, a path might show us how two people are connected, and the length of the shortest path between two people might tell us something about the social distance between them. In a graph representing roadways, the shortest path between two nodes might very literally represent the shortest path between two places.

Two of the oldest yet most famous graph search algorithms are Breadth First Search (BFS) and Depth First Search (DFS). These Two algorithms are both simple, and they are pretty similar. With both algorithms, we explore individual nodes — one by one — until we find a node matching a particular condition.

Consistent with Depth First Search, first, we should specify the start node. Now, arbitrarily pick one of that node’s neighbors and go there. If that node has neighbors, arbitrarily pick one of those and go there unless we’ve already seen that node. And we repeat this process until one of two things happens. If we reach the specified end node, we terminate the algorithm and report success. If we reach a node with only neighbors we’ve already seen or no neighbors at all, we go back one step and try one of the neighbors we didn’t try last time.

The only difference between DFS and BFS is the order in which nodes are processed. In DFS, we prioritize the deepest node in the frontier; in BFS, we do the opposite. We explore all the neighbors of our starting node before exploring any other node. After we have explored all the immediate neighbors, we explore nodes that are two hops away from the starting node. Then three hops, then four hops, and so on.

## References

Tyler Elliot Bettilyon. (2019, February 7). Breadth First Search and Depth First Search. In _Medium – Where good ideas find you_. Retrieved 10:07, August 4, 2022, from [https://medium.com/tebs-lab/breadth-first-search-and-depth-first-search-4310f3bf8416](https://medium.com/tebs-lab/breadth-first-search-and-depth-first-search-4310f3bf8416)

## License
This project is licensed under the terms of the [MIT license](https://github.com/sprbpr/bfs-dfs-visualizer-in-graph/blob/main/LICENSE).
