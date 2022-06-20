module EventSource.EventBus


type EventMessage = int * Commands.Command
type EventBusQueue = EventMessage list
type GlobalBus = GlobalBus of EventBusQueue list
