namespace Site

open WebSharper

[<JavaScript>]
module Client =
    let All =
        let ( !+ ) x = Samples.Set.Singleton(x)

        Samples.Set.Create [
            !+ SpeechUtterance.Sample
            !+ SpeechSynthesis.Sample
        ]

    [<SPAEntryPoint>]
    let Main() =
        All.Show()