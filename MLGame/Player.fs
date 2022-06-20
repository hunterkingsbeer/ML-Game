module MLGame.Player

open Types.Players
open Types.Genes
open Types.Teams
open Types.Board

module Initialization =
    let initMinion (team: TeamType) position =
         Minion
            { Team = team
              Position = position
              Size = Size 0
              Genes = GeneSet((Hunter 0, Flee 0), (Social 0, AntiSocial 0), (Hungry 0, Full 0), (Chomp 0, Exploration 0)) }

module Movements =
    type Up = Up of int
    type Down = Down of int
    type Left = Left of int
    type Right = Right of int
    
    let moveUp = Up -1
    let moveDown = Down 1
    let moveLeft = Left -1
    let moveRight = Right 1
    
    type Direction =
        | MoveUp of Up
        | MoveDown of Down
        | MoveLeft of Left
        | MoveRight of Right 
    
    let movePlayer (direction: Direction) (player: Minion) =
        match direction with
        | MoveUp y' -> ""
        | MoveDown y' -> ""
        | MoveLeft x' -> ""
        | MoveRight x' -> ""

module Food =
    type Discard = Discard 
    type Chomp = Chomp
    type FoodDecision =
        | DiscardFood of Discard
        | ChompFood of Chomp 
        member this.lookAtFood (decision: FoodDecision) (player: Minion) =
            ""
        
module Fight =
    type Attack = Attack of int
    type Flee = Flee of int
    
    type FightDecision =
        | AttackEnemy of Attack
        | FleeEnemy of Flee
        
        member this.faceEnemy (decision: FightDecision) (player: Minion) =
            ""