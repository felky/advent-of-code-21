string[] ReadFile()
{
    string[] readText = System.IO.File.ReadAllLines(@"input.txt");
    return readText;
}

string[] file = ReadFile();

// 1*

int[] xyCoords = new int[2] { 0, 0 };

for (int i = 0; i < file.Length; i++)
{
    string[] coords = file[i].Split(' ');
    switch (coords[0])
    {
        case "forward":
            xyCoords[0] += Int32.Parse(coords[1]);
            break;
        case "down":
            xyCoords[1] += Int32.Parse(coords[1]);
            break;
        case "up":
            xyCoords[1] -= Int32.Parse(coords[1]);
            break;
    }
}

Console.WriteLine(xyCoords[0] * xyCoords[1]);

// 2*
int[] xyAimCoords = new int[3] { 0, 0, 0 };

for (int i = 0; i < file.Length; i++)
{
    string[] coords = file[i].Split(' ');
    switch (coords[0])
    {
        case "forward":
            xyAimCoords[0] += Int32.Parse(coords[1]);
            xyAimCoords[1] += (Int32.Parse(coords[1]) * xyAimCoords[2]); 
            break;
        case "down":
            xyAimCoords[2] += Int32.Parse(coords[1]);
            break;
        case "up":
            xyAimCoords[2] -= Int32.Parse(coords[1]);
            break;
    }

    Console.WriteLine(xyAimCoords[0] + ' ' + xyAimCoords[1] + ' ' + xyAimCoords[2]);
}

Console.WriteLine(xyAimCoords[0] * xyAimCoords[1]);