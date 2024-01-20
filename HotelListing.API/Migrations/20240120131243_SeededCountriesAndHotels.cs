using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededCountriesAndHotels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "FR", "France" },
                    { 2, "ES", "Spain" },
                    { 3, "US", "United States" },
                    { 4, "TR", "Turkiye" },
                    { 5, "IT", "Italy" },
                    { 6, "MX", "Mexico" },
                    { 7, "UK", "United Kingdom" },
                    { 8, "DE", "Germany" },
                    { 9, "GR", "Greece" },
                    { 10, "AT", "Austria" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "CountryId", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, "4499 Rond-point Des Lilas, 21597 Albi", 1, "Encantar Fuga", 4.7000000000000002 },
                    { 2, "55 Pont d'Orsel, 62980 Perigueux", 1, "Luxo Opulento", 4.9000000000000004 },
                    { 3, "73 Chaussée d'Orsel, 73904 Athis-Mons", 1, "Luar Adornado", 5.0 },
                    { 4, "582 Gaffe Trasbot, 75209 Arles", 1, "Tranquilidade Radiante", 4.5999999999999996 },
                    { 5, "812 Dreve Boutard, 20394 Le Tampon", 1, "Sussurro Sofisticado", 4.5999999999999996 },
                    { 6, "4 Esplanade Blaise Pascal, 91572 Sceaux", 1, "Oasis Adornado", 4.7999999999999998 },
                    { 7, "318 Passage Du Guichet, 80079 Malakoff", 1, "Fuga Elegante", 4.5 },
                    { 8, "585 Traboule De Colombes, 93551 Vaulx-en-Velin", 1, "Regal Bliss", 4.2999999999999998 },
                    { 9, "7 Cours La Cote des Amandiers, 85974 Lievin", 1, "Felicidade Real", 4.5 },
                    { 10, "46 Chemin D'Argenteuil, 26982 Bobigny", 1, "Majestade Paradiso", 4.5999999999999996 },
                    { 11, "Esc. 535 Lugar Antonia Baeza 99 Esc. 103, Algeciras, And 11640", 2, "Hotel Costa del Mar", 4.9000000000000004 },
                    { 12, "Rambla Emilio, 76, Motril, Can 07669", 2, "Templo de la Rosa Resort", 4.9000000000000004 },
                    { 13, "Esc. 378 Lugar Jose Emilio Arce, 6, Valladolid, Mur 40953", 2, "Hotel Sunny Petalo", 4.9000000000000004 },
                    { 14, "Esc. 160 Explanada Teodoro Cardenas, 9, Alcoy, Mur 64922", 2, "Motel historico de Vale", 4.7000000000000002 },
                    { 15, "Extrarradio Adela, 15, Santander, Nav 01987", 2, "Panorama Hotel & Spa", 5.0 },
                    { 16, "Poligono Laura 1 Esc. 539, Torrejon de Ardoz, Cbr 51884", 2, "Hotel Pacifico", 4.5 },
                    { 17, "Puerta 647 Colonia Mateo Toledo 54, Torrelavega, Rio 00109", 2, "Exaltado Manor Resort", 4.7000000000000002 },
                    { 18, "Puerta 573 Ronda Maria Jose Montemayor 4, Estepona, Mur 68351", 2, "Hotel Lobo Supremo", 4.5999999999999996 },
                    { 19, "Esc. 381 Pasaje Adela, 68 Puerta 893, Cornella de Llobregat, Nav 91188", 2, "Galaxia Resort & Spa", 4.7999999999999998 },
                    { 20, "Puerta 757 Partida Marisol Aragon 2, Molina de Segura, Com 00279", 2, "Hotel Troposfera", 4.5 },
                    { 21, "554 Gutmann Shoal, Raynorfort, NC 78628", 3, "Enchant Escape", 4.9000000000000004 },
                    { 22, "97036 Paucek Meadows, Cristshire, SD 58309", 3, "Opulent Luxe", 4.2999999999999998 },
                    { 23, "5257 Emard Streets, North Fredericfurt, AK 80005-7767", 3, "Adorned Moonlight", 4.7999999999999998 },
                    { 24, "768 Vandervort Station, Port Moshe, LA 44351-4421", 3, "Radiant Tranquility", 4.9000000000000004 },
                    { 25, "8445 Miller Hill, Lake Oliver, DE 01809-4728", 3, "Sophisticated Whisper", 4.4000000000000004 },
                    { 26, "581 Donovan Common, South Douglassstad, MS 22045", 3, "Adorned Oasis", 4.9000000000000004 },
                    { 27, "95400 Melany Ferry, East Hectorshire, AR 33483", 3, "Elegant Escape", 4.7999999999999998 },
                    { 28, "Suite 140 6063 Erna View, Port Lashandaberg, AK 11528-8440", 3, "Regal Bliss", 4.7999999999999998 },
                    { 29, "656 Tristan Passage, Ricemouth, IN 13748-6171", 3, "Fusion Summer", 4.2999999999999998 },
                    { 30, "7966 Preston Meadows, West Maurita, NC 68934", 3, "Majesty Paradise", 4.5999999999999996 },
                    { 31, "Umurbey Street, Konak, Izmir 35230", 4, "Beyaz Safari Hotel", 4.7000000000000002 },
                    { 32, "Aydintepe Road, Tuzla, Istanbul 34944", 4, "Grand Tide Hotel", 4.2999999999999998 },
                    { 33, "Ortamahalle Place, Bayrampasa, Istanbul 34030", 4, "Prizma Tatil Hotel", 4.4000000000000004 },
                    { 34, "Cumhuriyet Gardens, Kas, Antalya 07960", 4, "Ruyalar Regency Hotel", 4.7000000000000002 },
                    { 35, "Soguk Cesme Hill, Fatih, Istanbul 34122", 4, "Grandiose Castle Resort", 4.9000000000000004 },
                    { 36, "Yunus Emre Plaza, Meram, Konya, 42090", 4, "Yuce Ayna Hotel", 4.7999999999999998 },
                    { 37, "Eryaman Ayas Parkway, Etimesgut, Ankara 06790", 4, "Atlantis Korusu Hotel", 5.0 },
                    { 38, "Yanarsu Junction, Bornova, Izmir 35070", 4, "Doga Tesisi Hotel", 4.7000000000000002 },
                    { 39, "Kocatepe Crossing, Bayrampasa, Istanbul 34040", 4, "Fantezi Hotel", 4.2999999999999998 },
                    { 40, "Kusadasi Port Street, Kusadasi, Aydin 09400", 4, "Uclu Zirve Spa Resort", 4.5999999999999996 },
                    { 41, "Strada Samuel 2, Valdo lido, PI 73130", 5, "Esaltato Palazzo Resort", 4.5999999999999996 },
                    { 42, "Borgo Rosolino 6, Piano 8, Testa a mare, IM 53811", 5, "Pinnacolo Zaffiro Hotel", 4.5999999999999996 },
                    { 43, "Rotonda Riva 17, Appartamento 34, San Gilda salentino, CZ 72851", 5, "Resort Elegante", 4.2999999999999998 },
                    { 44, "Contrada Sala 4, Sabatino nell'emilia, PE 46584", 5, "Albergo Lunare", 4.7000000000000002 },
                    { 45, "Rotonda Fulvio 40, Piano 4, Mancini terme, LU 70629", 5, "Riposo Resort", 4.4000000000000004 },
                    { 46, "Rotonda Tazio 6, Ross del friuli, SI 60618", 5, "Albergo Polvere di Stelle", 4.5 },
                    { 47, "Contrada Matteo 5, Borgo Jole terme, CE 44862", 5, "Esaltato Star Hotel", 4.9000000000000004 },
                    { 48, "Borgo Pellegrino 38, Piano 1, Furio ligure, OG 16690", 5, "Regale Lion Hotel", 4.7999999999999998 },
                    { 49, "Via Adriano 98, Quarto Aroldo sardo, SO 15971", 5, "Scogliera Smeraldo Resort", 4.5999999999999996 },
                    { 50, "Piano 6 Borgo Moretti 707, Gatti calabro, MN 93819", 5, "Alba Loch Resort", 4.5999999999999996 },
                    { 51, "Puerta 141 Arroyo Berta Barreto, 13 Puerta 828, Bilbao, Com 48239", 6, "El Lago Sunrise Resort", 4.9000000000000004 },
                    { 52, "Esc. 481 Rincon Pablo 5 Puerta 803, Santa Lucia de Tirajana, Ast 20510", 6, "Complejo Acantilado Esmeralda", 4.5 },
                    { 53, "Muelle Benjamin, 22 Esc. 787, Calahorra, Can 09143", 6, "Hotel Panorama Otono", 4.9000000000000004 },
                    { 54, "Puerta 112 Entrada Marta 9, Palencia, Ara 31531", 6, "Hotel Vacaciones", 4.7000000000000002 },
                    { 55, "Esc. 129 Bloque Rosario 57 Esc. 931, Ponferrada, Cbr 48329", 6, "Actualizar Hotel", 4.5999999999999996 },
                    { 56, "Plaza Dorotea 8, Tarrasa, Ast 25111", 6, "Tiempo Libre Resort Resort", 4.5999999999999996 },
                    { 57, "Puerta 750 Riera Rosario 1, Almería, Bal 75211", 6, "Renacentista Hotel", 4.4000000000000004 },
                    { 58, "Puerta 361 Sector Sancho 7 Esc. 557, Rivas-Vaciamadrid, Vas 42313", 6, "Campamento Verano Resort", 4.2999999999999998 },
                    { 59, "Puerta 240 Travesia Monica, 48 Puerta 996, Torrevieja, Can 40461", 6, "Abismo Esmeralda Resort", 4.5 },
                    { 60, "Esc. 348 Colonia Julia, 33, Alicante, Ast 85172", 6, "Grand Oak Resort & Spa", 4.7000000000000002 },
                    { 61, "20 Grange Road, Doncaster, DN11 2VN", 7, "Eastern Star Hotel", 4.2999999999999998 },
                    { 62, "89 Alexander Road, Redhill, RH71 6TU", 7, "Sunset Orb Resort & Spa", 4.5999999999999996 },
                    { 63, "6 Grove Road, North London, N1 0ZD", 7, "Azure Heirloom Hotel", 4.9000000000000004 },
                    { 64, "28 Kingsway, Kirkcaldy, KY32 0TH", 7, "Emerald Island Hotel", 4.9000000000000004 },
                    { 65, "72 Park Avenue, Milton Keynes, MK2 0EB", 7, "Royal Echo Hotel", 4.9000000000000004 },
                    { 66, "56 Richmond Road, Darlington, DL10 3GF", 7, "Coastline Hotel", 4.9000000000000004 },
                    { 67, "9 New Street, Chelmsford, CM77 9VF", 7, "Light Sanctum Hotel", 4.7999999999999998 },
                    { 68, "31 Park Avenue, Plymouth, PL7 6UG", 7, "Modest Nimbus Hotel", 4.4000000000000004 },
                    { 69, "35 Park Lane, Wigan, WN45 6VI", 7, "Southern Maple Hotel", 4.7000000000000002 },
                    { 70, "32 The Green, Crewe, CW12 7AP", 7, "Golden Raven Motel", 4.4000000000000004 },
                    { 71, "Fridtjof-Nansen-Str. 77, Jaredberg, NI 50889", 8, "Lichtheiligtum Resort", 4.5 },
                    { 72, "5 OG Steglitzer Str. 18c, Süd Marinaburg, HB 15290", 8, "Bescheidener Nimbus Hotel", 5.0 },
                    { 73, "Zimmer 495 Am Frankenberg 3, Paschkestadt, BY 39595", 8, "Sudlicher Ahorn Hotel", 4.5999999999999996 },
                    { 74, "3 OG Amselweg 69a, Grimmstadt, MV 33837", 8, "Goldener Rabe Hotel", 4.5 },
                    { 75, "7 OG Mauspfad 32c, Huberdorf, NW 17359", 8, "Silbernes Universum Resort", 4.7999999999999998 },
                    { 76, "Maria-Terwiel-Str. 14c, Ost Steffenhagen, MV 92427", 8, "Herrenpalast Resort", 4.5999999999999996 },
                    { 77, "Dahlemer Str. 6, Cosimaberg, BW 96648", 8, "Orientalisches Hotel", 4.2999999999999998 },
                    { 78, "6 OG Ehrlichstr. 68a, Greenbrunn, BE 21295", 8, "Sternenlicht Resort", 4.2999999999999998 },
                    { 79, "Odenthaler Str. 4, Bad Dennis, HE 12691", 8, "Herrliches Vista Hotel", 4.7000000000000002 },
                    { 80, "Niederblecher 70, Bad Vanessa, HB 62368", 8, "Majestatischer Hotel & Spa", 4.9000000000000004 },
                    { 81, "Kolokotroni 16, Thessaloniki, Central Macedonia 564 30", 9, "Eleftherios Garden Hotel", 4.2999999999999998 },
                    { 82, "Patmos Island, Patmos, South Aegean 855 00", 9, "Zervakos Hotel & Spa", 4.9000000000000004 },
                    { 83, " Negri Fokionos 80, Athina, Attica 113 61", 9, "Gavriil Resort", 4.5 },
                    { 84, "Riga Fereou,  Kalamata, Peloponnese 241 00", 9, "Fotini Pateroti Resort", 4.7000000000000002 },
                    { 85, "Leoforos Mesogeion 59, Athina, Attica 115 26", 9, "Gianna Mundelli Hotel", 4.7000000000000002 },
                    { 86, "Gravias 6, Agia Paraskevi, Attica 153 42", 9, "Florentia Hotel", 4.4000000000000004 },
                    { 87, "25is Martiou 10, Edessa, Central Macedonia 582 00", 9, "Ismini Milea Resort", 4.4000000000000004 },
                    { 88, "Megalou Alexandrou 70, Athina, Attica 171 22", 9, "Yanna Galanidi Boutique Hotel", 4.7000000000000002 },
                    { 89, "Eleftheriou Venizelou 26, Kavala, Thrace 653 02", 9, "Rania Romana Regency", 4.4000000000000004 },
                    { 90, "Platia Theatrou 2, Athina, Attica 105 52", 9, "Kalliopi Kanea Villas & Guesthouses", 4.5999999999999996 },
                    { 91, "192 Holzgasse, Gemeinde Klosterneuburg, Bezirk Tulln, Lower Austria 3400", 10, "Mondlicht Resort", 4.7000000000000002 },
                    { 92, "2 Ohmgasse, Vienna 1210", 10, "Golden Flustern Villas & Guesthouses", 4.9000000000000004 },
                    { 93, "210 Greit, Bezirk Landeck, Tyrol 6542", 10, "Koniglich Harmonie", 4.5 },
                    { 94, "3 Waldegghofgasse, Vienna 1170", 10, "Funkeln Diamant Resort & Spa", 4.5999999999999996 },
                    { 95, "4 Overbeckgasse, Siedlung Auhofer, Vienna 1130", 10, "Azure Erheben Hotel", 4.5999999999999996 },
                    { 96, "Gemeinde Ardagger, Bezirk Amstetten, Lower Austria 3321", 10, "Elegant Urlaub", 5.0 },
                    { 97, "5-7 Primavesigasse, Donaustadt, Vienna 1220", 10, "Strahlend Himmel Hotel", 4.7000000000000002 },
                    { 98, "33 Trauttmansdorffgasse, Vienna 1130", 10, "Luxus Golden Hotel", 4.4000000000000004 },
                    { 99, "32 Pomedt, Bezirk Scharding, Upper Austria 4752 ", 10, "Royal Oasis Hotel", 4.7999999999999998 },
                    { 100, "7 Bahngasse, Bezirk Oberpullendorf, Burgenland 7451", 10, "Elegant Komfort Hotel", 4.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
