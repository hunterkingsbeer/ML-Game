module Application.Program

open Types.Board
open MLGame.Board

(*
open EventSource.EventBus
open MLGame.Player.Fight
open EventSource.Commands

let attackDecision: FightDecision = AttackEnemy(Attack 1)
let command: Command = Action (Player.FightDecision attackDecision)
let event: EventMessage = EventMessage (0, command)
let eventBus: EventBusQueue = [event]
let mutable globalBus: GlobalBus = GlobalBus [eventBus]
*)

[<EntryPoint>]
let main _ =
    let boardSettings: Settings =
        { BoardSize = {| x = 25; y = 25 |}
          NumFood = 25
          PlayersPerTeam = 25 }
    
    let board = initializeBoard boardSettings
    printBoard board boardSettings
    
    0