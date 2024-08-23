

List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach(Movie movie in myMovies)
{
    Console.WriteLine($"One of my favourite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Users\Z620\source\repos\data\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filePath);
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }   
    }

    public string Year
    { get { return year; } }

    public Movie(string _title, string _year)
    {
        this.title = _title;
        this.year = _year;
    }
}