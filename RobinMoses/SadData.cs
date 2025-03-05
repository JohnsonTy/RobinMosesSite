using RobinMoses.Data;
using RobinMoses.Models;
using Microsoft.AspNetCore.Identity;

namespace RobinMoses
{
    public class SadData
    {
        public static void Seed(WebDbContext context, IServiceProvider provider)
        {
            if (!context.MenuItems.Any())
            {
                //  ADMIN HERE
                var userManager = provider.GetRequiredService<UserManager<AppUser>>();
                var roleManager = provider.GetRequiredService<RoleManager<IdentityRole>>();

                const string ROLE = "Admin";
                const string SECRET_PASSWORD = "Secret!123";

                //// if role doesn't exist, create it
                bool isSuccess = true;
                if (roleManager.FindByNameAsync(ROLE).Result == null)
                {
                    isSuccess = roleManager.CreateAsync(new IdentityRole(ROLE)).Result.Succeeded;
                }

                var user1 = new AppUser { UserName = "Gabby"};
                

                isSuccess &= userManager.CreateAsync(user1, SECRET_PASSWORD).Result.Succeeded;
                if (isSuccess)
                {
                    isSuccess &= userManager.AddToRoleAsync(user1, ROLE).Result.Succeeded;
                }


                //////////////////////
                //  FOOD MENU HERE  //
                //////////////////////
                
                //  BOTANAS/APPETIZERS
                var Queso = new MenuItem
                {
                    Name = "Chula's Queso Dip",
                    Description = "A creamy, cheesy and spicy dip melted to perfection.",
                    Category = "Botanas",
                    Price = 7.25
                };
                context.MenuItems.Add(Queso);

                var RobinMosesNachos = new MenuItem
                {
                    Name = "Chula's Nachos",
                    Description = "Loaded tortilla chips served with melted cheese, beans, onions, tomatoes, jalapeños, sour cream, guacamole, and your choice of Chicken, Ground Beef, Shredded Beef. - Carne Asada, Carnitas, Al Pastor or Chile Verde (pork): add $1.00 - Meat & Cheese Nachos: $7.50",
                    Category = "Botanas",
                    Price = 12.25
                };
                context.MenuItems.Add(RobinMosesNachos);

                var Quesadilla = new MenuItem
                {
                    Name = "Quesadilla",
                    Description = "Our quesadillas are stuffed with Monterey Jack cheese, Cheddar cheese, onions and tomatoes, topped with sour cream and guacamole. Choose from: Chicken, Ground Beef, Shredded Beef or Veggies. - Carne Asada, Carnitas, Al Pastor, Chile Verde (pork): add $1.00",
                    Category = "Botanas",
                    Price = 12.25
                };
                context.MenuItems.Add(Quesadilla);

                var Flautas = new MenuItem
                {
                    Name = "Chicken Flautas (4)",
                    Description = "Chicken rolled up in a flour tortilla and deep fried until golden brown. Served with guacamole and sour cream. With rice and beans: $13.25",
                    Category = "Botanas",
                    Price = 10.25
                };
                context.MenuItems.Add(Flautas);

                var PolloFundido = new MenuItem
                {
                    Name = "Pollo Fundido (3)",
                    Description = "Chicken and Monterey Jack cheese rolled up in a flour tortilla and fried golden brown. Topped with spicy cream cheese sauce and cheese, then baked in the oven. Served with sour cream and guacamole.",
                    Category = "Botanas",
                    Price = 11.25
                };
                context.MenuItems.Add(PolloFundido);

                var Frachos = new MenuItem
                {
                    Name = "Frachos",
                    Description = "Fries topped with jalapenos and your choice of bacon or carne asada. Covered in melted cheese and garnished with pico de Gallo and guacamole. Ask your server for our Chipotle Ranch for the perfect combination.",
                    Category = "Botanas",
                    Price = 11.25
                };
                context.MenuItems.Add(Frachos);


                //  SPECIALTIES
                var Taquitos = new MenuItem
                {
                    Name = "Taquitos (4)",
                    Description = "Crispy tortillas rolled and topped with carrots, lettuce, tomatoes, cheese, and guacamole. Choose from Potato, Chicken, or Shredded Beef.",
                    Category = "Specialties",
                    Price = 9.75
                };
                context.MenuItems.Add(Taquitos);

                var Sopes = new MenuItem
                {
                    Name = "Sopes",
                    Description = "Shallow shell of masa that is grilled and stuffed with beans and topped with lettuce and sour cream, and sprinkled with cotija cheese and your choice of Chicken, Ground Beef, or Shredded Beef. - Carne Asada, Al Pastor, Chile Verde (pork)or Carnitas: add $1.00",
                    Category = "Specialties",
                    Price = 7.75
                };
                context.MenuItems.Add(Sopes);

                var Torta = new MenuItem
                {
                    Name = "Torta (Mexican Sandwhich)",
                    Description = "Mayonnaise, lettuce, tomatoes, avocado, onions, and cheese and choice of meat: Carne Asada, Carnitas, Al Pastor, or Chicken. - With fries: $13.50",
                    Category = "Specialties",
                    Price = 11.75
                };
                context.MenuItems.Add(Torta);

                var Huaraches = new MenuItem
                {
                    Name = "Huaraches",
                    Description = "A Mexican dish consisting of an oblong masa topped with melted cheese and your choice of carnitas, carne asada, al pastor, shredded beef, chicken, or chile verde. Garnished with lettuce, sour cream, cotija cheese, avocado and tomatoes.",
                    Category = "Specialties",
                    Price = 10.25
                };
                context.MenuItems.Add(Huaraches);

                var PlazaQuesadilla = new MenuItem
                {
                    Name = "Plaza Quesadilla",
                    Description = "Two freshly made oversized corn tortillas. Filled with melted cheese and carne asada. Topped with lettuce, cotija cheese, avocado, grilled onions and sour cream.",
                    Category = "Specialties",
                    Price = 11.25
                };
                context.MenuItems.Add(PlazaQuesadilla);

                //  SOUP
                var TortillaSoup = new MenuItem
                {
                    Name = "Tortilla Soup",
                    Description = "Delicious broth with chunks of avocado, cheese and Charbroiled chicken topped with sour cream and tortilla strips. - Bowl: $8.95",
                    Category = "Soup",
                    Price = 6.95
                };
                context.MenuItems.Add(TortillaSoup);

                var SoupSalad = new MenuItem
                {
                    Name = "Soup & Salad",
                    Description = "A cup of Tortilla soup with your choice of a taco or tostada salad.",
                    Category = "Soup",
                    Price = 10.75
                };
                context.MenuItems.Add(SoupSalad);

                //  BURRITOS
                var CaliforniaBurrito = new MenuItem
                {
                    Name = "Chula's California Burrito",
                    Description = "Comes with carne asada, guacamole, cheese, french fries, pico de gallo, and delicious ranch chipotle sauce. Substitute other meat: add $1.50",
                    Category = "Burritos",
                    Price = 11.25
                };
                context.MenuItems.Add(CaliforniaBurrito);

                var MexicanBLT = new MenuItem
                {
                    Name = "Mexican BLT",
                    Description = "Grilled chicken, bacon, cheese, lettuce, tomato, guacamole and chipotle ranch in a flour tortilla.",
                    Category = "Burritos",
                    Price = 11.75
                };
                context.MenuItems.Add(MexicanBLT);

                var QuesoCornBurrito = new MenuItem
                {
                    Name = "Queso Corn Burrito",
                    Description = "A burrito filled with rice, beans and your choice of chicken, ground beef or shredded beef. Topped with our flavorful queso corn salsa. Served with pico de gallo and guacamole.",
                    Category = "Burritos",
                    Price = 13.25
                };
                context.MenuItems.Add(QuesoCornBurrito);

                var BurritoRelleno = new MenuItem
                {
                    Name = "Burrito Relleno",
                    Description = "A Chile Relleno, rice, beans, sour cream and cheese.",
                    Category = "Burritos",
                    Price = 10.75
                };
                context.MenuItems.Add(BurritoRelleno);

                var BreakfastBurrito = new MenuItem
                {
                    Name = "Breakfast Burrito",
                    Description = "Stuffed with eggs, potato, cheese and your choice of bacon or sausage.",
                    Category = "Burritos",
                    Price = 8.25
                };
                context.MenuItems.Add(BreakfastBurrito);

                var BeanCheeseBurrito= new MenuItem
                {
                    Name = "Bean & Cheese Burrito",
                    Description = "A 12-inch flour tortilla stuffed with beans and cheese. Add meat for $2.50.",
                    Category = "Burritos",
                    Price = 6.25
                };
                context.MenuItems.Add(BeanCheeseBurrito);

                //  CHECK THIS ONE
                var WetBurrito = new MenuItem
                {
                    Name = "Wet Burrito",
                    Description = "Rice, beans, and cheese topped with lettuce, pico de gallo and your choice of sour cream or guacamole. Add $1.00 for sour cream and guacamole.\r\nComes with your choice of:\r\nChicken, Ground Beef, Shredded Beef, Tofu, Carne Asada (add $1.00), Chile Verde (add $1.00), Al Pastor (add $1.00), Carnitas (add $1.00), Veggies, Egg, Steak (add $3.25) or Grilled Chicken (add $3.25)",
                    Category = "Burritos",
                    Price = 13.25
                };
                context.MenuItems.Add(WetBurrito);

                var LoadedBurrito = new MenuItem
                {
                    Name = "Loaded Burrito",
                    Description = "Rice, beans, cheese, pico de gallo, lettuce, choice of guacamole or sour cream. Add $1.00 for sour cream and guacamole. Same protein options as Wet Burrito.",
                    Category = "Burritos",
                    Price = 11.25
                };
                context.MenuItems.Add(LoadedBurrito);

                var BurritoBowl = new MenuItem
                {
                    Name = "Burrito Bowl",
                    Description = "Rice, beans, and cheese, pico de gallo, lettuce, choice of guacamole or sour cream. Served in a bowl. Add $1.00 for sour cream and guacamole. Same protein options as Wet Burrito. *We can make any burrito into a bowl, just lettuce know!",
                    Category = "Burritos",
                    Price = 11.25
                };
                context.MenuItems.Add(BurritoBowl);

                //  FAJITAS
                var Fajita = new MenuItem
                {
                    Name = "Fajitas",
                    Description = "Sizzling hot fajitas on a bed of sautéed peppers and onions. Served with rice, beans, sour cream, guacamole, cheese, lettuce and pico de gallo. Choose: Carnitas, Grilled Chicken, Veggies or Steak. (Shrimp Fajita $21.25)",
                    Category = "Fajitas",
                    Price = 18.75
                };
                context.MenuItems.Add(Fajita);

                var FajitaBurrito = new MenuItem
                {
                    Name = "Fajita Burrito",
                    Description = "Rice, beans, cheese, sautéed bell peppers and onions garnished with lettuce, pico de gallo, sour cream, guacamole and your choice of grilled chicken or steak. (Shrimp $2.00 extra)",
                    Category = "Fajitas",
                    Price = 17.50
                };
                context.MenuItems.Add(FajitaBurrito);

                //  Check this one 
                var ComboPlates = new MenuItem
                {
                    Name = "Combo Plates",
                    Description = "All plates come with rice and beans. Choose one: $10.25 or Choose two: $12.25" +
                    "Choose from: Chicken, Ground Beef, Shredded Beef, Chile Verde (pork), Cheese, or Veggies. \r\n\r\nHard Taco • Tostada • Chile Relleno ($1.00 extra) • Tamal (wet) • Burrito • Enchilada • Taquitos (2) • Street Taco • Chimichanga",
                    Category = "Combos",
                    Price = 10.25
                };
                context.MenuItems.Add(ComboPlates);

                //  TACOS
                var StreetTaco = new MenuItem
                {
                    Name = "Street Taco",
                    Description = "Homemade Tortillas. Tacos come with cabbage, cilantro and onions." +
                    "Choice of Meats: Chicken, Ground Beef, Shredded Beef, Carne Asada, Carnitas, Al Pastor, Chile Verde, Grilled Chicken & Guacamole (add $2.00), Grilled Steak & Guacamole (add $2.00)" +
                    "Shrimp or Fish tacos come with cabbage, pico de gallo and guacamole (add $2.00)\r\n\r\nTofu tacos come with pico de gallo and guacamole (add $1.50)",
                    Category = "Tacos",
                    Price = 3.95
                };
                context.MenuItems.Add(StreetTaco);

                var HardTaco = new MenuItem
                {
                    Name = "Hard Taco",
                    Description = "Topped with lettuce, cheese, carrots and cotija cheese." +
                    "\"Choice of Meats: Chicken, Ground Beef, Shredded Beef, Carne Asada, Carnitas, Al Pastor, or Potato",
                    Category = "Tacos",
                    Price = 3.95
                };
                context.MenuItems.Add(HardTaco);

                //  ENCHILADAS
                var Enchiladas = new MenuItem
                {
                    Name = "Enchiladas",
                    Description = "Choose one: $10.25 Choose two: $12.25 Topped with cheese and your choice of sauce. Includes rice and beans." +
                    "Choose from: Chicken, Ground Beef, Shredded Beef, Cheese, Carne Asada, Chile Verde (pork), or Carnitas" +
                    "•Regular - Red house enchilada sauce\r\n•Suiza - Delicious tomatillo sauce\r\n•Crema - Creamy sour cream parmesan sauce\r\n•Mole - Rich dark mole sauce",
                    Category = "Enchiladas",
                    Price = 10.25
                };
                context.MenuItems.Add(Enchiladas);

                var SpinachEnchilada = new MenuItem
                {
                    Name = "Spinach Enchilada",
                    Description = "Corn tortilla stuffed with fresh baby spinach, tomatoes and Monterey Jack cheese. Topped with our house suiza sauce. One: $10.50 Two: $12.50",
                    Category = "Enchiladas",
                    Price = 10.50
                };
                context.MenuItems.Add(SpinachEnchilada);

                var VeggieEchilada = new MenuItem
                {
                    Name = "Veggie Echilada",
                    Description = "Corn tortilla stuffed with fresh broccoli, cauliflower, red peppers and yellow peppers, yellow squash and zucchini. Topped with our red house enchilada sauce. One: $10.50 Two: $12.50",
                    Category = "Enchiladas",
                    Price = 10.50
                };
                context.MenuItems.Add(VeggieEchilada);

                var ShrimpEnchilada = new MenuItem
                {
                    Name = "Shrimp Enchilada",
                    Description = "Tasty shrimp sautéed and topped with cream sauce, pico de gallo and sliced avacado. One: $13.25 Two: $15.75",
                    Category = "Enchiladas",
                    Price = 13.75
                };
                context.MenuItems.Add(ShrimpEnchilada);

                var PlazaEnchilada = new MenuItem
                {
                    Name = "Plaza Enchilada",
                    Description = "Two slightly crispy corn tortillas rolled up with your choice of chicken, shredded beef, ground beef, chile verde (pork) or carnitas. Topped with lettuce, carrots, cotija cheese, avocado, sour cream and green hot sauce (not served with rice or beans).",
                    Category = "Enchiladas",
                    Price = 11.25
                };
                context.MenuItems.Add(PlazaEnchilada);

                //  SALADS
                var TacoTostadaSalad = new MenuItem
                {
                    Name = "Taco/Tostada Salad",
                    Description = "Lettuce, pico de gallo, cheese, and avocado topped with crispy corn tortilla chips, pepitas (pumpkin seeds) and your choice of chicken, ground beef, shredded beef, chile verde (pork), carne asada, carnitas or al pastor Tostada Salad Comes on a crispy flat tortilla and your choice of refried or black beans.\r\nDressings:Chipotle Ranch, Ranch and Bleu Cheese.\r\nAdd $1.00 for sour cream and guacamole",
                    Category = "Salads",
                    Price = 12.95
                };
                context.MenuItems.Add(TacoTostadaSalad);

                //  DESSERTS
                var Sopapillas = new MenuItem
                {
                    Name = "Sopapillas",
                    Description = "A fresh flour tortilla lightly fried till crisp. Topped with cinnamon sugar, honey, whipped cream and drizzled with chocolate syrup",
                    Category = "Desserts",
                    Price = 4.50
                };
                context.MenuItems.Add(Sopapillas);

                var FriedIceCream = new MenuItem
                {
                    Name = "Fried Ice Cream",
                    Description = "Vanilla ice cream rolled in a crunchy topping and fried till crispy. Drizzled with chocolate syrup and topped with whipped cream.",
                    Category = "Desserts",
                    Price = 5.75
                };
                context.MenuItems.Add(FriedIceCream);

                var Flan = new MenuItem
                {
                    Name = "Flan",
                    Description = "Rich and creamy, delicate vanilla custard with carmelized sugar. Topped with whipped cream and cinnamon and sugar.",
                    Category = "Desserts",
                    Price = 5.75
                };
                context.MenuItems.Add(Flan);

                var Churros = new MenuItem
                {
                    Name = "Churros",
                    Description = "Warm and crispy churros stuffed with strawberry or apple. Topped with cinnamon and sugar and whipped cream.",
                    Category = "Desserts",
                    Price = 5.75
                };
                context.MenuItems.Add(Churros);

                //  CHULAS FAVORITES
                var CarneAsada = new MenuItem
                {
                    Name = "Carne Asada",
                    Description = "Tender skirt steak charbroiled and topped with grilled onions and guacamole",
                    Category = "Favorites",
                    Price = 20.25
                };
                context.MenuItems.Add(CarneAsada);

                var ChickenPorkCarnitas = new MenuItem
                {
                    Name = "Chicken Or Pork Carnitas",
                    Description = "Comes with onions, bell pepper and guacamole.",
                    Category = "Favorites",
                    Price = 17.25
                };
                context.MenuItems.Add(ChickenPorkCarnitas);

                var PolloCrema = new MenuItem
                {
                    Name = "Pollo A La Crema",
                    Description = "Chicken tossed with our savory sour cream parmesan cheese sauce.",
                    Category = "Favorites",
                    Price = 17.75
                };
                context.MenuItems.Add(PolloCrema);

                var ChickenEnMole = new MenuItem
                {
                    Name = "Chicken En Mole",
                    Description = "Delicious rich mole sauce tossed with chicken.",
                    Category = "Favorites",
                    Price = 17.75
                };
                context.MenuItems.Add(ChickenEnMole);

                var PolloChipotle = new MenuItem
                {
                    Name = "Pollo Chipotle",
                    Description = "Sautéed chicken in our homemade chipotle sauce (slightly spicy).",
                    Category = "Favorites",
                    Price = 17.75
                };
                context.MenuItems.Add(PolloChipotle);


                var ChileVerde = new MenuItem
                {
                    Name = "Chile Verde",
                    Description = "Tender chunks of pork, slow cooked in a green jalapeño chile sauce, garlic and tomatillos and topped with cheese.",
                    Category = "Favorites",
                    Price = 17.75
                };
                context.MenuItems.Add(ChileVerde);


                var RellanoYPolloAsado = new MenuItem
                {
                    Name = "Rellano Y Pollo Asado",
                    Description = "A relleno with charbroiled chicken topped with sour cream and guacamole",
                    Category = "Favorites",
                    Price = 18.50
                };
                context.MenuItems.Add(RellanoYPolloAsado);


                var ArrozConPollo = new MenuItem
                {
                    Name = "ArrozConPollo",
                    Description = "Sautéed chicken and mushrooms tossed in our homemade salsa poured over a bed of rice and melted cheese. Substitute Shrimp $1.25",
                    Category = "Favorites",
                    Price = 17.75
                };
                context.MenuItems.Add(ArrozConPollo);

                //  SHRIMP ENTREES
                var BaconWrappedShrimp = new MenuItem
                {
                    Name = "Bacon Wrapped Shrimp",
                    Description = "Delicious shrimp wrapped with bacon and topped with cheese served on a bed of onions and green peppers served with guacamole and pico de gallo.",
                    Category = "Shrimp",
                    Price = 20.25
                };
                context.MenuItems.Add(BaconWrappedShrimp);

                var DiablasCamarones = new MenuItem
                {
                    Name = "DiablasCamarones",
                    Description = "Shrimp, onions and mushrooms sautéed in a sweet and spicy red sauce, garnished with avocado.",
                    Category = "Shrimp",
                    Price = 18.95
                };
                context.MenuItems.Add(DiablasCamarones);

                var MojoDeAjoCamarones = new MenuItem
                {
                    Name = "Mojo De Ajo Camarones",
                    Description = "Shrimp, onions and mushrooms in a delicious garlic butter sauce, garnished with avocado.",
                    Category = "Shrimp",
                    Price = 18.95
                };
                context.MenuItems.Add(MojoDeAjoCamarones);

                var CamaronesALaCrema = new MenuItem
                {
                    Name = "Camarones A La Crema",
                    Description = "Shrimp, onions, green pappers and mushrooms sauteed in our savory sour cream parmesean cheese sauce, garnished with lettuce and tomatoes.",
                    Category = "Shrimp",
                    Price = 18.95
                };
                context.MenuItems.Add(CamaronesALaCrema);

                //  SIDES
                var GuacamoleSmall = new MenuItem
                {
                    Name = "Small Guacamole",
                    Description = " ",
                    Category = "Sides",
                    Price = 2.95
                };
                context.MenuItems.Add(GuacamoleSmall);

                var GuacamoleLarge = new MenuItem
                {
                    Name = "Large Guacamole",
                    Description = " ",
                    Category = "Sides",
                    Price = 4.95
                };
                context.MenuItems.Add(GuacamoleLarge);

                var SideFries = new MenuItem
                {
                    Name = "Side Of Fries",
                    Description = " ",
                    Category = "Sides",
                    Price = 5.75
                };
                context.MenuItems.Add(SideFries);

                var SideBurrito = new MenuItem
                {
                    Name = "Side Burrito",
                    Description = " ",
                    Category = "Sides",
                    Price = 6.25
                };
                context.MenuItems.Add(SideBurrito);

                //  FIXED LATER
                var SideEnchilada = new MenuItem
                {
                    Name = "Side Enchilada",
                    Description = " ",
                    Category = "Sides",
                    Price = 18.95
                };
                context.MenuItems.Add(SideEnchilada);

                var SideRice = new MenuItem
                {
                    Name = "Side of Rice",
                    Description = " ",
                    Category = "Sides",
                    Price = 3.95
                };
                context.MenuItems.Add(SideRice);

                var SideSourCream = new MenuItem
                {
                    Name = "Side of Sour Cream",
                    Description = " ",
                    Category = "Sides",
                    Price = 1.95
                };
                context.MenuItems.Add(SideSourCream);

                var SideChimi = new MenuItem
                {
                    Name = "Side Chimichanga",
                    Description = " ",
                    Category = "Sides",
                    Price = 6.95
                };
                context.MenuItems.Add(SideChimi);

                var SideTostada = new MenuItem
                {
                    Name = "Side Tostada",
                    Description = " ",
                    Category = "Sides",
                    Price = 4.50
                };
                context.MenuItems.Add(SideTostada);

                var Avocado = new MenuItem
                {
                    Name = "Side of Avocado",
                    Description = " ",
                    Category = "Sides",
                    Price = 2.75
                };
                context.MenuItems.Add(Avocado);

                var SideRelleno = new MenuItem
                {
                    Name = "Side Chile Relleno",
                    Description = " ",
                    Category = "Sides",
                    Price = 6.25
                };
                context.MenuItems.Add(SideRelleno);

                var SideRiceBeans = new MenuItem
                {
                    Name = "Side of Rice and Beans",
                    Description = " ",
                    Category = "Sides",
                    Price = 4.25
                };
                context.MenuItems.Add(SideRiceBeans);

                var SideBeans = new MenuItem
                {
                    Name = "Side of Beans",
                    Description = " ",
                    Category = "Sides",
                    Price = 3.95
                };
                context.MenuItems.Add(SideBeans);

                var Side5Shrimp = new MenuItem
                {
                    Name = "Side of 5 Shrimp",
                    Description = " ",
                    Category = "Sides",
                    Price = 4.50
                };
                context.MenuItems.Add(Side5Shrimp);

                var SideVeggies = new MenuItem
                {
                    Name = "Side of Veggies",
                    Description = " ",
                    Category = "Sides",
                    Price = 4.25
                };
                context.MenuItems.Add(SideVeggies);

                var SideSteak = new MenuItem
                {
                    Name = "Side of 3oz Steak",
                    Description = " ",
                    Category = "Sides",
                    Price = 6.25
                };
                context.MenuItems.Add(SideSteak);

                var SideJalapeno = new MenuItem
                {
                    Name = "Side Jalapeno",
                    Description = " ",
                    Category = "Sides",
                    Price = 0.75
                };
                context.MenuItems.Add(SideJalapeno);

                var SideMeat = new MenuItem
                {
                    Name = "Side of Meat",
                    Description = " ",
                    Category = "Sides",
                    Price = 5.75
                };
                context.MenuItems.Add(SideMeat);

                var SideChicken = new MenuItem
                {
                    Name = "Side of 3oz Grilled Chicken",
                    Description = " ",
                    Category = "Sides",
                    Price = 5.75
                };
                context.MenuItems.Add(SideChicken);

                //  DRINKS
                var Jarritos = new MenuItem
                {
                    Name = "Jarritos",
                    Description = "Mango, Lime, Guava, Mandarin, Strawberry, Fruit Punch, Grapefruit, Pineapple, Tamarind and Jamaica.",
                    Category = "Drinks",
                    Price = 3.75
                };
                context.MenuItems.Add(Jarritos);

                var Horchata = new MenuItem
                {
                    Name = "Horchata",
                    Description = "Mexican rice milk with cinnamon and vanilla.",
                    Category = "Drinks",
                    Price = 3.50
                };
                context.MenuItems.Add(Horchata);

                var StrawberryLemonade = new MenuItem
                {
                    Name = "Strawberry Lemonade",
                    Description = " ",
                    Category = "Drinks",
                    Price = 3.50
                };
                context.MenuItems.Add(StrawberryLemonade);

                var CokeRootBeer = new MenuItem
                {
                    Name = "Bottled Coca-Cola or Bottled Rootbeer",
                    Description = " ",
                    Category = "Drinks",
                    Price = 3.75
                };
                context.MenuItems.Add(Jarritos);

                var FountainDrink = new MenuItem
                {
                    Name = "Jarritos",
                    Description = "Pepsi, Diet Pepsi, Sierra Mist, Mt. Dew, Dr. Pepper, Diet Dr. Pepper, Crush Orange, and Lemonade.",
                    Category = "Drinks",
                    Price = 3.25
                };
                context.MenuItems.Add(Jarritos);

                var SidralMundet = new MenuItem
                {
                    Name = "Jarritos",
                    Description = "",
                    Category = "Drinks",
                    Price = 3.75
                };
                context.MenuItems.Add(SidralMundet);


                //////////////////////
                //  DRINK MENU HERE //
                //////////////////////

                var RegularMarg = new MenuItem
                {
                    Name = "Regular Margarita",
                    Description = "Chula's house-made margarita. Add strawberry, raspberry, mango, peach, or guava for a little extra kick.",
                    Category = "Margaritas",
                    Price = 8.50
                };
                context.MenuItems.Add(RegularMarg);

                var CadilacMarg = new MenuItem
                {
                    Name = "Cadilac Margarita",
                    Description = "Hornitos Reposado, Orange Liquor, and Chula's house-made margarita mix.",
                    Category = "Margaritas",
                    Price = 12.25
                };
                context.MenuItems.Add(CadilacMarg);

                var TopShelfMarg = new MenuItem
                {
                    Name = "Top Shelf Margarita",
                    Description = "Choose from our wide variety of tequilas. Lime, lemon and orange muddled with agave and topped with Grand Marnier. (Prices range based on tequila preference.)",
                    Category = "Margaritas",
                    Price = 12.25
                };
                context.MenuItems.Add(TopShelfMarg);

                var RobinMosesTopShelf = new MenuItem
                {
                    Name = "Chula's Top Shelf Margarita",
                    Description = "It's blue! Casamigos, Cointreau, lime and lemon muddled with agave and topped with Blue Raspberry.",
                    Category = "Margaritas",
                    Price = 14.95
                };
                context.MenuItems.Add(RobinMosesTopShelf);

                var Coronarita = new MenuItem
                {
                    Name = "Corona-Rita Margarita",
                    Description = "Two drinks in one! Our regular margarita on the rocks, topped with a Coronita.",
                    Category = "Margaritas",
                    Price = 12.25
                };
                context.MenuItems.Add(Coronarita);

                var SkinnyMarg = new MenuItem
                {
                    Name = "Skinny Margarita",
                    Description = "The classic tart margarita without the guilt.",
                    Category = "Margaritas",
                    Price = 10.75
                };
                context.MenuItems.Add(SkinnyMarg);

                var Mangonada = new MenuItem
                {
                    Name = "Mangonada Margarita",
                    Description = "A blended mango margarita poured in a glass drizzled with Chamoy topped with Tajin.",
                    Category = "Margaritas",
                    Price = 9.25
                };
                context.MenuItems.Add(Mangonada);

                var BasilMarg = new MenuItem
                {
                    Name = "Basil Lime Margarita",
                    Description = "Muddled basil and limes, agave, tequila and soda water.",
                    Category = "Margaritas",
                    Price = 9.25
                };
                context.MenuItems.Add(BasilMarg);

                var CoconutMarg = new MenuItem
                {
                    Name = "Coconut Margarita",
                    Description = "1800 Coconut Tequila, Coco Lopez and Chula's house-made margarita on the rocks.",
                    Category = "Margaritas",
                    Price = 9.25
                };
                context.MenuItems.Add(CoconutMarg);

                var SpicyMarg = new MenuItem
                {
                    Name = "Spicy Jalapeno Margarita",
                    Description = "Muddled jalapenos with Chula's house-made margarita mix served on the rocks with Tajin on the rim.",
                    Category = "Margaritas",
                    Price = 8.95
                };
                context.MenuItems.Add(SpicyMarg);

                var Rumchata = new MenuItem
                {
                    Name = "Rumchata",
                    Description = "Dark Aged Cruzan Rum topped with our house-made horchata and sprinkled with cinnamon and sugar.",
                    Category = "SpecialDrinks",
                    Price = 8.75
                };
                context.MenuItems.Add(Rumchata);

                var Micheladas = new MenuItem
                {
                    Name = "Micheladas",
                    Description = "Pacifico, fresh lime, Clamato juice, Tabasco, seasonings and Tajin on the rim",
                    Category = "SpecialDrinks",
                    Price = 8.95
                };
                context.MenuItems.Add(Micheladas);

                var ElectricBluegaloo = new MenuItem
                {
                    Name = "Electric Bluegaloo",
                    Description = "Muddled lemons, vodka, blue raspberry, and lemonade.",
                    Category = "SpecialDrinks",
                    Price = 10.15
                };
                context.MenuItems.Add(ElectricBluegaloo);

                var Paloma = new MenuItem
                {
                    Name = "Paloma",
                    Description = "Tequila, lime, grapefruit juice and a splash of soda water.",
                    Category = "ClassicDrinks",
                    Price = 8.95
                };
                context.MenuItems.Add(Paloma);

                var MexicanCandy = new MenuItem
                {
                    Name = "Mexican Candy",
                    Description = "Smirnoff Spicy Tamarind Vodka, raspberry puree, and cranberry juice served over ice with Chamoy and Tajin.",
                    Category = "SpecialDrinks",
                    Price = 10.75
                };
                context.MenuItems.Add(MexicanCandy);

                var Mule = new MenuItem
                {
                    Name = "Mule",
                    Description = "Vodka or tequila, ginger beer, simple syrup and lime.",
                    Category = "ClassicDrinks",
                    Price = 8.75
                };
                context.MenuItems.Add(Mule);

                var Daiquiri = new MenuItem
                {
                    Name = "Daiquiri",
                    Description = "Rum blended with sweet and sour mix and your choice of strawberry, raspberry, mango, peach or guava and topped with whipped cream",
                    Category = "ClassicDrinks",
                    Price = 8.95
                };
                context.MenuItems.Add(Daiquiri);

                var PinaColada = new MenuItem
                {
                    Name = "Pina Colada",
                    Description = "Rum blended with pineapple and coconut topped with whipped cream. Add strawberry, raspberry, mango, peach or guava for $0.75.",
                    Category = "ClassicDrinks",
                    Price = 8.95
                };
                context.MenuItems.Add(PinaColada);

                var Loco = new MenuItem
                {
                    Name = "Loco (Mai Tai)",
                    Description = "Cruzan Aged Dark and Light Rum, pineapple juice, orange juice, and a float of grenadine and Cruzan 151.",
                    Category = "SpecialDrinks",
                    Price = 9.95
                };
                context.MenuItems.Add(Loco);

                var Mojito = new MenuItem
                {
                    Name = "Mojito",
                    Description = "Rum muddled with mint, lime, simple syrup and club soda. Add a flavor for $0.75, or try it as a coconut mojito!",
                    Category = "ClassicDrinks",
                    Price = 8.95
                };
                context.MenuItems.Add(Mojito);

                var StrawberrySunrise = new MenuItem
                {
                    Name = "Strawberry Sunrise",
                    Description = "El Jimador Plata, fresh strawberry puree topped with orange juice.",
                    Category = "SpecialDrinks",
                    Price = 8.25
                };
                context.MenuItems.Add(StrawberrySunrise);

                var JarritosSub = new MenuItem
                {
                    Name = "Jarritos Submarine",
                    Description = "Tequila and lime juice over ice topped with your choice of your favorite Jarritos.",
                    Category = "SpecialDrinks",
                    Price = 11.95
                };
                context.MenuItems.Add(JarritosSub);

                var Sangria = new MenuItem
                {
                    Name = "Sangria",
                    Description = "Chula's refreshing house-made Sangria. Red wine, brandy, and the perfect combo of fruit purees.",
                    Category = "ClassicDrinks",
                    Price = 8.50
                };
                context.MenuItems.Add(Sangria);

                var TequilaCooler = new MenuItem
                {
                    Name = "Tequila Cooler",
                    Description = "Tequila, grapefruit juice, cranberry juice and a squeeze of lime.",
                    Category = "SpecialDrinks",
                    Price = 8.50
                };
                context.MenuItems.Add(TequilaCooler);

                var BloodyMary = new MenuItem
                {
                    Name = "Bloody Mary",
                    Description = "Vodka, Tapatio, Tabasco, Bloody Mary Seasoning, Bloody Mary Mix with salt on the rim. Garnished with olives and green beans. Try it with tequila for a Bloody Maria!",
                    Category = "ClassicDrinks",
                    Price = 8.75
                };
                context.MenuItems.Add(BloodyMary);

                var Sunburst = new MenuItem
                {
                    Name = "Sunburst",
                    Description = "Orange juice, pineapple juice, and our virgin margarita mix served over ice and topped with grenadine.",
                    Category = "NonAlcoholic",
                    Price = 4.95
                };
                context.MenuItems.Add(Sunburst);

                var VirginMarg = new MenuItem
                {
                    Name = "Virign Margarita",
                    Description = "Virgin margarita mix blended with your choice of flavor. Topped with whipped cream.",
                    Category = "NonAlcoholic",
                    Price = 5.75
                };
                context.MenuItems.Add(VirginMarg);

                var VirginColada = new MenuItem
                {
                    Name = "Virign Colada",
                    Description = "Blended coconut and pineappled topped with whipped cream.",
                    Category = "NonAlcoholic",
                    Price = 5.75
                };
                context.MenuItems.Add(VirginColada);

                var DraftBeer = new MenuItem
                {
                    Name = "Draft Beer",
                    Description = "Pacifico, Dos XX Amber, Boneyard RPM, Coldfire Cumulus Tropicallis, Hop Valley Hefe.",
                    Category = "Beers",
                    Price = 5.00
                };
                context.MenuItems.Add(DraftBeer);

                var BottleBeer = new MenuItem
                {
                    Name = "Bottle Beer",
                    Description = "Corona, Corona Light, Modelo Especial, Negra Modelo, Coors Light",
                    Category = "Beers",
                    Price = 4.95
                };
                context.MenuItems.Add(BottleBeer);

                var Wine = new MenuItem
                {
                    Name = "Wine",
                    Description = "Chardonnay, Pinot Grigio, Cabernet Sauvignon",
                    Category = "Wines",
                    Price = 4.95
                };
                context.MenuItems.Add(Wine);


                ///////////////////////
                //  LIQUOR MENU HERE //
                ///////////////////////

                var AbsolutVodka = new MenuItem
                {
                    Name = "Absolut Vodka",
                    Description = "",
                    Category = "Vodka",
                    Price = 6.75
                };
                context.MenuItems.Add(AbsolutVodka);

                var Avion = new MenuItem
                {
                    Name = "Avion",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.75
                };
                context.MenuItems.Add(Avion);

                var Bacardi = new MenuItem
                {
                    Name = "Bacardi",
                    Description = "",
                    Category = "Gin",
                    Price = 6.75
                };
                context.MenuItems.Add(Bacardi);

                var Beefeater = new MenuItem
                {
                    Name = "Beefeater",
                    Description = "",
                    Category = "Gin",
                    Price = 6.75
                };
                context.MenuItems.Add(Beefeater);

                var TheCaptain = new MenuItem
                {
                    Name = "Captain Morgan",
                    Description = "",
                    Category = "Rum",
                    Price = 6.75
                };
                context.MenuItems.Add(TheCaptain);

                var Casamigos = new MenuItem
                {
                    Name = "Casamigos",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.85
                };
                context.MenuItems.Add(Casamigos);

                var CazadoresAnejo = new MenuItem
                {
                    Name = "Cazadores Anejo",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.25
                };
                context.MenuItems.Add(CazadoresAnejo);

                var CazadoresBlanco = new MenuItem
                {
                    Name = "Cazadores Blanco",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.25
                };
                context.MenuItems.Add(CazadoresBlanco);

                var CazadoresRepo = new MenuItem
                {
                    Name = "Cazadores Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.25
                };
                context.MenuItems.Add(CazadoresRepo);

                var CoconutRum = new MenuItem
                {
                    Name = "Coconut Rum",
                    Description = "",
                    Category = "Rum",
                    Price = 7.25
                };
                context.MenuItems.Add(CoconutRum);

                var Cointreau = new MenuItem
                {
                    Name = "Cointreau",
                    Description = "",
                    Category = "Liqueur",
                    Price = 8.25
                };
                context.MenuItems.Add(Cointreau);

                var CorralejoBlanco = new MenuItem
                {
                    Name = "Corralejo Blanco",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.75
                };
                context.MenuItems.Add(CorralejoBlanco);

                var CorralejoRepo = new MenuItem
                {
                    Name = "Corralejo Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.75
                };
                context.MenuItems.Add(CorralejoRepo);

                var CrownRoyal = new MenuItem
                {
                    Name = "Crown Royal",
                    Description = "",
                    Category = "Whiskey",
                    Price = 7.25
                };
                context.MenuItems.Add(CrownRoyal);

                var Cruzan151 = new MenuItem
                {
                    Name = "Cruzan 151",
                    Description = "",
                    Category = "Rum",
                    Price = 6.95
                };
                context.MenuItems.Add(Cruzan151);

                var CruzanAged = new MenuItem
                {
                    Name = "Cruzan Aged Rum",
                    Description = "",
                    Category = "Rum",
                    Price = 7.25
                };
                context.MenuItems.Add(CruzanAged);

                var CruzanMango = new MenuItem
                {
                    Name = "Cruzan Mango Rum",
                    Description = "",
                    Category = "Rum",
                    Price = 7.25
                };
                context.MenuItems.Add(CruzanMango);

                var TheDonAnejo = new MenuItem
                {
                    Name = "Don Julio Anejo",
                    Description = "",
                    Category = "Tequila",
                    Price = 10.25
                };
                context.MenuItems.Add(TheDonAnejo);

                var TheDonBlanco = new MenuItem
                {
                    Name = "Don Julio Blanco",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.25
                };
                context.MenuItems.Add(TheDonBlanco);

                var TheDonRepo = new MenuItem
                {
                    Name = "Don Julio Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.25
                };
                context.MenuItems.Add(TheDonRepo);

                var EJBrandy = new MenuItem
                {
                    Name = "E & J Brandy",
                    Description = "",
                    Category = "Whiskey",
                    Price = 7.50
                };
                context.MenuItems.Add(EJBrandy);

                var EspolonRepo = new MenuItem
                {
                    Name = "Espolon Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 7.95
                };
                context.MenuItems.Add(EspolonRepo);

                var EspolonSilver = new MenuItem
                {
                    Name = "Espolon Silver",
                    Description = "",
                    Category = "Tequila",
                    Price = 7.95
                };
                context.MenuItems.Add(EspolonSilver);

                var GrandMarnier = new MenuItem
                {
                    Name = "Grand Marnier",
                    Description = "",
                    Category = "Liqueur",
                    Price = 8.00
                };
                context.MenuItems.Add(GrandMarnier);

                var GreyGoose = new MenuItem
                {
                    Name = "Grey Goose",
                    Description = "",
                    Category = "Vodka",
                    Price = 10.25
                };
                context.MenuItems.Add(GreyGoose);

                var Henny = new MenuItem
                {
                    Name = "Hennessy",
                    Description = "",
                    Category = "Whiskey",
                    Price = 9.95
                };
                context.MenuItems.Add(Henny);

                var HerraduaAnejo = new MenuItem
                {
                    Name = "Herradua Anejo",
                    Description = "",
                    Category = "Tequila ",
                    Price = 10.25
                };
                context.MenuItems.Add(HerraduaAnejo);

                var HerraduaRepo = new MenuItem
                {
                    Name = "Herradua Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.50
                };
                context.MenuItems.Add(HerraduaRepo);

                var HerraduaSilver = new MenuItem
                {
                    Name = "Herradua Silver",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.50
                };
                context.MenuItems.Add(HerraduaSilver);

                var HornitosPlato = new MenuItem
                {
                    Name = "Hornitos Plato",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.25
                };
                context.MenuItems.Add(HornitosPlato);

                var HornitosRepo = new MenuItem
                {
                    Name = "Hornitos Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.25
                };
                context.MenuItems.Add(HornitosRepo);

                var JackDaniels = new MenuItem
                {
                    Name = "Jack Daniels",
                    Description = "",
                    Category = "Whiskey",
                    Price = 7.75
                };
                context.MenuItems.Add(JackDaniels);

                var Jameason = new MenuItem
                {
                    Name = "Jameason",
                    Description = "",
                    Category = "Whiskey",
                    Price = 7.75
                };
                context.MenuItems.Add(Jameason);

                var ElJimadorRepo = new MenuItem
                {
                    Name = "El Jimador Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 7.50
                };
                context.MenuItems.Add(ElJimadorRepo);

                var ElJimadorSilver = new MenuItem
                {
                    Name = "El Jimador Silver",
                    Description = "",
                    Category = "Tequila",
                    Price = 7.50
                };
                context.MenuItems.Add(ElJimadorSilver);

                var Kahlua = new MenuItem
                {
                    Name = "Kahlua",
                    Description = "",
                    Category = "Liqueur",
                    Price = 7.25
                };
                context.MenuItems.Add(Kahlua);

                var KettleOne = new MenuItem
                {
                    Name = "Kettle One",
                    Description = "",
                    Category = "Vodka",
                    Price = 8.25
                };
                context.MenuItems.Add(KettleOne);

                var MakersMark = new MenuItem
                {
                    Name = "Makers Mark",
                    Description = "",
                    Category = "Whiskey",
                    Price = 8.25
                };
                context.MenuItems.Add(MakersMark);

                var Mezcal = new MenuItem
                {
                    Name = "Mezcal",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.25
                };
                context.MenuItems.Add(Mezcal);

                var MilagroAnejo = new MenuItem
                {
                    Name = "Milagro Anejo",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.75
                }; 
                context.MenuItems.Add(MilagroAnejo);

                var MilagroRepo = new MenuItem
                {
                    Name = "Milagro Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.75
                };
                context.MenuItems.Add(MilagroRepo);

                var MilagroSilver = new MenuItem
                {
                    Name = "Milagro Silver",
                    Description = "",
                    Category = "Tequila",
                    Price = 8.75
                };
                context.MenuItems.Add(MilagroSilver);

                var OldForester = new MenuItem
                {
                    Name = "Old Forester",
                    Description = "",
                    Category = "Whiskey",
                    Price = 7.75
                };
                context.MenuItems.Add(OldForester);

                var PatronAnejo = new MenuItem
                {
                    Name = "Patron Anejo",
                    Description = "",
                    Category = "Tequila",
                    Price = 10.95
                };
                context.MenuItems.Add(PatronAnejo);

                var PatronRepo = new MenuItem
                {
                    Name = "Patron Reposado",
                    Description = "",
                    Category = "Tequila",
                    Price = 10.25
                };
                context.MenuItems.Add(PatronRepo);

                var PatronSilver = new MenuItem
                {
                    Name = "Patron Silver",
                    Description = "",
                    Category = "Tequila",
                    Price = 9.95
                };
                context.MenuItems.Add(PatronSilver);

                var Pendleton = new MenuItem
                {
                    Name = "Pendleton",
                    Description = "",
                    Category = "Whiskey",
                    Price = 8.25
                };
                context.MenuItems.Add(Pendleton);

                var Pinnacle = new MenuItem
                {
                    Name = "Pinnacle",
                    Description = "",
                    Category = "Vodka",
                    Price = 7.25
                };
                context.MenuItems.Add(Pinnacle);

                var Tangueray = new MenuItem
                {
                    Name = "Tangueray",
                    Description = "",
                    Category = "Gin",
                    Price = 7.95
                };
                context.MenuItems.Add(Tangueray);

                var Titos = new MenuItem
                {
                    Name = "Tito's",
                    Description = "",
                    Category = "Vodka",
                    Price = 7.75
                };
                context.MenuItems.Add(Titos);

                context.SaveChanges();
            }
        }
    }
}
