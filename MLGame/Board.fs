module MLGame.Board

open System

open MLGame.Misc
open MLGame.Player

open Types.Board
open Types.Foods
open Types.Teams

let generateXYPositions (boardSettings: Settings) numPositions =
    let r = Random()

    let xValues =
        r.GetValues(0, boardSettings.BoardSize.x)
        |> Seq.take numPositions
        |> Seq.toList

    let yValues =
        r.GetValues(0, boardSettings.BoardSize.y)
        |> Seq.take numPositions
        |> Seq.toList

    List.zip xValues yValues

let printBoard (board: BoardInstance) (boardSettings: Settings) =
    let printItem (item: BoardItem) =
        match item with
        | Minion minion -> minion.Print()
        | Food food -> food.Print()
        | Empty -> Console.Write " _ "

    for x in 0 .. boardSettings.BoardSize.x - 1 do
        for y in 0 .. boardSettings.BoardSize.y - 1 do
            let item = board[x, y]
            printItem item

        Console.WriteLine()

let mutable numPlayersInitialized = 0 // TODO need to find a better way to do this

let initializeBoardPosition x y playerPositions foodPositions : BoardItem =
    let isInitFirstTeam numPlayers = numPlayersInitialized > numPlayers / 2

    if playerPositions |> List.contains (x, y) then
        numPlayersInitialized <- numPlayersInitialized + 1

        let teamColor =
            if isInitFirstTeam playerPositions.Length then
                TeamBlue(ConsoleColor.Blue) |> TeamType.Blue
            else
                TeamRed(ConsoleColor.Red) |> TeamType.Red

        Initialization.initMinion teamColor {| x = x; y = y |}
    else if foodPositions |> List.contains (x, y) then
        Food Berry
    else
        Empty

let initializeBoard boardSettings : BoardInstance =
    let playerPositions: (int * int) list =
        let numPlayers = boardSettings.PlayersPerTeam * 2
        generateXYPositions boardSettings numPlayers

    let foodPositions: (int * int) list =
        generateXYPositions boardSettings boardSettings.NumFood

    let board =
        Array2D.init
            boardSettings.BoardSize.x
            boardSettings.BoardSize.y
            (fun x y -> initializeBoardPosition x y playerPositions foodPositions)

    numPlayersInitialized <- 0

    board
