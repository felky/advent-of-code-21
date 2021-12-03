OneStar();
TwoStar();

string[] ReadFile()
{
    string[] readText = System.IO.File.ReadAllLines(@"input.txt");
    return readText;
}

// 1*
void OneStar()
{
    string[] textLines = ReadFile();
    int increases = 0;

    for (int i = 0; i < textLines.Length - 1; i++)
    {
        if (Int32.Parse(textLines[i + 1]) > Int32.Parse(textLines[i]))
            increases++;
    }

    Console.WriteLine(increases);
}

// 2*
void TwoStar()
{
    string[] textLines = ReadFile();
    int increases = 0;

    for (int i = 0; i < textLines.Length - 3; i++)
    {
        if (Int32.Parse(textLines[i + 1]) + Int32.Parse(textLines[i + 2]) + Int32.Parse(textLines[i + 3]) >
            Int32.Parse(textLines[i]) + Int32.Parse(textLines[i + 1]) + Int32.Parse(textLines[i + 2]))
            increases++; 
    }

    Console.WriteLine(increases);
}