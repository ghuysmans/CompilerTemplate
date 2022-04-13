System.Console.ReadLine ()
|> FSharp.Text.Lexing.LexBuffer<_>.FromString
|> Parser.parse Lexer.tokenize
|> printfn "%A"
