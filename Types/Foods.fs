module Types.Foods

open System

type FoodType =
    | Berry
    | SuperBerry

    member this.getFoodValue food =
        match food with
        | Berry -> 1
        | SuperBerry -> 2
    
    member this.Print () =
        Console.Write " "
        Console.BackgroundColor <- ConsoleColor.DarkGreen
        Console.Write "F"
        Console.ResetColor()
        Console.Write " "
