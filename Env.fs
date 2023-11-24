namespace AoC.Companion

open System
open System.IO
open Microsoft.Extensions.Configuration

module Env =
  let private config = (new ConfigurationBuilder()).AddUserSecrets().AddEnvironmentVariables().Build()

  let BaseDir = AppDomain.CurrentDomain.BaseDirectory
  let ProjectDir = Directory.GetParent(BaseDir).Parent.Parent.Parent.FullName
  let Year = AppDomain.CurrentDomain.FriendlyName.Replace("aoc", "").Replace(".", "") |> int
  let SessionToken = config["AOC_SESSION_TOKEN"]
