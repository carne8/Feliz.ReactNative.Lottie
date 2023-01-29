module Feliz.ReactNative.Lottie

open Fable.Core
open Fable.Core.JsInterop
open Feliz
open Feliz.ReactNative

[<Erase>]
module prop =
    [<Erase>]
    type lottie =
        static member inline progress (value: float) = Interop.mkAttr "progress" value
        static member inline speed (value: float) = Interop.mkAttr "speed" value
        static member inline duration (ms: int) = Interop.mkAttr "duration" ms
        static member inline loop (value: bool) = Interop.mkAttr "loop" value
        static member inline autoPlay (value: bool) = Interop.mkAttr "autoPlay" value
        static member inline autoSize (value: bool) = Interop.mkAttr "autoSize" value
        static member inline style value = prop.style value
        static member inline imageAssetsFolder (value: string) = Interop.mkAttr "imageAssetsFolder" value
        /// Only Windows.
        static member inline useNativeLooping (value: bool) = Interop.mkAttr "useNativeLooping" value
        /// Only Windows.
        static member inline onAnimationLoop (value: unit -> unit) = Interop.mkAttr "onAnimationLoop" value
        static member inline onAnimationFinish (value: {| isCancelled: bool |} -> unit) = Interop.mkAttr "onAnimationFinish" value
        static member inline cacheComposition (value: bool) = Interop.mkAttr "cacheComposition" value
        static member inline colorFilters (value: #seq<{| keyPath: string; color: string |}>) = Interop.mkAttr "colorFilters" (Seq.toArray value)
        /// Only IOS.
        static member inline textFiltersIOS (value: #seq<{| keypath: string; text: string |}>) = Interop.mkAttr "textFiltersIOS" (Seq.toArray value)
        /// Only Android.
        static member inline textFiltersAndroid (value: #seq<{| find: string; replace: string |}>) = Interop.mkAttr "textFiltersAndroid" (Seq.toArray value)

    [<Erase>]
    module lottie =
        [<Erase>]
        type source =
            static member inline local (path: string) = Interop.mkAttr "source" (importDefault path)
            static member inline remote (uri: string) = Interop.mkAttr "source" (createObj [ "uri", uri ])

        [<Erase>]
        type resizeMode =
            static member inline cover = Interop.mkAttr "resizeMode" "cover"
            /// Default value
            static member inline contain = Interop.mkAttr "resizeMode" "contain"
            static member inline center = Interop.mkAttr "resizeMode" "center"

        [<Erase>]
        type renderMode =
            static member inline hardware = Interop.mkAttr "renderMode" "HARDWARE"
            static member inline software = Interop.mkAttr "renderMode" "SOFTWARE"
            static member inline automatic = Interop.mkAttr "renderMode" "AUTOMATIC"

/// Use this type when you use a ref of a lottie component.
[<Erase>]
type LottieComponent =
    abstract member play: unit -> unit
    abstract member play: (int * int) -> unit
    abstract member reset: unit -> unit
    abstract member pause: unit -> unit
    abstract member resume: unit -> unit

[<Erase>]
type Comp =
    static member inline lottie (props: seq<IReactProperty>) : ReactElement = Interop.createElement (importDefault "lottie-react-native") (createObj !!props)