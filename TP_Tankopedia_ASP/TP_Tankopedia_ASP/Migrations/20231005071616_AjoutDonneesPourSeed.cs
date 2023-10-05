using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Tankopedia_ASP.Migrations
{
    public partial class AjoutDonneesPourSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nations",
                columns: new[] { "Id", "ImageURL", "Name" },
                values: new object[,]
                {
                    { 1, null, "U.S.A." },
                    { 2, null, "U.S.S.R" },
                    { 3, null, "Germany" },
                    { 4, null, "China" },
                    { 5, null, "France" },
                    { 6, null, "U.K." },
                    { 7, null, "Japan" },
                    { 8, null, "Czechoslovakia" },
                    { 9, null, "Sweden" },
                    { 10, null, "Poland" },
                    { 11, null, "Italy" }
                });

            migrationBuilder.InsertData(
                table: "StrategicRoles",
                columns: new[] { "Id", "Name", "imageURL" },
                values: new object[,]
                {
                    { 1, "Versatile Light Tanks", null },
                    { 2, "Wheeled Light Tanks", null },
                    { 3, "Assault Medium Tanks", null },
                    { 4, "Versatile Medium Tanks", null },
                    { 5, "Sniper Medium Tanks", null },
                    { 6, "Support Medium Tanks", null },
                    { 7, "Assault Heavy Tanks", null },
                    { 8, "Versatile Heavy Tanks", null },
                    { 9, "Breakthrough Heavy Tanks", null },
                    { 10, "Support Heavy Tanks", null },
                    { 11, "Assault Tank Destroyers", null },
                    { 12, "Versatile Tank Destroyers", null },
                    { 13, "Sniper Tank Destroyers", null },
                    { 14, "Support Tank Destroyer", null },
                    { 15, "SPGs", null }
                });

            migrationBuilder.InsertData(
                table: "TypeTanks",
                columns: new[] { "Id", "Name", "imageURL" },
                values: new object[,]
                {
                    { 1, "Light Tank", null },
                    { 2, "Medium Tank", null },
                    { 3, "Heavy Tank", null },
                    { 4, "Tank Destroyer", null },
                    { 5, "SPGS", null }
                });

            migrationBuilder.InsertData(
                table: "Tanks",
                columns: new[] { "Id", "Description", "ImageURL", "Name", "NationID", "StrategicRoleId", "TypeID", "YearOfCreation" },
                values: new object[,]
                {
                    { 1, "Development of the first Soviet post-war medium tank started in 1951. In 1961, the T-62 tank with a smoothbore gun was deployed. At the same time a variant, the T-62A, with a rifled gun was also deployed. In March 1962, mass production of the T-62A was discontinued. The T-62 tank was mass-produced from 1961 through 1975, with a total of twenty thousand vehicles manufactured. Later modifications of the vehicle are still in service.", null, "T-62A", 2, 4, 2, new DateTime(1961, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "A project for a heavy tank with an oscillating turret and automatic loader, developed from 1951. Experimental turrets for 120 mm and 155 mm guns were manufactured by 1957. However, the project was deemed unsuccessful and development was discontinued.", null, "T57 HEAVY TANK", 1, 10, 3, new DateTime(1957, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Main battle tank of the Federal Republic of Germany. Development was started in 1956. The first prototypes were built in 1965 at the Krauss-Maffei factory. The Leopard 1 saw service in the armies of more than 10 countries.", null, "LEOPARD 1", 3, 5, 2, new DateTime(1965, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "A self-propelled gun developed on the basis of the WZ-111 heavy tank in the first half of the 1960s. The development of the WZ-111 was discontinued, and all activity on the vehicle was canceled. No prototypes were built.", null, "WZ-111G FT", 4, 12, 4, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "An experimental project for an SPG that used some elements of the U.S. M47 chassis. As compared to the Bat.-Châtillon 155 55, the vehicle had a different turret and featured the magazine loading system. Existed only in blueprints.", null, "BAT.-CHÂTILLON 155 58", 5, 15, 5, new DateTime(1960, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "A light tank project with an oscillating turret for providing anti-tank defense behind infantry positions. No prototypes were built, and it existed only in blueprints.", null, "MANTICORE ", 6, 1, 1, null },
                    { 7, "Development of the superheavy tank was started after the Battles of Khalkhyn Gol in 1939. The vehicle was designed as a maneuverable fire unit that was unprecedented in scale—its hull alone weighed 100 tons. Only one prototype was built, without a turret and made of construction steel. Trials were discontinued due to the unreliable engine; at the end of 1944, the prototype was scrapped. The 15 cm howitzer was to be mounted on the tank after its assembly.", null, "O-I ", 7, 7, 3, new DateTime(1939, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "In the early 1950s, the ČKD company developed a project of a heavy tank for the Czechoslovakian Army based on concepts of the Soviet and German tank-building schools combined with its own ideas. The project was discontinued due to the unification of armament of Warsaw Pact countries. No prototypes were ever built.", null, "TNH T VZ. 51", 8, 9, 3, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Developed from 1969 through 1971 as a modernization of the Strv 103. Unlike the previous Strv 103A version, the Strv 103B was equipped with a more powerful gas-turbine engine, laser rangefinder, and infrared devices. The vehicle also accommodated the mounting of amphibious add-on equipment. In 1970, 220 vehicles went into service. At the same time, the vehicles of the previous modification were converted to the Strv 103B, which resulted in a total of 290 vehicles by 1971.", null, "STRV 103B", 9, 13, 4, new DateTime(1971, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "The vehicle was developed in the 1950s. Using the scaling method, Polish engineers took the elements of a medium tank chassis as the base and adjusted those elements to a different weight category. They were guided by the Soviet T-54, which meant that some of the vehicle's components were similar to the first versions of the Soviet medium tank. As a result, it was an extremely interesting design with a rather low silhouette. However, it existed only in blueprints. Such a heavy vehicle would require too many resources of the Polish industry.", null, "56TP", 10, 8, 3, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "In 1969, the Italian military delegation visited Germany to discuss the purchase of Leopard tanks. However, not all members of the delegation agreed with the acquisition of foreign vehicles. The Italian military experts and engineers specified the main requirements for the future tank: the slope angle of armor plates, the cast turret and gun mantlet, as well as the powerful engine from Mitsubishi that allowed production of a small, light, maneuverable, but perfectly-armored vehicle. The British and Soviet design plans collected by SIFAR-SID were taken into account. Development of the project was discontinued at the drafting and modelling stage.", null, "PROGETTO M40 MOD. 65", 11, 6, 2, null },
                    { 12, "In the early 1960s, the 75 mm caliber guns were deemed outdated. During 1963 and 1964, a total of 650 vehicles with FL 11 turrets were re-equipped with 90 mm guns to improve their firepower. The other vehicles with the same turret and \"outdated\" guns were removed from service in the French Army.", null, "PANHARD EBR 90", 5, 2, 1, new DateTime(1964, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "Id", "AimingTime", "AmoCapacity", "EnginePower", "HullArmor", "RateOfFire", "ReloadTime", "TankId", "TopSpeed", "Weight" },
                values: new object[,]
                {
                    { 1, 2m, 50, 580, 100, 9.09m, 6.60m, 1, 50, 39.80m },
                    { 2, 2.70m, 36, 810, 228, 7.74m, 25m, 2, 35, 54.43m },
                    { 3, 1.70m, 60, 830, 70, 6.45m, 9.30m, 3, 70, 42m },
                    { 4, 2.50m, 30, 550, 200, 4.46m, 13.45m, 4, 35, 49.59m },
                    { 5, 4.50m, 36, 720, 16, 2.50m, 52m, 5, 62, 38m },
                    { 6, 1.90m, 20, 530, 50, 4.29m, 14m, 6, 68, 12.40m },
                    { 7, 3.20m, 100, 1060, 150, 5.10m, 12m, 7, 29, 150.36m },
                    { 8, 2.10m, 44, 700, 130, 6.67m, 9m, 8, 50, 50.98m },
                    { 9, 1.10m, 50, 730, 40, 8.57m, 7m, 9, 50, 40.30m },
                    { 10, 2.30m, 35, 900, 80, 4.14m, 14.50m, 10, 40, 56.10m },
                    { 11, 2.50m, 35, 750, 40, 4.32m, 10.00m, 11, 65, 40.10m },
                    { 12, 1.60m, 43, 500, 40, 7.50m, 8.00m, 12, 83, 14.83m }
                });

            migrationBuilder.InsertData(
                table: "TankModules",
                columns: new[] { "Id", "Name", "TankId", "TypeModule", "imageURL" },
                values: new object[,]
                {
                    { 1, "T-62A", 1, "Chassis", null },
                    { 2, "V-55", 1, "Engine", null },
                    { 3, "R-123", 1, "Radio", null },
                    { 4, "T-62A", 1, "Turret", null },
                    { 5, "100 MM U-8TS", 1, "Gun", null },
                    { 6, "T97", 2, "Chassis", null },
                    { 7, "CONTINENTAL AV-1790-5C", 2, "Engine", null },
                    { 8, "AN/VRC-3", 2, "Radio", null },
                    { 9, "T169", 2, "Turret", null },
                    { 10, "120 MM GUN T179", 2, "Gun", null },
                    { 11, "LEOPARD 1", 3, "Chassis", null },
                    { 12, "MTU MB 838 CAM 500A", 3, "Engine", null },
                    { 13, "SEM 25A", 3, "Radio", null },
                    { 14, "LEOPARD 1", 3, "Turret", null },
                    { 15, "10,5CM BORDKANONE L7A3", 3, "Gun", null },
                    { 16, "WZ-111G FT MODEL 4", 4, "Chassis", null },
                    { 17, "12150LTG", 4, "Engine", null },
                    { 18, "A-220A", 4, "Radio", null },
                    { 19, "152 MM 59-152JG FT", 4, "Gun", null },
                    { 20, "BatingnollesChatillon 155", 5, "Chassis", null },
                    { 21, "HISPANO-SUIZA HS 110", 5, "Engine", null },
                    { 22, "SCR 528F", 5, "Radio", null },
                    { 23, "CANON DE 155 MM", 5, "Gun", null },
                    { 24, "MANTICORE 1955", 6, "Chassis", null },
                    { 25, "ROLL-ROYCE B81", 6, "Engine", null },
                    { 26, "C42 VHF", 6, "Radio", null },
                    { 27, "MANTICORE 1955", 6, "Turret", null },
                    { 28, "QF 105 MM GUN", 6, "Gun", null },
                    { 29, "O-I KAI", 7, "Chassis", null },
                    { 30, "2X KAWASAKI TYPE 98 V-12", 7, "Engine", null }
                });

            migrationBuilder.InsertData(
                table: "TankModules",
                columns: new[] { "Id", "Name", "TankId", "TypeModule", "imageURL" },
                values: new object[,]
                {
                    { 31, "TYPE 94 MK.4 BO", 7, "Radio", null },
                    { 32, "O-I", 7, "Turret", null },
                    { 33, "15 CM HOWITZER TYPE 96", 7, "Gun", null },
                    { 34, "TNH T VZ 51 DRUHY", 8, "Chassis", null },
                    { 35, "CKD AXK2", 8, "Engine", null },
                    { 36, "RADIOSTANICE RM-31T", 8, "Radio", null },
                    { 37, "TNH T VZ 61 PRVNI", 8, "Turret", null },
                    { 38, "122 MM VZ 44-51 2A", 8, "Gun", null },
                    { 39, "STRV 103B", 9, "Chassis", null },
                    { 40, "MOTORAGGREGAT 9", 9, "Engine", null },
                    { 41, "RA 421", 9, "Radio", null },
                    { 42, "10.5 CM KAN STRV 103 L/62", 9, "Gun", null },
                    { 43, "56TP", 10, "Chassis", null },
                    { 44, "W12-5P-1", 10, "Engine", null },
                    { 45, "10RT-26PA", 10, "Radio", null },
                    { 46, "56TP", 10, "Turret", null },
                    { 47, "122 MM ARMATA WZ.56", 10, "Gun", null },
                    { 48, "PROGETTO M40 MOD.65", 11, "Chassis", null },
                    { 49, "MITSUBISHI 10ZF", 11, "Engine", null },
                    { 50, "R 19", 11, "Radio", null },
                    { 51, "PROGETTO M40 MOD.65", 11, "Turret", null },
                    { 52, "CANNONE DA 105/51 M68", 11, "Gun", null },
                    { 53, "PANGARD EBR 90", 12, "Chassis", null },
                    { 54, "PANHARD H-101", 12, "Engine", null },
                    { 55, "SCR 508", 12, "Radio", null },
                    { 56, "PANHARD EBR 90", 12, "Turret", null },
                    { 57, "90 MM CN 90 F3", 12, "Gun", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "TankModules",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tanks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StrategicRoles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TypeTanks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TypeTanks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeTanks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypeTanks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TypeTanks",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
