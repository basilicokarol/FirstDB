using SQLite;




Console.WriteLine("Hello, World!");
//connessione al db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from artists");
Console.WriteLine($"in questa tabella ci sono {tblArtists.Count}record!");

//--------------------------------------------
//fine del main.... inizio della dichiarazione
//--------------------------------------------

public class Artist
{
public int ArtistId{ get; set; }
//public string Name { get; set; }

}