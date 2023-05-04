# FirstDB
- Come prima cosa creare una cartella con il nome giusto
- successivamente bisogna inserire la cartella su visual studio
- dobbiamo creare un nuovo progetto con il comando "dotnet new console"
- dal web scarichiamo chinook.db e metterlo nella cartella su visual studio
- dopo questi passaggi si può iniziare a scrivere il codice
- primo comando da aggiungere è using SQLite;
po allego il codice che segue
using SQLite;





//connessione al db
SQLiteConnection cn1 = new SQLiteConnection("chinook.db");
var tblArtists = cn1.Query<Artist>("select * from artists");
Console.WriteLine($"in questa tabella ci sono {tblArtists.Count}record!");

//--------------------------------------------
//fine del main.... inizio della dichiarazione
//--------------------------------------------

public class Artist
