module Index

open Elmish
open Thoth.Fetch

open Fable.React
open Fable.React.Props

open Shared


type Msg = GotHello of Result<Model,FetchError>

let init () =
    let model: Model = { Hello = "hello client" }
    let getHello () = Fetch.tryGet<_, Model> Route.hello

    let cmd =
        Cmd.OfPromise.perform getHello () GotHello

    model, cmd

let update msg model =
    match msg with
    | GotHello hello ->
        match hello with
        | Ok s -> { model with Hello = s.Hello }, Cmd.none
        | Error e ->
            { model with Hello = e.ToString()}, Cmd.none



let view model dispatch =
    div [ Style [ TextAlign TextAlignOptions.Center
                  Padding 40 ] ] [
        div [] [
            img [ Src "favicon.png" ]
            h1 [] [ str "safeMin" ]
            h2 [] [ str model.Hello ]
        ]
    ]
