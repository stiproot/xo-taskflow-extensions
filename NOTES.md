
## Node Types
### There needs to types of node abstratctions in a flow
1. A movement
2. A functory

In most cases, the movement is implicit...

Examples:
Then<T> is a movement, but a default node can be inferred
MoveTo -> movement, but a target node needs to be specified

## Node Traversal
### Root
Root<T> // specifies the root node, that will be awaited

Root<T>(c => c.Arg<Y>()) // Y results in an argument for T: T.t(Y.y) [in-review]
Root<T>().AsArg<Y>() // Linked Node is implied with, with Y requiring result [in-review]
Root<T>().AsArgs<X, Y>() // Pool Node is implied with, with X and Y both requiring results (unless opted out) [in-review]




## Conditional Nodes
### If
If<T> -> Then<R> // If defines binary functory, Then defines the true-conditional transition.
If<T> -> If<R> // true-conditional is implicit.

If<T> -> Pool<X, Y, Z> : Else<R> // if, then, else
If<T> -> Pool<X, Y, Z> // if, then
If<T> -> Else<R> // if, else

## Building
### 
```c#
var flow = builder
    .Root<IY_OutConstBool_SyncService>()
    .If<IY_InBool_OutBool_AsyncService>(
        b => b
            .Then<IY_InBoolStr_OutConstInt_AsyncService>(
                c => c
                    .RequireResult()
                    .AddArg("simon", "args")),
        b => b.Else<IService>(),
        c => c.RequireResult()
    );

var node = flow.Build();
```

FlowBuilder to NodeBuilder:
    Root() -> Binary().True().False();

Each call needs to build a node, which gets propogated "up"... to be continued.

