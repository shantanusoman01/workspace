using Entity;
using DataLayer;
namespace BzLayer;
public class MovieBZ
{   
    public List<Movie> GetMovies(){
        DataAccess dataAccess=new DataAccess();
        return dataAccess.GetMovies();
    }

}
