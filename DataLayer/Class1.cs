using Entity;
namespace DataLayer;
public class DataAccess
{
    public static List<Movie> movies=new List<Movie>(){
        new Movie{Id=1,Name="Toofan",Ryear=2022,Rating=2},
        new Movie{Id=2,Name="3 idiots",Ryear=2011,Rating=7},
        new Movie{Id=1,Name="Phir hera pheri",Ryear=2016,Rating=9},
        new Movie{Id=1,Name="Housefull 2",Ryear=2021,Rating=7},
        new Movie{Id=1,Name= "LAXMI",Ryear=2023,Rating=5}
    };
    public List<Movie>GetMovies(){
        return movies;
    }

}
