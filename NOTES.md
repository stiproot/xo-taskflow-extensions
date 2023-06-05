
### There needs to types of node abstratctions in a flow
1. A movement
2. A functory


MoveTo -> movement
Then -> movement

If<T> -> Then<R> // If defines binary functory, Then defines the true-conditional transition.
If<T> -> If<R> // true-conditional is implicit.

If<T> -> Pool<X, Y, Z> : Else<R> // if, then, else
If<T> -> Pool<X, Y, Z> // if, then
If<T> -> Else<R> // if, else



If -> binary branch node




