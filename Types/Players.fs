module Types.Players

open System
open Types.Teams

type Size = Size of int // 1, 2 or 3.

type Minion =
    { Team: TeamType
      mutable Position: {| x: int; y: int |}
      mutable Size: Size
      mutable Genes: Genes.GeneSet }
    member this.GetSize =
        match this.Size with
        | Size s -> s

    member this.Print () =
        Console.Write " "

        Console.BackgroundColor <-
            match this.Team with
            | Blue (TeamBlue colorRed) -> colorRed
            | Red (TeamRed colorBlue) -> colorBlue

        Console.Write "M"
        Console.ResetColor()
        Console.Write " "
