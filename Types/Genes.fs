module Types.Genes

type Hunter = Hunter of int
type Flee = Flee of int
type Social = Social of int
type AntiSocial = AntiSocial of int
type Hungry = Hungry of int
type Full = Full of int
type Chomp = Chomp of int
type Exploration = Exploration of int

type Gene =
    | HunterGene of Hunter
    | FleeGene of Flee 
    | SocialGene of Social
    | AntiSocialGene of AntiSocial
    | HungryGene of Hungry
    | FullGene of Full
    | ChompGene of Chomp
    | ExplorationGene of Exploration

    member this.getGene =
        match this with
        | HunterGene (Hunter hunter) -> hunter
        | FleeGene (Flee flee) -> flee
        | SocialGene (Social social) -> social
        | AntiSocialGene (AntiSocial anti) -> anti
        | HungryGene (Hungry hungry) -> hungry
        | FullGene (Full full) -> full
        | ChompGene (Chomp chomp) -> chomp
        | ExplorationGene (Exploration explore) -> explore

type GeneSet = (Hunter * Flee) * (Social * AntiSocial) * (Hungry * Full) * (Chomp * Exploration)
