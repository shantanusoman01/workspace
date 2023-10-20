using Entity;
using BzLayer;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MovieBZ bz=new MovieBZ();
        List<Movie> movies=bz.GetMovies();
        if(movies!=null){
            foreach(var m in movies){
                Console.WriteLine($"{m.Id} {m.Name} {m.Rating} {m.Ryear}");

            }
        }
        else{
            System.Console.WriteLine("No Movies Present");
        }
        
        
        
    }
}