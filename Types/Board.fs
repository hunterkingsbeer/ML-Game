module Types.Board

type BoardItem =
    | Minion of Players.Minion
    | Empty 
    | Food of Foods.FoodType
    
type BoardInstance = BoardItem [,]

type Settings =
    { BoardSize: {| x: int; y: int |}
      NumFood: int
      PlayersPerTeam: int }