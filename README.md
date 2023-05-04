# FirstDB
- Come prima cosa creare una cartella con il nome giusto
- successivamente bisogna inserire la cartella su visual studio
- dobbiamo creare un nuovo progetto con il comando "dotnet new console"
- dal web scarichiamo chinook.db e metterlo nella cartella su visual studio
- dopo questi passaggi si può iniziare a scrivere il codice
- primo comando da aggiungere è using SQLite;
 poi allego il codice che segue
 using SQLite;





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
 
  
  
  - dove trovare il chinook:
  Il database di esempio Chinook per un negozio di media digitali può essere utilizzato per esplorare e apprendere YugabyteDB.

-Puoi installare e utilizzare il database di esempio Chinook utilizzando:
 Un'installazione locale di YugabyteDB.
 Per installare YugabyteDB, fare riferimento a Quick Start.
 Utilizzo di cloud shell o di una shell client per connettersi a un cluster in YugabyteDB Managed.
 Fare riferimento a Connettersi ai cluster in YugabyteDB Managed.
 Per   iniziare con YugabyteDB Managed, fare riferimento a Avvio rapido.
 In entrambi i casi, si utilizza la CLI di YugabyteDB SQL shell (ysqlsh) per interagire con YugabyteDB utilizzando YSQL
 
-Il modello di dati Chinook rappresenta un archivio multimediale digitale, incluse tabelle per artisti, album, tracce multimediali, fatture e clienti.

 I dati relativi ai media sono stati creati utilizzando dati reali da una libreria iTunes di Apple.
 Le informazioni sui clienti e sui dipendenti sono state create utilizzando nomi e indirizzi fittizi che possono essere localizzati su Google Maps e altri dati ben      formattati (telefono, fax, e-mail, ecc.)
 Le informazioni sulle vendite sono state generate automaticamente utilizzando dati casuali per un periodo di quattro anni.
 Il database di esempio Chinook include:
 11 tavoli
 Una varietà di indici, vincoli di chiave primaria ed esterna
 Oltre 15.000 righe di dati
 
-Gli script Chinook SQL risiedono nella cartella condivisa dell'installazione di YugabyteDB o della shell del client. Possono anche essere trovati nella directory di     esempio del repository YugabyteDB GitHub. Per questo esercizio verranno utilizzati i seguenti file:

 chinook_ddl.sql — Crea le tabelle e i vincoli
 chinook_genres_artists_albums.sql — Carica le informazioni sull'artista e sull'album
 chinook_songs.sql — Carica le informazioni sui singoli brani
 Segui i passaggi qui per installare il database di esempio Chinook.
