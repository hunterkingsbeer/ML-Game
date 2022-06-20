module EventSource.Commands

open MLGame.Player.Movements
open MLGame.Player.Food
open MLGame.Player.Fight 

module Player =
    type Count = Count of unit
    type Action =
        | Direction of Direction
        | FoodDecision of FoodDecision
        | FightDecision of FightDecision
        
type Command =
    | Action of Player.Action
    // further commands to be added 
    