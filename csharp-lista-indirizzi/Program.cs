using csharp_lista_indirizzi;


List<Indirizzo> indirizzos = new List<Indirizzo>();

StreamReader file = File.OpenText("C:\\");

while(!file.EndOfStream)
    {

    string riga = file.ReadLine();
    string[] informazioniIndirizzi = riga.Split(",");

    string nome = informazioniIndirizzi[0];
    string cognome = informazioniIndirizzi[1];
    string via = informazioniIndirizzi[2];
    string città = informazioniIndirizzi[3];
    string provincia= informazioniIndirizzi[4];
    string zip = informazioniIndirizzi[5];

    
}