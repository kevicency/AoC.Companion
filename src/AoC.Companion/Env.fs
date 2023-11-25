namespace AoC.Companion

open System
open System.IO
open System.Text.RegularExpressions
open Microsoft.Extensions.Configuration

module Env =
  let private config =
    (new ConfigurationBuilder()).AddUserSecrets().AddEnvironmentVariables().Build()

  let private yearRx = Regex(@"20\d{2}", RegexOptions.Compiled)

  let BaseDir = AppDomain.CurrentDomain.BaseDirectory
  let ProjectDir = Directory.GetParent(BaseDir).Parent.Parent.Parent.FullName

  let Year =
    if yearRx.IsMatch(AppDomain.CurrentDomain.FriendlyName) then
      yearRx.Match(AppDomain.CurrentDomain.FriendlyName).Value |> int
    else
      DateTime.Today.Year

  let SessionToken = config["AOC_SESSION_TOKEN"]
