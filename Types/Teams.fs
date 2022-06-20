module Types.Teams

open System

type TeamBlue = TeamBlue of ConsoleColor
type TeamRed = TeamRed of ConsoleColor
type TeamType =
    | Blue of TeamBlue
    | Red of TeamRed