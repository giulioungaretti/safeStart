module Index

open Elmish
open Thoth.Fetch

open Fable.React
open Fable.React.Props

open Shared


type Msg = GotHello of string

let init () =
    let model: Model = { Hello = "" }
    let getHello () = Fetch.get<unit, string> Route.hello

    let cmd =
        Cmd.OfPromise.perform getHello () GotHello

    model, cmd

let update msg model =
    match msg with
    | GotHello hello -> { model with Hello = hello }, Cmd.none


let view model dispatch =
    div [ Style [ TextAlign TextAlignOptions.Center
                  Padding 40 ] ] [
        div [] [
            img [ Src "favicon.png" ]
            h1 [] [ str "safeMin" ]
            h2 [] [ str model.Hello ]
        ]
    ]
