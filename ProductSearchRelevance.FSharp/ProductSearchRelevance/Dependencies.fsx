﻿(*
Core dependencies

This file is intended to be loaded at the top of scripts, using:
#load "Dependencies.fsx"
Once this is done, the core dependencies are available in the script.
*)

#I "../packages/"

#r @"FSharp.Data/lib/net40/FSharp.Data.dll"
#r @"FParsec/lib/net40-client/FParsecCS.dll"
#r @"FParsec/lib/net40-client/FParsec.dll"
#r @"StemmersNet/lib/net20/StemmersNet.dll"

#load "Utilities.fs"
#load "Model.fsi"
#load "Model.fs"
#load "Features.fs"