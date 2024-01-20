using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "France",
                    Code = "FR"
                },
                new Country
                {
                    Id = 2,
                    Name = "Spain",
                    Code = "ES"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States",
                    Code = "US"
                },
                new Country
                {
                    Id = 4,
                    Name = "Turkiye",
                    Code = "TR"
                },
                new Country
                {
                    Id = 5,
                    Name = "Italy",
                    Code = "IT"
                },
                new Country
                {
                    Id = 6,
                    Name = "Mexico",
                    Code = "MX"
                },
                new Country
                {
                    Id = 7,
                    Name = "United Kingdom",
                    Code = "UK"
                },
                new Country
                {
                    Id = 8,
                    Name = "Germany",
                    Code = "DE"
                },
                new Country
                {
                    Id = 9,
                    Name = "Greece",
                    Code = "GR"
                },
                new Country
                {
                    Id = 10,
                    Name = "Austria",
                    Code = "AT"
                });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Encantar Fuga",
                    Address = "4499 Rond-point Des Lilas, 21597 Albi",
                    CountryId = 1,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Luxo Opulento",
                    Address = "55 Pont d'Orsel, 62980 Perigueux",
                    CountryId = 1,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Luar Adornado",
                    Address = "73 Chaussée d'Orsel, 73904 Athis-Mons",
                    CountryId = 1,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Tranquilidade Radiante",
                    Address = "582 Gaffe Trasbot, 75209 Arles",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Sussurro Sofisticado",
                    Address = "812 Dreve Boutard, 20394 Le Tampon",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Oasis Adornado",
                    Address = "4 Esplanade Blaise Pascal, 91572 Sceaux",
                    CountryId = 1,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Fuga Elegante",
                    Address = "318 Passage Du Guichet, 80079 Malakoff",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Regal Bliss",
                    Address = "585 Traboule De Colombes, 93551 Vaulx-en-Velin",
                    CountryId = 1,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 9,
                    Name = "Felicidade Real",
                    Address = "7 Cours La Cote des Amandiers, 85974 Lievin",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 10,
                    Name = "Majestade Paradiso",
                    Address = "46 Chemin D'Argenteuil, 26982 Bobigny",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 11,
                    Name = "Hotel Costa del Mar",
                    Address = "Esc. 535 Lugar Antonia Baeza 99 Esc. 103, Algeciras, And 11640",
                    CountryId = 2,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 12,
                    Name = "Templo de la Rosa Resort",
                    Address = "Rambla Emilio, 76, Motril, Can 07669",
                    CountryId = 2,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 13,
                    Name = "Hotel Sunny Petalo",
                    Address = "Esc. 378 Lugar Jose Emilio Arce, 6, Valladolid, Mur 40953",
                    CountryId = 2,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 14,
                    Name = "Motel historico de Vale",
                    Address = "Esc. 160 Explanada Teodoro Cardenas, 9, Alcoy, Mur 64922",
                    CountryId = 2,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 15,
                    Name = "Panorama Hotel & Spa",
                    Address = "Extrarradio Adela, 15, Santander, Nav 01987",
                    CountryId = 2,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 16,
                    Name = "Hotel Pacifico",
                    Address = "Poligono Laura 1 Esc. 539, Torrejon de Ardoz, Cbr 51884",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 17,
                    Name = "Exaltado Manor Resort",
                    Address = "Puerta 647 Colonia Mateo Toledo 54, Torrelavega, Rio 00109",
                    CountryId = 2,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 18,
                    Name = "Hotel Lobo Supremo",
                    Address = "Puerta 573 Ronda Maria Jose Montemayor 4, Estepona, Mur 68351",
                    CountryId = 2,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 19,
                    Name = "Galaxia Resort & Spa",
                    Address = "Esc. 381 Pasaje Adela, 68 Puerta 893, Cornella de Llobregat, Nav 91188",
                    CountryId = 2,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 20,
                    Name = "Hotel Troposfera",
                    Address = "Puerta 757 Partida Marisol Aragon 2, Molina de Segura, Com 00279",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 21,
                    Name = "Enchant Escape",
                    Address = "554 Gutmann Shoal, Raynorfort, NC 78628",
                    CountryId = 3,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 22,
                    Name = "Opulent Luxe",
                    Address = "97036 Paucek Meadows, Cristshire, SD 58309",
                    CountryId = 3,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 23,
                    Name = "Adorned Moonlight",
                    Address = "5257 Emard Streets, North Fredericfurt, AK 80005-7767",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 24,
                    Name = "Radiant Tranquility",
                    Address = "768 Vandervort Station, Port Moshe, LA 44351-4421",
                    CountryId = 3,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 25,
                    Name = "Sophisticated Whisper",
                    Address = "8445 Miller Hill, Lake Oliver, DE 01809-4728",
                    CountryId = 3,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 26,
                    Name = "Adorned Oasis",
                    Address = "581 Donovan Common, South Douglassstad, MS 22045",
                    CountryId = 3,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 27,
                    Name = "Elegant Escape",
                    Address = "95400 Melany Ferry, East Hectorshire, AR 33483",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 28,
                    Name = "Regal Bliss",
                    Address = "Suite 140 6063 Erna View, Port Lashandaberg, AK 11528-8440",
                    CountryId = 3,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 29,
                    Name = "Fusion Summer",
                    Address = "656 Tristan Passage, Ricemouth, IN 13748-6171",
                    CountryId = 3,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 30,
                    Name = "Majesty Paradise",
                    Address = "7966 Preston Meadows, West Maurita, NC 68934",
                    CountryId = 3,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 31,
                    Name = "Beyaz Safari Hotel",
                    Address = "Umurbey Street, Konak, Izmir 35230",
                    CountryId = 4,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 32,
                    Name = "Grand Tide Hotel",
                    Address = "Aydintepe Road, Tuzla, Istanbul 34944",
                    CountryId = 4,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 33,
                    Name = "Prizma Tatil Hotel",
                    Address = "Ortamahalle Place, Bayrampasa, Istanbul 34030",
                    CountryId = 4,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 34,
                    Name = "Ruyalar Regency Hotel",
                    Address = "Cumhuriyet Gardens, Kas, Antalya 07960",
                    CountryId = 4,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 35,
                    Name = "Grandiose Castle Resort",
                    Address = "Soguk Cesme Hill, Fatih, Istanbul 34122",
                    CountryId = 4,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 36,
                    Name = "Yuce Ayna Hotel",
                    Address = "Yunus Emre Plaza, Meram, Konya, 42090",
                    CountryId = 4,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 37,
                    Name = "Atlantis Korusu Hotel",
                    Address = "Eryaman Ayas Parkway, Etimesgut, Ankara 06790",
                    CountryId = 4,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 38,
                    Name = "Doga Tesisi Hotel",
                    Address = "Yanarsu Junction, Bornova, Izmir 35070",
                    CountryId = 4,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 39,
                    Name = "Fantezi Hotel",
                    Address = "Kocatepe Crossing, Bayrampasa, Istanbul 34040",
                    CountryId = 4,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 40,
                    Name = "Uclu Zirve Spa Resort",
                    Address = "Kusadasi Port Street, Kusadasi, Aydin 09400",
                    CountryId = 4,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 41,
                    Name = "Esaltato Palazzo Resort",
                    Address = "Strada Samuel 2, Valdo lido, PI 73130",
                    CountryId = 5,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 42,
                    Name = "Pinnacolo Zaffiro Hotel",
                    Address = "Borgo Rosolino 6, Piano 8, Testa a mare, IM 53811",
                    CountryId = 5,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 43,
                    Name = "Resort Elegante",
                    Address = "Rotonda Riva 17, Appartamento 34, San Gilda salentino, CZ 72851",
                    CountryId = 5,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 44,
                    Name = "Albergo Lunare",
                    Address = "Contrada Sala 4, Sabatino nell'emilia, PE 46584",
                    CountryId = 5,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 45,
                    Name = "Riposo Resort",
                    Address = "Rotonda Fulvio 40, Piano 4, Mancini terme, LU 70629",
                    CountryId = 5,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 46,
                    Name = "Albergo Polvere di Stelle",
                    Address = "Rotonda Tazio 6, Ross del friuli, SI 60618",
                    CountryId = 5,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 47,
                    Name = "Esaltato Star Hotel",
                    Address = "Contrada Matteo 5, Borgo Jole terme, CE 44862",
                    CountryId = 5,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 48,
                    Name = "Regale Lion Hotel",
                    Address = "Borgo Pellegrino 38, Piano 1, Furio ligure, OG 16690",
                    CountryId = 5,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 49,
                    Name = "Scogliera Smeraldo Resort",
                    Address = "Via Adriano 98, Quarto Aroldo sardo, SO 15971",
                    CountryId = 5,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 50,
                    Name = "Alba Loch Resort",
                    Address = "Piano 6 Borgo Moretti 707, Gatti calabro, MN 93819",
                    CountryId = 5,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 51,
                    Name = "El Lago Sunrise Resort",
                    Address = "Puerta 141 Arroyo Berta Barreto, 13 Puerta 828, Bilbao, Com 48239",
                    CountryId = 6,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 52,
                    Name = "Complejo Acantilado Esmeralda",
                    Address = "Esc. 481 Rincon Pablo 5 Puerta 803, Santa Lucia de Tirajana, Ast 20510",
                    CountryId = 6,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 53,
                    Name = "Hotel Panorama Otono",
                    Address = "Muelle Benjamin, 22 Esc. 787, Calahorra, Can 09143",
                    CountryId = 6,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 54,
                    Name = "Hotel Vacaciones",
                    Address = "Puerta 112 Entrada Marta 9, Palencia, Ara 31531",
                    CountryId = 6,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 55,
                    Name = "Actualizar Hotel",
                    Address = "Esc. 129 Bloque Rosario 57 Esc. 931, Ponferrada, Cbr 48329",
                    CountryId = 6,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 56,
                    Name = "Tiempo Libre Resort Resort",
                    Address = "Plaza Dorotea 8, Tarrasa, Ast 25111",
                    CountryId = 6,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 57,
                    Name = "Renacentista Hotel",
                    Address = "Puerta 750 Riera Rosario 1, Almería, Bal 75211",
                    CountryId = 6,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 58,
                    Name = "Campamento Verano Resort",
                    Address = "Puerta 361 Sector Sancho 7 Esc. 557, Rivas-Vaciamadrid, Vas 42313",
                    CountryId = 6,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 59,
                    Name = "Abismo Esmeralda Resort",
                    Address = "Puerta 240 Travesia Monica, 48 Puerta 996, Torrevieja, Can 40461",
                    CountryId = 6,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 60,
                    Name = "Grand Oak Resort & Spa",
                    Address = "Esc. 348 Colonia Julia, 33, Alicante, Ast 85172",
                    CountryId = 6,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 61,
                    Name = "Eastern Star Hotel",
                    Address = "20 Grange Road, Doncaster, DN11 2VN",
                    CountryId = 7,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 62,
                    Name = "Sunset Orb Resort & Spa",
                    Address = "89 Alexander Road, Redhill, RH71 6TU",
                    CountryId = 7,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 63,
                    Name = "Azure Heirloom Hotel",
                    Address = "6 Grove Road, North London, N1 0ZD",
                    CountryId = 7,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 64,
                    Name = "Emerald Island Hotel",
                    Address = "28 Kingsway, Kirkcaldy, KY32 0TH",
                    CountryId = 7,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 65,
                    Name = "Royal Echo Hotel",
                    Address = "72 Park Avenue, Milton Keynes, MK2 0EB",
                    CountryId = 7,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 66,
                    Name = "Coastline Hotel",
                    Address = "56 Richmond Road, Darlington, DL10 3GF",
                    CountryId = 7,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 67,
                    Name = "Light Sanctum Hotel",
                    Address = "9 New Street, Chelmsford, CM77 9VF",
                    CountryId = 7,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 68,
                    Name = "Modest Nimbus Hotel",
                    Address = "31 Park Avenue, Plymouth, PL7 6UG",
                    CountryId = 7,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 69,
                    Name = "Southern Maple Hotel",
                    Address = "35 Park Lane, Wigan, WN45 6VI",
                    CountryId = 7,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 70,
                    Name = "Golden Raven Motel",
                    Address = "32 The Green, Crewe, CW12 7AP",
                    CountryId = 7,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 71,
                    Name = "Lichtheiligtum Resort",
                    Address = "Fridtjof-Nansen-Str. 77, Jaredberg, NI 50889",
                    CountryId = 8,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 72,
                    Name = "Bescheidener Nimbus Hotel",
                    Address = "5 OG Steglitzer Str. 18c, Süd Marinaburg, HB 15290",
                    CountryId = 8,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 73,
                    Name = "Sudlicher Ahorn Hotel",
                    Address = "",
                    CountryId = 8,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 74,
                    Name = "Goldener Rabe Hotel",
                    Address = "3 OG Amselweg 69a, Grimmstadt, MV 33837",
                    CountryId = 8,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 75,
                    Name = "Silbernes Universum Resort",
                    Address = "",
                    CountryId = 8,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 76,
                    Name = "Herrenpalast Resort",
                    Address = "Maria-Terwiel-Str. 14c, Ost Steffenhagen, MV 92427",
                    CountryId = 8,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 77,
                    Name = "Orientalisches Hotel",
                    Address = "",
                    CountryId = 8,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 78,
                    Name = "Sternenlicht Resort",
                    Address = "6 OG Ehrlichstr. 68a, Greenbrunn, BE 21295",
                    CountryId = 8,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 79,
                    Name = "Herrliches Vista Hotel",
                    Address = "Odenthaler Str. 4, Bad Dennis, HE 12691",
                    CountryId = 8,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 80,
                    Name = "Majestatischer Hotel & Spa",
                    Address = "Niederblecher 70, Bad Vanessa, HB 62368",
                    CountryId = 8,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 81,
                    Name = "Eleftherios Garden Hotel",
                    Address = "Kolokotroni 16, Thessaloniki, Central Macedonia 564 30",
                    CountryId = 9,
                    Rating = 4.3
                },
                new Hotel
                {
                    Id = 82,
                    Name = "Zervakos Hotel & Spa",
                    Address = "Patmos Island, Patmos, South Aegean 855 00",
                    CountryId = 9,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 83,
                    Name = "Gavriil Resort",
                    Address = " Negri Fokionos 80, Athina, Attica 113 61",
                    CountryId = 9,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 84,
                    Name = "Fotini Pateroti Resort",
                    Address = "Riga Fereou,  Kalamata, Peloponnese 241 00",
                    CountryId = 9,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 85,
                    Name = "Gianna Mundelli Hotel",
                    Address = "Leoforos Mesogeion 59, Athina, Attica 115 26",
                    CountryId = 9,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 86,
                    Name = "Florentia Hotel",
                    Address = "Gravias 6, Agia Paraskevi, Attica 153 42",
                    CountryId = 9,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 87,
                    Name = "Ismini Milea Resort",
                    Address = "25is Martiou 10, Edessa, Central Macedonia 582 00",
                    CountryId = 9,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 88,
                    Name = "Yanna Galanidi Boutique Hotel",
                    Address = "Megalou Alexandrou 70, Athina, Attica 171 22",
                    CountryId = 9,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 89,
                    Name = "Rania Romana Regency",
                    Address = "Eleftheriou Venizelou 26, Kavala, Thrace 653 02",
                    CountryId = 9,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 90,
                    Name = "Kalliopi Kanea Villas & Guesthouses",
                    Address = "Platia Theatrou 2, Athina, Attica 105 52",
                    CountryId = 9,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 91,
                    Name = "Mondlicht Resort",
                    Address = "192 Holzgasse, Gemeinde Klosterneuburg, Bezirk Tulln, Lower Austria 3400",
                    CountryId = 10,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 92,
                    Name = "Golden Flustern Villas & Guesthouses",
                    Address = "2 Ohmgasse, Vienna 1210",
                    CountryId = 10,
                    Rating = 4.9
                },
                new Hotel
                {
                    Id = 93,
                    Name = "Koniglich Harmonie",
                    Address = "210 Greit, Bezirk Landeck, Tyrol 6542",
                    CountryId = 10,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 94,
                    Name = "Funkeln Diamant Resort & Spa",
                    Address = "3 Waldegghofgasse, Vienna 1170",
                    CountryId = 10,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 95,
                    Name = "Azure Erheben Hotel",
                    Address = "4 Overbeckgasse, Siedlung Auhofer, Vienna 1130",
                    CountryId = 10,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 96,
                    Name = "Elegant Urlaub",
                    Address = "Gemeinde Ardagger, Bezirk Amstetten, Lower Austria 3321",
                    CountryId = 10,
                    Rating = 5.0
                },
                new Hotel
                {
                    Id = 97,
                    Name = "Strahlend Himmel Hotel",
                    Address = "5-7 Primavesigasse, Donaustadt, Vienna 1220",
                    CountryId = 10,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 98,
                    Name = "Luxus Golden Hotel",
                    Address = "33 Trauttmansdorffgasse, Vienna 1130",
                    CountryId = 10,
                    Rating = 4.4
                },
                new Hotel
                {
                    Id = 99,
                    Name = "Royal Oasis Hotel",
                    Address = "32 Pomedt, Bezirk Scharding, Upper Austria 4752 ",
                    CountryId = 10,
                    Rating = 4.8
                },
                new Hotel
                {
                    Id = 100,
                    Name = "Elegant Komfort Hotel",
                    Address = "7 Bahngasse, Bezirk Oberpullendorf, Burgenland 7451",
                    CountryId = 10,
                    Rating = 4.5
                }
                );
        }
    }
}
