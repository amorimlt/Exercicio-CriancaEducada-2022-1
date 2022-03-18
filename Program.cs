string frase, palavracensurada = "#@$%*!&";

Console.Write("Digite uma frase: ");
frase = Console.ReadLine()!;

frase = frase
    .Replace("bobo", $"{palavracensurada}")
    .Replace("boba", $"{palavracensurada}")
    .Replace("feio", $"{palavracensurada}")
    .Replace("feia", $"{palavracensurada}")
    .Replace("estranho", $"{palavracensurada}")
    .Replace("estranha", $"{palavracensurada}")
    .Replace("esquisito", $"{palavracensurada}")
    .Replace("esquisita", $"{palavracensurada}")
    .Replace("panaca", $"{palavracensurada}")
    .Replace("chato", $"{palavracensurada}")
    .Replace("chata", $"{palavracensurada}");

Console.WriteLine($"{frase}");