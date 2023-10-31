using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Reflection.Emit;
using TP_Tankopedia_ASP.Models;
using TP_Tankopedia_ASP.Utility;

namespace TP_Tankopedia_ASP.Data
{
    public static class ModelBuilderDataGenerator
    { 
        public static void GenerateData(this ModelBuilder builder)
        {    
        #region Nation
        builder.Entity<Nation>().HasData(
                new Nation() { Id = 1, Name = "U.S.A." , pictureId = 1 },
                new Nation() { Id = 2, Name = "U.S.S.R", pictureId = 2 },
                new Nation() { Id = 3, Name = "Germany", pictureId = 3 },
                new Nation() { Id = 4, Name = "China", pictureId = 4 },
                new Nation() { Id = 5, Name = "France", pictureId = 5 },
                new Nation() { Id = 6, Name = "U.K.", pictureId = 6 },
                new Nation() { Id = 7, Name = "Japan", pictureId = 7 },
                new Nation() { Id = 8, Name = "Czechoslovakia", pictureId = 8 },
                new Nation() { Id = 9, Name = "Sweden", pictureId = 9 },
                new Nation() { Id = 10, Name = "Poland", pictureId = 10 },
                new Nation() { Id = 11, Name = "Italy", pictureId = 11 }
              );
            #endregion
            #region TypeTank
            builder.Entity<TypeTank>().HasData(
                new TypeTank() { Id = 1, Name = "Light Tank" },
                new TypeTank() { Id = 2, Name = "Medium Tank" },
                new TypeTank() { Id = 3, Name = "Heavy Tank" },
                new TypeTank() { Id = 4, Name = "Tank Destroyer" },
                new TypeTank() { Id = 5, Name = "SPGS" }
              );
            #endregion
            #region StrategicRole
            builder.Entity<StrategicRole>().HasData(
                new StrategicRole() { Id = 1, Name = "Versatile Light Tanks" },
                new StrategicRole() { Id = 2, Name = "Wheeled Light Tanks" },
                new StrategicRole() { Id = 3, Name = "Assault Medium Tanks" },
                new StrategicRole() { Id = 4, Name = "Versatile Medium Tanks" },
                new StrategicRole() { Id = 5, Name = "Sniper Medium Tanks" },
                new StrategicRole() { Id = 6, Name = "Support Medium Tanks" },
                new StrategicRole() { Id = 7, Name = "Assault Heavy Tanks" },
                new StrategicRole() { Id = 8, Name = "Versatile Heavy Tanks" },
                new StrategicRole() { Id = 9, Name = "Breakthrough Heavy Tanks" },
                new StrategicRole() { Id = 10, Name = "Support Heavy Tanks" },
                new StrategicRole() { Id = 11, Name = "Assault Tank Destroyers" },
                new StrategicRole() { Id = 12, Name = "Versatile Tank Destroyers" },
                new StrategicRole() { Id = 13, Name = "Sniper Tank Destroyers" },
                new StrategicRole() { Id = 14, Name = "Support Tank Destroyer" },
                new StrategicRole() { Id = 15, Name = "SPGs" }
              );
            #endregion
            #region Tank
            builder.Entity<Tank>().HasData(
                new Tank() { Id = 1, Name = "T-62A", NationID = 2, TypeID = 2, StrategicRoleId = 4, YearOfCreation =  1961, pictureId = 12, Description = "Development of the first Soviet post-war medium tank started in 1951. In 1961, the T-62 tank with a smoothbore gun was deployed. At the same time a variant, the T-62A, with a rifled gun was also deployed. In March 1962, mass production of the T-62A was discontinued. The T-62 tank was mass-produced from 1961 through 1975, with a total of twenty thousand vehicles manufactured. Later modifications of the vehicle are still in service." },
                new Tank() { Id = 2, Name = "T57 HEAVY TANK", NationID =1, TypeID = 3, StrategicRoleId = 10, YearOfCreation =  1957, pictureId = 13, Description = "A project for a heavy tank with an oscillating turret and automatic loader, developed from 1951. Experimental turrets for 120 mm and 155 mm guns were manufactured by 1957. However, the project was deemed unsuccessful and development was discontinued." },
                new Tank() { Id = 3, Name = "LEOPARD 1", NationID = 3, TypeID = 2, StrategicRoleId = 5, YearOfCreation =  1965, pictureId = 14, Description = "Main battle tank of the Federal Republic of Germany. Development was started in 1956. The first prototypes were built in 1965 at the Krauss-Maffei factory. The Leopard 1 saw service in the armies of more than 10 countries." },
                new Tank() { Id = 4, Name = "WZ-111G FT", NationID = 4, TypeID = 4, StrategicRoleId = 12, YearOfCreation =  1960, pictureId = 15, Description = "A self-propelled gun developed on the basis of the WZ-111 heavy tank in the first half of the 1960s. The development of the WZ-111 was discontinued, and all activity on the vehicle was canceled. No prototypes were built." },
                new Tank() { Id = 5, Name = "BAT.-CHÂTILLON 155 58", NationID = 5, TypeID = 5, StrategicRoleId = 15, YearOfCreation =  1960, pictureId = 16, Description = "An experimental project for an SPG that used some elements of the U.S. M47 chassis. As compared to the Bat.-Châtillon 155 55, the vehicle had a different turret and featured the magazine loading system. Existed only in blueprints." },
                new Tank() { Id = 6, Name = "MANTICORE ", NationID = 6, TypeID = 1, StrategicRoleId = 1, YearOfCreation = null, pictureId = 17, Description = "A light tank project with an oscillating turret for providing anti-tank defense behind infantry positions. No prototypes were built, and it existed only in blueprints." },
                new Tank() { Id = 7, Name = "O-I ", NationID = 7, TypeID = 3, StrategicRoleId = 7, YearOfCreation =  1939, pictureId = 18, Description = "Development of the superheavy tank was started after the Battles of Khalkhyn Gol in 1939. The vehicle was designed as a maneuverable fire unit that was unprecedented in scale—its hull alone weighed 100 tons. Only one prototype was built, without a turret and made of construction steel. Trials were discontinued due to the unreliable engine; at the end of 1944, the prototype was scrapped. The 15 cm howitzer was to be mounted on the tank after its assembly." },
                new Tank() { Id = 8, Name = "TNH T VZ. 51", NationID = 8, TypeID = 3, StrategicRoleId = 9, YearOfCreation =  1950, pictureId = 19, Description = "In the early 1950s, the ČKD company developed a project of a heavy tank for the Czechoslovakian Army based on concepts of the Soviet and German tank-building schools combined with its own ideas. The project was discontinued due to the unification of armament of Warsaw Pact countries. No prototypes were ever built." },
                new Tank() { Id = 9, Name = "STRV 103B", NationID = 9, TypeID = 4, StrategicRoleId = 13, YearOfCreation =  1971, pictureId = 20, Description = "Developed from 1969 through 1971 as a modernization of the Strv 103. Unlike the previous Strv 103A version, the Strv 103B was equipped with a more powerful gas-turbine engine, laser rangefinder, and infrared devices. The vehicle also accommodated the mounting of amphibious add-on equipment. In 1970, 220 vehicles went into service. At the same time, the vehicles of the previous modification were converted to the Strv 103B, which resulted in a total of 290 vehicles by 1971." },
                new Tank() { Id = 10, Name = "56TP", NationID = 10, TypeID = 3, StrategicRoleId = 8, YearOfCreation =  1950, pictureId = 21, Description = "The vehicle was developed in the 1950s. Using the scaling method, Polish engineers took the elements of a medium tank chassis as the base and adjusted those elements to a different weight category. They were guided by the Soviet T-54, which meant that some of the vehicle's components were similar to the first versions of the Soviet medium tank. As a result, it was an extremely interesting design with a rather low silhouette. However, it existed only in blueprints. Such a heavy vehicle would require too many resources of the Polish industry." },
                new Tank() { Id = 11, Name = "PROGETTO M40 MOD. 65", NationID = 11, TypeID = 2, StrategicRoleId = 6, YearOfCreation = null, pictureId = 22, Description = "In 1969, the Italian military delegation visited Germany to discuss the purchase of Leopard tanks. However, not all members of the delegation agreed with the acquisition of foreign vehicles. The Italian military experts and engineers specified the main requirements for the future tank: the slope angle of armor plates, the cast turret and gun mantlet, as well as the powerful engine from Mitsubishi that allowed production of a small, light, maneuverable, but perfectly-armored vehicle. The British and Soviet design plans collected by SIFAR-SID were taken into account. Development of the project was discontinued at the drafting and modelling stage." },
                new Tank() { Id = 12, Name = "PANHARD EBR 90", NationID = 5, TypeID = 1, StrategicRoleId = 2, YearOfCreation =  1964, pictureId = 23, Description = "In the early 1960s, the 75 mm caliber guns were deemed outdated. During 1963 and 1964, a total of 650 vehicles with FL 11 turrets were re-equipped with 90 mm guns to improve their firepower. The other vehicles with the same turret and \"outdated\" guns were removed from service in the French Army." }

              );
            #endregion
            #region TankModule
            builder.Entity<TankModule>().HasData(
                new TankModule() { Id = 1, Name = "T-62A", TypeModule = "Chassis", TankId = 1 },
                new TankModule() { Id = 2, Name = "V-55", TypeModule = "Engine" , TankId = 1},
                new TankModule() { Id = 3, Name = "R-123", TypeModule = "Radio", TankId = 1},
                new TankModule() { Id = 4, Name = "T-62A", TypeModule = "Turret", TankId = 1},
                new TankModule() { Id = 5, Name = "100 MM U-8TS" , TypeModule = "Gun", TankId = 1 },
                new TankModule() { Id = 6, Name = "T97", TypeModule = "Chassis", TankId = 2 },
                new TankModule() { Id = 7, Name = "CONTINENTAL AV-1790-5C", TypeModule = "Engine", TankId = 2 },
                new TankModule() { Id = 8, Name = "AN/VRC-3", TypeModule = "Radio", TankId = 2 },
                new TankModule() { Id = 9, Name = "T169", TypeModule = "Turret", TankId = 2 },
                new TankModule() { Id = 10, Name = "120 MM GUN T179", TypeModule = "Gun", TankId = 2 },//
                new TankModule() { Id = 11, Name = "LEOPARD 1", TypeModule = "Chassis", TankId = 3 },
                new TankModule() { Id = 12, Name = "MTU MB 838 CAM 500A", TypeModule = "Engine", TankId = 3 },
                new TankModule() { Id = 13, Name = "SEM 25A", TypeModule = "Radio", TankId = 3 },
                new TankModule() { Id = 14, Name = "LEOPARD 1", TypeModule = "Turret", TankId = 3 },
                new TankModule() { Id = 15, Name = "10,5CM BORDKANONE L7A3", TypeModule = "Gun", TankId = 3 },
                new TankModule() { Id = 16, Name = "WZ-111G FT MODEL 4", TypeModule = "Chassis", TankId = 4 },
                new TankModule() { Id = 17, Name = "12150LTG", TypeModule = "Engine", TankId = 4 },
                new TankModule() { Id = 18, Name = "A-220A", TypeModule = "Radio", TankId = 4 },
                new TankModule() { Id = 19, Name = "152 MM 59-152JG FT", TypeModule = "Gun", TankId = 4 },
                new TankModule() { Id = 20, Name = "BatingnollesChatillon 155", TypeModule = "Chassis", TankId = 5 },
                new TankModule() { Id = 21, Name = "HISPANO-SUIZA HS 110", TypeModule = "Engine", TankId = 5 },
                new TankModule() { Id = 22, Name = "SCR 528F", TypeModule = "Radio", TankId = 5 },
                new TankModule() { Id = 23, Name = "CANON DE 155 MM", TypeModule = "Gun", TankId = 5 },
                new TankModule() { Id = 24, Name = "MANTICORE 1955", TypeModule = "Chassis", TankId = 6 },
                new TankModule() { Id = 25, Name = "ROLL-ROYCE B81", TypeModule = "Engine", TankId = 6 },
                new TankModule() { Id = 26, Name = "C42 VHF", TypeModule = "Radio", TankId = 6 },
                new TankModule() { Id = 27, Name = "MANTICORE 1955", TypeModule = "Turret", TankId = 6 },
                new TankModule() { Id = 28, Name = "QF 105 MM GUN", TypeModule = "Gun", TankId = 6 },
                new TankModule() { Id = 29, Name = "O-I KAI", TypeModule = "Chassis", TankId = 7 },
                new TankModule() { Id = 30, Name = "2X KAWASAKI TYPE 98 V-12", TypeModule = "Engine", TankId = 7 },
                new TankModule() { Id = 31, Name = "TYPE 94 MK.4 BO", TypeModule = "Radio", TankId = 7 },
                new TankModule() { Id = 32, Name = "O-I", TypeModule = "Turret", TankId = 7 },
                new TankModule() { Id = 33, Name = "15 CM HOWITZER TYPE 96", TypeModule = "Gun", TankId = 7 },
                new TankModule() { Id = 34, Name = "TNH T VZ 51 DRUHY", TypeModule = "Chassis", TankId = 8 },
                new TankModule() { Id = 35, Name = "CKD AXK2", TypeModule = "Engine", TankId = 8 },
                new TankModule() { Id = 36, Name = "RADIOSTANICE RM-31T", TypeModule = "Radio", TankId = 8 },
                new TankModule() { Id = 37, Name = "TNH T VZ 61 PRVNI", TypeModule = "Turret", TankId = 8 },
                new TankModule() { Id = 38, Name = "122 MM VZ 44-51 2A", TypeModule = "Gun", TankId = 8 },
                new TankModule() { Id = 39, Name = "STRV 103B", TypeModule = "Chassis", TankId = 9 },
                new TankModule() { Id = 40, Name = "MOTORAGGREGAT 9", TypeModule = "Engine", TankId = 9 },
                new TankModule() { Id = 41, Name = "RA 421", TypeModule = "Radio", TankId = 9 },
                new TankModule() { Id = 42, Name = "10.5 CM KAN STRV 103 L/62", TypeModule = "Gun", TankId = 9 },
                new TankModule() { Id = 43, Name = "56TP", TypeModule = "Chassis", TankId = 10 },
                new TankModule() { Id = 44, Name = "W12-5P-1", TypeModule = "Engine", TankId = 10 },
                new TankModule() { Id = 45, Name = "10RT-26PA", TypeModule = "Radio", TankId = 10 },
                new TankModule() { Id = 46, Name = "56TP", TypeModule = "Turret", TankId = 10 },
                new TankModule() { Id = 47, Name = "122 MM ARMATA WZ.56", TypeModule = "Gun", TankId = 10 },
                new TankModule() { Id = 48, Name = "PROGETTO M40 MOD.65", TypeModule = "Chassis", TankId = 11 },
                new TankModule() { Id = 49, Name = "MITSUBISHI 10ZF", TypeModule = "Engine", TankId = 11 },
                new TankModule() { Id = 50, Name = "R 19", TypeModule = "Radio", TankId = 11 },
                new TankModule() { Id = 51, Name = "PROGETTO M40 MOD.65", TypeModule = "Turret", TankId = 11 },
                new TankModule() { Id = 52, Name = "CANNONE DA 105/51 M68", TypeModule = "Gun", TankId = 11 },
                new TankModule() { Id = 53, Name = "PANGARD EBR 90", TypeModule = "Chassis", TankId = 12 },
                new TankModule() { Id = 54, Name = "PANHARD H-101", TypeModule = "Engine", TankId = 12 },
                new TankModule() { Id = 55, Name = "SCR 508", TypeModule = "Radio", TankId = 12 },
                new TankModule() { Id = 56, Name = "PANHARD EBR 90", TypeModule = "Turret", TankId = 12 },
                new TankModule() { Id = 57, Name = "90 MM CN 90 F3", TypeModule = "Gun", TankId = 12 }
                );
            #endregion
            #region Characteristics
            builder.Entity<Characteristics>().HasData(
                new Characteristics() { Id = 1, TankId = 1, Weight = 39.80M, EnginePower = 580, TopSpeed = 50, HullArmor = 100, AmoCapacity = 50, ReloadTime = 6.60M, AimingTime = 2, RateOfFire = 9.09M  },
                new Characteristics() { Id = 2, TankId = 2, Weight = 54.43M, EnginePower = 810, TopSpeed = 35, HullArmor = 228, AmoCapacity = 36, ReloadTime = 25, AimingTime = 2.70M, RateOfFire = 7.74M },
                new Characteristics() { Id = 3, TankId = 3, Weight = 42, EnginePower = 830, TopSpeed = 70, HullArmor = 70, AmoCapacity = 60, ReloadTime = 9.30M, AimingTime = 1.70M, RateOfFire = 6.45M },
                new Characteristics() { Id = 4, TankId = 4, Weight = 49.59M, EnginePower = 550, TopSpeed = 35, HullArmor = 200, AmoCapacity = 30, ReloadTime = 13.45M, AimingTime = 2.50M, RateOfFire = 4.46M },
                new Characteristics() { Id = 5, TankId = 5, Weight = 38, EnginePower = 720, TopSpeed = 62, HullArmor = 16, AmoCapacity = 36, ReloadTime = 52, AimingTime = 4.50M, RateOfFire = 2.50M },
                new Characteristics() { Id = 6, TankId = 6, Weight = 12.40M, EnginePower = 530, TopSpeed = 68, HullArmor = 50, AmoCapacity = 20, ReloadTime = 14, AimingTime = 1.90M, RateOfFire = 4.29M },
                new Characteristics() { Id = 7, TankId = 7, Weight = 150.36M, EnginePower = 1060, TopSpeed = 29, HullArmor = 150, AmoCapacity = 100, ReloadTime = 12, AimingTime = 3.20M, RateOfFire = 5.10M },
                new Characteristics() { Id = 8, TankId = 8, Weight = 50.98M, EnginePower = 700, TopSpeed = 50, HullArmor = 130, AmoCapacity = 44, ReloadTime = 9, AimingTime = 2.10M, RateOfFire = 6.67M },
                new Characteristics() { Id = 9, TankId = 9, Weight = 40.30M, EnginePower = 730, TopSpeed = 50, HullArmor = 40, AmoCapacity = 50, ReloadTime = 7, AimingTime = 1.10M, RateOfFire = 8.57M },
                new Characteristics() { Id = 10, TankId = 10, Weight = 56.10M, EnginePower = 900, TopSpeed = 40, HullArmor = 80, AmoCapacity = 35, ReloadTime = 14.50M, AimingTime = 2.30M, RateOfFire = 4.14M },
                new Characteristics() { Id = 11, TankId = 11, Weight = 40.10M, EnginePower = 750, TopSpeed = 65, HullArmor = 40, AmoCapacity = 35, ReloadTime = 10.00M, AimingTime = 2.50M, RateOfFire = 4.32M },
                new Characteristics() { Id = 12, TankId = 12, Weight = 14.83M, EnginePower = 500, TopSpeed = 83, HullArmor = 40, AmoCapacity = 43, ReloadTime = 8.00M, AimingTime = 1.60M, RateOfFire = 7.50M }

              );
            #endregion
            #region Picture
            builder.Entity<Picture>().HasData(
                //drapeaux
                new Picture() { pictureId = 1, FileName = "9bdcc69e-9b0a-4aaf-b79a-8c8e5537f4b5.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 2, FileName = "984bf917-4720-4011-8d12-854f1015a33f.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 3, FileName = "253a6bfd-ccbb-4296-bff3-b655b6599ebd.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 4, FileName = "8737e698-b5da-4aef-b0dc-55d8eccaf61d.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 5, FileName = "7a1e115a-b107-4637-b2c0-1e1a86ffed7d.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 6, FileName = "fe0afbdf-9fb4-4fd8-b09a-7977dbd77bc0.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 7, FileName = "00c84d4d-a645-44f2-8b1a-eabf0e3c62d4.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 8, FileName = "c5d1102f-34bd-46a0-9e6a-ab2544cb9621.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 9, FileName = "b360c5ac-dc5e-4310-a833-15a0af7a1929.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 10, FileName = "5a428329-03db-458b-b882-5192fbd9ebe9.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 11,FileName = "8876fef9-7f61-4f1b-b2ed-aa1c03a7eb23.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                //tanks
                new Picture() { pictureId = 12, FileName = "0cdd4032-0352-4254-9161-5d8f5fc33287.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 13, FileName = "b6f2b7c6-1914-4ecf-8271-791089c22b1c.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 14, FileName = "0a66050b-617b-426d-8d01-1cfdc53f6a9c.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 15, FileName = "9e04a735-2cdf-4151-81aa-f9319e5ab21a.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 16, FileName = "f90f830b-0acb-4ae3-8bfe-aee7622be9a5.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 17, FileName = "333249ff-b0a1-479b-a988-89caa173e1dc.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 18, FileName = "564e8122-f919-4b3e-a248-c5f572be4b60.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 19, FileName = "5ff17622-d961-432c-be99-66a58024a72f.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 20, FileName = "c721c906-08a7-4f73-af0d-fbf4984ad193.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 21, FileName = "4136038d-1213-4646-8d74-4bd152fa0e93.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 22, FileName = "590fbeff-440c-44c7-ac82-cdd8b879be67.png", MimeType = "image/png", DateOfAddition = DateTime.Now },
                new Picture() { pictureId = 23, FileName = "152499c3-41c5-460f-92e0-330b4462895e.png", MimeType = "image/png", DateOfAddition = DateTime.Now }
              );
            #endregion
            #region Rôles
            // Rôles de base
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = AppConstants.AdminRole
                    ,
                    NormalizedName = AppConstants.AdminRole.ToUpper()
                },
                 new IdentityRole
                 {
                     Name = AppConstants.TankCommander,
                     NormalizedName = AppConstants.TankCommander.ToUpper()
                 },
                  new IdentityRole
                  {
                      Name = AppConstants.Visitor,
                      NormalizedName = AppConstants.Visitor.ToUpper()
                  }
                );
            #endregion
            #region Users
            // Création des rôles initiaux
            //Administrator
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            User admin = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Admin",
                Email = "admin@tankopedia.ca",
                NormalizedEmail = "ADMIN@TANKOPEDIA.COM",
                NormalizedUserName = "ADMIN"
            };
            admin.PasswordHash = hasher.HashPassword(admin, AppConstants.testInitPassword);//Test123!

            //Moderator
            User tankCommander = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Commander",
                Email = "commander@tankopedia.ca",
                NormalizedEmail = "COMMANDER@TANKOPEDIA.COM",
                NormalizedUserName = "COMMANDER"
            };
            tankCommander.PasswordHash = hasher.HashPassword(tankCommander, AppConstants.testInitPassword);//Test123!

            //Visiteur
            User visitor = new User
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Visitor",
                Email = "visitor@tankopedia.ca",
                NormalizedEmail = "VISITOR@TANKOPEDIA.COM",
                NormalizedUserName = "VISITOR"
            };
            visitor.PasswordHash = hasher.HashPassword(visitor, AppConstants.testInitPassword);//Test123!

            //SEED
            builder.Entity<User>().HasData(admin, tankCommander, visitor);

            //Nous attribuons le rôle d'administrateur à l'aide de ITankopediaUserService et program.cs
            //Attribuer des rôles à tout nouvel utilisateur = "Visiteur" dans l'action Register/UsersController

            #endregion
        }
    }
}
